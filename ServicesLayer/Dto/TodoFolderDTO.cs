using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Dto
{
   public class TodoFolderDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<TodoItemDTO> TodoItems { get; set; }

        public TodoFolderDTO()
        {
            TodoItems = new List<TodoItemDTO>();
        }
    }
}
