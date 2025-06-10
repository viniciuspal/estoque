using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class UsuariosController : Controller
    {
        // Lista estática para simulação (pode substituir por banco de dados)
        private static List<Usuario> usuarios = new List<Usuario>();

        // Lista todos os usuários
        public IActionResult Index()
        {
            return View(usuarios);
        }

        // Exibe o formulário de cadastro
        public IActionResult Create()
        {
            return View();
        }

        // Processa o cadastro
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            usuarios.Add(usuario);
            return RedirectToAction("Index");
        }
    }
}
