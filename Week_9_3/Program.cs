Console.WriteLine("");

new MyClass();

class MyClass
{
    static MyClass()
    {
        Console.WriteLine("static constructor");
    }
    public MyClass()
    {
        Console.WriteLine("instance created");
    }
}