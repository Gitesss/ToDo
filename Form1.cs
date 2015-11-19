using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ToDo
{
    public partial class Form1 : Form , IDisposable
    {
        List<ToDo> ToDoCollection;
        Group GroupList;
        ClM_ToDo ToDoMenager;

        public Form1()
        {
            
            InitializeComponent();
            ToDoCollection = new List<ToDo>();
            GroupList = new Group();
            FillcmbGroup();
            NumberscmbPiority();
            ShowAllToDoThing();
            ToDoMenager = new ClM_ToDo();
        }
       
        private void ShowAllToDoThing()
        {
           
            foreach(ToDo CurrentToDo in ToDoCollection)
            {
               
                ListViewItem newItem = new ListViewItem();
                newItem.BackColor = ToDoSort.GetColorByToDo(CurrentToDo);
                newItem.SubItems.Add(CurrentToDo.Lp.ToString());
                newItem.SubItems.Add(CurrentToDo.ToDoThing);
                newItem.SubItems.Add(CurrentToDo.Piority.ToString());
                newItem.SubItems.Add(CurrentToDo.Group);
                newItem.SubItems.Add(CurrentToDo.Date.ToShortDateString());

                lstvMainView.Items.Add(newItem);
                //lstvMainView.Items["Lp"].Text = CurrentToDo.Lp.ToString();
                //lstvMainView.Items["ToDoCol"].Text = CurrentToDo.ToDoThing;
                //lstvMainView.Items["Piority"].Text = CurrentToDo.Piority.ToString();
                //lstvMainView.Items["Group"].Text = CurrentToDo.Group;
                //lstvMainView.Items["Date"].Text = CurrentToDo.Date.ToShortDateString();
            }
            int i = 0;
        }

        private ToDo GetSelectedObjectFromList(string Lp)
        {
            int iLp = Convert.ToInt32(Lp);

            ToDo SelectedObject = ToDoCollection.Find(x => x.Lp == iLp);
            return SelectedObject;
        }

        private ToDoDetails GetSelectedObjectFromListDetails(string Lp,ToDo selectedItem)
        {
            int iLp = Convert.ToInt32(Lp);
            ToDoDetails SelectedObject =selectedItem.ToDoDetails.Find(x => x.Lp == iLp);
            return SelectedObject;
        }

        private void AddNewRow(ToDo CurrentToDo)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.SubItems.Add(CurrentToDo.Lp.ToString());
            newItem.SubItems.Add(CurrentToDo.ToDoThing);
            newItem.SubItems.Add(CurrentToDo.Piority.ToString());
            newItem.SubItems.Add(CurrentToDo.Group);
            newItem.SubItems.Add(CurrentToDo.Date.ToShortDateString());

            lstvMainView.Items.Add(newItem);
        }
        private void NumberscmbPiority()
        {
            for (int i = 1; i <= 5; i++)
            {
                cmbPiority.Items.Add(i.ToString());
            }
        }

        private void DeleteToDoItemList()
        {
            if(lstvMainView.SelectedIndices.Count>0)
            {
                ToDoCollection.RemoveAt(lstvMainView.SelectedIndices[0]);
                ShowAllToDoThing();
            
            }
    
        }

        private void RefreshList()
        {
            lstvMainView.Items.Clear();
            ShowAllToDoThing();
            lstvMainView.Refresh();
        }

        private void FillcmbGroup()
        {
            foreach(string GroupName in GroupList.GroupCollection )
            {
                cmbGroup.Items.Add(GroupName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewToDo();
        }

        private void AddNewToDo()
        {
            ToDo newToDo = new ToDo();

            newToDo.Lp = ToDoCollection.Count + 1;
            newToDo.ToDoThing = txtToDo.Text;
            newToDo.Piority = Convert.ToInt32(cmbPiority.Text);
            newToDo.Group = cmbGroup.Text;
            newToDo.Date = dateFinish.Value;

            ToDoCollection.Add(newToDo);
            MessageBox.Show("Dodano pomyślnie.");
            AddNewRow(newToDo);
        }

        void IDisposable.Dispose()
        {
            GroupList.Dispose();
            ToDoCollection.Clear();
            ToDoCollection = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToDoMenager.Serialize(ToDoCollection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         if(File.Exists("data.bin"))
             ToDoCollection = new List<ToDo>(ToDoMenager.Deserialize());
         ShowAllToDoThing();
        }

       

        private void rdbPiority_Click(object sender, EventArgs e)
        {
           List<ToDo> temp = new List<ToDo>(ToDoSort.StortByPiority(ToDoCollection));
            ToDoCollection.Clear();
            ToDoCollection = new List<ToDo>(temp);
            RefreshList();
        }

        private void rdbGroup_Click(object sender, EventArgs e)
        {
            List<ToDo> temp = new List<ToDo>(ToDoSort.StortByGroup(ToDoCollection));
            ToDoCollection.Clear();
            ToDoCollection = new List<ToDo>(temp);
            RefreshList();
        }

        private void rnbDate_Click(object sender, EventArgs e)
        {
            List<ToDo> temp = new List<ToDo>(ToDoSort.StortByDate(ToDoCollection));
            ToDoCollection.Clear();
            ToDoCollection = new List<ToDo>(temp);
            RefreshList();
        }
      
        

        private void lstvMainView_MouseClick(object sender, MouseEventArgs e)
        {
            ToDo SelectedObject = GetSelectedObjectFromList(lstvMainView.SelectedItems[0].SubItems[1].Text);
     
            SelectedObject.ShowToDoDetails(lstToDoDetails);
            SelectedObject.SetProgressBar(progressBar1);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteToDoItemList();
            RefreshList();
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            ToDoDetails toDoDetails = new ToDoDetails();
            toDoDetails.Lp = lstToDoDetails.Items.Count+1;
            toDoDetails.Task = txtTask.Text;
            ToDo SelectedObject = GetSelectedObjectFromList(lstvMainView.SelectedItems[0].SubItems[1].Text);
            SelectedObject.ToDoDetails.Add(toDoDetails);
            txtTask.Text = String.Empty;
            SelectedObject.ShowToDoDetails(lstToDoDetails);
        }

        private void btnTaskFinish_Click(object sender, EventArgs e)
        {
            ToDo SelectedObject = GetSelectedObjectFromList(lstvMainView.SelectedItems[0].SubItems[1].Text);
            ToDoDetails toDoDetails = GetSelectedObjectFromListDetails(lstToDoDetails.SelectedItems[0].Text, SelectedObject);
            toDoDetails.Done = true;
            SelectedObject.ShowToDoDetails(lstToDoDetails);
            SelectedObject.SetProgressBar(progressBar1);
        }

      
    }
}
