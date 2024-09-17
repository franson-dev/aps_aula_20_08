using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aps_aula_20_08
{
    public partial class Figures : Form
    {
        public Figures()
        {
            InitializeComponent();

            ExibirRaio(false);
            ExibirBase(false);
            ExibirLado(false);
            ExibirAltura(false);
            ExibirTriangulo(false);
            ExibirArea(false);
            ExibirPerimetro(false);
            ExibirCriar(false);
        }

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch (cmbForma.Text)
            {
                case "Circulo":
                    ExibirRaio(true);
                    ExibirArea(true);
                    ExibirPerimetro(true);
                    ExibirCriar(true);
                    ExibirBase(false);
                    ExibirLado(false);
                    ExibirAltura(false);
                    ExibirTriangulo(false);
                    break;
                case "Triângulo":
                    ExibirBase(true);
                    ExibirAltura(true);
                    ExibirTriangulo(true);
                    ExibirArea(true);
                    ExibirPerimetro(true);
                    ExibirCriar(true);
                    ExibirLado(false);
                    ExibirRaio(false);
                    break;
                case "Retângulo":
                    ExibirBase(true);
                    ExibirAltura(true);
                    ExibirArea(true);
                    ExibirPerimetro(true);
                    ExibirCriar(true);
                    ExibirLado(false);
                    ExibirRaio(false);
                    ExibirTriangulo(false);
                    break;
                case "Quadrado":
                    ExibirLado(true);
                    ExibirArea(true);
                    ExibirPerimetro(true);
                    ExibirCriar(true);
                    ExibirRaio(false);
                    ExibirBase(false);
                    ExibirAltura(false);
                    ExibirTriangulo(false);

                    break;
                default:
                    break;
            }
           
        }

        private void ExibirCriar(bool visivel)
        {
            cmbObjetos.Visible = btnCriar.Visible = visivel;
        }

        private void ExibirPerimetro(bool visivel)
        {
            lblPerimetro.Visible = tbPerimetro.Visible = visivel;
        }

        private void ExibirArea(bool visivel)
        {
            lblArea.Visible = tbArea.Visible = visivel;
        }

        private void ExibirTriangulo(bool visivel)
        {
            cmbTriangulo.Visible = lblTriangulo.Visible = visivel;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = tbBase.Visible = visivel;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = tbAltura.Visible = visivel;
        }


        private void ExibirLado(bool visivel)
        {
            lblLado.Visible = tbLado.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = tbRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            switch(cmbForma.Text)
            {
                case "Quadrado":
                    if (tbLado.Text != "")
                    {
                        FormaGeometrica quadrado = new Quadrado() { Lado = Convert.ToDouble(tbLado.Text) };
                        cmbObjetos.Items.Add(quadrado);
                        tbLado.Clear();
                        tbArea.Text = quadrado.CalcularArea().ToString();
                        tbPerimetro.Text = quadrado.CalcularPerimetro().ToString();
                    }
                    break;
                case "Retângulo":
                    if (tbAltura.Text != "" && tbBase.Text != "")
                    {
                        FormaGeometrica retangulo = new Retangulo(Convert.ToDouble(tbBase.Text),Convert.ToDouble(tbAltura.Text));
                        cmbObjetos.Items.Add(retangulo);
                        tbBase.Clear();
                        tbAltura.Clear();
                        tbArea.Text = retangulo.CalcularArea().ToString();
                        tbPerimetro.Text = retangulo.CalcularPerimetro().ToString();
                    }
                    break;
                case "Circulo":
                    if (tbRaio.Text != "")
                    {
                        FormaGeometrica circulo = new Circulo() { Raio = Convert.ToDouble(tbRaio.Text)};
                        cmbObjetos.Items.Add(circulo);
                        tbRaio.Clear();
                        tbArea.Text = circulo.CalcularArea().ToString();
                        tbPerimetro.Text = circulo.CalcularPerimetro().ToString();
                    }
                    break;
                case "Triângulo":
                    switch (cmbTriangulo.Text)
                    {
                        case "Isósceles":
                            break;
                        case "Equilátero":
                            break;
                        case "Retângulo":
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
