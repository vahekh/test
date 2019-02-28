using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppS.Models;

namespace WebAppS.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";

            STC_1Context db = new STC_1Context();

            var ttt = (from p in db.Profiles
                       where p.ClientId == 8
                       select p).ToList();
        }
    }
}
