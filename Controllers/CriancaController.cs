using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Data;


namespace ProjetoIntegrador.Controllers
{
    public class CriancaController : Controller
    {
        private readonly Data.ProjetoIntegradorContext _context;
        public CriancaController(ProjetoIntegradorContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> BuscarCrianca()
        {
            return View(await _context.Criancas.ToListAsync());
        }
        public async Task<IActionResult> DetalhesCrianca(int id)
        {
            return View(await _context.Criancas.FindAsync(id));
        }

        public async Task<IActionResult> CadastroCrianca(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(await _context.Motoristas.FindAsync(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroCrianca(
            [Bind("Id,Nome_Cri,DataNasc_Cri,RG_Cri,CPF_Cri,Escola,Sala,Professor,Periodo")]
            Crianca crianca)
        {
            if (ModelState.IsValid)
            {
                if (crianca.Id != 0)
                {
                    _context.Update(crianca);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    _context.Add(crianca);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("BuscarCriancas");
            }
            return View(crianca);


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}