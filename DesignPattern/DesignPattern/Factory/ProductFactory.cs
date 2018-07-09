using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Factory
{
     public class ProductFactory
    {
        public IProduct GetProductType(EnumProduct product)
        {
            switch(product)
            {
                case EnumProduct.Electronic:
                    return new ElectronProduct();
                case EnumProduct.Fashion:
                    {
                        return new FashionProduct();
                    }
                default:
                    return new HomeProduct();
            }
        }
    }
}
