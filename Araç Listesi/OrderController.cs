using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private List<Marka> GetMarkas()
        {
            return new List<Marka>
            {
                new Marka {Id=1, Name="Audi"},
                new Marka {Id=2, Name="BMW"},
                new Marka {Id=3, Name="Mercedes"}

            };
        }

        private List<Model> GetModels()
        {
            return new List<Model>
            {
                new Model {Id=1, Name="Audi=A3"},
                new Model {Id=1, Name="Audi=A4"},
                new Model {Id=2, Name="Bmw=320"},
                new Model {Id=2, Name="Bmw=520"},
                new Model {Id=3, Name="Mercedes=A200"},
                new Model {Id=3, Name="Mercedes=AMG-GT"}
            };
        }

        private List<Kasa> GetKasas()
        {
            return new List<Kasa>
            {
                new Kasa {Id=1, Name="Sedan"},
                new Kasa {Id=2, Name="Hatchback"},
            };
        }

        private List<Renk> GetRenks()
        {
            return new List<Renk>
            {
                new Renk {Id=1, Name="Beyaz"},
                new Renk {Id=1, Name="Siyah"},
                new Renk {Id=2, Name="Sarı"},
                new Renk {Id=2, Name="Lacivert"},
                new Renk {Id=3, Name="Yeşil"},
                new Renk {Id=3, Name="Kırmızı"}
            };
        }


        public IActionResult Index()
        {
            var model = new Order
            {
                Models = GetModels(),
                Markas = GetMarkas(),
                Kasas = GetKasas(),
                Renks = GetRenks()
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Order model)
        {
            if (ModelState.IsValid)
            {

                TempData["SuccessMessage"] = "Siparişiniz Başarılı";
                return RedirectToAction("Index");

            }
            model.Models = GetModels();
            model.Markas = GetMarkas();
            model.Kasas = GetKasas();
            model.Renks = GetRenks();
            return View(model);
        }


    }
}
