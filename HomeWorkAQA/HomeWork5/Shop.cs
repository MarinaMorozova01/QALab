using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    [Serializable]
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Phone[] Phones { get; set; }
    }

}
