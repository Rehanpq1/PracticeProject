using DesignPatern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern
{
   abstract public class BaseAbstractProduct
    {
        protected Product product = null;
        public BaseAbstractProduct()
        {
           product = new Product();
        }

        public Product ApplyDiscount_Coupoun()
        {
            IProduct iProduct = this.GetProduct();
            product.Discount = iProduct.GetDiscount();
            product.Couple = iProduct.ApplyCoupoun();
            return product;
        }

        public abstract IProduct GetProduct();
    }
    public class FashionProductFactory : BaseAbstractProduct
    {

        public override IProduct GetProduct()
        {
            FashionProduct objfashionProduct = new FashionProduct();
            product.Id = 10;
            product.ReturnAllow = objfashionProduct.IsReturnAllowed();
            product.Category = objfashionProduct.GetCategory();
            product.DeliveryCharge = objfashionProduct.GetDeliveryCharge();
            return objfashionProduct;
        }
    }

    public class ElectronProductFactory : BaseAbstractProduct
    {
        public override IProduct GetProduct()
        {
            ElectronProduct objElectronProduct = new ElectronProduct();
            product.Category = objElectronProduct.GetCategory();

            product.ReturnAllow = objElectronProduct.IsReturnAllowed();
            return objElectronProduct;
        }
    }
}
