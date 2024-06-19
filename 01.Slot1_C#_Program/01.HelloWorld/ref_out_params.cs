using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld
{
    internal class ref_out_params
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 3 };
            Console.WriteLine(MajorityElement(a));
        }

        private static void SumArray(out int s, params int[] list)
        {
            s = 0;
            for (int i = 0; i < list.Length; i++)
            {
                s += list[i];
            }
        }


        public static bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
            while (true)
            {
                int temp = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    temp += digit * digit;
                    n /= 10;
                }
                if (set.Contains(temp))
                    return false;
                set.Add(temp);
                n = temp;
            }
            return true;
        }

        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count > 0)
                {
                    char peek = stack.Pop();
                    bool a = s[i] == ')' && peek == '(';
                    bool b = s[i] == '}' && peek == '{';
                    bool c = s[i] == ']' && peek == '[';
                    if (!(a || b || c)) return false;
                }
            }
            return true;
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long num1 = 0;
            int count1 = 0;
            int count2 = 0;
            long num2 = 0;

            while (l1 != null)
            {
                num1 += l1.val * (long)Math.Pow(10, count1++);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                num2 += l2.val * (long)Math.Pow(10, count2++);
                l2 = l2.next;
            }
            long num3 = num1 + num2;
            
            ListNode result = new ListNode();
            ListNode dummy = result;
            do
            {
                long value = (long)num3 % 10;
                dummy.next = new ListNode((int)value);
                dummy = dummy.next;
                num3 /= 10;
            } while (num3 > 0);
            return result.next;
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (dic[nums[i]] > nums.Length / 2)
                    {
                        return nums[i];
                    }
                    dic[nums[i]]++;
                    continue;
                }
                dic.Add(nums[i], 1);
            }
            return 0;
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
