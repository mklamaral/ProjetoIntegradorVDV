using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Data;


namespace ProjetoIntegrador.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly Data.ProjetoIntegradorContext _context;
        public MotoristaController(ProjetoIntegradorContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> BuscarMotorista()
        {
            return View(await _context.Motoristas.ToListAsync());
        }
        public async Task<IActionResult> DetalhesMotorista(int id)
        {
            return View(await _context.Motoristas.FindAsync(id));
        }
        public async Task<IActionResult> AlterarMotorista(int id)
        {
            return View(await _context.Motoristas.FindAsync(id));
        }

        public async Task<IActionResult> CadastroMotorista(int? id)
        {
            // Recuperar o ID do usuário do TempData ou Session
           
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
        public async Task<IActionResult> CadastroMotorista(
            [Bind("Id,Nome,DataNasc,CPF,RG,Telefone,Email,Rua,Numero,CEP,Bairro,Cidade,Estado,Complemento,Marca,Modelo,Ano_Fab,Placa,Cor,Capacidade_Passageiros,CNH,Data_ValidadeCNH,CRLV,CRMC,Data_ValidadeCRMC")]
            Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                if (motorista.Id != 0)
                {
                    _context.Update(motorista);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    _context.Add(motorista);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("BuscarMotoristas");
            }
            return View(motorista);

            
        }
        public IActionResult Index()
            {
                return View();
            }
    }
}

