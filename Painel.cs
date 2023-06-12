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
    public partial class Dashboard : Form
    {
        List<Aluno> alunos;
        public Dashboard()
        {
            InitializeComponent();
            alunos = new List<Aluno>();
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            user.Text = Login.nome;
            Pagar.Enabled = false;
        }

        private void Inscrever_Click(object sender, EventArgs e)
        {
            //Inscrição

            int index = -1;

            foreach (Aluno p in alunos)
            {
                if (p.Nome == textNome.Text)
                {
                    index = alunos.IndexOf(p);
                }

            }
            textNome.Focus();

            if (textNome.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                textNome.Focus();
                return;
            }

            if (textMorada.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                textMorada.Focus();
                return;
            }

            if (textMorada.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                textMorada.Focus();
                return;
            }

            if (comboDoc.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                comboDoc.Focus();
                return;
            }

            if (comboGenero.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                comboGenero.Focus();
                return;
            }

            if (maskedTELE.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                maskedTELE.Focus();
                return;
            }

            if (textDoc_I.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                textDoc_I.Focus();
                return;
            }
            if (ComboCurso.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
                ComboCurso.Focus();
                return;
            }



            // Aluno
            Aluno a = new Aluno();
            a.Nome = textNome.Text;
            a.Morada = textMorada.Text;
            a.Genero = comboGenero.SelectedItem.ToString();
            a.Telefone = maskedTELE.Text;
            a.Documento = comboDoc.SelectedItem.ToString();
            a.NDocumento = textDoc_I.Text;
            a.Curso = ComboCurso.SelectedItem.ToString();
            a._Fotos = Foto.ImageLocation;

            if (index < 0)
            {
                alunos.Add(a);

            }
            else
            {
                alunos[index] = a;

            }

            Limpar();
            listar();

            //HABILITAR O BOTÃO PAGAR//

            Incrito.Enabled = true;

        }

        private void Limpar()
        {
            // Aluno
            Foto.ImageLocation = "";
            textNome.Text = "";
            textMorada.Text = "";
            maskedTELE.Text = "";
            comboGenero.SelectedIndex = -1;
            textDoc_I.Text = "";
            comboDoc.SelectedIndex = -1;
            ComboCurso.SelectedIndex = -1;
            textNome.Focus();

        }

        //lista
        public void listar()
        {
            lista.Items.Clear();

            foreach (Aluno alu in alunos)
            {
                lista.Items.Add(alu.Nome);

            }
        }

        public static string nome;

        //Comentário para expensaão de painel

        bool expandir;

        private void temp_Tick(object sender, EventArgs e)
        {
            if (expandir)
            {
                sidenav.Width -= 10;
                if (sidenav.Width == sidenav.MinimumSize.Width)
                {
                    expandir = false;
                    temp.Stop();
                }

            }
            else
            {
                sidenav.Width += 10;
                if (sidenav.Width == sidenav.MaximumSize.Width)
                {
                    expandir = true;
                    temp.Stop();
                }
            }

        }

        private void menu_Click(object sender, EventArgs e)
        {
            temp.Start();
        }

        private void Inscrito_Click(object sender, EventArgs e)
        {
            
        }
        private void SetFoto_Click(object sender, EventArgs e)
        {
            openFD.Title = "Adicionar as imagens";
            openFD.Filter = "Arquivos|*.png;*jpg";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Foto.ImageLocation = openFD.FileName;

            }

        }

        private void Incrito_Click(object sender, EventArgs e)
        {
            InscritoUser.BringToFront();
           
        }

        public static string n_usuario;
        public static string n_cand;

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            

        }

        private void Pagar_Click_1(object sender, EventArgs e)
        {
            PagarPropina op = new PagarPropina();
            op.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            inscritos.BringToFront();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            textNome.Clear();
            textMorada.Clear();
            maskedTELE.Clear();
            ComboCurso.SelectedItem = "";
            comboGenero.SelectedItem = "";
            textDoc_I.Clear();
            comboDoc.SelectedItem = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /*HABILITAR OS BOTÕES*/
            textNome.Focus();
            textNome.Enabled = true;
            textMorada.Enabled = true;
            maskedTELE.Enabled = true;
            ComboCurso.Enabled = true;
            comboGenero.Enabled = true;
            textDoc_I.Enabled = true;
            comboDoc.Enabled = true;
            SetFoto.Enabled = true;
            Foto.Enabled = true;
        }

        private void lista_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void InscritoUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            Aluno p = alunos[indice];

            /*Adicionando*/

            textNome.Text = p.Nome;
            n_usuario = textNome.Text;
            textMorada.Text = p.Morada;
            maskedTELE.Text = p.Telefone;
            ComboCurso.Text = p.Curso;
            n_cand = ComboCurso.Text;
            comboGenero.Text = p.Genero;
            textDoc_I.Text = p.NDocumento;
            comboDoc.Text = p.Documento;
            Foto.ImageLocation = p._Fotos;
            InscritoUser.Visible = false;
            Inscrever.Visible = false;
            Pagar.Enabled = true;

            
            /*DESABILITAR OS BOTÕES*/

            textNome.Enabled = false;
            textMorada.Enabled = false;
            maskedTELE.Enabled = false;
            ComboCurso.Enabled = false;
            comboGenero.Enabled = false;
            textDoc_I.Enabled = false;
            comboDoc.Enabled = false;
            SetFoto.Enabled = false;
            Foto.Enabled = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }



        private void temp2_Tick(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}

