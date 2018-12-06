using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    [Serializable]
    class NameException : ArgumentException
    {
        public string Name { get; }
        public NameException(string name)
        {
            Name = name;
        }
        public NameException(string message, string name) : base(message)
        {
            Name = name;
        }
        public NameException(string message, string name, Exception innerException) : base(message, innerException)
        {
            Name = name;
        }
    }
}
