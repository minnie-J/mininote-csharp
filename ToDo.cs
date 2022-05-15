using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote
{
    public enum Status
    {
        ToDo,
        Doing,
        Done
    }
    [Serializable]
    internal class ToDo
    {
        private int id;
        private string regDate;
        private string text;
        private int status;

        public ToDo(int id, string regDate, string text, int status)
        {
            this.id = id;
            this.regDate = regDate;
            this.text = text;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
