using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Data;


namespace ProjetoIntegrador.Controllers
{
    public class ResponsavelController : Controller
    {
        private readonly Data.ProjetoIntegradorContext _context;
        public ResponsavelController(ProjetoIntegradorContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> BuscarResponsavel()
        {
            return View(await _context.Responsaveis.ToListAsync());
        }
        public async Task<IActionResult> DetalhesResponsavel(int id)
        {
            return View(await _context.Responsaveis.FindAsync(id));
        }
        public async Task<IActionResult> AlterarResponsavel(int id)
        {
            return View(await _context.Responsaveis.FindAsync(id));
        }

        public async Task<IActionResult> CadastroResponsavel(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(await _context.Responsaveis.FindAsync(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroResponsavel(
            [Bind("Id,Nome,GrauParentesco,DataNasc,Telefone,Email,ContatoEmergencia,NomeContatoEmergencia,RG,CPF,Rua,Numero,CEP,Bairro,Cidade,Estado,NomeAdc,GrauParentescoAdc,TelefoneAdc,RuaAdc,NumeroAdc,CEPAdc,BairroAdc,EstadoAdc,CidadeAdc")]
            Responsavel responsavel)
        {
            if (ModelState.IsValid)
            {
                if (responsavel.Id != 0)
                {
                    _context.Update(responsavel);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    _context.Add(responsavel);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("BuscarResponsaveis");
            }
            return View(responsavel);


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}