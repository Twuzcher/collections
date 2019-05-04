using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collections.Collection
{
    public class UserCollection
    {
        readonly Element[] elements = new Element[4];

        public Element this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        int position = -1;

        public bool MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return elements[position]; }
        }

        public UserCollection GetEnumerator()
        {
            return this;
        }
    }
}
