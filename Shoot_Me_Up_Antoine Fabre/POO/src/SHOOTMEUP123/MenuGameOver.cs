﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public partial class MenuGameOver : Form
    {
        public MenuGameOver()
        {
            InitializeComponent();
        }

        private void MenuGameOver_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //methode si on clique sur le bouton 1 ca cache cette fenetre et ca ouvre la fenetre 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();     
            menugame menugame = new menugame();
            menugame.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //si on clique sur le bouton 2 ca ferme cette fenetre et ca ouvre la fenetre de jeu 
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
