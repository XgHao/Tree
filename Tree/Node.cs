using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
