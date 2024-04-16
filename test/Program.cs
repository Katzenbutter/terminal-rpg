/*
double num1, num2;
char operation;

Console.Write("write the firt number");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("write the second number");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("choose + ; - ; / ; *");
operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+': 
        Console.WriteLine(Add(num1, num2));
        break;
    case '-':
        Console.WriteLine(Subtract(num1, num2));
        break;
    case '/':
        if(num2 != 0)
        {
            Console.WriteLine(Divide(num1, num2));
        }
        else
        {
            Console.WriteLine("you cant divide to 0");
        }
        break;
    case '*':
        Console.WriteLine(Multiply(num1, num2));
        break;
    default: Console.WriteLine("wrong operation");
        break;
}

static double Add(double x,double y)
{
    return x + y;
}

static double Subtract(double x,double y)
{
    return x - y;
}

static double Multiply(double x,double y)
{
    return (x * y);
}

static double Divide(double x,double y)
{
    return x/ y;
}
*/

/*
Console.WriteLine("select a geometric figure :  circle, square, rectangle");
string GeometricFigure = Console.ReadLine();
switch (GeometricFigure)
{
    case "circle":
        Console.WriteLine("πr². Enter the radius");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Circle(radius));
    break;
    case "square":
        Console.WriteLine("a² . Enter lenght a");
        double LengthA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Square(LengthA));
    break;
    case "rectangle":
        Console.WriteLine("a * b . Enter a");
        double Width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("a * b . Enter b");
        double Length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Rectangle(Width, Length));
    break;
    default:
        Console.WriteLine("wrong geometric Figure");
    break;

}

static double Circle(double radius)
{
    return Math.PI * radius * radius;
}

static double Square(double LenghtA)
{
    return LenghtA * LenghtA;
}

static double Rectangle(double width, double Length)
{
    return width * Length;
}
*/

/*
class Plane
{
    public string namePlane;
    public string materialPlane;
    public void Info()
    {
        Console.WriteLine($"name of the plane: {namePlane}, material of the plane:{materialPlane}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Plane firstPlane = new();
        firstPlane.namePlane = "amirates";
        firstPlane.materialPlane = "metal";
        firstPlane.Info();
    }

}
*/



/*
Console.WriteLine("Enter the operation: Increase Balance , Decrease Balance ,Transfer");
string Operation = Console.ReadLine();

Console.WriteLine("Enter an amount");
double.TryParse(Console.ReadLine(), out double amount);


Account firstAccount = new Account("daserstekonto", 10);

Account secondAccount = new Account("konto", 20);


switch (Operation)
{
    case "Increase Balance":
        {
           firstAccount.IncreaseBalance(amount);
            Console.WriteLine(firstAccount.BalanceAcc);

        }
        break;
    case "Decrease Balance":
        {
            firstAccount.DecreaseBalance(amount);
            Console.WriteLine(firstAccount.BalanceAcc);
    
        }
        break;
    case "Transfer":
        {
            firstAccount.Transfer(amount,secondAccount);

            Console.WriteLine(firstAccount.BalanceAcc);
            Console.WriteLine(secondAccount.BalanceAcc);
            
        }
        break;
    default:Console.WriteLine("error");
        break;
}
*/









/* Value name speed - bike
 * value name speed brand - car
 * value name speed - material
 */

/*TRANSPORT
public class Bike
{
    public string Name { get; set; }
    public int Value { get; set; }
    public string Speed { get; set; }

    public Bike(string name, int value, string speed)
    {
        Name = name;
        Value = value;
        Speed = speed;

    }

    public static List<Bike> CreateListBike()
    {
        List<Bike> bikes = new List<Bike>();
        bikes.Add(new Bike("mountain bike", 900, "40 Km/h"));
        return bikes;

    }

    public static Bike AddBike()
    {
        Console.WriteLine("Enter Bike Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Bike Value");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bike Speed");
        string speed = Console.ReadLine();

        return new Bike(name, value, speed);
    }

    public void ShowBikeInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Value: {Value}");
        Console.WriteLine($"Speed: {Speed}");
    }
}

  public class Motorcycle : Bike
{
    public string Material { get; set; }

    public Motorcycle(string name, int value, string speed, string material) : base(name, value, speed)
    {
        Material = material;
    }




    public static Motorcycle AddMotorcycle()
    {
        Console.WriteLine("Enter Motorcycle Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Motorcycle Value");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Motorcycle Speed");
        string speed = Console.ReadLine();
        Console.WriteLine("Enter Motorcycle Material");
        string material = Console.ReadLine();

        return new Motorcycle(name, value, speed, material);

    }


    public void ShowMotorcycleInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Value: {Value}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Material:{Material}");
    }
}




public class Car : Bike
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Car(string name, int value, string speed, string brand, int year) : base(name, value, speed)
    {
        Brand = brand;
        Year = year;
    }

    public static Car AddCar()
    {
        Console.WriteLine("Enter Car Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Car Value");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Car Speed");
        string speed = Console.ReadLine();
        Console.WriteLine("Enter Car Brand");
        string brand = Console.ReadLine();
        Console.WriteLine("Enter year of production");
        int year = int.Parse(Console.ReadLine());

        return new Car(name, value, speed, brand, year);

    }

    public void ShowCarInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Value: {Value}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Year: {Year}");
    }

}

    class Program
    {
        public static void Main(string[] args)
        {
            Bike newbike = Bike.AddBike();
            Console.WriteLine($"New Bike added:");
            newbike.ShowBikeInfo();
        
            Motorcycle newmotorcycle = Motorcycle.AddMotorcycle();
            Console.WriteLine($"New Motorcycle added:");
            newmotorcycle.ShowMotorcycleInfo();

            Car newcar = Car.AddCar();
            Console.WriteLine($"New Car added:");
            newcar.ShowCarInfo();

        }
    }


*/

/*
public interface IMovie
{
    public void Name()
    {
        Console.WriteLine("Avatar");
    }
}

public class Series : IMovie
{
    public void Name()
    {
        Console.WriteLine("big bang theory");
    }
}

class Program
{
    static void Main()
    {
        Series s = new Series();
        s.Name();

    }
}
*/


