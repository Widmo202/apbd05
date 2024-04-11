using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new()
    {
        new Animal(1,"AAA", "Cat",2.3,"Brown"),
        new Animal(2,"BBB", "Cat",3,"Black"),
        new Animal(3,"CCC", "Dog",4,"Brown"),
        new Animal(4,"DDD", "Dog",5.3,"Black")
    };
}