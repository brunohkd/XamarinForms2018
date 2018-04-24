using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ConsultarCEP.Servico.Modelo;
using ConsultarCEP.Servico;

namespace ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BuscarButton.Clicked += BuscarCEP;
		}

        private void BuscarCEP(object sender, EventArgs args) {

            //TODO - Lógica

            //TODO - Validações

            string cep = "";

            if (CepEntrada.Text != null) { 
                cep = CepEntrada.Text.Trim();
            }

            if (isValidCEP(cep)) {
                try {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        CepSaida.Text = string.Format("Endereço: {2} - {3}, {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
                    } else
                    {
                        DisplayAlert("ERRO!", "O endereço não foi encontrado para o cep informado: " + cep, "OK");
                    }
                } catch (Exception e) {
                    DisplayAlert("ERRO!", e.Message, "OK");
                }
            } else
            {
                //TODO
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valid = true;
           
            if(cep.Length != 8) {
                DisplayAlert("ERRO!", "CEP Inválido! O CEP deve conter 8 caracteres.", "OK");
                valid = false;
            }
            int NovoCep = 0;
            if (!int.TryParse(cep, out NovoCep)) { //valida se o cep digitado é numérico.
                DisplayAlert("ERRO!", "CEP Inválido! O CEP deve conter apenas números.", "OK");
                valid = false;
            }


            return valid;
        }
	}
}
