public class ExampleClass
{
    public int? MyProperty { get; set; } //Nullable type

    public ExampleClass(int? value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //Using Null-Conditional Operator
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null");
    }

    //Alternative approach with null check
    public void MyMethod2()
    {
        if (MyProperty.HasValue)
        {
            Console.WriteLine(MyProperty.Value.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null");
        }
    }
}