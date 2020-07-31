namespace EntellectUniCup
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnFile = new System.Windows.Forms.Button();
            this.rtxOpenDIsplay = new System.Windows.Forms.RichTextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.rtxSequence = new System.Windows.Forms.RichTextBox();
            this.btnShowTestScore = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(12, 12);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(186, 64);
            this.BtnFile.TabIndex = 0;
            this.BtnFile.Text = "OpenFile";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // rtxOpenDIsplay
            // 
            this.rtxOpenDIsplay.Location = new System.Drawing.Point(223, 12);
            this.rtxOpenDIsplay.Name = "rtxOpenDIsplay";
            this.rtxOpenDIsplay.Size = new System.Drawing.Size(409, 773);
            this.rtxOpenDIsplay.TabIndex = 1;
            this.rtxOpenDIsplay.Text = "";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(672, 12);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(195, 89);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Get move sequence";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // rtxSequence
            // 
            this.rtxSequence.Location = new System.Drawing.Point(932, 12);
            this.rtxSequence.Name = "rtxSequence";
            this.rtxSequence.Size = new System.Drawing.Size(401, 773);
            this.rtxSequence.TabIndex = 3;
            this.rtxSequence.Text = "";
            // 
            // btnShowTestScore
            // 
            this.btnShowTestScore.Location = new System.Drawing.Point(1381, 12);
            this.btnShowTestScore.Name = "btnShowTestScore";
            this.btnShowTestScore.Size = new System.Drawing.Size(168, 64);
            this.btnShowTestScore.TabIndex = 4;
            this.btnShowTestScore.Text = "Test";
            this.btnShowTestScore.UseVisualStyleBackColor = true;
            this.btnShowTestScore.Click += new System.EventHandler(this.btnShowTestScore_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(1619, 26);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(291, 38);
            this.txtScore.TabIndex = 5;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2230, 825);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnShowTestScore);
            this.Controls.Add(this.rtxSequence);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.rtxOpenDIsplay);
            this.Controls.Add(this.BtnFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.RichTextBox rtxOpenDIsplay;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.RichTextBox rtxSequence;
        private System.Windows.Forms.Button btnShowTestScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

