namespace Tree;

public class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }

    /// <summary>
    /// Data.
    /// </summary>
    public T Data { get; }

    /// <summary>
    /// Left.
    /// </summary>
    public Node<T>? Left { get; set; }

    /// <summary>
    /// Right.
    /// </summary>
    public Node<T>? Right { get; set; }

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

    /// <summary>
    /// 获取节点深度.
    /// </summary>
    /// <returns></returns>
    public int GetDepth()
    {
        if (Data == null)
        {
            return 0;
        }

        // 左右深度
        var lDepth = Left?.GetDepth() ?? 0;
        var rDepth = Right?.GetDepth() ?? 0;
        return Math.Max(lDepth, rDepth) + 1;
    }

    /// <summary>
    /// 获取左子树结果.
    /// </summary>
    /// <param name="func"></param>
    /// <param name="default"></param>
    /// <returns></returns>
    public T GetData(Func<T, T, T, T> func, T @default)
    {
        var lMax = Left == null ? @default : Left.GetData(func, @default);
        var rMax = Right == null ? @default : Right.GetData(func, @default);

        return func(Data, lMax, rMax);
    }
}