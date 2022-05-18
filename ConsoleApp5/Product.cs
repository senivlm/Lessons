using System;

 public class Product
{
	public string Name { get; } 
	public double Prise { get; }
	public double Weight { get; }
	public  Product (string name, double prise, double weight )
	{
		Name = name;
		if (prise < 0 || weight < 0)
			throw new ArgumentException();
		Prise = prise;
		Weight = weight;
		
	}




}
