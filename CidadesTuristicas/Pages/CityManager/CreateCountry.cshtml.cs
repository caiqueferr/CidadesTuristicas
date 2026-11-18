using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;


namespace CidadesTuristicas.Pages.CityManager
{
    public class CreateCountryModel : PageModel
    {
        public void OnGet()
        {
            Paises = new List<InputModel>();

            for (int i = 0; i < 5; i++)
            {
                Paises.Add(new InputModel());
            }
        }


        public void OnPost()
        {

            if (ModelState.IsValid)
            {
               
            }


        }


        [BindProperty]
        public List<InputModel> Paises { get; set; } = new List<InputModel>();


 

        public class InputModel
        {


            [Required(ErrorMessage = "O nome do País é obrigatório")]


            [MinLength(3, ErrorMessage = "O nome deve ter pelo menos {1} caracteres")]
            public string CountryName { get; set; }


            
            [Required(ErrorMessage = "O codigo do País é obrigatório")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve conter exatamente 2 caracteres.")] 
            public string CountryCode { get; set; }


        }
    }
}
