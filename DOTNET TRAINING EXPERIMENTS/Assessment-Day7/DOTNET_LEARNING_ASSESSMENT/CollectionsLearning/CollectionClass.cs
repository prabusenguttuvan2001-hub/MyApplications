using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.CollectionsLearning
{
    internal class CollectionClass
    {
        static void Main(string[] args)
        {
            //ICollection<int> l = new List<int>();
            //l.Add(1);
            //l.Remove(0);
            //IList<int> list = new ObservableCollection<int>();


            //ICollection<int> num = new List<int>();


            // SETS
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };


            set1.UnionWith(set2); // A U B
            set1.IntersectWith(set2); // common elements stored in set1
            set1.ExceptWith(set2); // set2 elements present in set1 are removed.
            set1.SymmetricExceptWith(set2); // common elements removed
            var arr = new int[10];

            //set1.CopyTo(arr);

            //foreach (var sets in set1)
            //{
            //    Console.Write(sets +" ");
            //}

            //DICTIONARY

            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Parbu");
            students.Add(2, "Karthi");
            students.Add(3, "Anu");

            if(students.TryGetValue(4, out string name))
            {
                Console.WriteLine(name);
            }

            

        }

       
        
        
    }
}
