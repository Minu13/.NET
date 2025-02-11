using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArraywithAndWithoutLinqApp.Models
{
    public class ArrayFlattener
    {
        //with LINQ
        public static List<string> FlattenLinq(List<List<List<string>>> nestedArray)
        {
            return nestedArray.SelectMany(inner1 => inner1)
                              .SelectMany(inner2 => inner2)
                              .ToList();
        }

        // without LINQ
        public static List<string> FlattenIterative(List<List<List<string>>> nestedArray)
        {
            List<string> flattened = new List<string>();

            foreach (var inner1 in nestedArray)
            {
                foreach (var inner2 in inner1)
                {
                    foreach (var str in inner2)
                    {
                        flattened.Add(str);
                    }
                }
            }

            return flattened;
        }
    }
}
    

