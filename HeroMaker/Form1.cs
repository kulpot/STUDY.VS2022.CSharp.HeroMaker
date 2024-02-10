﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//------------------ C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
//ref link:https://www.youtube.com/watch?v=UgbzxnlckxY&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=15

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool[] abilities = {false, false, false, false, false, false, false, false };

            abilities[0] = chk_fly.Checked;
            abilities[1] = chk_xray.Checked;
            abilities[2] = chk_invisible.Checked;
            abilities[3] = chk_energy.Checked;
            abilities[4] = chk_luck.Checked;
            abilities[5] = chk_fart.Checked;
            abilities[6] = chk_water_breath.Checked;
            abilities[7] = chk_timecontrol.Checked;

            string status_message = "You have selected the following abilities:";
        }
    }
}
