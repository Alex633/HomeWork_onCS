using System;
using System.Collections.Generic;

namespace HWCardDeck
{
	class Program
	{
		//���������� ��������, �� ����� � ���� ������ �������, � ��� �����, ����� ��� ��� ��������, ����� �������� ����� ������� ��� �����.
		//����� ������� ����� ��������� � ���, � �� ������ ����� ���������� ���� ����.
		//��������� ������ � �����, ��������, �����.
		//�� ������ ������� ���, ��� �� ������ ���.

		static void Main(string[] args)
		{

		}
	}

	class Seller
	{
		private List<Product> _products = new List<Product>();
	}

	class Player
	{

	}

	class Product
	{
		private string _name;
		private int _price;

		public Product(string name, int price)
		{
			_name = name;
			_price = price;
		}
	}
}