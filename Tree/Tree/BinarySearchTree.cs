namespace Tree.Tree;

/// <summary>
/// 二叉搜索树.
/// </summary>
public class BinarySearchTree : Tree<int>
{
    /// <summary>
    /// 二叉搜索树插入.
    /// </summary>
    /// <param name="value"></param>
    public override void Insert(int value)
    {
        // 要插入的节点
        var insertNode = new Node<int>(value);

        // 如果当前节点不存在，则直接插入
        if (Root == null)
        {
            Root = insertNode;
            return;
        }

        // 当前需要比较的节点
        var curNode = Root;

        // 一直循环比较，直到找到一个空的位置.
        while (true)
        {
            // 放入左边.
            if (value <= curNode.Data)
            {
                // 如果左边节点为空，则直接放入
                if (curNode.Left == null)
                {
                    curNode.Left = insertNode;
                    return;
                }

                // 若左节点不为空，则当前左节点是需要比较的下一个节点
                curNode = curNode.Left;
            }
            // 放入右边
            else
            {
                // 如果右边节点为空，则直接放入
                if (curNode.Right == null)
                {
                    curNode.Right = insertNode;
                    return;
                }

                // 若右节点不为空，则当前右节点是需要比较的下一个节点
                curNode = curNode.Right;
            }
        }
    }

    public override int GetMax()
    {
        if (Root == null)
        {
            return -1;
        }

        var cur = Root;
        while (cur.Right != null)
        {
            cur = cur.Right;
        }

        return cur.Data;
    }

    public override int GetMin()
    {
        if (Root == null)
        {
            return -1;
        }

        var cur = Root;
        while (cur.Left != null)
        {
            cur = cur.Left;
        }

        return cur.Data;
    }
}