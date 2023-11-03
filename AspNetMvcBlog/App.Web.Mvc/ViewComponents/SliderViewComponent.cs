using App.Persistence.Data;
using Microsoft.AspNetCore.Mvc;


namespace App.Web.Mvc.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var database = new DataBase();
            var sliderItem = database.SliderItems; 
            return View(sliderItem);
            
        }
    }
}