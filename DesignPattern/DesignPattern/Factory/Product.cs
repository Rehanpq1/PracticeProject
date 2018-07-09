using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Factory
{
	public class FashionProduct : IProduct
	{
		public decimal ApplyCoupoun()
		{
			return 300;
		}
		public decimal GetDiscount()
		{
			return 30;
		}

        public decimal GetDeliveryCharge()
        {
            return 100;
        }

        public bool IsReturnAllowed()
        {
            return true;
        }

        public string GetCategory()
        {
            return EnumProduct.Fashion.ToString();
        }
	}

	public class ElectronProduct : IProduct
	{
		public decimal ApplyCoupoun()
		{
			return 200;
		}
		public decimal GetDiscount()
		{
			return 20;
		}

        public bool IsReturnAllowed()
        {
            return false;
        }

        public string GetCategory()
        {
            return EnumProduct.Electronic.ToString();
        }
    }

	public class HomeProduct : IProduct
	{
		public decimal ApplyCoupoun()
		{
			return 100;
		}
		public decimal GetDiscount()
		{
			return 10;
		}
	}
}
