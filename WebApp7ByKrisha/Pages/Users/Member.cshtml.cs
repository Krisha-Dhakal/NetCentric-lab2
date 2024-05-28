using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages.Users
{
    [Authorize(Roles = "Admin, Member")]
    public class MemberModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
