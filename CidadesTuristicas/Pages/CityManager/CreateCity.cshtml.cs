using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CidadesTuristicas.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        public void OnGet()
        {

        }


        public void OnPost()
        {

                      

            if (ModelState.IsValid)
            {
                CidadeRecebida = Input.CityName;
            }
 
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public string CidadeRecebida { get; set; } 

        public class InputModel
        {


            [Required(ErrorMessage = "O nome da cidade é obrigatório")]


            [MinLength(3, ErrorMessage = "O nome deve ter pelo menos {1} caracteres")]
            public string CityName {  get; set; }
            
            
        }
    }
}
