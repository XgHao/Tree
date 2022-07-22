namespace Tree
{
    public class Node<T>
    {
        /// <summary>
        /// Data.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Left.
        /// </summary>
        public Node<T> Left { get; set; }

        /// <summary>
        /// Right.
        /// </summary>
        public Node<T> Right { get; set; }

        /// <summary>
        /// 先序遍历：根 -> 左 -> 右.
        /// </summary>
        public void PreOrder()
        {
            // 当前节点没有值
            if (Data == null)
            {
                return;
            }

            // 打印当前根数据.
            Console.WriteLine(Data);

            // 打印左节点
            Left?.PreOrder();

            // 打印右节点
            Right?.PreOrder();
        }

        /// <summary>
        /// 中序遍历：左 -> 根 ->  右.
        /// </summary>
        public void InOrder()
        {
            // 当前节点没有值.
            if (Data == null)
            {
                return;
            }

            // 打印左节点
            Left?.InOrder();

            // 打印当前根数据.
            Console.WriteLine(Data);

            // 打印右节点
            Right?.InOrder();
        }

        /// <summary>
        /// 后序遍历：左 -> 右 -> 根.
        /// </summary>
        public void PostOrder()
        {
            // 当前节点没有值.
            if (Data == null)
            {
                return;
            }

            // 打印左节点
            Left?.PostOrder();

            // 打印右节点
            Right?.PostOrder();

            // 打印当前根数据.
            Console.WriteLine(Data);
        }
    }
}
