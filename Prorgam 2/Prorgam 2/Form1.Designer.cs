namespace Prorgam_2
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
            this.promptLbl = new System.Windows.Forms.Label();
            this.creditLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.creditTxt = new System.Windows.Forms.TextBox();
            this.dayOutputLbl = new System.Windows.Forms.Label();
            this.timeOutputLbl = new System.Windows.Forms.Label();
            this.regCalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Location = new System.Drawing.Point(38, 34);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(139, 16);
            this.promptLbl.TabIndex = 0;
            this.promptLbl.Text = "Enter your Last Name:";
            // 
            // creditLbl
            // 
            this.creditLbl.AutoSize = true;
            this.creditLbl.Location = new System.Drawing.Point(38, 67);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(119, 16);
            this.creditLbl.TabIndex = 1;
            this.creditLbl.Text = "Enter Credit Hours:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(201, 31);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 22);
            this.nameTxt.TabIndex = 2;
            // 
            // creditTxt
            // 
            this.creditTxt.Location = new System.Drawing.Point(201, 64);
            this.creditTxt.Name = "creditTxt";
            this.creditTxt.Size = new System.Drawing.Size(100, 22);
            this.creditTxt.TabIndex = 3;
            // 
            // dayOutputLbl
            // 
            this.dayOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayOutputLbl.Location = new System.Drawing.Point(166, 125);
            this.dayOutputLbl.Name = "dayOutputLbl";
            this.dayOutputLbl.Size = new System.Drawing.Size(135, 23);
            this.dayOutputLbl.TabIndex = 4;
            // 
            // timeOutputLbl
            // 
            this.timeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOutputLbl.Location = new System.Drawing.Point(166, 166);
            this.timeOutputLbl.Name = "timeOutputLbl";
            this.timeOutputLbl.Size = new System.Drawing.Size(135, 23);
            this.timeOutputLbl.TabIndex = 5;
            // 
            // regCalcBtn
            // 
            this.regCalcBtn.Location = new System.Drawing.Point(78, 228);
            this.regCalcBtn.Name = "regCalcBtn";
            this.regCalcBtn.Size = new System.Drawing.Size(179, 35);
            this.regCalcBtn.TabIndex = 6;
            this.regCalcBtn.Text = "When Do I Register?";
            this.regCalcBtn.UseVisualStyleBackColor = true;
            this.regCalcBtn.Click += new System.EventHandler(this.RegCalcBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.regCalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.regCalcBtn);
            this.Controls.Add(this.timeOutputLbl);
            this.Controls.Add(this.dayOutputLbl);
            this.Controls.Add(this.creditTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.promptLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Label creditLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox creditTxt;
        private System.Windows.Forms.Label dayOutputLbl;
        private System.Windows.Forms.Label timeOutputLbl;
        private System.Windows.Forms.Button regCalcBtn;
    }
}

