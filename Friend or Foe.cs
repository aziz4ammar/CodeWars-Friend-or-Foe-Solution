using System;
using System.Linq;

public class Kata
{
    public static string[] FriendOrFoe(string[] names)
    {
        return names.Where(name => name.Length == 4).ToArray();
    }
}