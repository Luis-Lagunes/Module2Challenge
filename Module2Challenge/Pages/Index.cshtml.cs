using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double MilesDriven { get; set; }
    [BindProperty]
    public double GallonsUsed { get; set; }
    public double MPG { get; set; }
    public bool ShowResult { get; set; }

        public void OnPost()
        {
            double milesDriven = MilesDriven;
            double gallonsUsed = GallonsUsed;
            MPG = milesDriven / gallonsUsed;
            ShowResult = true;
        }
    }