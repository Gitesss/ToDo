using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class ToDoSort
    {
        public static List<ToDo> StortByPiority(List<ToDo> ToDoCollection)
        {
            List<ToDo> tmp = new List<ToDo>();
            do
            {
                int max = ToDoCollection.Max(x => x.Piority);
                ToDo MaxPiorityObject = ToDoCollection.FirstOrDefault(x => x.Piority == max);
                tmp.Add(MaxPiorityObject);
                ToDoCollection.Remove(MaxPiorityObject);
            } while (ToDoCollection.Count > 0);
            return tmp;
        }

        private static List<string> MakeGroupList(List<ToDo> ToDoCollection)
        {
          int j = 0;
          int couter = 0;
            List<string> GroupList = new List<string>();
            foreach (ToDo todoItem in ToDoCollection)
            {
               if(j== 0)
                  GroupList.Add(todoItem.Group);

               for (int i = 0; i < GroupList.Count; i++)
               {
                   if (todoItem.Group != GroupList[i])
                      couter++; 
               }
               if (couter == GroupList.Count)
               {
                   GroupList.Add(todoItem.Group);              
               }
               couter = 0;
                j++;
            }
            return GroupList;
        }


        public static List<ToDo> StortByGroup(List<ToDo> ToDoCollection)
        {
            List<string> GroupList = new List<string>(MakeGroupList(ToDoCollection));
          

            List<ToDo> tmp = new List<ToDo>();
            for (int i = 0; i < GroupList.Count;i++ )
            {
                for(int j=0; j < ToDoCollection.Count;j++)
                {
                    if (GroupList[i] == ToDoCollection[j].Group)
                    {
                        tmp.Add(ToDoCollection[j]);
                        ToDoCollection.RemoveAt(j);
                        j = -1;
                    }

                }
            }

                return tmp;
        }

        private static double  DateDifference(DateTime one, DateTime two)
        {
            TimeSpan daysSpan = one.Subtract(two);
            return daysSpan.TotalDays;
        }

        public static Color GetColorByToDo(ToDo toDo)
        {
            DateTime Now = DateTime.Now;

            if (DateDifference(toDo.Date, Now) > 0)
            {
                return Color.White;
            }
            else if ((int)DateDifference(toDo.Date, Now) == 0)
            {
                return Color.Orange;
            }
            else if (DateDifference(toDo.Date, Now) < 0)
                return Color.Red;

            return Color.White;
        }

        private static int FindMinDate(List<ToDo> ToDoCollection)
        {
            DateTime Now = DateTime.Now;

            int min = (int)DateDifference(ToDoCollection[0].Date, Now);
            int index=0;
            int i=0;
            foreach (ToDo task in ToDoCollection )
            {
               
                int Days = (int)DateDifference(task.Date, Now);
                if(min > Days)
                {

                    index = i;
                    min = Days;
                }

                i++;
            }
            return index;
        }

        public static List<ToDo> StortByDate(List<ToDo> ToDoCollection)
        {
            List<ToDo> tmp = new List<ToDo>();
            
            int index = 0;

            do
            {
                int minDate = FindMinDate(ToDoCollection);
                tmp.Add(ToDoCollection[minDate]);
                ToDoCollection.RemoveAt(minDate);

            } while (ToDoCollection.Count > 0);

            return tmp;
        }
        
    }
}
