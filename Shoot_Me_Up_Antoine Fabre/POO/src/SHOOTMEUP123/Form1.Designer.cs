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
            System.Windows.Forms.Timer MoveEnnemi;
            System.Windows.Forms.Timer timer2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bullettimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bulletenemitimer = new System.Windows.Forms.Timer(this.components);
            this.timerCreationBullet = new System.Windows.Forms.Timer(this.components);
            this.TimerCrationBall = new System.Windows.Forms.Timer(this.components);
            this.CoolDown = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timerLevelUp = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BulletEnnemi = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Bullet123 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RondScore = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ultimate = new System.Windows.Forms.PictureBox();
            MoveEnnemi = new System.Windows.Forms.Timer(this.components);
            timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BulletEnnemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RondScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveEnnemi
            // 
            MoveEnnemi.Enabled = true;
            MoveEnnemi.Tick += new System.EventHandler(this.MoveEnnemi_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.timerCreationBullet.Interval = 3000;
            this.timerCreationBullet.Tick += new System.EventHandler(this.timerCreationBullet_Tick);
            // 
            // TimerCrationBall
            // 
            this.TimerCrationBall.Enabled = true;
            this.TimerCrationBall.Interval = 1000;
            this.TimerCrationBall.Tick += new System.EventHandler(this.TimerCrationBall_Tick);
            // 
            // CoolDown
            // 
            this.CoolDown.Enabled = true;
            this.CoolDown.Interval = 1000;
            this.CoolDown.Tick += new System.EventHandler(this.CoolDown_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1058, 933);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // timerLevelUp
            // 
            this.timerLevelUp.Enabled = true;
            this.timerLevelUp.Interval = 10;
            this.timerLevelUp.Tick += new System.EventHandler(this.timerLevelUp_Tick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(818, 865);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "attaque de base";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1031, 865);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "ultimate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 970);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "1";
            // 
            // BulletEnnemi
            // 
            this.BulletEnnemi.BackgroundImage = global::SHOOTMEUP123.Properties.Resources.pixil_frame_0_;
            this.BulletEnnemi.Location = new System.Drawing.Point(612, 320);
            this.BulletEnnemi.Name = "BulletEnnemi";
            this.BulletEnnemi.Size = new System.Drawing.Size(164, 68);
            this.BulletEnnemi.TabIndex = 35;
            this.BulletEnnemi.TabStop = false;
            this.BulletEnnemi.Visible = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox27.BackgroundImage")));
            this.pictureBox27.Location = new System.Drawing.Point(715, 962);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(48, 48);
            this.pictureBox27.TabIndex = 33;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox26.BackgroundImage")));
            this.pictureBox26.Location = new System.Drawing.Point(1096, 1001);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(10, 10);
            this.pictureBox26.TabIndex = 32;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Visible = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox25.BackgroundImage")));
            this.pictureBox25.Location = new System.Drawing.Point(1080, 1001);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(10, 10);
            this.pictureBox25.TabIndex = 31;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Visible = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox24.BackgroundImage")));
            this.pictureBox24.Location = new System.Drawing.Point(1063, 1000);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(10, 10);
            this.pictureBox24.TabIndex = 30;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Visible = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox23.BackgroundImage")));
            this.pictureBox23.Location = new System.Drawing.Point(1048, 1000);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(10, 10);
            this.pictureBox23.TabIndex = 29;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Visible = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.BackgroundImage")));
            this.pictureBox22.Location = new System.Drawing.Point(1032, 1000);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(10, 10);
            this.pictureBox22.TabIndex = 28;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Visible = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.BackgroundImage")));
            this.pictureBox21.Location = new System.Drawing.Point(872, 1000);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(10, 10);
            this.pictureBox21.TabIndex = 27;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Visible = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox20.BackgroundImage")));
            this.pictureBox20.Location = new System.Drawing.Point(856, 1000);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(10, 10);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Visible = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.Location = new System.Drawing.Point(840, 1000);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(10, 10);
            this.pictureBox19.TabIndex = 25;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Visible = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.Location = new System.Drawing.Point(824, 1000);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(10, 10);
            this.pictureBox18.TabIndex = 24;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Visible = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox17.BackgroundImage")));
            this.pictureBox17.Location = new System.Drawing.Point(808, 1000);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(10, 10);
            this.pictureBox17.TabIndex = 23;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox16.BackgroundImage")));
            this.pictureBox16.Location = new System.Drawing.Point(1096, 1000);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(10, 10);
            this.pictureBox16.TabIndex = 22;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.Location = new System.Drawing.Point(1080, 1000);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 10);
            this.pictureBox15.TabIndex = 21;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.Location = new System.Drawing.Point(1064, 1000);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 10);
            this.pictureBox14.TabIndex = 20;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.Location = new System.Drawing.Point(1048, 1000);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(10, 10);
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(1032, 1000);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(10, 10);
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.Location = new System.Drawing.Point(872, 1000);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 10);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(856, 1000);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 10);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(840, 1000);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 10);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(824, 1000);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 10);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(808, 1000);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 10);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(1031, 910);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 85);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
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
            // Bullet123
            // 
            this.Bullet123.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bullet123.BackgroundImage")));
            this.Bullet123.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bullet123.Location = new System.Drawing.Point(241, 226);
            this.Bullet123.Name = "Bullet123";
            this.Bullet123.Size = new System.Drawing.Size(39, 72);
            this.Bullet123.TabIndex = 2;
            this.Bullet123.TabStop = false;
            this.Bullet123.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(567, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(914, 797);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ultimate
            // 
            this.Ultimate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ultimate.BackgroundImage")));
            this.Ultimate.Location = new System.Drawing.Point(956, 320);
            this.Ultimate.Name = "Ultimate";
            this.Ultimate.Size = new System.Drawing.Size(86, 282);
            this.Ultimate.TabIndex = 8;
            this.Ultimate.TabStop = false;
            this.Ultimate.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.BulletEnnemi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
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
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BulletEnnemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RondScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private EventHandler pictureBox2_Click;
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerLevelUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BulletEnnemi;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
    }
}

