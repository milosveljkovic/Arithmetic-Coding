using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticAlg.Class
{
    public class CharFrequency
    {
        private char char_name;
        private int frequency;
        private double probability;
        private double low_range_boundary,hight_range_boundary;
        private double low,high;

        public CharFrequency(char c,int f)
        {
            this.Char_name = c;
            this.Frequency = f;
        }


        public char Char_name { get => char_name; set => char_name = value; }
        public int Frequency { get => frequency; set => frequency = value; }
        public double Probability { get => probability; set => probability = value; }
        public double Low_range_boundary { get => low_range_boundary; set => low_range_boundary = value; }
        public double Hight_range_boundary { get => hight_range_boundary; set => hight_range_boundary = value; }
        public double Low { get => low; set => low = value; }
        public double High { get => high; set => high = value; }
    }
}
