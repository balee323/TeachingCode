namespace ImprovedVersion1
{
    partial class SpaceGameFrm
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
            this.Text_lbl = new System.Windows.Forms.Label();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.levelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_lbl
            // 
            this.Text_lbl.AutoSize = true;
            this.Text_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Text_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_lbl.ForeColor = System.Drawing.Color.Red;
            this.Text_lbl.Location = new System.Drawing.Point(104, 187);
            this.Text_lbl.Name = "Text_lbl";
            this.Text_lbl.Size = new System.Drawing.Size(272, 55);
            this.Text_lbl.TabIndex = 43;
            this.Text_lbl.Text = "Game Over";
            this.Text_lbl.Visible = false;
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReplayBtn.Location = new System.Drawing.Point(197, 268);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(262, 44);
            this.ReplayBtn.TabIndex = 44;
            this.ReplayBtn.Text = "Restart";
            this.ReplayBtn.UseVisualStyleBackColor = false;
            this.ReplayBtn.Visible = false;
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Red;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuitBtn.Location = new System.Drawing.Point(197, 358);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(262, 44);
            this.QuitBtn.TabIndex = 45;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(55, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "SCORE:";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.scorelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scorelbl.Location = new System.Drawing.Point(133, 91);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(32, 24);
            this.scorelbl.TabIndex = 40;
            this.scorelbl.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(507, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "LEVEL:";
            // 
            // levelbl
            // 
            this.levelbl.AutoSize = true;
            this.levelbl.BackColor = System.Drawing.Color.Transparent;
            this.levelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.levelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.levelbl.Location = new System.Drawing.Point(1492, 66);
            this.levelbl.Name = "levelbl";
            this.levelbl.Size = new System.Drawing.Size(32, 24);
            this.levelbl.TabIndex = 42;
            this.levelbl.Text = "01";
            // 
            // SpaceGameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 714);
            this.Controls.Add(this.levelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.Text_lbl);
            this.KeyPreview = true;
            this.Name = "SpaceGameFrm";
            this.Text = "Space Game";
            this.Load += new System.EventHandler(this.SpaceGameFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceGameFrm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceGameFrm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Text_lbl;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label levelbl;
    }
}

