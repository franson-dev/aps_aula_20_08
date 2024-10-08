﻿
namespace aps_aula_20_08
{
    partial class Figures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Figures));
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.listObjetos = new System.Windows.Forms.ListBox();
            this.LimparBotao = new System.Windows.Forms.Button();
            this.RemoverBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.BackColor = System.Drawing.Color.Transparent;
            this.lblForma.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForma.Location = new System.Drawing.Point(28, 24);
            this.lblForma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(68, 22);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Forma";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTriangulo.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTriangulo.Location = new System.Drawing.Point(267, 24);
            this.lblTriangulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(99, 22);
            this.lblTriangulo.TabIndex = 1;
            this.lblTriangulo.Text = "Triângulo";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.BackColor = System.Drawing.Color.Transparent;
            this.lblRaio.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaio.Location = new System.Drawing.Point(44, 77);
            this.lblRaio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(52, 22);
            this.lblRaio.TabIndex = 2;
            this.lblRaio.Text = "Raio";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.BackColor = System.Drawing.Color.Transparent;
            this.lblLado.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLado.Location = new System.Drawing.Point(40, 77);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(56, 22);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltura.Location = new System.Drawing.Point(27, 77);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(69, 22);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.BackColor = System.Drawing.Color.Transparent;
            this.lblBase.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBase.Location = new System.Drawing.Point(44, 110);
            this.lblBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(52, 22);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Base";
            // 
            // tbRaio
            // 
            this.tbRaio.BackColor = System.Drawing.Color.White;
            this.tbRaio.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaio.Location = new System.Drawing.Point(100, 74);
            this.tbRaio.Margin = new System.Windows.Forms.Padding(2);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(148, 29);
            this.tbRaio.TabIndex = 6;
            // 
            // tbLado
            // 
            this.tbLado.BackColor = System.Drawing.Color.White;
            this.tbLado.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLado.Location = new System.Drawing.Point(100, 74);
            this.tbLado.Margin = new System.Windows.Forms.Padding(2);
            this.tbLado.Name = "tbLado";
            this.tbLado.Size = new System.Drawing.Size(148, 29);
            this.tbLado.TabIndex = 7;
            // 
            // tbAltura
            // 
            this.tbAltura.BackColor = System.Drawing.Color.White;
            this.tbAltura.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAltura.Location = new System.Drawing.Point(100, 74);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(2);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(148, 29);
            this.tbAltura.TabIndex = 8;
            // 
            // tbBase
            // 
            this.tbBase.BackColor = System.Drawing.Color.White;
            this.tbBase.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBase.Location = new System.Drawing.Point(100, 107);
            this.tbBase.Margin = new System.Windows.Forms.Padding(2);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(148, 29);
            this.tbBase.TabIndex = 9;
            // 
            // tbPerimetro
            // 
            this.tbPerimetro.BackColor = System.Drawing.Color.White;
            this.tbPerimetro.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPerimetro.Location = new System.Drawing.Point(370, 107);
            this.tbPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.tbPerimetro.Name = "tbPerimetro";
            this.tbPerimetro.ReadOnly = true;
            this.tbPerimetro.Size = new System.Drawing.Size(148, 29);
            this.tbPerimetro.TabIndex = 13;
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.White;
            this.tbArea.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArea.Location = new System.Drawing.Point(370, 70);
            this.tbArea.Margin = new System.Windows.Forms.Padding(2);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(148, 29);
            this.tbArea.TabIndex = 12;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.BackColor = System.Drawing.Color.Transparent;
            this.lblPerimetro.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerimetro.Location = new System.Drawing.Point(257, 107);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(100, 22);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArea.Location = new System.Drawing.Point(304, 73);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(53, 22);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area";
            // 
            // cmbForma
            // 
            this.cmbForma.BackColor = System.Drawing.SystemColors.Window;
            this.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForma.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Quadrado",
            "Circulo",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(100, 21);
            this.cmbForma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(148, 30);
            this.cmbForma.TabIndex = 14;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.CmbForma_SelectedIndexChanged);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriangulo.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Isósceles",
            "Equilátero",
            "Retângulo"});
            this.cmbTriangulo.Location = new System.Drawing.Point(370, 21);
            this.cmbTriangulo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(148, 30);
            this.cmbTriangulo.TabIndex = 15;
            this.cmbTriangulo.TextChanged += new System.EventHandler(this.cmbTriangulo_TextChanged);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriar.FlatAppearance.BorderSize = 100;
            this.btnCriar.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCriar.Location = new System.Drawing.Point(136, 143);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(70, 35);
            this.btnCriar.TabIndex = 17;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // listObjetos
            // 
            this.listObjetos.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjetos.FormattingEnabled = true;
            this.listObjetos.ItemHeight = 14;
            this.listObjetos.Location = new System.Drawing.Point(532, 20);
            this.listObjetos.Name = "listObjetos";
            this.listObjetos.Size = new System.Drawing.Size(332, 158);
            this.listObjetos.TabIndex = 18;
            this.listObjetos.SelectedIndexChanged += new System.EventHandler(this.CalcularNovamente);
            // 
            // LimparBotao
            // 
            this.LimparBotao.BackColor = System.Drawing.Color.Transparent;
            this.LimparBotao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LimparBotao.FlatAppearance.BorderSize = 100;
            this.LimparBotao.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparBotao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LimparBotao.Location = new System.Drawing.Point(397, 143);
            this.LimparBotao.Margin = new System.Windows.Forms.Padding(2);
            this.LimparBotao.Name = "LimparBotao";
            this.LimparBotao.Size = new System.Drawing.Size(95, 35);
            this.LimparBotao.TabIndex = 19;
            this.LimparBotao.Text = "Limpar";
            this.LimparBotao.UseVisualStyleBackColor = false;
            this.LimparBotao.Click += new System.EventHandler(this.LimparBotao_Click);
            // 
            // RemoverBotao
            // 
            this.RemoverBotao.BackColor = System.Drawing.Color.Transparent;
            this.RemoverBotao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RemoverBotao.FlatAppearance.BorderSize = 100;
            this.RemoverBotao.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverBotao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoverBotao.Location = new System.Drawing.Point(869, 77);
            this.RemoverBotao.Margin = new System.Windows.Forms.Padding(2);
            this.RemoverBotao.Name = "RemoverBotao";
            this.RemoverBotao.Size = new System.Drawing.Size(97, 35);
            this.RemoverBotao.TabIndex = 20;
            this.RemoverBotao.Text = "Remover";
            this.RemoverBotao.UseVisualStyleBackColor = false;
            this.RemoverBotao.Click += new System.EventHandler(this.RemoverBotao_Click);
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(977, 196);
            this.Controls.Add(this.RemoverBotao);
            this.Controls.Add(this.LimparBotao);
            this.Controls.Add(this.listObjetos);
            this.Controls.Add(this.btnCriar);
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
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Figures";
            this.Text = "Germetric Figures";
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
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ListBox listObjetos;
        private System.Windows.Forms.Button LimparBotao;
        private System.Windows.Forms.Button RemoverBotao;
    }
}

