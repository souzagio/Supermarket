using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Registration
{
    public partial class FormSingUp : Form
    {
        public FormSingUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string mail = textBox1.Text;
                string msg = Classes.MailSet.SendMail(mail);
                MessageBox.Show(msg, "Aviso");
            }
            else
            {
                textBox1.Clear(); textBox1.Focus();
               
            }
        }
    }
}
