using AccessSystemv4.Data;
using AccessSystemv4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AccessSystemv4.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrabajadorController(ApplicationDbContext context)
        {
            _context = context;
        }

        //HTTP Get Index
        public IActionResult Index()
        {
            IEnumerable<Trabajador> listTrabajadores = _context.Trabajador;
            return View(listTrabajadores);
        }

        //HTTP Get Create
        public IActionResult Create()
        {
            
            return View();
        }
        //HTTP Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Trabajador trabajador)
        {
            if (ModelState.IsValid) {
                _context.Trabajador.Add(trabajador);
                _context.SaveChanges();

                TempData["mensaje"] = "El trabajador se ha creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        //HTTP Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) {
                return NotFound();
            }

            //Obtener el trabajador
            var trabajador = _context.Trabajador.Find(id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return View(trabajador);
        }
        //HTTP Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                _context.Trabajador.Update(trabajador);
                _context.SaveChanges();

                TempData["mensaje"] = "El trabajador se ha actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        //HTTP Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el trabajador
            var trabajador = _context.Trabajador.Find(id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return View(trabajador);
        }
        //HTTP Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTrabajador(int? id)
        {
            //Obtener trabajador por id
            var trabajador = _context.Trabajador.Find(id);

            if (trabajador == null) {
                return NotFound();
            }

            
                _context.Trabajador.Remove(trabajador);
                _context.SaveChanges();

                TempData["mensaje"] = "El trabajador se ha eliminado correctamente";
                return RedirectToAction("Index");
            
        }


    }
}
