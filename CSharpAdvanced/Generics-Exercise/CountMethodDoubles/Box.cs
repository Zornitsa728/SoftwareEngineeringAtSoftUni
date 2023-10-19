﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T itemToCompare)
        {
            int count = 0;

            foreach (T item in items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(string)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
