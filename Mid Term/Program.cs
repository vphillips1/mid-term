﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Mid_Term
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ShoppingTwo.GetItemFromUser(TextFile.ReadFromTxt(@"productlist.txt"));
        }
    }
}
