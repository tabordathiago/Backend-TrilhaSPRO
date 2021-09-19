using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DayOne
{
    [Route("test")]
    public class FirstController : ControllerBase //(crtl + .)
    {
        [HttpGet("getvalue")]
        public string RetornaValor(
            [FromQuery] string name,
            [FromQuery] DateTime? nascimento
            )
        {
            if (nascimento == null)
            {
                throw new Exception("data invalida");
            }

            var idade = (int)(DateTime.Now - nascimento.Value).TotalDays / 365;

            return "Seu nome é " +name+", e sua idade é: "+idade.ToString();
        }
    }
}
