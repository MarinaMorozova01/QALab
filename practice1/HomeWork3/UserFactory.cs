using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class UserFactory 
    {
        public T CreatePerson<T>() where T : new()
        {
            T person = new T();
            return person;          
        }

       
    }
}
