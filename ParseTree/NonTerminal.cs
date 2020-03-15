using System;


namespace parseTree
{
    class NonTerminal: iTerminal
    {
        public string Equation { get; set; }

        public iTerminal LeftChild { get; set; }

        public iTerminal RightChild { get; set; }


        public bool root { get; set; }

        public NonTerminal(string equation, iTerminal left, iTerminal right, bool state = false)
        {
            Equation = equation;
            LeftChild = left;
            RightChild = right;
            root = state;
        }

        public override string ToString()
        {
            if(root) {
                return String.Format("{0} {1} {2}", LeftChild, Equation, RightChild);
            }

            return String.Format("({0} {1} {2})", LeftChild, Equation, RightChild);
        }

        public Double toValue() 
        {
            switch(Equation) 
            {
                case("*"):
                    return LeftChild.toValue() * RightChild.toValue();

                case("+"):
                    return LeftChild.toValue() + RightChild.toValue();

                case("/"):
                    return LeftChild.toValue() / RightChild.toValue();

                case("-"):
                    return LeftChild.toValue() - RightChild.toValue();

                default:
                    return 0F;
            }
        }
    }
}