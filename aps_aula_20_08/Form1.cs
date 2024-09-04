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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbForma.Text)
            {
                case "Circunferência":
                    ExibirRaio(true);
                    ExibirLado(false);
                    ExibirAltura(false);
                    ExibirBase(false);
                    ExibirTriangulo(false);
                    break;
                case "Triângulo":
                    ExibirRaio(false);
                    ExibirBase(true);
                    ExibirLado(false);
                    ExibirAltura(true);
                    ExibirTriangulo(true);
                    break;
                case "Retângulo":
                    ExibirBase(true);
                    ExibirRaio(false);
                    ExibirAltura(true);
                    ExibirLado(false);
                    ExibirTriangulo(false);
                    break;
                case "Quadrado":
                    ExibirBase(false);
                    ExibirRaio(false);
                    ExibirAltura(false);
                    ExibirLado(true);
                    ExibirTriangulo(false);
                    break;
                default:
                    break;
            }
           
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
    }
}
