﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsbMecenat.GUI
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnGestionAsso_Click(object sender, EventArgs e)
        {
            FrmGestionAsso FrmGestionAsso = new FrmGestionAsso();
            FrmGestionAsso.ShowDialog();
        }
    }
}
