using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController: Controller
    {
        public IActionResult Index(){
            var model = Repostory.Applications;
            return View(model);
        }
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model){

            if(Repostory.Applications.Any(c => c.Email.Equals(model.Email))){
                ModelState.AddModelError("","Bu email önceden başvurmuş.");
            }


            if(ModelState.IsValid){
                Repostory.Add(model);
                return View("Feedback",model);
            }else{
                return View();
            }
            
        }
        
    }
    
}