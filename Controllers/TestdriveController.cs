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
    public class TestdriveController : Controller
    {
         public IActionResult formularioTestdrive(){
            return View();
        }

        public IActionResult EditarTestdrive(int Id){
            TestdriveRepository tdr = new TestdriveRepository();
            Testdrive TdEncontrado = tdr.BuscarPorId(Id);
            return View(TdEncontrado);
        }

         [HttpPost]
        public IActionResult EditarTestdrive(Testdrive u){
            TestdriveRepository tdr = new TestdriveRepository();
            tdr.Editar(u);
            return RedirectToAction("listaTd","Testdrive");
        }

        public IActionResult Excluir(int Id){
            TestdriveRepository tdr = new TestdriveRepository();
            Testdrive TdEncontrado = tdr.BuscarPorId(Id);
            tdr.Excluir(TdEncontrado);
            return RedirectToAction("listaTd","Testdrive");
        }

        [HttpPost]
        public IActionResult formulariotestdrive(Testdrive u){
            TestdriveRepository tdr = new TestdriveRepository();
            tdr.Cadastrar(u);
            return RedirectToAction("listaTd","Testdrive");
        }

        public IActionResult listaTd(){
            TestdriveRepository tdr = new TestdriveRepository();
            List<Testdrive> Lista = tdr.listar();
            return View(Lista);
        }
    }
}