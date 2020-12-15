using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public abstract class SortStrategy
    {
        public abstract List<Student> Sort(List<Student> list);
    }

    class ByName : SortStrategy
    {
        public override List<Student> Sort(List<Student> list)
        {
            return list.OrderBy(s => s.Name).ToList();
        }
    }

    class ByIndexNumber : SortStrategy
    {
        public override List<Student> Sort(List<Student> list)
        {
            return list.OrderBy(s => s.IndexNumber).ToList();
        }
    }

    public class StudentSortedList
    {
        private List<Student> list = new List<Student>();
        private SortStrategy sortStrategy;

        public List<Student> List { get { return list; } set { list = value; } }

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortStrategy = sortstrategy;
        }

        public List<Student> Sort()
        {
            return this.sortStrategy.Sort(list);
        }
    }
}
