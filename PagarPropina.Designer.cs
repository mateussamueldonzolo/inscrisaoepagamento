
namespace TLP_P1
{
    partial class PagarPropina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarPropina));
            this.panel2 = new System.Windows.Forms.Panel();
            this.curso = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pagarP = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MPropina = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ValorP = new System.Windows.Forms.Label();
            this.nuser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.curso);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pagarP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MPropina);
            this.panel2.Controls.Add(this.ValorP);
            this.panel2.Controls.Add(this.nuser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 467);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // curso
            // 
            this.curso.AutoSize = true;
            this.curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curso.Location = new System.Drawing.Point(305, 128);
            this.curso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(64, 20);
            this.curso.TabIndex = 25;
            this.curso.Text = "@curso";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 77);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(90, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TLP_P1.Properties.Resources.cash_in_hand_127px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pagarP
            // 
            this.pagarP.BorderRadius = 10;
            this.pagarP.CheckedState.Parent = this.pagarP;
            this.pagarP.CustomImages.Parent = this.pagarP;
            this.pagarP.FillColor = System.Drawing.SystemColors.Highlight;
            this.pagarP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pagarP.ForeColor = System.Drawing.Color.White;
            this.pagarP.HoverState.Parent = this.pagarP;
            this.pagarP.Location = new System.Drawing.Point(155, 365);
            this.pagarP.Name = "pagarP";
            this.pagarP.ShadowDecoration.Parent = this.pagarP;
            this.pagarP.Size = new System.Drawing.Size(345, 51);
            this.pagarP.TabIndex = 23;
            this.pagarP.Text = "Pagamento da proprina";
            this.pagarP.Click += new System.EventHandler(this.pagarP_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(371, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "16.060kz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(152, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total a ser pago:";
            // 
            // MPropina
            // 
            this.MPropina.BackColor = System.Drawing.Color.Transparent;
            this.MPropina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MPropina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MPropina.FocusedColor = System.Drawing.Color.Empty;
            this.MPropina.FocusedState.Parent = this.MPropina;
            this.MPropina.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MPropina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MPropina.FormattingEnabled = true;
            this.MPropina.HoverState.Parent = this.MPropina;
            this.MPropina.ItemHeight = 30;
            this.MPropina.ItemsAppearance.Parent = this.MPropina;
            this.MPropina.Location = new System.Drawing.Point(155, 254);
            this.MPropina.Name = "MPropina";
            this.MPropina.ShadowDecoration.Parent = this.MPropina;
            this.MPropina.Size = new System.Drawing.Size(345, 36);
            this.MPropina.TabIndex = 16;
            this.MPropina.SelectedIndexChanged += new System.EventHandler(this.MPropina_SelectedIndexChanged_2);
            // 
            // ValorP
            // 
            this.ValorP.AutoSize = true;
            this.ValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorP.ForeColor = System.Drawing.Color.Green;
            this.ValorP.Location = new System.Drawing.Point(272, 311);
            this.ValorP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValorP.Name = "ValorP";
            this.ValorP.Size = new System.Drawing.Size(113, 29);
            this.ValorP.TabIndex = 9;
            this.ValorP.Text = "16.060 kz";
            // 
            // nuser
            // 
            this.nuser.AutoSize = true;
            this.nuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuser.Location = new System.Drawing.Point(270, 97);
            this.nuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nuser.Name = "nuser";
            this.nuser.Size = new System.Drawing.Size(133, 20);
            this.nuser.TabIndex = 3;
            this.nuser.Text = "@nomedoinscrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor da Propina : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Q. Meses:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel3;
            // 
            // PagarPropina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 467);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagarPropina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagarPropina";
            this.Load += new System.EventHandler(this.PagarPropina_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button pagarP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox MPropina;
        private System.Windows.Forms.Label ValorP;
        private System.Windows.Forms.Label nuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label curso;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}