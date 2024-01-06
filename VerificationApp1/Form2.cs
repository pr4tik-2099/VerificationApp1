using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Name_lbl.Text = Form1.Name;
            Age_lbl.Text = Form1.Age;
            Pnum_lbl.Text = Form1.Pnum;
            Pan_lbl.Text = Form1.Pan_num;
            Voter_lbl.Text = Form1.Vtr_num;
            Dob_lbl.Text = Form1.Dob;
            if (Form1.chbox)
            {
                grp_lbl.Show();
            }
            else
            {
                grp_lbl.Hide();
            }
        }
    }
}
