using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLP_P1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
 
        }


        public static string nome;

        funcionario log = new funcionario();
        
       
        private void nUsuario_TextChanged(object sender, EventArgs e)
        {
        }


        private void SenhaUser_TextChanged(object sender, EventArgs e)
        {

         
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Tratamento de erro

                log.Nome = nUsuario.Text;
                nome = log.Nome;
                log.Senha = SenhaUser.Text;

                if (log.Nome == "Admin" || log.Senha == "12")
                {
                    Dashboard l = new Dashboard();
                    this.Hide();
                    l.Show();
                }

                if (log.Nome == "" || log.Senha == "")
                {
                    MessageBox.Show("Preencha o campo");
                }
            
            
        }

        private void Acesso()
        { 
            
        }

        private void vision_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void vision_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.Show();
        }
    }
}
