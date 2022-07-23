using System.Text;
using Common;

namespace Tree.Tree
{
    /// <summary>
    /// 树.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Tree<T>
    {
        /// <summary>
        /// Root.
        /// </summary>
        public Node<T>? Root { get; set; }

        /// <summary>
        /// 插入值.
        /// </summary>
        /// <param name="value"></param>
        public abstract void Insert(T value);

        /// <summary>
        /// 获取最大值.
        /// </summary>
        /// <returns></returns>
        public abstract T GetMax();

        /// <summary>
        /// 获取最小值
        /// </summary>
        /// <returns></returns>
        public abstract T GetMin();

        /// <summary>
        /// 先序遍历：根 -> 左 -> 右.
        /// </summary>
        [MethodTimer]
        public void PreOrder()
        {
            Root?.PreOrder();
        }

        /// <summary>
        /// 中序遍历：左 -> 根 ->  右.
        /// </summary>
        [MethodTimer]
        public void InOrder()
        {
            Root?.InOrder();
        }

        /// <summary>
        /// 后序遍历：左 -> 右 -> 根.
        /// </summary>
        [MethodTimer]
        public void PostOrder()
        {
            Root?.PostOrder();
        }

        /// <summary>
        /// 获取树的高度.
        /// </summary>
        /// <returns></returns>
        [MethodTimer]
        public int GetHeight()
        {
            return Root?.GetDepth() ?? 0;
        }

        [MethodTimer]
        public override string ToString()
        {
            if (Root == null)
            {
                return string.Empty;
            }

            var res = new StringBuilder();
            var deep = 1;
            var nodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            while (true)
            {
                for (int index = 0; index < Math.Pow(2, deep - 1); index++)
                {
                    var node = nodes.Dequeue();
                    var data = node == null ? " " : node.Data?.ToString();
                    res.Append($"[{data}] ");

                    nodes.Enqueue(node?.Left);
                    nodes.Enqueue(node?.Right);
                }
                res.AppendLine();

                deep++;
                if (nodes.All(e => e == null))
                {
                    break;
                }
            }

            return res.ToString();
        }
    }
}
