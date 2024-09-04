
namespace aps_aula_20_08
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
            this.components = new System.ComponentModel.Container();
            this.lblForma = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.tbLado = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.tbPerimetro = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(28, 27);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(55, 20);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Forma";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(262, 32);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(74, 20);
            this.lblTriangulo.TabIndex = 1;
            this.lblTriangulo.Text = "Triângulo";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(28, 168);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(42, 20);
            this.lblRaio.TabIndex = 2;
            this.lblRaio.Text = "Raio";
            this.lblRaio.Click += new System.EventHandler(this.lblRaio_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(28, 202);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(45, 20);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(28, 237);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(28, 273);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(46, 20);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Base";
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // tbRaio
            // 
            this.tbRaio.BackColor = System.Drawing.Color.White;
            this.tbRaio.Location = new System.Drawing.Point(85, 162);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(189, 26);
            this.tbRaio.TabIndex = 6;
            // 
            // tbLado
            // 
            this.tbLado.BackColor = System.Drawing.Color.White;
            this.tbLado.Location = new System.Drawing.Point(85, 196);
            this.tbLado.Name = "tbLado";
            this.tbLado.Size = new System.Drawing.Size(189, 26);
            this.tbLado.TabIndex = 7;
            // 
            // tbAltura
            // 
            this.tbAltura.BackColor = System.Drawing.Color.White;
            this.tbAltura.Location = new System.Drawing.Point(85, 231);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(189, 26);
            this.tbAltura.TabIndex = 8;
            this.tbAltura.TextChanged += new System.EventHandler(this.tbAltura_TextChanged);
            // 
            // tbBase
            // 
            this.tbBase.BackColor = System.Drawing.Color.White;
            this.tbBase.Location = new System.Drawing.Point(85, 270);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(189, 26);
            this.tbBase.TabIndex = 9;
            // 
            // tbPerimetro
            // 
            this.tbPerimetro.BackColor = System.Drawing.Color.White;
            this.tbPerimetro.Location = new System.Drawing.Point(387, 196);
            this.tbPerimetro.Name = "tbPerimetro";
            this.tbPerimetro.ReadOnly = true;
            this.tbPerimetro.Size = new System.Drawing.Size(189, 26);
            this.tbPerimetro.TabIndex = 13;
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.White;
            this.tbArea.Location = new System.Drawing.Point(387, 157);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(189, 26);
            this.tbArea.TabIndex = 12;
            this.tbArea.TextChanged += new System.EventHandler(this.tbArea_TextChanged);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(304, 199);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(77, 20);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(338, 160);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area";
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Quadrado",
            "Circunferência",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(85, 24);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(121, 28);
            this.cmbForma.TabIndex = 14;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Isósceles",
            "Escaleno",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(342, 29);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(121, 28);
            this.cmbTriangulo.TabIndex = 15;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(598, 29);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(121, 28);
            this.cmbObjetos.TabIndex = 16;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(517, 29);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 28);
            this.btnCriar.TabIndex = 17;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbObjetos);
            this.Controls.Add(this.cmbTriangulo);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.tbPerimetro);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbLado);
            this.Controls.Add(this.tbRaio);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblForma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.TextBox tbLado;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.TextBox tbPerimetro;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

