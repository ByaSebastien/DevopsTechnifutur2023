using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoCollectionsGeneriques : ICommand
    {
        public string Name => "Demo collections génériques";

        public void Execute()
        {
            List<string> list = new List<string>();
            list.Add("Coucou");
            list.Add("les Devops");
            list.Add("ça boum?");
            list.Add("On va boire une boite Tony?");

            Console.WriteLine(list[3]);
            list.Remove("Coucou");
            list.RemoveAt(0);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }


            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Coucou");
            dict.Add(3, "Salut");
            dict.Add(5, "Salam");

            Console.WriteLine(dict[3]);
            dict.Remove(1);
            dict[1] = "";
            foreach (KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            Dictionary<string, string> dict2 = new Dictionary<string, string>();
            dict2.Add("Un", "Coucou");
            dict2.Add("Deux", "Salut");
            dict2.Add("Trois", "Salam");

            Console.WriteLine(dict2["Trois"]);
            dict2.Remove("Un");
            dict2["Un"] = "";
            foreach (KeyValuePair<string, string> kvp in dict2)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            int nb = queue.Peek();
            Console.WriteLine(nb);
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Un");
            stack.Push("Deux");
            stack.Push("Trois");
            string myString = stack.Pop();
            Console.WriteLine(myString);
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}
