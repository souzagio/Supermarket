using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System;

namespace Supermarket
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }
        Classes.Intermed med = new Classes.Intermed();
        public Int16 i = 0;
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* try
            {
                string Login = txtLogin.Text;
                string Senha = txtPass.Text;
                med.Logar(Login, Senha);
                int i = med.ID;
                if (i != 0)
                MessageBox.Show("Encontrado");
            }
            catch { }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                string Login = txtLogin.Text;
                string Senha = txtPass.Text;
                string msg  = med.Logar(Login,Senha);
                i = med.ID;
                if (i > 0)
                {
                    string ID = i.ToString();
                    MessageBox.Show(ID);
                    
                }
                else if(i == -1)
                {
                    MessageBox.Show("STP ativa, falha nas credenciais");
                }
                else { MessageBox.Show(msg); string rec = i.ToString(); MessageBox.Show(rec); }
            }
            catch { }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}