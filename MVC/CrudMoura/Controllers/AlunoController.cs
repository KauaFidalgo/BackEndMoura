using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public static List<Aluno> listaDeAlunos = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "João", Idade = 20, Curso = "Engenharia"},
            new Aluno { Id = 2, Nome = "Maria", Idade = 22, Curso = "Medicina"},
            new Aluno { Id = 3, Nome = "Pedro", Idade = 21, Curso = "Direito"},
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            return View();
                
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Aluno aluno)
        {
            return View();

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}