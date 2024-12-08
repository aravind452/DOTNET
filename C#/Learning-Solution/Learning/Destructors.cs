using System;

public class Destructors
{
    public Destructors()
    {
        Console.WriteLine("Constructor called!");
    }

    ~Destructors()
    {
        Console.WriteLine("Destructor Called!");
    }
}
