#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MvcLinq.Models;

public class Trainer {
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}
    public int Experience {get; set;}

    public Trainer() {}

    public Trainer(int theId, string theFirst, string theLast, string theEmail, int theExp) {
        Id = theId;
        FirstName = theFirst;
        LastName = theLast;
        Email = theEmail;
        Experience = theExp;
    }

    public string print() {
        return $@"
            Full Name: {FirstName} {LastName}
            Email: {Email}
            Experience Level: {Experience}
        ";
    }
    
}