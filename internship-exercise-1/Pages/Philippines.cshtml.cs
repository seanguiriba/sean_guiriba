using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace internship_exercise_1.Pages
{
    public class PhilippinesModel : PageModel
    {
        public void OnGet()
        {
            ViewData["v1"] = "ito ang mga tourist spot sa Pilipinas woah";
            ViewData["v2"] = "ito ang mga tourist spot sa Pilipinas wow nice";
            ViewData["v3"] = "ito ang mga tourist spot sa Pilipinas lupit";
            ViewData["v4"] = "ito ang mga tourist spot sa Pilipinas panis";
            ViewData["v5"] = "ito ang mga tourist spot sa Pilipinas oyyy";
        }
    }
}
