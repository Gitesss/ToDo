using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    class ClM_ToDo
    {
        public void Serialize(List<ToDo> ToDoCollection)
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                   
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, ToDoCollection);
                  
                }
               // MessageBox.Show("Udało sie zapisać do pliku.");
            }
            catch (IOException Ex)
            {
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public List<ToDo> Deserialize()
        {
            using (Stream stream = File.Open("data.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();

                List<ToDo> ToDoCollection = (List<ToDo>)bin.Deserialize(stream);
                return ToDoCollection;
            }
        }
    }
}
