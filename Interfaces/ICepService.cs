using System.Threading.Tasks;
using RestSharp;

namespace EstoqueApp.Interfaces
{
    internal interface ICepService
    {
        public Task<RestResponse> GetCepInformation(string cep); 
    }
}
