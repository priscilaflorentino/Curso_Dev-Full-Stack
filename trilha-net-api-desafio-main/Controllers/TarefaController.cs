using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trilha_net_api_desafio_main.Context;
using trilha_net_api_desafio_main.Models;

namespace trilha_net_api_desafio_main.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("Tarefa/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null) {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("Tarefa/ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefas = _context.Tarefas.Select(x=>x);
            if (tarefas.Count() == 0) {
                return NotFound();
            }
            return Ok(tarefas);
        }

        [HttpGet("Tarefa/ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefas = _context.Tarefas.Where(x=>x.Titulo.Contains(titulo));
            if (tarefas.Count() == 0) {
                return NotFound();
            }
            return Ok(tarefas);  
        }

        [HttpGet("Tarefa/ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            if (tarefa == null) {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("Tarefa/ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            if (tarefa == null) {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost("Tarefa")]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            _context.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("Tarefa/{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue) {
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            }

            var tarefaBanco = _context.Tarefas.Find(id);
            if (tarefaBanco == null) {
                return NotFound();
            }
            tarefaBanco.Titulo    = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data      = tarefa.Data;
            tarefaBanco.Status    = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok(tarefaBanco);

        }

        [HttpDelete("Tarefa/{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
