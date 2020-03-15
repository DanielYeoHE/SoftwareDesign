using System;


namespace parseTree
{
    class Terminal: iTerminal
    {
        public double Value { get; set; }

        public Terminal(double val)
        {
            Value = val;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public Double toValue()
        {
            return Value;
        }
    }
}