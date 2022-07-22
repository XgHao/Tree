namespace Tree
{
    /// <summary>
    /// 基础树.
    /// </summary>
    public class BasicTree : Tree<int>
    {
    }

    public class Tree<T>
    {
        /// <summary>
        /// Root.
        /// </summary>
        public Node<T> Root { get; set; }

        /// <summary>
        /// 根 -> 左 -> 右.
        /// </summary>
        public void PreOrder()
        {
            PreOrder(Root);
        }

        /// <summary>
        /// 根 -> 左 -> 右.
        /// </summary>
        public static void PreOrder(Node<T> node)
        {
            // 当前节点不存在.
            if (node == null)
            {
                return;
            }

            // 打印当前根数据.
            Console.WriteLine(node.Data);

            // 打印左节点
            PreOrder(node.Left);

            // 打印右节点
            PreOrder(node.Right);
        }


        /// <summary>
        /// 左 -> 根 ->  右.
        /// </summary>
        public void InOrder()
        {
            InOrder(Root);
        }

        /// <summary>
        /// 左 -> 根 ->  右.
        /// </summary>
        public static void InOrder(Node<T> node)
        {
            // 当前节点不存在.
            if (node == null)
            {
                return;
            }

            // 打印左节点
            InOrder(node.Left);

            // 打印当前根数据.
            Console.WriteLine(node.Data);

            // 打印右节点
            InOrder(node.Right);
        }


        /// <summary>
        /// 左 -> 右 -> 根.
        /// </summary>
        public void PostOrder()
        {
            PostOrder(Root);
        }

        /// <summary>
        /// 左 -> 右 -> 根.
        /// </summary>
        public static void PostOrder(Node<T> node)
        {
            // 当前节点不存在.
            if (node == null)
            {
                return;
            }

            // 打印左节点
            PostOrder(node.Left);

            // 打印右节点
            PostOrder(node.Right);

            // 打印当前根数据.
            Console.WriteLine(node.Data);
        }
    }
}
