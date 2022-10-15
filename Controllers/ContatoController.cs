using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PI_MVC_SQL.Models;

namespace PI_MVC_SQL.Controllers
{
    public class ContatoController : Controller
    {
         public IActionResult formulariocontato(){
            return View();
        }

        public IActionResult EditarContato(int Id){
            ContatoRepository cr = new ContatoRepository();
            Contato CEncontrado = cr.BuscarPorId(Id);
            return View(CEncontrado);
        }

         [HttpPost]
        public IActionResult EditarContato(Contato u){
            ContatoRepository cr = new ContatoRepository();
            cr.Editar(u);
            return RedirectToAction("listaMensagem","Contato");
        }

        public IActionResult Excluir(int Id){
            ContatoRepository cr = new ContatoRepository();
            Contato CEncontrado = cr.BuscarPorId(Id);
            cr.Excluir(CEncontrado);
            return RedirectToAction("listaMensagem","Contato");
        }

        [HttpPost]
        public IActionResult formulariocontato(Contato u){
            ContatoRepository cr = new ContatoRepository();
            cr.Cadastrar(u);
            return RedirectToAction("listaMensagem","Contato");
        }

        public IActionResult listaMensagem(){
            ContatoRepository cr = new();
            List<Contato> Lista = cr.Listar();
            return View(Lista);
        }
    }
}