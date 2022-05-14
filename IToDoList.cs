using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote
{
    internal interface IToDoList
    {
        void Initialize();
        Dictionary<int, ToDo> GetToDoList();
        bool AddToDo(string text);
        bool UpdateToDo(int id, ToDo todo);
        bool RemoveToDo(int id);
    }
}
