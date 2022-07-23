namespace Tree.Tree
{
    /// <summary>
    /// 完全二叉树.
    /// </summary>
    public class CompleteBinaryTree : Tree<int>
    {
        /// <summary>
        /// 完全二叉树插入值.
        /// </summary>
        /// <param name="value"></param>
        public override void Insert(int value)
        {
            var insertNode = new Node<int> { Data = value };

            if (Root == null)
            {
                Root = insertNode;
                return;
            }

            var nodeQueue = new Queue<Node<int>>();
            nodeQueue.Enqueue(Root);

            while (true)
            {
                // 当前校验的节点
                var curNode = nodeQueue.Dequeue();
                if (curNode.Left == null)
                {
                    curNode.Left = insertNode;
                    return;
                }

                if (curNode.Right == null)
                {
                    curNode.Right = insertNode;
                    return;
                }

                // 把当前节点的子节点放入队列
                nodeQueue.Enqueue(curNode.Left);
                nodeQueue.Enqueue(curNode.Right);
            }
        }

        public override int GetMax()
        {
            if (Root == null)
            {
                return -1;
            }

            return Root.GetData((parent, left, right) => Math.Max(Math.Max(parent, left), right), int.MinValue);
        }

        public override int GetMin()
        {
            if (Root == null)
            {
                return -1;
            }

            return Root.GetData((parent, left, right) => Math.Min(Math.Min(parent, left), right), int.MaxValue);
        }
    }
}
