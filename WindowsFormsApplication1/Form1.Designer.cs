namespace ConsoleApplication1
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
			this.btnFormata = new System.Windows.Forms.Button();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lblInput = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.cmbOperation = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.lbl3 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.lbl4 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.lbl5 = new System.Windows.Forms.Label();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.btnFormat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFormata
			// 
			this.btnFormata.Location = new System.Drawing.Point(174, 61);
			this.btnFormata.Name = "btnFormata";
			this.btnFormata.Size = new System.Drawing.Size(75, 23);
			this.btnFormata.TabIndex = 0;
			this.btnFormata.Text = "Formatar";
			this.btnFormata.UseVisualStyleBackColor = true;
			this.btnFormata.Click += new System.EventHandler(this.btnFormat_Click);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(11, 25);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(157, 20);
			this.txt1.TabIndex = 2;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(12, 9);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(49, 13);
			this.lbl1.TabIndex = 4;
			this.lbl1.Text = "Param 1:";
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Location = new System.Drawing.Point(13, 163);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(34, 13);
			this.lblInput.TabIndex = 5;
			this.lblInput.Text = "Input:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(218, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Resultado:";
			// 
			// rtbResult
			// 
			this.rtbResult.Location = new System.Drawing.Point(221, 178);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.Size = new System.Drawing.Size(204, 278);
			this.rtbResult.TabIndex = 8;
			this.rtbResult.Text = "";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(12, 48);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(49, 13);
			this.lbl2.TabIndex = 10;
			this.lbl2.Text = "Param 2:";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(11, 64);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(157, 20);
			this.txt2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(174, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// rtbInput
			// 
			this.rtbInput.Location = new System.Drawing.Point(12, 179);
			this.rtbInput.Name = "rtbInput";
			this.rtbInput.Size = new System.Drawing.Size(198, 277);
			this.rtbInput.TabIndex = 13;
			this.rtbInput.Text = "";
			// 
			// cmbOperation
			// 
			this.cmbOperation.FormattingEnabled = true;
			this.cmbOperation.Items.AddRange(new object[] {
            "Replace",
            "Remove Break",
            "RMB+Replace",
            "ClassToInsertSQL",
            "ClassToXmlCase"});
			this.cmbOperation.Location = new System.Drawing.Point(12, 118);
			this.cmbOperation.Name = "cmbOperation";
			this.cmbOperation.Size = new System.Drawing.Size(147, 21);
			this.cmbOperation.TabIndex = 14;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(174, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Location = new System.Drawing.Point(256, 9);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(73, 13);
			this.lbl3.TabIndex = 16;
			this.lbl3.Text = "Replacement:";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(255, 25);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(157, 20);
			this.txt3.TabIndex = 15;
			// 
			// lbl4
			// 
			this.lbl4.AutoSize = true;
			this.lbl4.Location = new System.Drawing.Point(256, 48);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(44, 13);
			this.lbl4.TabIndex = 18;
			this.lbl4.Text = "Current:";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(255, 64);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(157, 20);
			this.txt4.TabIndex = 17;
			// 
			// lbl5
			// 
			this.lbl5.AutoSize = true;
			this.lbl5.Location = new System.Drawing.Point(356, 87);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(56, 13);
			this.lbl5.TabIndex = 20;
			this.lbl5.Text = "Separator:";
			// 
			// txt5
			// 
			this.txt5.Location = new System.Drawing.Point(385, 103);
			this.txt5.MaxLength = 1;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(27, 20);
			this.txt5.TabIndex = 19;
			this.txt5.Text = ",";
			// 
			// btnFormat
			// 
			this.btnFormat.Location = new System.Drawing.Point(174, 118);
			this.btnFormat.Name = "btnFormat";
			this.btnFormat.Size = new System.Drawing.Size(75, 23);
			this.btnFormat.TabIndex = 21;
			this.btnFormat.Text = "Go";
			this.btnFormat.UseVisualStyleBackColor = true;
			this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 468);
			this.Controls.Add(this.btnFormat);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.txt5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.cmbOperation);
			this.Controls.Add(this.rtbInput);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblInput);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.btnFormata);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFormata;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox rtbResult;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btnFormat;
    }
}