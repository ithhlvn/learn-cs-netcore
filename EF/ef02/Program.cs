﻿using System;
using System.Threading.Tasks;
using ef02.Model;

namespace ef02
{
    class Program
    {
         
        static async Task Main(string[] args)
        {
            ShopContext.EnableLogging();
            await ShopContext.DeleteDatabase();
            await ShopContext.CreateDatabase();
            // await ShopContext.InsertSampleData();

            // var p    = await ShopContext.FindProduct(2);
            // var cxx = p.Category; 
        }
    }
}