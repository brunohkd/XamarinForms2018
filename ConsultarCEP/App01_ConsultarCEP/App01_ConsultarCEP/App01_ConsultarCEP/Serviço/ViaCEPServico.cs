using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace App01_ConsultarCEP.Serviço
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static void BuscarEnderecoViaCEP(string cep) {

            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wb = new WebClient();

            
            

        }
    }
}
