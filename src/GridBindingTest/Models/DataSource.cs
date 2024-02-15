namespace GridBindingTest.Models;

public static class DataSource
{
    public static Person[] GetData()
    {
        Person[] result = new Person[4];

        for (int i = 1; i < 5; i++)
        {
            result[i - 1] = new Person(i);
        }

        return result;
    }
}