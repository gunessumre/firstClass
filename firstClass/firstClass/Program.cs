using System;

public class Person
{
    
    public string name { get; set; }
    public string surName { get; set; }
    public DateTime bornDate { get; set; }
    
    public void printInfo()
    {
        Console.WriteLine($"Ad: {name}, Soyad: {surName}, Doğum Tarihi: {bornDate.ToShortDateString()}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Person student1 = new Person { name = "Martin", surName = "Eden", bornDate = new DateTime(1889, 6, 12) };
        Person student2 = new Person { name = "Jude", surName = "Fawley", bornDate = new DateTime(1875, 9, 18) };
        Person teacher1 = new Person { name = "Rodion Romanovic", surName = "Raskolnikov", bornDate = new DateTime(1846, 2, 22) };
        Person teacher2 = new Person { name = "Zeynep", surName = "Çelik", bornDate = new DateTime(1900, 11, 5) };

        
        student1.printInfo();
        student2.printInfo();
        teacher1.printInfo();
        teacher2.printInfo();
    }
}