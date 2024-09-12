using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triângulo":
                    SelecionarTriangulo();
                    break;
                case "Retângulo":
                    SelecionarRetangulo();
                    break;
                case "Circunferência":
                    SelecionarCircunferencia();
                    break;
               
            }
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            ExibirLado1(false);
            ExibirLado2(false);

            lblRaio.Visible = txtRaio.Visible = false;
            cmbTriangulo.Visible = false;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void SelecionarTriangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirLado1(true);
            ExibirLado2(true);
            ExibirRaio(false);
            lblRaio.Visible = txtRaio.Visible = false;
            cmbTriangulo.Visible = true;
        }


        private void ExibirLado1(bool visivel)
        {
            lblLado1.Visible = txtLado1.Visible = visivel;
        }

        private void ExibirLado2(bool visivel)
        {
            lblLado2.Visible = txtLado2.Visible = visivel;
        }


        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirLado1(false);
            ExibirLado2(false);
            lblRaio.Visible = txtRaio.Visible = false;
            cmbTriangulo.Visible = false;

        }

        private void SelecionarCircunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirLado1(false);
            ExibirLado2(false);
            ExibirRaio(true);
            lblRaio.Visible = txtRaio.Visible = true;
            cmbTriangulo.Visible = false;
        }
        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }



        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado()
                {
                    Lado = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);
            }
            else if (cmbForma.Text.Equals("Retângulo"))
            {
                FormaGeometrica retangulo = new Retangulo()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(retangulo);
            }
            else if (cmbForma.Text.Equals("Triângulo"))
            {
               
                FormaGeometrica triangulo = new Triangulo()
                {
                    
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text),
                    Lado1 = Convert.ToDouble(txtLado1.Text),
                    Lado2 = Convert.ToDouble(txtLado2.Text)

                };
                cmbObjetos.Items.Add(triangulo);
            }
            else if (cmbForma.Text.Equals("Circunferência"))
            {
                FormaGeometrica circunferencia = new Circunferencia()
                {
                   Raio = (int)Convert.ToDouble(txtRaio.Text)
                   

                };
                cmbObjetos.Items.Add(circunferencia);

            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                
                e.Handled = true;
            }

           
            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
               
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
               
                e.Handled = true;
            }

           
            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
    
    
    
}
