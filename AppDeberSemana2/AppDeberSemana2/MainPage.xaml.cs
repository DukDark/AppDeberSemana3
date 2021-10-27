using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDeberSemana2
{
    public partial class MainPage : ContentPage
    {
        string usuariolog;
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            usuariolog = usuario;

        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);
                double valor3 = Convert.ToDouble(txtValor3.Text);
                double valor4 = Convert.ToDouble(txtValor4.Text);

                

                double porcen1 = valor1 * 0.3;
                double porcen2 = valor2 * 0.2;
                double suma = porcen1 + porcen2;
                double porcen3 = valor3 * 0.3;
                double porcen4 = valor4 * 0.2;
                double suma1 = porcen3 + porcen4;
                double suma2 = suma + suma1;
                if (suma2>=5)
                {

                txtPorcen1.Text = porcen1.ToString();
                txtPorcen2.Text = porcen2.ToString();
                txtResultado.Text = suma.ToString();
                txtPorcen3.Text = porcen3.ToString();
                txtPorcen4.Text = porcen4.ToString();
                txtResultado1.Text = suma1.ToString();
                txtValor5.Text = suma2.ToString();
                    DisplayAlert("Aprobado", "Felicidades por aprobar el curso", "ok");
                  }
                else
                {
                    DisplayAlert("Reprobado", "Su nota es menor a 5 por lo tanto, no podra rendir examen de recuperacion", "ok");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "Ok");
            }
        }

        

        private void btnSumar2_Clicked(object sender, EventArgs e)
        {

        }

        
    }
}
