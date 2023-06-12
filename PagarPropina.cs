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
    public partial class PagarPropina : Form
    {
        public PagarPropina()
        {
            InitializeComponent();

            MPropina.Items.Add("Um mês");
            MPropina.Items.Add("Dois meses");
            MPropina.Items.Add("Três meses");
            MPropina.Items.Add("Quatro meses");
            MPropina.Items.Add("Cinco meses");
            MPropina.Items.Add("Seis meses");
            MPropina.Items.Add("sete meses");
            MPropina.Items.Add("Oito meses");
            MPropina.Items.Add("Nove meses");
            MPropina.Items.Add("Dez meses");
            MPropina.Items.Add("Onze meses");
            MPropina.Items.Add("Um ano");

            MPropina.SelectedIndex = 0;
        }

        public int RecValor = 16060;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PagarPropina_Load(object sender, EventArgs e)
        {
            nuser.Text = Dashboard.n_usuario;
            curso.Text = Dashboard.n_cand;
        }
        
        private void MPropina_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        private void som()
        {
           

            if (MPropina.Items[1] != null)
            {
                ValorP.Text = RecValor++.ToString(); 
            } 
        }

        private void MPropina_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pagarP_Click(object sender, EventArgs e)
        {
           
            
        }

        private void MPropina_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (MPropina.SelectedIndex == 0)
            { ValorP.Text = "16.060 kz"; }

            else if (MPropina.SelectedIndex == 1)
            { ValorP.Text = "32.120 kz"; }

            else if (MPropina.SelectedIndex == 2)
            { ValorP.Text = "48.180 kz"; }

            else if (MPropina.SelectedIndex == 3)
            { ValorP.Text = "64.240 kz"; }

            else if (MPropina.SelectedIndex == 4)
            { ValorP.Text = "80.300 kz"; }

            else if (MPropina.SelectedIndex == 5)
            { ValorP.Text = "96.360 kz"; }

            else if (MPropina.SelectedIndex == 6)
            { ValorP.Text = "112.420 kz"; }

            else if (MPropina.SelectedIndex == 7)
            { ValorP.Text = "128.480 kz"; }

            else if (MPropina.SelectedIndex == 8)
            { ValorP.Text = "144.540 kz"; }

            else if (MPropina.SelectedIndex == 9)
            { ValorP.Text = "160.600 kz"; }

            else if (MPropina.SelectedIndex == 10)
            { ValorP.Text = "176.660 kz"; }

            else if (MPropina.SelectedIndex == 11)
            { ValorP.Text = "192.720 kz"; }
        }

        private void pagarP_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento Efectuado com sucesso!");
            Dashboard login = new Dashboard();
            this.Hide();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
        }
    }
}
