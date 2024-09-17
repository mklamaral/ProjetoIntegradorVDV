using ProjetoIntegrador.Data;
using ProjetoIntegrador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoIntegrador.Controllers
{
    public class LoginResponsavelController : Controller
    {
        private readonly ProjetoIntegradorContext _context;
        public LoginResponsavelController(ProjetoIntegradorContext context)
        {
            _context = context;
        }

        //GET: Account/Login
       [HttpGet]
        public ActionResult LoginResponsavel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginResponsavel(Responsavel model)
        {
            if (ModelState.IsValid)
            {
                // Buscar o usuário no banco de dados
                var usuario = _context.Responsaveis.FirstOrDefault(p => p.Usuario == model.Usuario);

                // Verificar se o usuário existe e a senha está correta
                if (usuario != null && usuario.Senha == model.Senha)
                {
                    // Armazenar o nome do usuário no TempData
                    TempData["Usuario"] = usuario.Usuario;
                    // Opcional: Se precisar que o TempData persista além do próximo redirecionamento
                    TempData.Keep("Usuario");
                    // Armazenar o ID do usuário no TempData
                    TempData["UsuarioId"] = usuario.Id;

                    // Opcional: Se precisar que o TempData persista além do próximo redirecionamento
                    TempData.Keep("UsuarioId");

                    TempData["TipoUsuario"] = "1";
                    TempData.Keep("TipoUsuario");
                    // Login bem-sucedido, redireciona para a página inicial
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Adicionar mensagem de erro para o usuário e senha incorretos
                    ModelState.AddModelError("", "Login inválido. Verifique o usuário e a senha.");
                }
            }

            // Se chegamos aqui, algo falhou; mostre o formulário novamente com os erros
            return View(model);
        }



        //// Este método deve ser substituído pela sua lógica de autenticação real
        //private bool ValidarUsuario(string s, string u)
        //{
        //    // Simulação de verificação de usuário
        //    // Aqui, você pode usar seu banco de dados, API, ou qualquer outro método para validar o usuário
        //    var usuario = _context.Responsaveis.SingleOrDefault(p => p.Usuario == u);

        //    if (usuario == null || usuario.Senha != s)
        //        return false;
        //    else
        //        return true;

        //}

        // GET: Account/Logout
        [HttpGet]
        public ActionResult Logout()
        {
            // Lógica de logout
            // Exemplo: Session.Clear(); ou FormsAuthentication.SignOut();

            return View("Login");
        }
    }
}
