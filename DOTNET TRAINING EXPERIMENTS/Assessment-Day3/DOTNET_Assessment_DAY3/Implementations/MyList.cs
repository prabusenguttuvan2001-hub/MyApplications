using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_Assessment_DAY3.Implementations
{
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList(int capacity = 4)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }

            _items[_count] = item;
            _count++;
        }

        private void Resize()
        {
            T[] newArray = new T[_items.Length * 2];

            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }

        public int Count
        {
            get { return _count; }
        }


        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();

                return _items[index];
            }
        }





        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(10);
            list.Add(20);

            Console.WriteLine(list[0]);
            Console.WriteLine(list.Count);


        }
    }
}
