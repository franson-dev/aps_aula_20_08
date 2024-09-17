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
        List<FormaGeometrica> ListaPoligonos = new List<FormaGeometrica>();
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
            ExibirRemover(false);
            ExibirLimpar(false);
        }

        private void CmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReiniciarCampos();
            


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
                    ExibirRemover(true);
                    ExibirLimpar(true);
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
                    ExibirRemover(true);
                    ExibirLimpar(true);
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
                    ExibirRemover(true);
                    ExibirLimpar(true);
                    ReiniciarAltura();
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
                    ExibirRemover(true);
                    ExibirLimpar(true);
                    break;
                default:
                    break;
            }

        }

        private void ReiniciarCampos()
        {
            tbAltura.Text = "";
            tbBase.Text = "";
            tbRaio.Text = "";
            tbLado.Text = "";
        }

        private void ReiniciarAltura()
        {
            tbAltura.Enabled = true;
            tbAltura.BackColor = Color.White;
        }

        private void ExibirLimpar(bool visivel)
        {
            LimparBotao.Visible = visivel;
        }
        private void ExibirRemover(bool visivel)
        {
            RemoverBotao.Visible = visivel;
        }

        private void ExibirCriar(bool visivel)
        {
            listObjetos.Visible = btnCriar.Visible = visivel;
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

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbForma.Text)
                {
                    case "Quadrado":
                        if (tbLado.Text != "" && double.Parse(tbLado.Text) > 0)
                        {
                            FormaGeometrica quadrado = new Quadrado() { Lado = Convert.ToDouble(tbLado.Text) };
                            listObjetos.Items.Add(quadrado);
                            ListaPoligonos.Add(quadrado);
                            tbArea.Text = quadrado.CalcularArea().ToString();
                            tbPerimetro.Text = quadrado.CalcularPerimetro().ToString();
                            tbLado.Clear();
                        }
                        break;
                    case "Retângulo":
                        if (tbAltura.Text != "" && tbBase.Text != "" && double.Parse(tbBase.Text) > 0 && double.Parse(tbAltura.Text) > 0)
                        {
                            FormaGeometrica retangulo = new Retangulo(Convert.ToDouble(tbBase.Text), Convert.ToDouble(tbAltura.Text));
                            listObjetos.Items.Add(retangulo);
                            ListaPoligonos.Add(retangulo);
                            tbArea.Text = retangulo.CalcularArea().ToString();
                            tbPerimetro.Text = retangulo.CalcularPerimetro().ToString();
                            tbAltura.Clear();
                            tbBase.Clear();
                        }
                        break;
                    case "Circulo":
                        if (tbRaio.Text != "" && double.Parse(tbRaio.Text) > 0)
                        {
                            FormaGeometrica circulo = new Circulo() { Raio = Convert.ToDouble(tbRaio.Text) };
                            listObjetos.Items.Add(circulo);
                            ListaPoligonos.Add(circulo);
                            tbArea.Text = circulo.CalcularArea().ToString();
                            tbPerimetro.Text = circulo.CalcularPerimetro().ToString();
                            tbRaio.Clear();
                        }
                        break;
                    case "Triângulo":
                        switch (cmbTriangulo.Text)
                        {
                            case "Isósceles":
                                if (tbAltura.Text != "" && tbBase.Text != "" && double.Parse(tbBase.Text) > 0 && double.Parse(tbAltura.Text) > 0)
                                {
                                    Triangulo triIsosceles = new TrianguloIsosceles(double.Parse(tbBase.Text), double.Parse(tbAltura.Text));
                                    listObjetos.Items.Add(triIsosceles);
                                    tbArea.Text = triIsosceles.CalcularArea().ToString();
                                    tbPerimetro.Text = triIsosceles.CalcularPerimetro().ToString();
                                    tbBase.Clear();
                                    tbAltura.Clear();

                                }
                                break;
                            case "Equilátero":
                                if (tbBase.Text != "" && double.Parse(tbBase.Text) > 0)
                                {
                                    Triangulo triEquilatero = new TrianguloEquilatero(double.Parse(tbBase.Text));
                                    listObjetos.Items.Add(triEquilatero);
                                    ListaPoligonos.Add(triEquilatero);
                                    tbArea.Text = triEquilatero.CalcularArea().ToString();
                                    tbPerimetro.Text = triEquilatero.CalcularPerimetro().ToString();
                                    tbAltura.Text = triEquilatero.CalcularHipotenusa().ToString();
                                    tbBase.Clear();
                                }
                                break;
                            case "Retângulo":
                                if (tbAltura.Text != "" && tbBase.Text != "" && double.Parse(tbBase.Text) > 0 && double.Parse(tbAltura.Text) > 0)
                                {
                                    Triangulo triRetangulo = new TrianguloRetangulo(double.Parse(tbBase.Text), double.Parse(tbAltura.Text));
                                    listObjetos.Items.Add(triRetangulo);
                                    ListaPoligonos.Add(triRetangulo);
                                    tbArea.Text = triRetangulo.CalcularArea().ToString();
                                    tbPerimetro.Text = triRetangulo.CalcularPerimetro().ToString();
                                    tbBase.Clear();
                                    tbAltura.Clear();
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } catch (FormatException)
            { 
                MessageBox.Show("Valor não aceito!");
                ReiniciarCampos();
            };
        }

        private void cmbTriangulo_TextChanged(object sender, EventArgs e)
        {
            if (cmbTriangulo.Text == "Equilátero" && tbAltura.Enabled)
            {
                tbAltura.Enabled = false;
                tbAltura.BackColor = Color.Silver;
                tbAltura.Text = "";
            }
            else
            {
                tbAltura.Enabled = true;
                tbAltura.BackColor = Color.White;
                tbAltura.Text = "";
            }
        }

        private void CalcularNovamente(object sender, EventArgs e)
        {
            if (listObjetos.SelectedIndex != -1)
            {
                FormaGeometrica poligonoSelecionado = ListaPoligonos[listObjetos.SelectedIndex];
                tbArea.Text = poligonoSelecionado.CalcularArea().ToString();
                tbPerimetro.Text = poligonoSelecionado.CalcularPerimetro().ToString();
            }
        }

        private void LimparBotao_Click(object sender, EventArgs e)
        {
            tbArea.Clear();
            tbPerimetro.Clear();
            tbAltura.Clear();
            tbBase.Clear();
            tbRaio.Clear();
            tbLado.Clear();
        }

        private void RemoverBotao_Click(object sender, EventArgs e)
        {
            if (listObjetos.SelectedIndex >= 0)
            {
                int selectedIndex = listObjetos.SelectedIndex;

                listObjetos.Items.RemoveAt(selectedIndex);
                ListaPoligonos.RemoveAt(selectedIndex);

                tbArea.Clear();
                tbPerimetro.Clear();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }
    }
}
