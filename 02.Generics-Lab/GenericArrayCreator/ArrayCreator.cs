public class ArrayCreator
{
    public static T[] Create<T>(int length, T defaultValue)
    {
        var result = new T[length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = defaultValue;
        }

        return result;
    }
}
