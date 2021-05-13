using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model
{
    public partial class TodoFolder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TodoItem> TodoItems { get; set; }

        public TodoFolder()
        {
            TodoItems = new List<TodoItem>();
        }
    }
}

