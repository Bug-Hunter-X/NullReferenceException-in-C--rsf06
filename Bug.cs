public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a member that might be null
        Console.WriteLine(MyProperty.ToString()); // Potential NullReferenceException
    }
}