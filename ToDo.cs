using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote
{
    internal class ToDo
    {
        private int id;
        private string regDate;
        private string text;
        private string status;

        public ToDo(int id, string regDate, string text, string status)
        {
            this.id = id;
            this.regDate = regDate;
            this.text = text;
            this.status = status;
        }

        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public string RegDate { 
            get { return regDate; }
            set { regDate = value; }
        }
        public string Text { 
            get { return text; }
            set { text = value; }
        }
        public string Status { 
            get { return status; }
            set { status = value; }
        }
    }
}
