namespace AritmeticAlg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeHolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compressedData = new System.Windows.Forms.Label();
            this.handleDecompress = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InputFilePathLabel = new System.Windows.Forms.Label();
            this.ChooseOutputFileBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputFilePathLabel = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.compressionMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.handleCompress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(230, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input file size:";
            // 
            // sizeHolder
            // 
            this.sizeHolder.AutoSize = true;
            this.sizeHolder.ForeColor = System.Drawing.Color.Lime;
            this.sizeHolder.Location = new System.Drawing.Point(330, 287);
            this.sizeHolder.Name = "sizeHolder";
            this.sizeHolder.Size = new System.Drawing.Size(16, 17);
            this.sizeHolder.TabIndex = 3;
            this.sizeHolder.Text = "0";
            this.sizeHolder.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(230, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compressed file size:";
            // 
            // compressedData
            // 
            this.compressedData.AutoSize = true;
            this.compressedData.ForeColor = System.Drawing.Color.Lime;
            this.compressedData.Location = new System.Drawing.Point(378, 318);
            this.compressedData.Name = "compressedData";
            this.compressedData.Size = new System.Drawing.Size(16, 17);
            this.compressedData.TabIndex = 5;
            this.compressedData.Text = "0";
            this.compressedData.Visible = false;
            // 
            // handleDecompress
            // 
            this.handleDecompress.BackColor = System.Drawing.Color.White;
            this.handleDecompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleDecompress.Location = new System.Drawing.Point(358, 210);
            this.handleDecompress.Name = "handleDecompress";
            this.handleDecompress.Size = new System.Drawing.Size(123, 52);
            this.handleDecompress.TabIndex = 6;
            this.handleDecompress.Text = "Decode";
            this.handleDecompress.UseVisualStyleBackColor = false;
            this.handleDecompress.Click += new System.EventHandler(this.handleDecompress_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.BackColor = System.Drawing.Color.Lime;
            this.ChooseFileBtn.Location = new System.Drawing.Point(51, 73);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(140, 34);
            this.ChooseFileBtn.TabIndex = 8;
            this.ChooseFileBtn.Text = "Choose Input File";
            this.ChooseFileBtn.UseVisualStyleBackColor = false;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(212, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "File Path: ";
            // 
            // InputFilePathLabel
            // 
            this.InputFilePathLabel.AutoSize = true;
            this.InputFilePathLabel.ForeColor = System.Drawing.Color.Lime;
            this.InputFilePathLabel.Location = new System.Drawing.Point(289, 82);
            this.InputFilePathLabel.Name = "InputFilePathLabel";
            this.InputFilePathLabel.Size = new System.Drawing.Size(46, 17);
            this.InputFilePathLabel.TabIndex = 10;
            this.InputFilePathLabel.Text = "label4";
            this.InputFilePathLabel.Visible = false;
            // 
            // ChooseOutputFileBtn
            // 
            this.ChooseOutputFileBtn.BackColor = System.Drawing.Color.Lime;
            this.ChooseOutputFileBtn.Location = new System.Drawing.Point(51, 132);
            this.ChooseOutputFileBtn.Name = "ChooseOutputFileBtn";
            this.ChooseOutputFileBtn.Size = new System.Drawing.Size(140, 34);
            this.ChooseOutputFileBtn.TabIndex = 11;
            this.ChooseOutputFileBtn.Text = "Choose Output File";
            this.ChooseOutputFileBtn.UseVisualStyleBackColor = false;
            this.ChooseOutputFileBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(212, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "File Path: ";
            // 
            // OutputFilePathLabel
            // 
            this.OutputFilePathLabel.AutoSize = true;
            this.OutputFilePathLabel.ForeColor = System.Drawing.Color.Lime;
            this.OutputFilePathLabel.Location = new System.Drawing.Point(289, 141);
            this.OutputFilePathLabel.Name = "OutputFilePathLabel";
            this.OutputFilePathLabel.Size = new System.Drawing.Size(46, 17);
            this.OutputFilePathLabel.TabIndex = 13;
            this.OutputFilePathLabel.Text = "label4";
            this.OutputFilePathLabel.Visible = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // compressionMessage
            // 
            this.compressionMessage.AutoSize = true;
            this.compressionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressionMessage.ForeColor = System.Drawing.Color.Lime;
            this.compressionMessage.Location = new System.Drawing.Point(199, 356);
            this.compressionMessage.Name = "compressionMessage";
            this.compressionMessage.Size = new System.Drawing.Size(64, 25);
            this.compressionMessage.TabIndex = 14;
            this.compressionMessage.Text = "label5";
            this.compressionMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(659, 438);
            this.Controls.Add(this.compressionMessage);
            this.Controls.Add(this.OutputFilePathLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChooseOutputFileBtn);
            this.Controls.Add(this.InputFilePathLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChooseFileBtn);
            this.Controls.Add(this.handleDecompress);
            this.Controls.Add(this.compressedData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Arithmetic coding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compressedData;
        private System.Windows.Forms.Button handleDecompress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InputFilePathLabel;
        private System.Windows.Forms.Button ChooseOutputFileBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OutputFilePathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label compressionMessage;
    }
}

