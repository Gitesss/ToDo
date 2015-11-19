using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{

[Serializable]
    class ToDoDetails
    {
        public int Lp { set; get; }
        public string Task { get; set; }
        public bool Done { get; set; }
   
    }
}
