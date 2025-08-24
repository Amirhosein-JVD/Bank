public class ListDataProvider<T>
{
    private static ListDataProvider<T> _Instance;
    public List<T> universalDataList;

    private ListDataProvider()
    {
        universalDataList = new List<T> ();
    }

    public static ListDataProvider<T> Instnace()
    {
        if (_Instance == null)
        {
            _Instance = new ListDataProvider<T> ();
        }
        return _Instance;
    }
}