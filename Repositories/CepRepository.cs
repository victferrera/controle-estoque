using EstoqueApp.Interfaces;
using System.Threading.Tasks;
using System.Net.Http;

namespace EstoqueApp.Repositories
{
    internal class CepRepository : ICepService
    {
        public async Task<HttpResponseMessage> GetCepInformation(string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";

            var client = new HttpClient();

            var response = await client.GetAsync(url);

            return response;
        }
    }
}
