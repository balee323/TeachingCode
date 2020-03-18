namespace SpaceGame
{
    partial class SpaceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceForm));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Aircraft = new System.Windows.Forms.PictureBox();
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRigthTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTopTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveEnemisTimer = new System.Windows.Forms.Timer(this.components);
            this.Text_lbl = new System.Windows.Forms.Label();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.EnemisMunitionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Aircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Aircraft
            // 
            this.Aircraft.BackColor = System.Drawing.Color.Transparent;
            this.Aircraft.Image = ((System.Drawing.Image)(resources.GetObject("Aircraft.Image")));
            this.Aircraft.Location = new System.Drawing.Point(263, 405);
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.Size = new System.Drawing.Size(50, 50);
            this.Aircraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aircraft.TabIndex = 0;
            this.Aircraft.TabStop = false;
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Interval = 5;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveRigthTimer
            // 
            this.MoveRigthTimer.Interval = 5;
            this.MoveRigthTimer.Tick += new System.EventHandler(this.MoveRigthTimer_Tick);
            // 
            // MoveTopTimer
            // 
            this.MoveTopTimer.Interval = 5;
            this.MoveTopTimer.Tick += new System.EventHandler(this.MoveTopTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Interval = 5;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 10;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "SCORE:";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.scorelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scorelbl.Location = new System.Drawing.Point(90, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(38, 22);
            this.scorelbl.TabIndex = 27;
            this.scorelbl.Text = "00";
            // 
            // levelbl
            // 
            this.levelbl.AutoSize = true;
            this.levelbl.BackColor = System.Drawing.Color.Transparent;
            this.levelbl.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.levelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.levelbl.Location = new System.Drawing.Point(542, 10);
            this.levelbl.Name = "levelbl";
            this.levelbl.Size = new System.Drawing.Size(33, 22);
            this.levelbl.TabIndex = 29;
            this.levelbl.Text = "01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(464, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "LEVEL:";
            // 
            // MoveEnemisTimer
            // 
            this.MoveEnemisTimer.Enabled = true;
            this.MoveEnemisTimer.Tick += new System.EventHandler(this.MoveEnemisTimer_Tick);
            // 
            // Text_lbl
            // 
            this.Text_lbl.AutoSize = true;
            this.Text_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Text_lbl.Font = new System.Drawing.Font("Gimme Danger", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_lbl.ForeColor = System.Drawing.Color.Red;
            this.Text_lbl.Location = new System.Drawing.Point(61, 108);
            this.Text_lbl.Name = "Text_lbl";
            this.Text_lbl.Size = new System.Drawing.Size(461, 93);
            this.Text_lbl.TabIndex = 35;
            this.Text_lbl.Text = "Game Over";
            this.Text_lbl.Visible = false;
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplayBtn.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReplayBtn.Location = new System.Drawing.Point(154, 218);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(262, 44);
            this.ReplayBtn.TabIndex = 36;
            this.ReplayBtn.Text = "Restart";
            this.ReplayBtn.UseVisualStyleBackColor = false;
            this.ReplayBtn.Visible = false;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Red;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBtn.Font = new System.Drawing.Font("New York Escape Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuitBtn.Location = new System.Drawing.Point(154, 279);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(262, 44);
            this.QuitBtn.TabIndex = 37;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Visible = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // EnemisMunitionTimer
            // 
            this.EnemisMunitionTimer.Enabled = true;
            this.EnemisMunitionTimer.Interval = 20;
            this.EnemisMunitionTimer.Tick += new System.EventHandler(this.EnemisMunitionTimer_Tick);
            // 
            // SpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.Text_lbl);
            this.Controls.Add(this.levelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aircraft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "SpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.SpaceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Aircraft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Aircraft;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRigthTimer;
        private System.Windows.Forms.Timer MoveTopTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer MoveEnemisTimer;
        private System.Windows.Forms.Label Text_lbl;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Timer EnemisMunitionTimer;
    }
}

