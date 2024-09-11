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
                case "Circunferência":
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
                    FormaGeometrica objeto = new Quadrado() { Lado = Convert.ToDouble(tbLado.Text) };
                    cmbObjetos.Items.Add(objeto);
                    tbLado.Clear();
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
