using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
namespace IdentityManager.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly IConfiguration _configuration;
        public MenuViewComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var defaultList=new List<string>
            {
                "Home"
            };
            List<string> menus = _configuration.GetSection("Menus").Get<List<string>>() ?? defaultList;
            return View(menus);
        }
    }
}
