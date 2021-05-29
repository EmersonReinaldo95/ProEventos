﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento []{
            new Evento(){
                EventoId =1,
                Tema = "Angular",
                Local = " Belo Horizonte",
                Lote = "1ª Lote", 
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")  ,
                ImagemUrl = "foto.png"                
                },
                new Evento(){
                EventoId =2,
                Tema = "Angular e suas novidades",
                Local = " São Paulo",
                Lote = "2ª Lote", 
                QtdPessoas = 120,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")  ,
                ImagemUrl = "foto1.png"                
                }                                
            };   
        
       public EventoController()
        {          
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {  
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {  
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {  
            return $"Exemplo de put com id = {id}";       
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {  
            return $"Exemplo de Delete com id = {id}";       
        }

    }
}