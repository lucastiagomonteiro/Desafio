using DesafioEstagio1.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using DesafioEstagio1.Services;

namespace DesafioEstagio1.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly FaturamentoService _faturamentoService;
        private readonly InverterStringService _inverterService;
        private readonly PercentualService _percentualService;

        public HomeController()
        {
            _faturamentoService = new FaturamentoService();
            _inverterService = new InverterStringService();
            _percentualService = new PercentualService();
        }

        public IActionResult Index()
        {
            return View();
        }

        //Aqui está a logica do primeiro desafio:
        public IActionResult Soma()
        {
            // Chama a função que calcula a soma dos números de 1 a 13
            return View(SomaValores());
        }
        // Método que realiza o cálculo da soma dos números de 1 até Indice
        private int SomaValores()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            return soma;
        }

        //Logica do segundo desafio:
        [HttpGet]
        public IActionResult Fibonacci()
        {
            return View(new FibonacciModel());
        }
        [HttpPost]
        public IActionResult Fibonacci(FibonacciModel model, FibonacciService service)
        {
            model.Resultado = service.CalcularFibonacci(model);
            return View(model);
        }

        //Desafio 03
        public IActionResult Faturamento(FaturamentoModel model)
        {
            _faturamentoService.FuncaoFaturamento(model);
            return View(model); // Retornando a View com o Model atualizado
        }

        //Desafio 04
        public IActionResult Percentual()
        {
            @ViewBag.resultado = _percentualService.CalculoPercentual();
            return View();
        }

        //Desafio 05
        public IActionResult InverterString() 
        {
            InverterStringModel model = new InverterStringModel();

            if (HttpContext.Request.Method == "POST")
            {
                // Obtém os dados do formulário enviado (o valor de txt)
                model.txt = HttpContext.Request.Form["txt"]; // Captura o valor enviado do input

                // Chama o método Inverter e passa o modelo
                _inverterService.Inverter(model);
            }

            return View(model);
        }
    }
}
