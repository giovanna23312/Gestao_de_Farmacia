﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaVital
{
    public partial class Farma : Form
    {
        public Farma()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqClieFarma clie = new PesqClieFarma();
            this.Hide();
            clie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesqMedFarma med = new PesqMedFarma();
            this.Hide();
            med.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrnLogin login = new FrnLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
