using System;
using System.Collections.Generic;

namespace HomeWork3
{
    
    class UserFactory 
    {
        Random random = new Random();
        public T CreatePerson<T>() where T : new()
        {
            T person = new T();
            return person;          
        }

        #region Exercise 3

        public List<T> SetRandomPerson<T>() where T : new()
        {           
            List<T> listPerson = new List<T>();

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                T employee = new T();
                listPerson.Add(employee);
            }

            return listPerson;
        }

        #endregion

    }
}
