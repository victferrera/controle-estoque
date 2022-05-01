using System.Threading.Tasks;
using System.Net.Http;

namespace EstoqueApp.Interfaces
{
    internal interface ICepService
    {
        Task<HttpResponseMessage> GetCepInformation(string cep);
    }
}
