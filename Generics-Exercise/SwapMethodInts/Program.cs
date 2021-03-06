﻿using GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapMethodInts
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxInt<int> box = new BoxInt<int>();
            for (int i = 0; i < n; i++)
            {
                box.BoxItem.Add(int.Parse(Console.ReadLine()));
            }

            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.SwapMe(nums[0], nums[1]);
            for (int i = 0; i < box.BoxItem.Count; i++)
            {
                Console.WriteLine($"{box.BoxItem[i].GetType()}: {box.BoxItem[i]}");
            }
        }
    }
}
