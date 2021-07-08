using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Data.Entities;
using ProjetoFinal.Services;

namespace ProjetoFinal.Controllers
{
    public class OpenBankController : Controller
    {

        private readonly OpenBankItau _openBankItau;
        public OpenBankController(OpenBankItau openBankItau){
            _openBankItau = openBankItau;
        }

        public async Task<Root> GetElectronicChannel()
        {
            return await _openBankItau.GetElectronicChannel();
        }
    }
}