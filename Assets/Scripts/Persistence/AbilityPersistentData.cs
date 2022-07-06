using UnityEngine;

[System.Serializable]
public class AbilityPersistentData
{
    [SerializeField]
    private string _id;

    public int Level;

    public string Id => _id;

    public AbilityPersistentData(string id)
    {
        _id = id;
    }

    public AbilityPersistentData(AbilityPersistentData other)
    {
        _id = other._id;
        Level = other.Level;
    }
}
