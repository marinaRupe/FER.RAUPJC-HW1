using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class GenericList <X> :IGenericList<X>
    {
        private X[] _internalStorage;
        private int _lastElementIndex;
        public int Count
        {
            get
            {
                return _lastElementIndex + 1;
            }
        }

        public GenericList ()
        {
            _internalStorage = new X[4];
            _lastElementIndex = -1;
        }

        public GenericList(int initialSize)
        {
            if (initialSize > 0)
            {
                _internalStorage = new X[initialSize];
                _lastElementIndex = -1;
            }
            else
            {
                Console.WriteLine("Initial size cannot be negative!");
            }
        }

        public void Add(X item)
        {
            if ((_lastElementIndex + 1) == _internalStorage.Length)
            {
                X[] newStorage = new X[_internalStorage.Length * 2];

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

        public bool Remove(X item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i].Equals(item))
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


        public X GetElement(int index)
        {
            try
            {
                X element = _internalStorage[index];
                return element;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range!");
                return default(X);
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            int listSize = _internalStorage.Length;
            _internalStorage = new X[listSize];
            _lastElementIndex = -1;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i <= _lastElementIndex; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        //  IEnumerable <X> implementation
        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
