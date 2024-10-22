using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriBem.Models;

namespace NutriBem.Controllers
{
    public class PlanoAlimentarsController : Controller
    {
        private readonly AppDbContext _context;

        public PlanoAlimentarsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PlanoAlimentars
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanosAlimentares.ToListAsync());
        }

        // GET: PlanoAlimentars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .Include(p => p.Refeicoes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        // GET: PlanoAlimentars/Create
        public async Task<IActionResult> Create()
        {
            var refeicoes = await _context.Refeicoes.ToListAsync();
            ViewBag.Refeicoes = new SelectList(refeicoes, "Id", "Tiporefeicao"); // Ajuste "Tiporefeicao" conforme necessário
            return View();
        }


        // POST: PlanoAlimentars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // POST: PlanoAlimentars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Nomepaciente,Objetivo,Descricao,Observacao")] PlanoAlimentar planoAlimentar, int[] RefeicoesSelecionadas)
        {
            if (ModelState.IsValid)
            {
                // Associar as refeições selecionadas ao plano alimentar
                if (RefeicoesSelecionadas != null)
                {
                    foreach (var refeicaoId in RefeicoesSelecionadas)
                    {
                        var refeicao = await _context.Refeicoes.FindAsync(refeicaoId);
                        if (refeicao != null)
                        {
                            planoAlimentar.Refeicoes.Add(refeicao);
                        }
                    }
                }

                _context.Add(planoAlimentar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Se o modelo não for válido, recarregue as refeições
            var refeicoes = await _context.Refeicoes.ToListAsync();
            ViewBag.Refeicoes = new SelectList(refeicoes, "Id", "Tiporefeicao");
            return View(planoAlimentar);
        }


        // GET: PlanoAlimentars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }
            return View(planoAlimentar);
        }

        // POST: PlanoAlimentars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Nomepaciente,Objetivo,Descricao,Observacao")] PlanoAlimentar planoAlimentar)
        {
            if (id != planoAlimentar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoAlimentar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoAlimentarExists(planoAlimentar.Id))
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
            return View(planoAlimentar);
        }

        // GET: PlanoAlimentars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        // POST: PlanoAlimentars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
            if (planoAlimentar != null)
            {
                _context.PlanosAlimentares.Remove(planoAlimentar);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoAlimentarExists(int id)
        {
            return _context.PlanosAlimentares.Any(e => e.Id == id);
        }
    }
}
