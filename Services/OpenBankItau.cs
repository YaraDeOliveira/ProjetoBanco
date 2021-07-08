using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoFinal.Data.Entities;

namespace ProjetoFinal.Services
{
    public class OpenBankItau
    {
        private string UrlEndPoint = "https://api.itau/open-banking/channels/v1/electronic-channels";
        public async Task<Root> GetElectronicChannel()
        {
            //Cria requisição passando URL
            WebRequest requestGet = WebRequest.Create(UrlEndPoint);
            //Informa o metodo
            requestGet.Method = "GET";
            //cria objeto que recebera a resposta
            HttpWebResponse responseGet = (HttpWebResponse)await requestGet.GetResponseAsync();
            Root result = new Root();
            using(Stream stream = responseGet.GetResponseStream()){
                //cria um StreamReader para receber o scream
                StreamReader sr = new StreamReader(stream);
                //armazena todo o conteudo na string
                string strResult = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Root>(strResult);
            }

            return result;
        }
    }
}