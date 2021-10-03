using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImcApp.Api.Entities;
using ImcApp.Api.Controllers;

 /* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2, Ejercicio 1: iIMC
    Nombre del alumno: Rafael Salazar Perera
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace ImcApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImcController : ControllerBase
    {
         [HttpPost]
        public string ResultadoFinal( IMC iMC)
        {    
            String men="";
             double Resultado;

            Resultado = (iMC.Peso / Math.Pow((iMC.Altura/100), 2));

           
            if(Resultado < 18.5)
            {
                 men= "Su peso es inferior a lo normal";
            }
            else
            {
                if(Resultado>= 18.5  && Resultado <=24.9)
                {
                     men="Su peso esta bien";
                }
                else
                {
                    if(Resultado>=25.00 && Resultado <= 29.9)
                    {
                         men="Su Peso esta un poco mas alto de lo normal";
                    }
                    else
                    {
                         men="Tienes sobre peso";
                    }
                }
                
            }
          return"Tu imc: "+ Convert.ToString(Resultado)+"Tu peso es:"+ men;
           
        
        }

    }
    
}