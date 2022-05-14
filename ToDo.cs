﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote
{
    enum Status
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

        public int Id { get; set; }
        public string RegDate { get; set; }
        public string Text { get; set; }
        public int Status { get; set; }
    }
}
