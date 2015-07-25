using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    [Version(1.0)]
    public class GenericList<T> where T:IComparable<T>
    {
       
        private const int Defaultcapacity = 16;

        private T[] elements;
        private int count;
        public GenericList(int capacity = Defaultcapacity)
        {
            this.elements = new T[capacity];
            this.count = 0;

        }
        public void Add(T element)
        {
            if (this.count >= this.elements.Length)
            {
                Resize(element);

            }
            this.elements[this.count] = element;
            this.count++;
        }
        private void Resize(T element)
        {
            T[] newArray = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                newArray[i] = this.elements[i];
            }
            this.elements = newArray;
        }
        public void Remove(T element)
        {
            List<T> temp = elements.ToList();
            temp.Remove(element);
            T[] result = new T[this.elements.Length - 1];
            result = temp.ToArray();
            elements = result;
        }

        public T Access (int index)
        {
            if (index>this.count||index<0)
            {
                throw new ArgumentOutOfRangeException("index","Index is out of range");
            }
            return elements[index]; 
        }

        public void Insert(T element, int index)
        {
            if (index>elements.Length+1||index<0)
            {
                throw new ArgumentOutOfRangeException("index","Index is out of range");
            }

            T[]newArray=new T[this.elements.Length+1];
            for (int i = 0,j=0; i < this.elements.Length; i++,j++)
            {
                if (i==index)
                {
                    newArray[j] =element;
                    j++;
                    this.count++;
                }
                newArray[j] = elements[i];
            }
            this.elements = newArray;

        }
        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
            }

            this.count = 0;
        }
        public int FindIndex(T element)
        {
            int index=0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                     index= i;
                    break;
                }
            }
            return index;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T min = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T max = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
        public override string ToString()
        {
            var resultElements = this.elements.Take(this.count);

            return string.Join(" ", resultElements);
        }
    }
}
