using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class Worker
    {
        private string name;
        public string Name
        {
            set
            {
                foreach (char c in value)
                    if (Char.IsLetter(c))
                        name = value;
                else throw new NameException("Name must contain only letters", value);
            }
            get
            {
                return name;
            }
        }
        private int age;
        public int Age
        {
            set
            {
                if (value < 16) throw new AgeException("The age must be not less than 16", value);
                else
                    age = value;
            }
            get
            {
                return age;
            }
        }

        public Worker()
        {

        }
        public Worker(string name, int a)
        {
            Name = name;
            Age = a;
        }
    }
}
