namespace ServicesLayer.Services
{
    using AutoMapper;
    using DataAccess.Model;
    using Microsoft.EntityFrameworkCore;
    using ServicesLayer.Dto;
    using System.Collections.Generic;
    using System.Linq;

    public class TodosService : ITodosService
    {
        readonly TodosContext todosContext;
        readonly Mapper mapper;

        public TodosService(TodosContext context)
        {
            todosContext = context;
            mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TodoFolder, TodoFolderDTO>();
                cfg.CreateMap<TodoItem, TodoItemDTO>();
            }           )
            );
        }

        public List<TodoFolderDTO> GetTodoFolders()
        {
            List<TodoFolderDTO> dtos = new();
            this.todosContext.TodoFolders.Include(f => f.TodoItems).ToList().ForEach(folderEntity =>
            {

                dtos.Add(this.mapper.Map<TodoFolderDTO>(folderEntity));
            });

            return dtos;
        }
    }
}