using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Tuple_Discard
{
    
    internal class Ref
    {
        static String[] array = { "hello", "world", "haha" };

        static void Main(string[] args)
        {
            ref String res = ref findString("keke");
            res = "hehe";
            Console.WriteLine(String.Join(" ",array)); // "hello" "hehe" "haha"
        }
        public static ref String findString(String target)
        {
            int count = 0;
            ref String res = ref array[0];
            for (count = 0; count < array.Length; count++)
            {
                if (array[count].Equals(target))
                {
                    res = ref array[count];
                    break;
                }   
            }
            return ref res;
            return count < array.Length?? ref res;
        }
        public static String findString2(String target)
        {
            int count = 0;
            String res = array[0];
            for (count = 0; count < array.Length; count++)
            {
                if (array[count].Equals(target))
                {
                    res = array[count];
                    break;
                }
            }
            /*return ref res; */
            return count < array.Length? "not found":"found";
        }

    }
    
}
