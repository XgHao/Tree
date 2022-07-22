using System.Text;

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
        public Node<T> Root { get; set; }

        /// <summary>
        /// 插入值.
        /// </summary>
        /// <param name="value"></param>
        public abstract void Insert(T value);

        /// <summary>
        /// 先序遍历：根 -> 左 -> 右.
        /// </summary>
        public void PreOrder()
        {
            Root.PreOrder();
        }

        /// <summary>
        /// 中序遍历：左 -> 根 ->  右.
        /// </summary>
        public void InOrder()
        {
            Root.InOrder();
        }

        /// <summary>
        /// 后序遍历：左 -> 右 -> 根.
        /// </summary>
        public void PostOrder()
        {
            Root.PostOrder();
        }

        public override string ToString()
        {
            if (Root == null)
            {
                return string.Empty;
            }

            var res = new StringBuilder();
            var i = 1;
            var nodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            while (true)
            {
                res.Append($"{i}: ");
                for (int j = 0; j < Math.Pow(2, i - 1); j++)
                {
                    if (!nodes.TryDequeue(out var node))
                    {
                        break;
                    }
                    var data = node == null ? "NULL" : node.Data?.ToString();
                    res.Append($"{data} ");

                    nodes.Enqueue(node?.Left);
                    nodes.Enqueue(node?.Right);
                }
                res.AppendLine();

                i++;
                if (nodes.All(e => e == null))
                {
                    break;
                }
            }

            return res.ToString();
        }
    }
}
