using System;

public class Animal
{
    private string animalName; 
    private double animalWeight;
    private int animalAge;       
    private string animalSpecies; 
    public string Name
    {
        get => animalName;
        set => animalName = value;
    }

    public double Weight
    {
        get => animalWeight;
        set => animalWeight = value;
    }

    public int Age
    {
        get => animalAge;
        set => animalAge = value;
    }

    public string Species
    {
        get => animalSpecies;
        set => animalSpecies = value;
    }

    public Animal()
    {
        
        Name = "Мурка";        
        Weight = 4.5;         
        Age = 3;               
        Species = "кішка";    
    }

    public void ShowWeight()
    {
        Console.WriteLine($"Вага тварини: {Weight} кг");
    }

    public void DescribeAnimal()
    {
        Console.WriteLine($"Ця тварина {Species} з іменем {Name}");
    }
}
