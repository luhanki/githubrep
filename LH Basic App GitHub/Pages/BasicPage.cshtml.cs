using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LH_Basic_App_GitHub.Pages
{
    public class BasicPageModel : PageModel
    {
        public string Name {  get; set; }

        public void OnGet()
        {
            Class1 tp = new Class1();
            Name = tp.Name;
        }
    }
}
