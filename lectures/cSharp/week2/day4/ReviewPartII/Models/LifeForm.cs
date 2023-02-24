#pragma warning disable CS8618
namespace ReviewPartII.Models;

public abstract class LifeForm
{
    public int? Age {get; set;}
    public string? Type {get; set;}
    public string? Name {get; set;}
    public string? Food {get; set;}
    public float? Height {get; set;}

    // public LifeForm(int theAge, string theType, string theName, string theFood, float theHeight) {
    //     Age = theAge;
    //     Type = theType;
    //     Name = theName;
    //     Food = theFood;
    //     Height = theHeight;
    // }
    // public LifeForm() {}
}
