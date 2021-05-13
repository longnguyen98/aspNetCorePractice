using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model
{
    public partial class TodoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
        public Guid? TodoFolderId { get; set; }

        public virtual TodoFolder TodoFolder { get; set; }
    }
}
