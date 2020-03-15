using System;

namespace parseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Terminal(2);
            var node2 = new Terminal(10);
            var node3 = new Terminal(-5);


            /* Testing code */
            // var node4 = new Terminal(30);
            // var node5 = new Terminal(5);
            // var operatorNode1 = new NonTerminal("+", node2, node3);
            // var operatorNode2 = new NonTerminal("/", node4, node2);
            // var operatorNode3 = new NonTerminal("*", operatorNode1, operatorNode2);
            // var operatorNode4 = new NonTerminal("*", node5, operatorNode3, true);
            // var rootEquation = operatorNode4.ToString();
            // var rootValue = operatorNode4.toValue();

            var operatorNode1 = new NonTerminal("+", node2, node3);
            var operatorNode2 = new NonTerminal("*", node1, operatorNode1);

            var rootEquation = operatorNode2.ToString();
            var rootValue = operatorNode2.toValue();

            Console.WriteLine("Equation " + rootEquation);
            Console.WriteLine("result: " + rootValue);
        }
    }
}
