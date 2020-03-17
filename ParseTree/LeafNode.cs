using System;


namespace parseTree
{
    class leafNode: iNode
    {
        public double Value { get; set; }

        public leafNode(double val)
        {
            Value = val;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public Double Operate()
        {
            return Value;
        }
    }
}