namespace Methods;

public class Methods : Methods.IMethods
{

    public string reverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);


    }

    public bool isEven(int number)
    {
        if (number%2>=0)
        {
            return true;

        }

        return false;
    }

    public int findMax(int[] numbers)
    {
        return numbers.Max();
    }

    public int CountOccurencies(string input, char character)
    {
        throw new NotImplementedException();
    }

    public void RemoveDuplicates(int[] numbers)
    {
        throw new NotImplementedException();
    }
    
    public interface IMethods
    {
        public string reverseString(string s);
        public bool isEven(int number);
        public int findMax(int[] numbers);
        public int CountOccurencies(string input, char character);
        public void RemoveDuplicates(int[] numbers);

    }
    
    
    
}