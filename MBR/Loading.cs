﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBR
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = this.label1.BackColor;
            this.TransparencyKey = this.label1.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MenuPrincipal principal = new MenuPrincipal();
                this.Hide();
                principal.ShowDialog();
            }
        }

    }
}


