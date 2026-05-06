using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROYECTO_1
{
    internal class PILA
    {
        private Stack<TRABAJO> pila = new Stack<TRABAJO>();

        public void Push(TRABAJO t)
        {
            pila.Push(t);
        }

        public TRABAJO Pop()
        {
            if (pila.Count > 0)
                return pila.Pop();
            else
                return null;
        }

        public TRABAJO Peek()
        {
            if (pila.Count > 0)
                return pila.Peek();
            else
                return null;
        }

        public int Cantidad()
        {
            return pila.Count;
        }
    }
}
