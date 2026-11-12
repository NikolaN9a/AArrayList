using System.Collections;
using System.ComponentModel;
using System.Threading.Channels;

namespace arrayList
{
    internal class arrayList
    {
        public bool Count { get; private set; }
        public bool Capacity { get; private set; }

        static void Main(string[] args) 
        {
            ArrayList element  = new ArrayList();
            element.Add(23);
            element.Add(30);
            element.Add("Hello");
            element.Add("Ivan");
            foreach (var index in element)
            {
                Console.WriteLine(index);
            }
            element.Insert(1, 25);
            foreach (var index in element)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine(new string ('-', 20) );
            Console.WriteLine(element.Count);
            Console.WriteLine(element.Capacity);
            element.Remove(23);
            element.RemoveAt(1);
             Console.WriteLine(element.Count);
            Console.WriteLine(element.Capacity);
            element.Add(true);
            element.Add(10);
            element.Add(20);
            element.Add("programirane");
            foreach(var index in element)

            {
                Console.WriteLine(index);
            }
            Console.WriteLine(element.Count);
            Console.WriteLine(element.Capacity);
            if(element.Contains(10))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Element at index 0: {element[0]}");
        }
         

        private void Remove(int v)
        {
            throw new NotImplementedException();
        }

        private void Insert(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void Add(string v)
        {
            throw new NotImplementedException();
        }

        private void Add(int v)
        {
            throw new NotImplementedException();
        }
    }
}
// АСД 26/27
