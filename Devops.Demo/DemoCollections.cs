using Logique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoCollections : ICommand
    {
        public string Name => "Demo collections";

        public void Execute()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Toto");
            arrayList.Add(true);

            arrayList.Remove("Toto");

            foreach (var item in arrayList)
            {
                switch (item)
                {
                    case int i:
                        Console.WriteLine(5 + i);
                        break;
                    case string s:
                        Console.WriteLine("Bonjour " + s);
                        break;
                    case bool b:
                        if (b)
                            Console.WriteLine("yep");
                        break;
                }
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Coucou");
            hashtable.Add("Salut", "Bob");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
