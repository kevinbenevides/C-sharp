using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Checkpoint.Models;
using Projeto.Checkpoint.Repositorios;

namespace Projeto.Checkpoint.Controllers 
{
    public class UsuarioController : Controller 
    {
        [HttpGet]
        public ActionResult Index(){
            return View ();
        }

        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel(
                nome: form["nome"], 
                email: form["email"],
                senha: form["senha"],
                tipousuario: form["tipousuario"]
                                        );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction("Login", "Usuario");
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.Login(form["email"], form["senha"]);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction ("Index", "Usuario");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }
    }
}