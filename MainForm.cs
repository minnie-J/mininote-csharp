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
    public partial class MainForm : Form
    {
        ToDoList todos = ToDoList.Instance();
        Dictionary<int, ToDo> todoList;

        bool isAOT = false;

        public MainForm()
        {
            InitializeComponent();
            todos.Initialize();
            todoList = todos.GetToDoList();
            setTotalCount();
            aotButton.Visible = false;

            for (int i = 0; i < todoList.Count; i++)
            {
                ToDo currentToDo = todoList[i];
                setToDo(i, currentToDo);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            aotButton.Visible = true;
            introPanel.Visible = false;
            mainMenu.Visible = true;
        }

        private void aotButton_Click(object sender, EventArgs e)
        {
            isAOT = !isAOT;

            if (isAOT)
            {
                aotButton.ForeColor = Color.SeaGreen;
                TopMost = true;
            }
            else
            {
                aotButton.ForeColor = SystemColors.ControlDark;
                TopMost = false;
            }
        }

        private void setTotalCount()
        {
            totalCount.Text = "Total" + todoList.Count;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ToDoEditForm toDoEditor = new ToDoEditForm();
            toDoEditor.ShowDialog();
            //ToDoEditForm frm = new ToDoEditForm("test!!!!");
            //frm.ShowDialog();

            setTotalCount();
        }

        private void setToDo(int idx, ToDo todo)
        {
            //// 
            //// toDoItem2
            //// 
            //this.toDoItem2.Location = new System.Drawing.Point(8, 50);
            //this.toDoItem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.toDoItem2.Name = "toDoItem2";
            //this.toDoItem2.Size = new System.Drawing.Size(360, 34);
            //this.toDoItem2.TabIndex = 1;
            //// 
            //// toDoItem1
            //// 
            //this.toDoItem1.Location = new System.Drawing.Point(8, 8);
            //this.toDoItem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.toDoItem1.Name = "toDoItem1";
            //this.toDoItem1.Size = new System.Drawing.Size(360, 34);
            //this.toDoItem1.TabIndex = 0;

            //this.todoListPanel.Controls.Add(this.toDoItem2);
            int calcPoint(int index)
            {
                return 8 + 42 * index;
            }


            ToDoItem todoItem = new ToDoItem(todo.Id);
            todoItem.Location = new System.Drawing.Point(8, calcPoint(idx));
            todoItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            todoItem.Size = new System.Drawing.Size(360, 34);
            todoItem.TabIndex = idx;

            todoListPanel.Controls.Add(todoItem);
        }
    }
}