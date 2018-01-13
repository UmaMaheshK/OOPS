using System;
using System.Linq;

namespace OOPS.Indexers
{
    class IndexerExp4
    {
        private string[] names;
        public IndexerExp4(int size)
        {
            names = new string[size];
            int index = 0;
            Array.ForEach(names, element => { names[index++] = "Empty"; Console.WriteLine("name[{0}] = {1}", index - 1, names[index - 1]); });
            //names.Select(element => { element = "Empty"; return element; });
        }

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }

        static void Main(string[] args)
        {
            int size = 10;
            IndexerExp4 index = new IndexerExp4(size);

            index[9] = "Some Value";
            index[3] = "Another Value";
            index[5] = "Any Value";

            Console.WriteLine("\nAfter change values\n");
            for (int i = 0; i < size; i++)
                Console.WriteLine(index[i]);
        }
    }
}
/*      ***OUTPUT***
 
    name[0] = Empty
    name[1] = Empty
    name[2] = Empty
    name[3] = Empty
    name[4] = Empty
    name[5] = Empty
    name[6] = Empty
    name[7] = Empty
    name[8] = Empty
    name[9] = Empty
    
    After change values

    Empty
    Empty
    Empty
    Another Value
    Empty
    Any Value
    Empty
    Empty
    Empty
    Some Value

 */
