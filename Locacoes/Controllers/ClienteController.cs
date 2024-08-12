using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Locacoes.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                Id = 1,
                Nome = "Rebeca",
                Email = "rebecaAndrade@mail.com",
                Telefone = "(21)999887799",
                Cidade = "Rio de Janeiro"
            },
            new Cliente()
            {
                Id = 2,
                Nome = "Medina",
                Email = "gabrielMedina@mail.com",
                Telefone = "(14)998887744",
                Cidade = "Santos"
            }

        };
        public IActionResult Index()
        {
            return View(Clientes);
        }
    }
}
