using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora(){
            var obj = new{
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome){
            var msg = $"Olá {nome}! Seja bem vindo";

            return Ok(new {msg});
        }
    }
}