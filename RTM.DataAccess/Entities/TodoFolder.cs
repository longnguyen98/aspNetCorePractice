using System;
using System.Collections.Generic;

#nullable disable

namespace RTM.DataAccess.Entities
{
    public partial class TodoFolder
    {
        public TodoFolder()
        {
            TodoItems = new HashSet<TodoItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
