namespace Tree.Tree
{
    public static class TreeBuilder
    {
        /// <summary>
        /// 构建完全二叉树.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static CompleteBinaryTree BuildCompleteBinaryTree(this IEnumerable<int> values)
        {
            var tree = new CompleteBinaryTree();
            foreach (var value in values)
            {
                tree.Insert(value);
            }

            return tree;
        }

        /// <summary>
        /// 构建二叉搜索树.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static BinarySearchTree BuildBinarySearchTree(this IEnumerable<int> values)
        {
            var tree = new BinarySearchTree();
            foreach (var value in values)
            {
                tree.Insert(value);
            }

            return tree;
        }
    }
}
