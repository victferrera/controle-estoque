using EstoqueApp.Interfaces;
using System.Threading.Tasks;
using RestSharp;

namespace EstoqueApp.Repositories
{
    internal class CepRepository : ICepService
    {
        public async Task<RestResponse> GetCepInformation(string cep)
        {
            var client = new RestClient("https://viacep.com.br/ws/");

            var request = new RestRequest($"{cep}/json/");

            var response = await client.ExecuteGetAsync(request);

            return response;
        }
    }
}
