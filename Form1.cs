using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AritmeticAlg.Class;

namespace AritmeticAlg
{
    public partial class Form1 : Form
    {
        private Dictionary<char, UInt64[]> symbol_current_sum;
        List<KeyValuePair<char, UInt64>> char_frequency_pairs;
        private UInt64 total_symbols;

        public Form1()
        {
            InitializeComponent();
        }

        private void handleCompress(object sender, EventArgs e)
        {
            StreamReader input_reader = new StreamReader(InputFilePathLabel.Text);
            Stream stream = new FileStream(OutputFilePathLabel.Text, FileMode.OpenOrCreate);
            BinaryWriter output_writer = new BinaryWriter(stream);

            var fileName = @InputFilePathLabel.Text;
            FileInfo fileinfo = new FileInfo(fileName);

            long file_size = fileinfo.Length;
            sizeHolder.Text = file_size.ToString() + "  bytes";
            sizeHolder.Visible = true;

            Encode(input_reader, output_writer);

            output_writer.Close();
            input_reader.Close();

            fileName = @OutputFilePathLabel.Text;
            fileinfo = new FileInfo(fileName);

            long compressed_file_size = fileinfo.Length;
            compressedData.Text = compressed_file_size.ToString() + "  bytes";
            compressedData.Visible = true;

            compressionMessage.Text = "Compression successful!";
            compressionMessage.Visible = true;
        }

        public void Encode(StreamReader input_stream, BinaryWriter output_stream)
        {
            findSymbolFrequenies(input_stream);
            writeLength(output_stream);
            writeSymbolFrequency(output_stream);
            encodeAndWrite(input_stream, output_stream);
        }

        public void writeLength(BinaryWriter output_stream)
        {
            output_stream.Write(total_symbols);   
        }

        private void findSymbolFrequenies(StreamReader input_stream)
        {
            Dictionary<char, UInt64> char_frequencies = new Dictionary<char, UInt64>();
            symbol_current_sum = new Dictionary<char, UInt64[]>();
            char_frequency_pairs = new List<KeyValuePair<char, UInt64>>();
            int ascii_value;
            char char_value;
            UInt64 sum = 0;

            while (!input_stream.EndOfStream)
            {
                ascii_value = input_stream.Read();
                char_value = Convert.ToChar(ascii_value);
                if (char_frequencies.ContainsKey(char_value))
                    char_frequencies[char_value] += 1;
                else
                    char_frequencies[char_value] = 1;
            }

            foreach (KeyValuePair<char, UInt64> pair in char_frequencies)
                char_frequency_pairs.Add(pair);
            
            // sort by number of frequencies
            char_frequency_pairs.Sort(
                delegate (KeyValuePair<char, UInt64> firstPair,
                     KeyValuePair<char, UInt64> nextPair)
                {
                    return firstPair.Value.CompareTo(nextPair.Value);
                });
            char_frequency_pairs.Reverse();

            foreach (KeyValuePair<char, UInt64> pair in char_frequency_pairs)
            {
                symbol_current_sum[pair.Key] = new UInt64[2] { sum, sum + pair.Value };
                sum += pair.Value;
            }
            total_symbols = sum;
        }

        private void writeSymbolFrequency(BinaryWriter writer)
        {
            writer.Write((UInt16)char_frequency_pairs.Count);
            foreach (KeyValuePair<char, UInt64> pair in char_frequency_pairs)
            {
                writer.Write(pair.Key);
                writer.Write(pair.Value);
            }
        }

        private void encodeAndWrite(StreamReader input_stream, BinaryWriter output_stream)
        {
            input_stream.BaseStream.Position = 0;
            input_stream.DiscardBufferedData();
            char symbol;
            double low_range;
            double high_range;
            double range = 1, low = 0;
            int ascii;

            while (!input_stream.EndOfStream)
            {
                ascii = input_stream.Read();
                symbol = Convert.ToChar(ascii);

                low_range = (double)symbol_current_sum[symbol][0]/((double)total_symbols);
                high_range = (double)symbol_current_sum[symbol][1]/((double)total_symbols);
                low += (range * low_range);
                range = (range * high_range) - (range * low_range);
            }
            output_stream.Write(low);
        }

        

        private void handleDecompress_Click(object sender, EventArgs e)
        {
            Stream stream = new FileStream(InputFilePathLabel.Text, FileMode.Open);
            BinaryReader input_reader = new BinaryReader(stream);
            StreamWriter output_writer = new StreamWriter(OutputFilePathLabel.Text);

            Decode(input_reader, output_writer);

            input_reader.Close();
            output_writer.Close();

            compressionMessage.Text = "Decompression successful!";
            compressionMessage.Visible = true;
        }

        public void Decode(BinaryReader input_reader, StreamWriter output_writer)
        {
            setTotalSymbols(input_reader);
            readSymbolsFrequencies(input_reader);
            decode(input_reader,output_writer);
        }

        public void setTotalSymbols(BinaryReader input_reader)
        {
            total_symbols = input_reader.ReadUInt64();
        }

        public void readSymbolsFrequencies(BinaryReader input_reader)
        {
            UInt16 number_of_letters = input_reader.ReadUInt16();
            List<KeyValuePair<char, UInt64>> char_frequency_pairs = new List<KeyValuePair<char, UInt64>>();
            KeyValuePair<char, UInt64> char_freq_pair;
            char symbol;
            UInt64 symbol_frequency;
            UInt64 sum = 0;
            symbol_current_sum = new Dictionary<char, UInt64[]>();

            for (UInt64 i = 0; i < number_of_letters; i++)
            {
                symbol = input_reader.ReadChar();
                symbol_frequency = input_reader.ReadUInt64();

                char_freq_pair = new KeyValuePair<char, UInt64>(symbol, symbol_frequency);
                char_frequency_pairs.Add(char_freq_pair);
            }

            foreach (KeyValuePair<char, UInt64> pair in char_frequency_pairs)
            {
                symbol_current_sum[pair.Key] = new UInt64[2] { sum, sum + pair.Value };
                sum += pair.Value;
            }

        }

        private void decode(BinaryReader input_reader, StreamWriter output_writer)
        {
            double range, low_range, high_range, symbol_range;
            range = Math.Round(input_reader.ReadDouble(),10);

            for (UInt64 i = 0; i < total_symbols; i++)
            {
                foreach (KeyValuePair<char, UInt64[]> pair in symbol_current_sum)
                {
                    low_range = Math.Round((double)symbol_current_sum[pair.Key][0] / ((double)total_symbols),10);
                    high_range = Math.Round((double)symbol_current_sum[pair.Key][1] / ((double)total_symbols),10);
                    symbol_range = high_range - low_range;
                    if (low_range <= range && high_range > range)
                    {
                        range = Math.Round((range - low_range) / symbol_range,10);
                        output_writer.Write(pair.Key);
                        break;
                    }
                }
            }
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                InputFilePathLabel.Text = filePath;
                InputFilePathLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog2.FileName;
                OutputFilePathLabel.Text = filePath;
                OutputFilePathLabel.Visible = true;
            }
        }
    }
}
