using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieHandlerRazor.Services;

namespace MovieHandlerRazor.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        public List<Models.Studios> Studios {get; set;}
        public StudioService StudioService {get; set;}

        public GetStudiosModel(StudioService studioService)
        {
            this.StudioService = studioService;
        }

        public IActionResult OnGet()
        {
            Studios = StudioService.GetAllStudios();
            return Page();
        }
    }
}
