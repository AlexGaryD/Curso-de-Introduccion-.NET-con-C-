using System;
using Newtonsoft.Json;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        var person = new Person
        {
            Name = "Alexis Vera",
            Age = 32
        };
        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serialized JSON:" + json);
        
        var deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age ={deserializedPerson.Age}");
    }
}