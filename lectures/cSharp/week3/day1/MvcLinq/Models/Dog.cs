#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MvcLinq.Models;

public class Dog {
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string FamilyName {get; set;}
    public string Breed {get; set;}
    public int Age {get; set;}
    public string Owner {get; set;}
    public Dog() {}

    public Dog(int dogId, string dogFirst, string dogLast, string dogBreed, int dogAge, string dogOwner) {
        Id = dogId;
        FirstName = dogFirst;
        FamilyName = dogLast;
        Breed = dogBreed;
        Age = dogAge;
        Owner = dogOwner;
    }

    public string Print() {
        return $@"
            Dog Name: {FirstName} {FamilyName}
            Owner: {Owner}
            Breed: {Breed} & Age: {Age}
        ";
    }
}