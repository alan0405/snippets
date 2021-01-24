using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomModel
{
    class file
    {
        public string name { get; set; }        
        public string ex { get; set; }
        public string content { get; set; }

        public file(string n,string e,string c)
        {
            name = n;
            ex = e;
            content = c;                
        }
    }
}
