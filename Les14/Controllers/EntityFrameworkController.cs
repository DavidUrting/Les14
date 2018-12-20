using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Les14.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Les14.Controllers
{
    public class EntityFrameworkController : Controller
    {
        public IActionResult ParentChild()
        {
            CreateInitialDataIfNecessary();

            RelationManager mgr = new RelationManager();
            Parent p = mgr.GetParent(1, true);

            return View(p);
        }

        private void CreateInitialDataIfNecessary()
        {
            RelationManager mgr = new RelationManager();
            if (mgr.GetParent(1, false) == null)
            {
                mgr.AddParent(new Parent()
                {
                    Children = new List<Child>
                    {
                        new Child() { ParentID = 1 },
                        new Child() { ParentID = 1 }, 
                        new Child() { ParentID = 1 }
                    }
                });
            }
        }
    }
}