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
    internal class ToDoList : IToDoList
    {
        // Singleton
        private static ToDoList instance = null;
        public static ToDoList Instance()
        {
            if (instance == null)
            {
                instance = new ToDoList();
            }
            return instance;
        }

        private Dictionary<int, ToDo> todos = new Dictionary<int, ToDo>();
        private int _id = 0;

        public void Initialize()
        {
            DirectoryInfo dataDir = new DirectoryInfo(dir);
            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
            {
                LoadData();

                // LINQ로 max값 찾아서 새 ToDo에 들어갈 아이디 정의
                _id = todos.Max(todo => todo.Key) + 1;
            }

            if (!dataDir.Exists)
            {
                dataDir.Create();
            }
        }

        public Dictionary<int, ToDo> GetToDoList()
        {
            return todos;
        }
        private void SetToDoList(Dictionary<int, ToDo> todos)
        {
            this.todos = todos;
        }
        public ToDo GetToDo(int id)
        {
            return this.todos[id];
        }
        public bool AddToDo(string text)
        {
            string regDate = DateTime.Now.ToString("G");
            int status = 0;
            ToDo todo = new ToDo(_id, regDate, text, status);

            todos.Add(_id, todo);

            bool result = SaveData();

            if (result)
            {
                _id++;
            }
            else
            {
                RemoveToDo(_id);
            }

            return result;
        }
        public bool RemoveToDo(int id)
        {
            todos.Remove(id);
            return false;
        }
        public bool UpdateToDo(int id, ToDo todo)
        {
            todos[id] = todo;
            return false;
        }



        // 파일 read/write --------------

        static string dir = AppDomain.CurrentDomain.BaseDirectory + "data";
        static string fileName = "todos.dat";
        static string filePath = dir + "\\" + fileName;

        private void LoadData()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Dictionary<int, ToDo> list = formatter.Deserialize(fs) as Dictionary<int, ToDo>;
                SetToDoList(list);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File Not Found.");
                throw;
            }
            finally { fs.Close(); }
        }

        private bool SaveData()
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, todos);

                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            finally { fs.Close(); }
        }
    }
}
