using BuscaCEP.Models;
using Newtonsoft.Json;
using System.Security.Policy;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace BuscaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Url = "https://viacep.com.br/ws/";

        private void BuscarCEP(object sender, EventArgs e)
        {

            var newUrl = Url + tb_CEP.Text + "/json";
            lb_MostrarDados.Items.Clear();
            tb_CEP.Clear();
            HttpClient client = new HttpClient();
            var response = client.GetAsync(newUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var req = response.Content.ReadAsStringAsync().Result;
                var ceplocalization = JsonConvert.DeserializeObject<Localization>(req);

                if (ceplocalization != null)
                {
                    AdiconarDadosLB(ceplocalization);                               
                }
            } else
            {
                MessageBox.Show("O CEP inserido não foi encontrado!");
            }


        }

        private void AdiconarDadosLB(Localization dados)
        {
            lb_MostrarDados.Items.Add("CEP: " + dados.CEP);
            lb_MostrarDados.Items.Add("UF: " + dados.Uf);
            lb_MostrarDados.Items.Add("IBGE: " + dados.Ibge);
            lb_MostrarDados.Items.Add("BAIRRO: " + dados.Bairro);
            lb_MostrarDados.Items.Add("COMPLEMENTO: " + dados.Complemento);
            lb_MostrarDados.Items.Add("DDD: " + dados.DDD);
            lb_MostrarDados.Items.Add("LOCADIDADE: " + dados.Localidade);
            lb_MostrarDados.Items.Add("LOGRADOURO: " + dados.Logradouro);
            lb_MostrarDados.Items.Add("GIA: " + dados.Gia);
            lb_MostrarDados.Items.Add("SIAFI: " + dados.Siafi);
        }

    }
}