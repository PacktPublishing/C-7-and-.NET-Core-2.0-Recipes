using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._8._2
{
    public class MyStack<T>
    {
        private List<T> _list = new List<T>();

        public void Push(T value)
        {
            _list.Add(value);
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return value;
        }
    }
}
