using AttentionMarkerAttributeApp.Models;
using System.Reflection;

namespace AttentionMarkerAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MethodInfo> methodsWithAttention = new List<MethodInfo>();
            MethodInfo[] methods = typeof(Class_A).GetMethods();

            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ThisMethodNeedAttention), false);

                if (attributes.Length > 0)
                {
                    methodsWithAttention.Add(method);
                }
            }
            foreach (MethodInfo method in methodsWithAttention)
            {
                Console.WriteLine($"Method: {method.Name} needs attention.");
            }
        }
    }
}
