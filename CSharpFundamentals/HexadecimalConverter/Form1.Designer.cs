namespace HexadecimalConverter
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
            this.RadioToBase16 = new System.Windows.Forms.RadioButton();
            this.RadioToBase10 = new System.Windows.Forms.RadioButton();
            this.TxtOutPut = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RadioToBase16
            // 
            this.RadioToBase16.AutoSize = true;
            this.RadioToBase16.Location = new System.Drawing.Point(44, 233);
            this.RadioToBase16.Name = "RadioToBase16";
            this.RadioToBase16.Size = new System.Drawing.Size(150, 17);
            this.RadioToBase16.TabIndex = 1;
            this.RadioToBase16.TabStop = true;
            this.RadioToBase16.Text = "To Base 16 (Hexadecimal)";
            this.RadioToBase16.UseVisualStyleBackColor = true;
            // 
            // RadioToBase10
            // 
            this.RadioToBase10.AutoSize = true;
            this.RadioToBase10.Location = new System.Drawing.Point(44, 265);
            this.RadioToBase10.Name = "RadioToBase10";
            this.RadioToBase10.Size = new System.Drawing.Size(80, 17);
            this.RadioToBase10.TabIndex = 2;
            this.RadioToBase10.TabStop = true;
            this.RadioToBase10.Text = "To Base 10";
            this.RadioToBase10.UseVisualStyleBackColor = true;
            // 
            // TxtOutPut
            // 
            this.TxtOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutPut.Location = new System.Drawing.Point(44, 306);
            this.TxtOutPut.Name = "TxtOutPut";
            this.TxtOutPut.ReadOnly = true;
            this.TxtOutPut.Size = new System.Drawing.Size(175, 29);
            this.TxtOutPut.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(44, 117);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(175, 29);
            this.txtInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Base 10 to Base 16 converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click here to open online tool for comparison.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.TxtOutPut);
            this.Controls.Add(this.RadioToBase10);
            this.Controls.Add(this.RadioToBase16);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioToBase16;
        private System.Windows.Forms.RadioButton RadioToBase10;
        private System.Windows.Forms.TextBox TxtOutPut;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

