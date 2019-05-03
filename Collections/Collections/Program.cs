using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Collection;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection();
            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);
            IEnumerator enumerator = (collection as IEnumerable).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("{0} - {1}", element.FieldA, element.FieldB);
            }
            Console.ReadKey();
        }
    }
}
