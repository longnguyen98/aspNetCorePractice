using ServicesLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public interface ITodosService
    {
        List<TodoFolderDTO> GetTodoFolders();
    }
}
