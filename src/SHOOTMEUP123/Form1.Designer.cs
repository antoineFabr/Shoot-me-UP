using System;

namespace SHOOTMEUP123
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bullet123 = new System.Windows.Forms.PictureBox();
            this.bullettimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bulletenemitimer = new System.Windows.Forms.Timer(this.components);
            this.timerCreationBullet = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TimerCrationBall = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.RondScore = new System.Windows.Forms.PictureBox();
            this.Ultimate = new System.Windows.Forms.PictureBox();
            this.CoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RondScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(921, 797);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(499, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bullet123
            // 
            this.Bullet123.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bullet123.BackgroundImage")));
            this.Bullet123.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bullet123.Location = new System.Drawing.Point(241, 226);
            this.Bullet123.Name = "Bullet123";
            this.Bullet123.Size = new System.Drawing.Size(45, 72);
            this.Bullet123.TabIndex = 2;
            this.Bullet123.TabStop = false;
            this.Bullet123.Visible = false;
            // 
            // bullettimer
            // 
            this.bullettimer.Interval = 50;
            this.bullettimer.Tick += new System.EventHandler(this.bullettimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.label1.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(673, 933);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bulletenemitimer
            // 
            this.bulletenemitimer.Interval = 10;
            this.bulletenemitimer.Tick += new System.EventHandler(this.bulletenemitimer_Tick);
            // 
            // timerCreationBullet
            // 
            this.timerCreationBullet.Enabled = true;
            this.timerCreationBullet.Interval = 1000;
            this.timerCreationBullet.Tick += new System.EventHandler(this.timerCreationBullet_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(612, 894);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(731, 125);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // TimerCrationBall
            // 
            this.TimerCrationBall.Enabled = true;
            this.TimerCrationBall.Interval = 1000;
            this.TimerCrationBall.Tick += new System.EventHandler(this.TimerCrationBall_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(808, 910);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 84);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(1031, 910);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(85, 84);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // RondScore
            // 
            this.RondScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.RondScore.Location = new System.Drawing.Point(644, 910);
            this.RondScore.Name = "RondScore";
            this.RondScore.Size = new System.Drawing.Size(100, 100);
            this.RondScore.TabIndex = 7;
            this.RondScore.TabStop = false;
            // 
            // Ultimate
            // 
            this.Ultimate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ultimate.BackgroundImage")));
            this.Ultimate.Location = new System.Drawing.Point(958, 320);
            this.Ultimate.Name = "Ultimate";
            this.Ultimate.Size = new System.Drawing.Size(84, 282);
            this.Ultimate.TabIndex = 8;
            this.Ultimate.TabStop = false;
            this.Ultimate.Visible = false;
            // 
            // CoolDown
            // 
            this.CoolDown.Enabled = true;
            this.CoolDown.Interval = 1000;
            this.CoolDown.Tick += new System.EventHandler(this.CoolDown_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1033, 911);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 83);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bullet123);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RondScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ultimate);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "Form1";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RondScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private EventHandler pictureBox2_Click;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Bullet123;
        private System.Windows.Forms.Timer bullettimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer bulletenemitimer;
        private System.Windows.Forms.Timer timerCreationBullet;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer TimerCrationBall;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox RondScore;
        public System.Windows.Forms.PictureBox Ultimate;
        private System.Windows.Forms.Timer CoolDown;
        private System.Windows.Forms.Panel panel1;
    }
}

