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
        
        public MainForm()
        {
            InitializeComponent();
            todos.Initialize();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            introPanel.Visible = false;
            mainMenu.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ToDoEditForm toDoEditor = new ToDoEditForm();
            toDoEditor.ShowDialog();
            //ToDoEditForm frm = new ToDoEditForm("test!!!!");
            //frm.ShowDialog();
        }
    }
}