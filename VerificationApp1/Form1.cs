using System.Security.Cryptography.X509Certificates;

namespace VerificationApp1
{
    public partial class Form1 : Form
    {
        public static string Name;
        public static string Age;
        public static string Pnum;
        public static string Pan_num;
        public static string Vtr_num;
        public static Boolean chbox;
        public static string Dob;


        public Form1()
        {


            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Grp18_box.Hide();
            Alert_lbl.Hide();

        }

        private void Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkbox.Checked)
            {
                Grp18_box.Show();
            }
            else
            {
                Grp18_box.Hide();
            }
        }

        private void Sbmt_btn_Click(object sender, EventArgs e)
        {
            Name = Name_txt.Text;
            Age = Age_txt.Text;
            Pnum = Pnum_txt.Text;
            chbox = Chkbox.Checked;
            Pan_num = Pan_txt.Text;
            Vtr_num = Voter_txt.Text;
            Dob = dateTimePicker1.Value.ToLongDateString();

            Form2 form2 = new Form2();

            if (Name == "" || Age == "" || Pnum == "")
            {
                Alert_lbl.Show();
            }
            else if (Chkbox.Checked)
            {
                if (Vtr_num == "" || Pan_num == "")
                {
                    Alert_lbl.Show();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are those previous informations are correct", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    form2.Show();
                }
            }

            /*     DialogResult dr = MessageBox.Show("Are those previous informations are correct", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                 if (dr == DialogResult.Yes)
                 {
                     form2.Show();
                 }                               */


        }
    }
}