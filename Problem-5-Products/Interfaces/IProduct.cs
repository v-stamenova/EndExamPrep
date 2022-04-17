namespace Problem_5_Products.Interfaces
{
	interface IProduct
	{
		decimal Price();

		decimal Price_DDS();

		decimal Price_Customer();

		decimal Profit();
	}
}
