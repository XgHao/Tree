using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Common
{
    /// <summary>
    /// 方法计时器.
    /// </summary>
    [PSerializable]
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class MethodTimerAttribute : OnMethodBoundaryAspect
    {
        private static readonly Stopwatch _sp;

        static MethodTimerAttribute()
        {
            _sp = Stopwatch.StartNew();
        }

        /// <summary>
        /// 方法名.
        /// </summary>
        public string MethodName { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _sp.Restart();
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _sp.Stop();
            var methodName = string.IsNullOrEmpty(MethodName) ? args.Method.Name : MethodName;
            Console.WriteLine($"【LOG:{methodName}: Total use {_sp.ElapsedMilliseconds}ms.】");
        }
    }
}