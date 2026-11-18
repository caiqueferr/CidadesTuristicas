using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CidadesTuristicas.Pages.CityManager
{
    public class CityDetailsModel : PageModel
    {
        public void OnGet(string cityName)
        {
            CidadeRecebida = cityName;
        }

        public string CidadeRecebida { get; set; }
        public List<string> Cities = ["Rio", "São Paulo", "Brasília"];
    }
}
