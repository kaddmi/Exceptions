using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    [Serializable]
    class AgeException : ArgumentException
    {
        public int Age { get; }
        public AgeException(int age)
        {
            Age = age;
        }
        public AgeException(string message, int age): base(message)
        {
            Age = age;
        }
        public AgeException(string message, int age, Exception innerException) : base(message, innerException)
        {
            Age = age;
        }
    }
}
