using System;

namespace UnitTest
{
    public class Base
    {
        public int Value { get; }

        private Base(){ }

        public Base(int value)
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "The value must be higher than 0.");
            }

            Value = value;
        }
    }
}
