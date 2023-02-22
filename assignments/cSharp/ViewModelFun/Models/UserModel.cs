#pragma warning disable CS8618
// namespace ViewModelFun.Models;

public class User
{
    public string Name {get; set;}
    public string LastName {get; set;}

    public User(string theName, string lastName) {
        Name = theName;
        LastName = lastName;
    }

//     public User(string first)
//     {
//         FirstName = first;
//     }
}
