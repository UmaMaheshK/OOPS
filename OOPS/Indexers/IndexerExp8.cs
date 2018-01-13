using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Indexers
{
    class SampleCollection2<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];
        // Define the indexer to allow client code to use [] notation.
        //C# 7.0
        public T this[int i]
        {
            //get => arr[i];
            //set => arr[i] = value;
        }
    }
    class IndexerExp8
    {
        static void Main()
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World.";
            Console.WriteLine(stringCollection[0]);
        }
    }
}
// The example displays the following output:
// Hello, World.