using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Les14.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Les14.Controllers
{
    public class BindingController : Controller
    {
        [HttpGet]
        public IActionResult MultipleCheckbox()
        {
            MultipleCheckboxViewModel model = new MultipleCheckboxViewModel();
            foreach (var id in new string[] { "A", "B", "C", "D", "E"})
            {
                model.Checkboxen.Add(new MultipleCheckboxViewModel.Checkbox()
                {
                    Selected = false,
                    ID = id,
                    Text = $"Hier wat uitleg over {id}"
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult MultipleCheckbox(MultipleCheckboxViewModel model)
        {
            var aangvinkteIds = model.Checkboxen.Where(c => c.Selected).Select(c => c.ID).ToList();
            return Json($"Jij vinkte {string.Join(',',aangvinkteIds)} aan");
        }
    }
}