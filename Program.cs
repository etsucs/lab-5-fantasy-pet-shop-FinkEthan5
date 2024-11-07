using System;
using System.Collections.Generic;

public class FantasyPet
{
    public string Name { get; }
    public string Species { get; }
    public int Age { get; }
    public decimal Price { get; }
    public string MagicPower { get; }

    public FantasyPet(string name, string species, int age, decimal price, string magicPower)
    {
        Name = name;
        Species = species;
        Age = age;
        Price = price;
        MagicPower = magicPower;
    }

    public void Description()
    {
        Console.WriteLine($"Pet Name: {Name}, Species: {Species}, Age: {Age} years, Magic Power: {MagicPower}");
    }

    public decimal DiscountPrice(decimal percent)
    {
        return Price * (1 - percent / 100);
    }

    public void PerformMagic()
    {
        Console.WriteLine($"{Name} is now demonstrating its magical ability: {MagicPower}!");
    }
}

public class PetShop
{
    private List<FantasyPet> pets;
    public PetShop()
    {
        pets = new List<FantasyPet>();
    }

    public void AddPet(FantasyPet pet)
    {
        pets.Add(pet);
        Console.WriteLine($"{pet.Name} the {pet.Species} has been added to the pet shop!");
    }

    public void ListPets()
    {
        Console.WriteLine("Listing all pets in the shop:");
        foreach (var pet in pets)
        {
            pet.Description();
        }
    }
}

public class Program
{
    public static void Main() // Main Function 
    {
        FantasyPet dragon = new FantasyPet("Draco", "Dragon", 5, 1500m, "breathes fire");  // adds pets with all of the needed description to the fantasy pet list
        FantasyPet phoenix = new FantasyPet("Ash", "Phoenix", 3, 1200m, "rises from ashes");
        FantasyPet unicorn = new FantasyPet("Stella", "Unicorn", 7, 2000m, "heals with its horn");

        PetShop petShop = new PetShop();

        petShop.AddPet(dragon);
        petShop.AddPet(phoenix);
        petShop.AddPet(unicorn);

        dragon.Description();
        phoenix.Description();
        unicorn.Description();

        Console.WriteLine($"{dragon.Name}'s discounted price (10% off): {dragon.DiscountPrice(10):C}");
        Console.WriteLine($"{phoenix.Name}'s discounted price (15% off): {phoenix.DiscountPrice(15):C}");

        dragon.PerformMagic();
        phoenix.PerformMagic();

        petShop.ListPets();
    }
}
