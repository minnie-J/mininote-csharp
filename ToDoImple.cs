using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MiniNote
{
    internal class ToDoImple : InterfaceToDo
    {
        static string dir = AppDomain.CurrentDomain.BaseDirectory + "/data";
        static string fileName = "todos.dat";
        string filePath = dir + "/" + fileName;

        List<ToDo> toDoList = new List<ToDo>();

        void LoadData()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                toDoList = formatter.Deserialize(fs) as List<ToDo>;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error");
                throw;
            }
            finally { fs.Close(); }
        }

        bool SaveData()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, toDoList);
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            finally { fs.Close(); }
        }


        public List<ToDo> getToDoList()
        {
            DirectoryInfo dataDir = new DirectoryInfo(dir);
            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
            {
                LoadData();
            }
            
            if (!dataDir.Exists)
            {
                dataDir.Create();
            }

            return toDoList;
        }
        public bool addToDo(ToDo toDo) { return false; }
        public bool updateToDo(int id, ToDo toDo) { return false; }
        public bool removeToDo(int id) { return false; }

    }
}
