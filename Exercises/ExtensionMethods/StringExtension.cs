﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string Shorten(this string str,int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new IndexOutOfRangeException("Invalid length");

            var words =str.Split(' ');

            if(words.Length<=numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
