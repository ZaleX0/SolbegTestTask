namespace SolbegTestTask.Services;

public interface IReverseStringService
{
    string Reverse(string str);
}

public class ReverseStringService : IReverseStringService
{
    public string Reverse(string str)
    {
        if (str.Length <= 1)
            return str;

        else
            return Reverse(str.Substring(1)) + str[0];
    }
}
