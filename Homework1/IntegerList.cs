using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _lastElementIndex;
        public int Count
        {
            get
            {
                return _lastElementIndex + 1;
            }
        }

        public IntegerList()
        {
            _internalStorage = new int[4];
            _lastElementIndex = -1;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize > 0)
            {
                _internalStorage = new int[initialSize];
                _lastElementIndex = -1;
            }
            else
            {
                Console.WriteLine("Initial size cannot be negative!");
            }
        }

        public void Add(int item)
        {
            if ((_lastElementIndex + 1) == _internalStorage.Length)
            {
                int[] newStorage = new int[_internalStorage.Length * 2];

                for (int i = 0; i < _internalStorage.Length; i++)
                {
                    newStorage[i] = _internalStorage[i];
                }

                newStorage[_internalStorage.Length] = item;
                _internalStorage = newStorage;
            }

            else
            {
                _lastElementIndex++;
                _internalStorage[_lastElementIndex] = item;
            }
        }

        public bool Remove(int item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return RemoveAt(i);
                }
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > _lastElementIndex || index < 0)
            {
                return false;
            }
            else
            {
                for (int i = index; i < _lastElementIndex; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }

                _lastElementIndex--;
                return true;
            }
        }


        public int GetElement(int index)
        {
            try
            {
                int element = _internalStorage[index];
                return element;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range!");
                return -1;
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }


        public void Clear()
        {
            int listSize = _internalStorage.Length;
            _internalStorage = new int[listSize];
            _lastElementIndex = -1;
        }


        public bool Contains(int item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
