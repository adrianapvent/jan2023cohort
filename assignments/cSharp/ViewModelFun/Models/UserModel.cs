namespace ViewModelFun.Models;

public class Users
{
    public string Name {get; set;}
    public string LastName {get; set;}

    public User(string theName, string lastName) {
        Name = theName;
        LastName = lastName;
    }
}
