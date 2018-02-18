using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Denga.Pipeworks.HttpCommunication.Example.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
