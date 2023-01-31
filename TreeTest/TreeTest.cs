using NUnit.Framework;
using Tree.Tree;

namespace TreeTest;

[TestFixture]
public class TreeTest
{
    [Test(Description = "��ȫ������")]
    public void Test_CompleteBinaryTree()
    {
        var values = new[] { 5, 1, 6, 3,  4, 2, 7, 8, 9 };

        var completeBinaryTree = values.BuildCompleteBinaryTree();

        Console.WriteLine(completeBinaryTree.ToString());
        Console.WriteLine("-------------------------------");

        Console.WriteLine($"{nameof(completeBinaryTree.GetMax)}: {completeBinaryTree.GetMax()}");
        Console.WriteLine($"{nameof(completeBinaryTree.GetMin)}: {completeBinaryTree.GetMin()}");
        Console.WriteLine($"{nameof(completeBinaryTree.GetHeight)}: {completeBinaryTree.GetHeight()}");
        Console.WriteLine($"{nameof(completeBinaryTree.PreOrder)}");
        completeBinaryTree.PreOrder();
        Console.WriteLine($"{nameof(completeBinaryTree.InOrder)}");
        completeBinaryTree.InOrder();
        Console.WriteLine($"{nameof(completeBinaryTree.PostOrder)}");
        completeBinaryTree.PostOrder();
    }

    [Test(Description = "����������")]
    public void Test_BinarySearchTree()
    {
        var values = new[] { 5, 1, 6, 3, 4, 2, 7, 8, 9 };

        var binarySearchTree = values.BuildBinarySearchTree();

        Console.WriteLine(binarySearchTree.ToString());
        Console.WriteLine("-------------------------------");

        Console.WriteLine($"{nameof(binarySearchTree.GetMax)}: {binarySearchTree.GetMax()}");
        Console.WriteLine($"{nameof(binarySearchTree.GetMin)}: {binarySearchTree.GetMin()}");
        Console.WriteLine($"{nameof(binarySearchTree.GetHeight)}: {binarySearchTree.GetHeight()}");
        Console.WriteLine($"{nameof(binarySearchTree.PreOrder)}");
        binarySearchTree.PreOrder();
        Console.WriteLine($"{nameof(binarySearchTree.InOrder)}");
        binarySearchTree.InOrder();
        Console.WriteLine($"{nameof(binarySearchTree.PostOrder)}");
        binarySearchTree.PostOrder();
    }
}