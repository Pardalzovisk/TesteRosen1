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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            cliente.Id = Clientes.Select(x => x.Id).Max() + 1; 
            Clientes.Add(cliente);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            var clienteOld = Clientes.Where(cli => cli.Id == cliente.Id).First();
            Clientes.Remove(clienteOld);
            Clientes.Add(cliente); 
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }

        public IActionResult Delete(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = Clientes.Where(cli => cli.Id == id).First();
            Clientes.Remove(cliente);
            return RedirectToAction("Index");
        }

    }
}
