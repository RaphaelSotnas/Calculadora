using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RealizarCalculo(string operador1, string operacao, string operador2)
        {

            double op1 = Convert.ToDouble(operador1);
            double op2 = Convert.ToDouble(operador2);
            double resultado;

            if(operacao == "+")
            {
             resultado = op1 + op2;
            }
            else if (operacao == "-")
            {
                resultado = op1 - op2;
            }
            else if (operacao == "/")
            {
                resultado = op1 / op2;
            }
            else if (operacao == "*" || operacao == "x")
            {
                resultado = op1 * op2;
            }
            else
            {
                resultado = 0;
            }

            ViewData["valor"] = resultado;

            return View();
        }
    }

}
