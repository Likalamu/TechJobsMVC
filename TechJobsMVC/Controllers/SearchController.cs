using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        // TODO #3: Create an action method to process a search request and render the updated search view. 

        //@RequestMapping(value = "results")
        //public String results(Model model, @RequestParam String searchType, String searchTerm)
        //{ //search in ALL columns
        //    ArrayList<HashMap<String, String>> jobsToPrint = new ArrayList<HashMap<String, String>>();
        //    if (searchType.equals("all"))
        //    {
        //        jobsToPrint = JobData.findByValue(searchTerm);

        //        model.addAttribute("title", searchTerm + " from all columns");
        //        model.addAttribute("listItems", jobsToPrint);
        //        model.addAttribute("columns", columnChoices);
        //    }
        //    else
        //    {
        //        jobsToPrint = JobData.findByColumnAndValue(searchType, searchTerm);
        //        model.addAttribute("title", searchTerm + " from " + searchType + " columns");
        //        model.addAttribute("listItems", jobsToPrint);
        //        model.addAttribute("columns", columnChoices);
        //    }
        //    return "search";
        //}
    }
}
