using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_bt
{
    internal class Position
    {
        private string name;
        
        public Position() { }

        public Position(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
