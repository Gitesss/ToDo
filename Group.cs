using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Group : IDisposable
    {
        public List<string> GroupCollection { get; set; }

        public Group()
        {
            GroupCollection = new List<string>();
            GroupCollection.Add("Rodzina");
            GroupCollection.Add("Szkoła");
            GroupCollection.Add("Praca");
            GroupCollection.Add("Koledzy");
            
        }

        public void Dispose()
        {
            GroupCollection.Clear();
            GroupCollection = null;
        }
    }
}
