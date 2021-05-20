using System;
using System.Collections.Generic;
using System.Text;

namespace Obolonskih_WORK
{
    class BaseRoom
    {
        public BaseRoom(int size) 
        {
            m_Squaere = size;
        }
        int GetSquare() { return m_Squaere; }
        ~BaseRoom() { }
        protected int m_Squaere;
    }
}
