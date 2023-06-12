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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

      
        private void Dashboard_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb.Value < 45)
            {
                pb.Value = pb.Value + 1;
            }
            else
            {
                timer1.Enabled = false;
                Login a = new Login();
                this.Hide();
                a.Show();
            }
        }
    }
    
}
