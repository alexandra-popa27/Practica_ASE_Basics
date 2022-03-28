
using Practica_ASE_Basics;

class Program
{
    public readonly string Audi = "Audi";
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Primul proiect pe git");
        Console.WriteLine("Un alt mesaj");
        Console.WriteLine("Testare Commit and Push");

        int i = 100;
        object o = i;//boxing->se salveaza pe heap
        Console.WriteLine("Obiectul e:" + o);
        int j = (int)o;//unboxing->se salveaza inapoi pe stiva
        Console.WriteLine("Value type e:" + j);

        string s = "";//empty string(String.Empty)
        string s1 = String.Empty;
        string s2 = null;

        int? test_nullable = 0;//nullable(?) permite atribuirea variabilei si null
        test_nullable = null;//daca punem var in fata lui test nullable avem eroare deoarece var ia tipul primei asignari,adica int,si nu ii putem da null variabilei int

        var total_price = 0;//var se poate folosi in locul orcarei tip de data

        const string Audi = "Audi";
        Car car = new Car("mercedes");
        Console.WriteLine("Masina e:" + car._audi);

        Car1 audi = new Car1() { Brand = "Audi", Capacity = CapacityEnum._3000, Model = "AudiA5", NoOfDoors = 2, Year = 2019, Color = ColorEnum.Red, Kilometers = 8000 };
        audi.Run();
    }
}

