using Newtonsoft.Json;
using ProjetoFiapCoinProva.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ProjetoFiapCoinProva.Layers.Service
{
    public class MoedaService
    {
        public IList<MoedaModel> Get()
        {
            var uri = String.Format("http://fiapcoin-webapi.azurewebsites.net/api/Cotacoes");


            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var moedas = JsonConvert.DeserializeObject<IList<MoedaModel>>(resultado);
                return moedas;
            }
            else
            {
                throw new Exception("Moedas não encontradas!");
            }

        }

        public MoedaModel GetById(int _id)
        {
            var uri = String.Format("http://fiapcoin-webapi.azurewebsites.net/api/Cotacoes/{0}", _id);

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var moeda = JsonConvert.DeserializeObject<MoedaModel>(resultado);
                return moeda;
            }
            else
            {
                throw new Exception("Dados da moeda não encontradas!");
            }
        }
    }
}
