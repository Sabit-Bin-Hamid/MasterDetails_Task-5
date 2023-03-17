using MasterDetails.Models;
using MasterDetails.Models.DemoDbContext;
using Microsoft.AspNetCore.Mvc;

namespace MasterDetails.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly ProjectDbContext _db;

        public PurchasesController(ProjectDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Purchase purchase) 
        {
            try
            {
                
                if (purchase.PurchaseDetails!=null && purchase.PurchaseDetails.Count>0)
                {
                    _db.Purchases.Add(purchase);
                    var isPurchased=_db.SaveChanges() > 0;
                    if(isPurchased)
                    {
                        
                        // Clear the input box by creating a new, empty object
                        purchase = new Purchase();
                        return RedirectToAction("Create");
                    }
                    else
                    {
                        
                        return View();
                    }

                }
                else{
                    return View();
                }
            }catch (Exception ex) { throw ex; }
        }
    }
}
