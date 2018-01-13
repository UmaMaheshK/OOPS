using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Indexers
{
    class SampleCollection1<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];
        int nextIndex = 0;
        // Define the indexer to allow client code to use [] notation.
        public T this[int i] => arr[i];//Expression Body Definitions in c# 6.0
        public void Add(T value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }
    }
    class IndexerExp7
    {
        static void Main()
        {
            var stringCollection = new SampleCollection1<string>();
            stringCollection.Add("Hello, World");
            System.Console.WriteLine(stringCollection[0]);
        }
    }
}
// The example displays the following output:
// Hello, World.