using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
[Serializable]
    class ToDo 
    {
        public int Lp { get; set; }
        public string ToDoThing { get; set; }
        public int Piority { get; set; }
        public string Group { get; set; }
        public DateTime Date { get; set; }
        public List<ToDoDetails> ToDoDetails { get; set; }
     
        public ToDo()
        {
            ToDoDetails = new List<ToDoDetails>();
           
        }

        public void SetProgressBar(ProgressBar progressBar)
        {
            progressBar.Value = 0;
            int count = 0;
            foreach(ToDoDetails CurrentToDoDetails in ToDoDetails)
            {
                if (CurrentToDoDetails.Done == true)
                    count++;
                
            }
            double score = 100 * count / ToDoDetails.Count;
            int z;
            if (score>0)
            progressBar.Value = (int)score;
            progressBar.Refresh();
        }

        public void ShowToDoDetails(ListView lstToDoDetails)
        {
            lstToDoDetails.Items.Clear();
            try
            {           
                foreach (ToDoDetails CurrentToDo in ToDoDetails)
                {
                    ListViewItem newItem = new ListViewItem();
                    if(CurrentToDo.Done == true)
                        newItem.BackColor = Color.LightGreen;
                    
                    newItem.Text=CurrentToDo.Lp.ToString();
                    newItem.SubItems.Add(CurrentToDo.Task);
                    lstToDoDetails.Items.Add(newItem);
                }
            }
            catch(NullReferenceException Ex)
            {
              //  MessageBox.Show(Ex.Message);
            }
            
        }

    }
}
