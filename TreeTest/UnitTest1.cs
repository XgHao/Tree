using Tree;
using Telerik.JustMock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1()
        {
            var node1 = new Node<int>();
            var node2 = new Node<int>();
            var node3 = new Node<int>();
            var node4 = new Node<int>();
            var node5 = new Node<int>();

            node1.Data = 5;
            node1.Left = node2;
            node1.Right = node3;
            node2.Data = 6;
            node2.Left = node5;
            node2.Right = node4;
            node3.Data = 7;
            node4.Data = 9;
            node5.Data = 8;

            var tree = new BasicTree { Root = node1 };

            Console.WriteLine($"{nameof(tree.PreOrder)}");
            tree.PreOrder();
            Console.WriteLine($"{nameof(tree.InOrder)}");
            tree.InOrder();
            Console.WriteLine($"{nameof(tree.PostOrder)}");
            tree.PostOrder();
        }
    }
}