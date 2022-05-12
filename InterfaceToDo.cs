using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote
{
    internal interface InterfaceToDo
    {
        List<ToDo> getToDoList();
        bool addToDo(ToDo toDo);
        bool updateToDo(int id, ToDo toDo);
        bool removeToDo(int id);
    }
}
