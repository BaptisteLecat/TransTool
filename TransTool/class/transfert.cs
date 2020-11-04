using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransTool
{
    class Transfert
    {
        private int id;
        private string content;
        private int type;
        private DateTime date;

        public Transfert(int id, string content, int type, DateTime date)
        {
            this.id = id;
            this.content = content;
            this.type = type;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public int Type { get => type; set => type = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
