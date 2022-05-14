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
        }

        //private void setAOT()
        //{

        //}

        private void setTotalCount()
        {
            totalCount.Text = "Total" + todoList.Count;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            aotButton.Visible = true;
            introPanel.Visible = false;
            mainMenu.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ToDoEditForm toDoEditor = new ToDoEditForm();
            toDoEditor.ShowDialog();
            //ToDoEditForm frm = new ToDoEditForm("test!!!!");
            //frm.ShowDialog();

            setTotalCount();
        }

        private void aotButton_Click(object sender, EventArgs e)
        {
            isAOT = !isAOT;

            if (isAOT)
            {
                aotButton.ForeColor = Color.SeaGreen;
                TopMost = true;
            } else
            {
                aotButton.ForeColor = SystemColors.ControlDark;
                TopMost = false;
            }
        }
    }
}