using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Common;

/// <summary>
/// 方法计时器.
/// </summary>
[PSerializable]
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class MethodTimerAttribute : OnMethodBoundaryAspect
{
    /// <summary>
    /// 方法名.
    /// </summary>
    public string? MethodName { get; set; }

    public override void OnEntry(MethodExecutionArgs args)
    {
        var sp = Stopwatch.StartNew();
        args.MethodExecutionTag = sp;
    }

    public override void OnSuccess(MethodExecutionArgs args)
    {
        if (args.MethodExecutionTag is Stopwatch sp)
        {
            sp.Stop();
            var methodName = string.IsNullOrEmpty(MethodName) ? args.Method.Name : MethodName;
            Console.WriteLine($"【LOG:{methodName}: Total use {sp.ElapsedMilliseconds}ms.】");
        }
    }
}