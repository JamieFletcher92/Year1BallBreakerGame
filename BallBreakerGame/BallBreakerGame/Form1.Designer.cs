namespace BallBreakerGame
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxBat = new System.Windows.Forms.PictureBox();
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelReady = new System.Windows.Forms.Label();
            this.pictureBoxBrick10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrick = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLevelScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOverallScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBat
            // 
            this.pictureBoxBat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxBat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBat.Image")));
            this.pictureBoxBat.Location = new System.Drawing.Point(438, 458);
            this.pictureBoxBat.Name = "pictureBoxBat";
            this.pictureBoxBat.Size = new System.Drawing.Size(146, 21);
            this.pictureBoxBat.TabIndex = 3;
            this.pictureBoxBat.TabStop = false;
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxBall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBall.Image")));
            this.pictureBoxBall.Location = new System.Drawing.Point(510, 321);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(18, 17);
            this.pictureBoxBall.TabIndex = 4;
            this.pictureBoxBall.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelReady);
            this.panel1.Controls.Add(this.pictureBoxBrick10);
            this.panel1.Controls.Add(this.pictureBoxBrick9);
            this.panel1.Controls.Add(this.pictureBoxBrick8);
            this.panel1.Controls.Add(this.pictureBoxBrick7);
            this.panel1.Controls.Add(this.pictureBoxBrick6);
            this.panel1.Controls.Add(this.pictureBoxBrick5);
            this.panel1.Controls.Add(this.pictureBoxBrick4);
            this.panel1.Controls.Add(this.pictureBoxBrick3);
            this.panel1.Controls.Add(this.pictureBoxBrick2);
            this.panel1.Controls.Add(this.pictureBoxBrick1);
            this.panel1.Controls.Add(this.pictureBoxBrick);
            this.panel1.Controls.Add(this.pictureBoxBall);
            this.panel1.Controls.Add(this.pictureBoxBat);
            this.panel1.Location = new System.Drawing.Point(5, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 488);
            this.panel1.TabIndex = 0;
            // 
            // labelReady
            // 
            this.labelReady.AutoSize = true;
            this.labelReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReady.ForeColor = System.Drawing.Color.White;
            this.labelReady.Location = new System.Drawing.Point(253, 226);
            this.labelReady.Name = "labelReady";
            this.labelReady.Size = new System.Drawing.Size(447, 37);
            this.labelReady.TabIndex = 7;
            this.labelReady.Text = "Level 1! Press R When Ready!";
            // 
            // pictureBoxBrick10
            // 
            this.pictureBoxBrick10.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick10.Image")));
            this.pictureBoxBrick10.Location = new System.Drawing.Point(858, 27);
            this.pictureBoxBrick10.Name = "pictureBoxBrick10";
            this.pictureBoxBrick10.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick10.TabIndex = 5;
            this.pictureBoxBrick10.TabStop = false;
            // 
            // pictureBoxBrick9
            // 
            this.pictureBoxBrick9.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick9.Image")));
            this.pictureBoxBrick9.Location = new System.Drawing.Point(774, 27);
            this.pictureBoxBrick9.Name = "pictureBoxBrick9";
            this.pictureBoxBrick9.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick9.TabIndex = 5;
            this.pictureBoxBrick9.TabStop = false;
            // 
            // pictureBoxBrick8
            // 
            this.pictureBoxBrick8.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick8.Image")));
            this.pictureBoxBrick8.Location = new System.Drawing.Point(690, 27);
            this.pictureBoxBrick8.Name = "pictureBoxBrick8";
            this.pictureBoxBrick8.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick8.TabIndex = 5;
            this.pictureBoxBrick8.TabStop = false;
            // 
            // pictureBoxBrick7
            // 
            this.pictureBoxBrick7.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick7.Image")));
            this.pictureBoxBrick7.Location = new System.Drawing.Point(606, 27);
            this.pictureBoxBrick7.Name = "pictureBoxBrick7";
            this.pictureBoxBrick7.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick7.TabIndex = 5;
            this.pictureBoxBrick7.TabStop = false;
            // 
            // pictureBoxBrick6
            // 
            this.pictureBoxBrick6.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick6.Image")));
            this.pictureBoxBrick6.Location = new System.Drawing.Point(522, 27);
            this.pictureBoxBrick6.Name = "pictureBoxBrick6";
            this.pictureBoxBrick6.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick6.TabIndex = 5;
            this.pictureBoxBrick6.TabStop = false;
            // 
            // pictureBoxBrick5
            // 
            this.pictureBoxBrick5.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick5.Image")));
            this.pictureBoxBrick5.Location = new System.Drawing.Point(438, 27);
            this.pictureBoxBrick5.Name = "pictureBoxBrick5";
            this.pictureBoxBrick5.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick5.TabIndex = 5;
            this.pictureBoxBrick5.TabStop = false;
            // 
            // pictureBoxBrick4
            // 
            this.pictureBoxBrick4.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick4.Image")));
            this.pictureBoxBrick4.Location = new System.Drawing.Point(354, 27);
            this.pictureBoxBrick4.Name = "pictureBoxBrick4";
            this.pictureBoxBrick4.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick4.TabIndex = 5;
            this.pictureBoxBrick4.TabStop = false;
            // 
            // pictureBoxBrick3
            // 
            this.pictureBoxBrick3.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick3.Image")));
            this.pictureBoxBrick3.Location = new System.Drawing.Point(270, 27);
            this.pictureBoxBrick3.Name = "pictureBoxBrick3";
            this.pictureBoxBrick3.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick3.TabIndex = 5;
            this.pictureBoxBrick3.TabStop = false;
            // 
            // pictureBoxBrick2
            // 
            this.pictureBoxBrick2.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick2.Image")));
            this.pictureBoxBrick2.Location = new System.Drawing.Point(186, 27);
            this.pictureBoxBrick2.Name = "pictureBoxBrick2";
            this.pictureBoxBrick2.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick2.TabIndex = 5;
            this.pictureBoxBrick2.TabStop = false;
            // 
            // pictureBoxBrick1
            // 
            this.pictureBoxBrick1.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick1.Image")));
            this.pictureBoxBrick1.Location = new System.Drawing.Point(102, 27);
            this.pictureBoxBrick1.Name = "pictureBoxBrick1";
            this.pictureBoxBrick1.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick1.TabIndex = 5;
            this.pictureBoxBrick1.TabStop = false;
            // 
            // pictureBoxBrick
            // 
            this.pictureBoxBrick.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBrick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrick.Image")));
            this.pictureBoxBrick.Location = new System.Drawing.Point(18, 27);
            this.pictureBoxBrick.Name = "pictureBoxBrick";
            this.pictureBoxBrick.Size = new System.Drawing.Size(78, 30);
            this.pictureBoxBrick.TabIndex = 5;
            this.pictureBoxBrick.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1017, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lives:";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.BackColor = System.Drawing.Color.Aqua;
            this.labelLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(1072, 54);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(18, 20);
            this.labelLives.TabIndex = 2;
            this.labelLives.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(970, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level Score:";
            // 
            // labelLevelScore
            // 
            this.labelLevelScore.AutoSize = true;
            this.labelLevelScore.BackColor = System.Drawing.Color.Aqua;
            this.labelLevelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelScore.Location = new System.Drawing.Point(1072, 84);
            this.labelLevelScore.Name = "labelLevelScore";
            this.labelLevelScore.Size = new System.Drawing.Size(18, 20);
            this.labelLevelScore.TabIndex = 2;
            this.labelLevelScore.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(959, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Overall Score:";
            // 
            // labelOverallScore
            // 
            this.labelOverallScore.AutoSize = true;
            this.labelOverallScore.BackColor = System.Drawing.Color.Aqua;
            this.labelOverallScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverallScore.Location = new System.Drawing.Point(1072, 116);
            this.labelOverallScore.Name = "labelOverallScore";
            this.labelOverallScore.Size = new System.Drawing.Size(18, 20);
            this.labelOverallScore.TabIndex = 2;
            this.labelOverallScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1055, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "R = Resume!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "P = Pause!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1126, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelOverallScore);
            this.Controls.Add(this.labelLevelScore);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBat;
        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.PictureBox pictureBoxBrick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLevelScore;
        private System.Windows.Forms.PictureBox pictureBoxBrick5;
        private System.Windows.Forms.PictureBox pictureBoxBrick4;
        private System.Windows.Forms.PictureBox pictureBoxBrick3;
        private System.Windows.Forms.PictureBox pictureBoxBrick2;
        private System.Windows.Forms.PictureBox pictureBoxBrick1;
        private System.Windows.Forms.PictureBox pictureBoxBrick10;
        private System.Windows.Forms.PictureBox pictureBoxBrick9;
        private System.Windows.Forms.PictureBox pictureBoxBrick8;
        private System.Windows.Forms.PictureBox pictureBoxBrick7;
        private System.Windows.Forms.PictureBox pictureBoxBrick6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOverallScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelReady;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
    }
}

