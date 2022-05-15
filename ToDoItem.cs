using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniNote
{
    public partial class ToDoItem : UserControl
    {
        ToDoList todos = ToDoList.Instance();
        ToDo todo;

        public ToDoItem()
        {
            InitializeComponent();
        }

        public ToDoItem(int id)
        {
            InitializeComponent();
            todo = todos.GetToDo(id);
            setStatus(todo.Status);
            setText(todo.Text);
        }

        private void setStatus(int statusCode)
        {
            statucButton.Text = ((Status)statusCode).ToString();
        }

        private void setText(string text)
        {
            todoText.Text = text;
        }

        private void statucButton_Click(object sender, EventArgs e)
        {

        }

    }
}
