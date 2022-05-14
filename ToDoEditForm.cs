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
    public partial class ToDoEditForm : Form
    {
        ToDoList todos = ToDoList.Instance();

        bool isNew;
        ToDo todo = null;

        string defaulLabel;
        Color defaultColor = System.Drawing.SystemColors.WindowText;
        bool isEmptyString = false;

        public ToDoEditForm()
        {
            InitializeComponent();
            isNew = true;
            defaulLabel = "Tell me what To Do";
            changeLabel(defaulLabel);
        }

        public ToDoEditForm(int id)
        {
            InitializeComponent();
            isNew = false;

            todo = todos.GetToDo(id);
            textBox.Text = todo.Text;

            defaulLabel = "내용 수정";
            changeLabel(defaulLabel);
        }

        private void changeLabel(string label, Color? color = null)
        {
            infoLabel.Text = label;
            infoLabel.ForeColor = color.HasValue ? color.Value : defaultColor;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEmptyString) return;

            if (isNew)
            {
                todos.AddToDo(textBox.Text);
            }
            else
            {
                todo.Text = textBox.Text;
                todos.UpdateToDo(todo.Id, todo);
            }

            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                changeLabel("내용을 입력해주세요!", Color.Red);
                isEmptyString = true;
                return;
            }
            else
            {
                changeLabel(defaulLabel, defaultColor);
                isEmptyString = false;
            }
        }
    }
}
