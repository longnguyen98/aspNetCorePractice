using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Dto
{
   public class TodoItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
    }
}
