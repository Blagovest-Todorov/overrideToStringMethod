using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOf
{
    public class Box<T>
    {
        public T Value { get; set; }

        public Box(T inputValue)
        {
            this.Value = inputValue;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
}
