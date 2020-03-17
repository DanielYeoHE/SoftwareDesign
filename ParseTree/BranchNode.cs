using System;


namespace parseTree
{
    class branchNode: iNode
    {
        public string Equation { get; set; }

        public iNode LeftChild { get; set; }

        public iNode RightChild { get; set; }


        public bool root { get; set; }

        public branchNode(string equation, iNode left, iNode right, bool state = false)
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

        public Double Operate() 
        {
            switch(Equation) 
            {
                case("*"):
                    return LeftChild.Operate() * RightChild.Operate();

                case("+"):
                    return LeftChild.Operate() + RightChild.Operate();

                case("/"):
                    return LeftChild.Operate() / RightChild.Operate();

                case("-"):
                    return LeftChild.Operate() - RightChild.Operate();

                default:
                    return 0F;
            }
        }
    }
}