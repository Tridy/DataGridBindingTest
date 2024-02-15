using System;

namespace GridBindingTest.Models;

public class Person
{
    public int Id
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    public string[] Tags
    {
        get;
        set;
    }

    public Person(int id)
    {
        Id = id;
        Name = $"a{id + 1}";
        Tags = new[] { "myTag-One", "myTag-Two", $"myTag-Three" };
    }
    
    public string TagsCount
    {
        get
        {
            if (Tags == null)
            {
                return "'Tags' is null";
            }

            return Tags.Length.ToString();
        }
    }
}