using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private GenericList<T> _genericList;
        private int _lastIndex;

        public GenericListEnumerator (GenericList<T> list)
        {
            _genericList = list;
            _lastIndex = -1;
        }

        public T Current
        {
            get
            {
                return _genericList.GetElement(_lastIndex);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _genericList.GetElement(_lastIndex);
            }
        }

        public bool MoveNext()
        {
            if ( (_lastIndex + 1) <= (_genericList.Count - 1) )
            {
                _lastIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
        }

        public void Reset()
        {
        }
    }
}
