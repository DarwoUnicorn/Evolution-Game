[System.Serializable]
public class PersistentCurrency
{
    public int Count;

    public PersistentCurrency()
    {
        
    }

    public PersistentCurrency(PersistentCurrency other)
    {
        Count = other.Count;
    }
}
