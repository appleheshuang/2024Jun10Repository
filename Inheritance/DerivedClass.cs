namespace CSharpLearning;

public class SquareBoxForCat:SquareBox
{
    [Fact]
    public void ForCat()
    {
        Console.WriteLine("Cat Food");
    }

    public void CatEat()
    {
        Console.WriteLine("Cat Eat");
    }
}