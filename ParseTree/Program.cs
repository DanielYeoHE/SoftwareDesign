using System;

namespace parseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new leafNode(2);
            var node2 = new leafNode(10);
            var node3 = new leafNode(-5);


            /* Testing code */
            // var node4 = new leafNode(30);
            // var node5 = new leafNode(5);
            // var operatorNode1 = new branchNode("+", node2, node3);
            // var operatorNode2 = new branchNode("/", node4, node2);
            // var operatorNode3 = new branchNode("*", operatorNode1, operatorNode2);
            // var operatorNode4 = new branchNode("*", node5, operatorNode3, true);
            // var rootEquation = operatorNode4.ToString();
            // var rootValue = operatorNode4.toValue();

            var operatorNode1 = new branchNode("+", node2, node3);
            var operatorNode2 = new branchNode("*", node1, operatorNode1, true);

            var rootEquation = operatorNode2.ToString();
            var rootValue = operatorNode2.Operate();

            Console.WriteLine("Equation " + rootEquation);
            Console.WriteLine("result: " + rootValue);
        }
    }
}
