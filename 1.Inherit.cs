using System;

public class Car
	{
		protected string name;
		public Car(string name)
		{
			this.name = name;
		}
	public Car()
    {
    }
		public virtual string  Name
		{
			get{return name;}
			set
			{
				if(value.Length>3)
					name = value;
				else
					name="Unknown";
			}
		}
	}	

public class Maruti : Car
{
	public Maruti(string name) : base(name)
	{
	}
	public override string  Name
		{
			get{return name;}
			set
			{
				if(value.Length>3)
					name = value + " -Maruti";
				else
					name="Unknown";
			}
		}
	public bool haveAGS;
}

public class Mahindra : Car
{
	public Mahindra(string name) : base(name)
	{
	}
	public Mahindra(){}
	public override string  Name
		{
			get{return name;}
			set
			{
				if(value.Length>3)
					name = value + " -Mahindra";
				else
					name="Unknown";
			}
		}
}
public class Program
{	
	public static void Main()
	{
		Maruti car1 = new Maruti("Swift");
		car1.haveAGS = true;
		car1.Name = "Swift";
		Console.WriteLine("Details Car 1: {0} and {1}",car1.Name,car1.haveAGS==true?"Have AGS":"not Have AGS");		
		Mahindra car2 = new Mahindra();
		car2.Name = "XUV500";
		Console.WriteLine("Car 2: {0}",car2.Name);
	}
}