using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestCrudCore.Models;

namespace TestCrudCore.Controllers
{
    public class ManutenzioneController : Controller
    {
        private readonly DataContext _context;

        public ManutenzioneController(DataContext context)
        {
            _context = context;
        }

        // GET: Manutenzione
        public async Task<IActionResult> Index()
        {
            return View(await _context.Manutenzione.ToListAsync());
        }

        // GET: Manutenzione/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manutenzioneModel = await _context.Manutenzione
                .FirstOrDefaultAsync(m => m.IdMacchina == id);
            if (manutenzioneModel == null)
            {
                return NotFound();
            }

            return View(manutenzioneModel);
        }

        // GET: Manutenzione/Create
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMacchina,MacchinaImg,CodMacchina,DesMacchina,IdTipoGetMacchina,Modello,Matricola,Marca,OreDisponibilita,Autonoma,MultiCommessa,DataAcquisto,Specifiche,IdStato,IdFunzione,IdReparto,IdCentrocosto,CostoOrario,OnLine,Schedula,TipoConnessione,DesConnessione,Validita,DesReparto,DesFunzione,DesStato,DesCentrocosto")] ManutenzioneModel manutenzioneModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manutenzioneModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manutenzioneModel);
        }

        // GET: Manutenzione/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manutenzioneModel = await _context.Manutenzione.FindAsync(id);
            if (manutenzioneModel == null)
            {
                return NotFound();
            }
            return View(manutenzioneModel);
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMacchina,MacchinaImg,CodMacchina,DesMacchina,IdTipoGetMacchina,Modello,Matricola,Marca,OreDisponibilita,Autonoma,MultiCommessa,DataAcquisto,Specifiche,IdStato,IdFunzione,IdReparto,IdCentrocosto,CostoOrario,OnLine,Schedula,TipoConnessione,DesConnessione,Validita,DesReparto,DesFunzione,DesStato,DesCentrocosto")] ManutenzioneModel manutenzioneModel)
        {
            if (id != manutenzioneModel.IdMacchina)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manutenzioneModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManutenzioneModelExists(manutenzioneModel.IdMacchina))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(manutenzioneModel);
        }

        // GET: Manutenzione/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manutenzioneModel = await _context.Manutenzione
                .FirstOrDefaultAsync(m => m.IdMacchina == id);
            if (manutenzioneModel == null)
            {
                return NotFound();
            }

            return View(manutenzioneModel);
        }

        // POST: Manutenzione/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var manutenzioneModel = await _context.Manutenzione.FindAsync(id);
            _context.Manutenzione.Remove(manutenzioneModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManutenzioneModelExists(int id)
        {
            return _context.Manutenzione.Any(e => e.IdMacchina == id);
        }
    }
}
