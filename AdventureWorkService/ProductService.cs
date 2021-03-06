﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorkService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {       

        public List<string> ListProducts()
        {
            Console.WriteLine("ClientCall");
            List<string> productList = new List<string>();
            try
            {
                using (AdventureWorks db = new AdventureWorks())
                {
                    productList = db.Products.Select(i => i.ProductNumber).ToList();
                }
            }
            catch
            {

            }
            return productList;
        }
    }
}
