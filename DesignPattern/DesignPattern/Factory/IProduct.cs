using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern
{
	public enum EnumProduct
	{
		Electronic =0,
		Fashion =1,
		Home =2
	}
	public interface IProduct
	{
		decimal GetDiscount();
		decimal ApplyCoupoun();
	}
}
