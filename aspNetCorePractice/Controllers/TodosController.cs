
using aspnetCorePractice.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServicesLayer;
using ServicesLayer.Dto;
using ServicesLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetCorePractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService todosService;

        public TodosController(ITodosService service)
        {
            todosService = service;
        }

        //[HttpGet("items")]
        //public async Task<IActionResult> List()
        //{
        //    return Ok(await _todosContext.TodoItems.ToListAsync());
        //}
        [HttpGet("folders")]
        public IActionResult Folders()
        {
            List<TodoFolderDTO> _folders = todosService.GetTodoFolders();

            return Ok(_folders);
        }
        //[HttpGet("{id}")]
        //public IActionResult FindById(string id)
        //{
        //    Console.WriteLine("Finding entity with id:" + id);
        //    bool itemExists = _todoRepository.DoesItemExist(id);
        //    if (itemExists)
        //    {
        //        return Ok(_todoRepository.Find(id));
        //    }
        //    else
        //    {
        //        return NotFound(ErrorCode.RecordNotFound.ToString());
        //    }

        //}
        //[HttpPost]
        //public IActionResult Create([FromBody] TodoItem item)
        //{
        //    try
        //    {
        //        if (item == null || !ModelState.IsValid)
        //        {
        //            return BadRequest(ErrorCode.TodoItemNameAndNotesRequired.ToString());
        //        }
        //        item.Id = Guid.NewGuid().ToString();
        //        _todoRepository.Insert(item);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest(ErrorCode.CouldNotCreateItem.ToString());
        //    }
        //    return Ok(item);
        //}
        //[HttpPut]
        //public IActionResult Edit([FromBody] TodoItem item)
        //{
        //    try
        //    {
        //        if (item == null || !ModelState.IsValid)
        //        {
        //            return BadRequest(ErrorCode.TodoItemNameAndNotesRequired.ToString());
        //        }
        //        var existingItem = _todoRepository.Find(item.Id);
        //        if (existingItem == null)
        //        {
        //            return NotFound(ErrorCode.RecordNotFound.ToString());
        //        }
        //        _todoRepository.Update(item);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest(ErrorCode.CouldNotUpdateItem.ToString());
        //    }
        //    return Ok(item);
        //}
        //[HttpDelete("{id}")]
        //public IActionResult Delete(string id)
        //{
        //    try
        //    {
        //        var item = _todoRepository.Find(id);
        //        if (item == null)
        //        {
        //            return NotFound(ErrorCode.RecordNotFound.ToString());
        //        }
        //        _todoRepository.Delete(id);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest(ErrorCode.CouldNotDeleteItem.ToString());
        //    }
        //    return NoContent();
        //}

    }
}
