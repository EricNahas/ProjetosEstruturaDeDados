using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class Ambiente
    {
        private int id;
        private string name;
        private Queue<Log> logs;

        public Ambiente()
        {
            id = -1;
            Name = "-1";
        }

        public Ambiente(int id, string name, Queue<Log> logs)
        {
            this.Id = id;
            this.Name = name;
            this.Logs = logs;
        }

        public Ambiente(int id, string name)
        {
            Id = id;
            Name = name;
            Logs = new Queue<Log>();
        }

        public Ambiente (int id)
        {
            Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Queue<Log> Logs { get => logs; set => logs = value; }

        public void registraLog(Log log) 
        { 
            this.Logs.Enqueue(log);
        }


    }
}
