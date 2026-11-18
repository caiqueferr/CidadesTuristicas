using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CidadesTuristicas.Pages.CityManager
{
    public class SaveNoteModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {

            if (ModelState.IsValid)
            {
                Conteudo = Input.Content;

                string pastaPrincipal = _environment.WebRootPath;

                string pastaFiles = Path.Combine(pastaPrincipal, "files");

                Directory.CreateDirectory(pastaFiles);

                string nomeArquivo = $"note-{DateTime.Now.Ticks}.txt";
                string caminhoCompleto = Path.Combine(pastaFiles, nomeArquivo);

                System.IO.File.WriteAllText(caminhoCompleto, Conteudo);
                ArquivoSalvo = $"/files/{nomeArquivo}";
            }

        }


        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public string Conteudo { get; set; }
        public string ArquivoSalvo { get; set; }

        private readonly IWebHostEnvironment _environment;
        
        

        public SaveNoteModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


    public class InputModel
        {
            public string Content { get; set; }
        }
    }
}
