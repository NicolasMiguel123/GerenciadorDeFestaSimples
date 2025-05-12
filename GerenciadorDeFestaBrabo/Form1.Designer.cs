namespace GerenciadorDeFestaBrabo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbNomeconsulta = new System.Windows.Forms.TextBox();
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.libConvidados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.grbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = ((System.Drawing.Image)(resources.GetObject("pibLogo.Image")));
            this.pibLogo.Location = new System.Drawing.Point(33, 3);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(157, 140);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            this.pibLogo.Click += new System.EventHandler(this.pibLogo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(252, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 39);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciador de Festas";
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.lblResultado);
            this.grbConsulta.Controls.Add(this.pibResultado);
            this.grbConsulta.Controls.Add(this.btnConsultar);
            this.grbConsulta.Controls.Add(this.txbNomeconsulta);
            this.grbConsulta.Controls.Add(this.lblNomeConsulta);
            this.grbConsulta.Location = new System.Drawing.Point(33, 199);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(316, 239);
            this.grbConsulta.TabIndex = 2;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta";
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(20, 134);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(42, 39);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 7;
            this.pibResultado.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(47, 82);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(230, 35);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbNomeconsulta
            // 
            this.txbNomeconsulta.Location = new System.Drawing.Point(61, 56);
            this.txbNomeconsulta.Name = "txbNomeconsulta";
            this.txbNomeconsulta.Size = new System.Drawing.Size(202, 20);
            this.txbNomeconsulta.TabIndex = 5;
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Location = new System.Drawing.Point(17, 59);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(38, 13);
            this.lblNomeConsulta.TabIndex = 4;
            this.lblNomeConsulta.Text = "Nome:";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.libConvidados);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(402, 199);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(320, 239);
            this.grbCadastro.TabIndex = 3;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(69, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 8;
            // 
            // txbCadastro
            // 
            this.txbCadastro.Location = new System.Drawing.Point(75, 52);
            this.txbCadastro.Name = "txbCadastro";
            this.txbCadastro.Size = new System.Drawing.Size(202, 20);
            this.txbCadastro.TabIndex = 10;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(31, 55);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 9;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(60, 78);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 25);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // libConvidados
            // 
            this.libConvidados.FormattingEnabled = true;
            this.libConvidados.Location = new System.Drawing.Point(34, 124);
            this.libConvidados.Name = "libConvidados";
            this.libConvidados.Size = new System.Drawing.Size(263, 95);
            this.libConvidados.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Name = "Form1";
            this.Text = "Gerenciador de Festas";
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbNomeconsulta;
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox libConvidados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
    }
}

