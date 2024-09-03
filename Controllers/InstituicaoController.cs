using Capitulo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Capitulo01.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes =
            new List<Instituicao>()
            {
                new Instituicao()
                {
                    InstituicaoID = 1,
                    Nome = "UFRGS",
                    Endereco = "Porto Alegre"
                },
                new Instituicao()
                {
                    InstituicaoID = 2,
                    Nome = "Feevale",
                    Endereco = "Novo Hamburgo"
                },
                new Instituicao()
                {
                    InstituicaoID = 3,
                    Nome = "Unisinos",
                    Endereco = "São Leopoldo"
                },
                new Instituicao()
                {
                    InstituicaoID = 4,
                    Nome = "Faccat",
                    Endereco = "Taquara"
                },
                new Instituicao()
                {
                    InstituicaoID = 5,
                    Nome = "PUCRS",
                    Endereco = "Porto Alegre"
                }
            };
        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.InstituicaoID));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            return RedirectToAction("Index");
        }
    }
}
