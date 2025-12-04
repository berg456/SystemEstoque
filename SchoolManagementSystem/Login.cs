using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    
    public partial class Login : Form
    {
        public static string fk_ad;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtSenha.Text;
            string userdb, passworddb;
            
            returnclass rc = new returnclass();
            userdb = rc.scalarReturn("select count(ad_id) from administator where ad_name='"+user+"'");
            if (userdb.Equals("0"))
            {
                MessageBox.Show("Nome de Usuário Inválido!");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
            else 
            {
               passworddb = rc.scalarReturn("select ad_password from administator where ad_name='" + user + "'");
                if(passworddb.Equals(password)) 
                { 
                    Principal f = new Principal();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Senha Inválida!");
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
        }
    }
}
