using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.AbstractFactory
{
    public class ProductAbstractFactoryMethod
    {
        public BaseAbstractProduct CreateProduct(EnumProduct enumProduct)
        {
            switch (enumProduct)
            {
                case EnumProduct.Electronic:
                    {
                        return new ElectronProductFactory();
                    }
                default:
                    {
                        return new FashionProductFactory();
                    }
            }
        }
    }
}
