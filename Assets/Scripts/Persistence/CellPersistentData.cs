using UnityEngine;

[System.Serializable]
public class CellPersistentData
{
    [SerializeField]
    private string _id;

    public int Experience;
    public int CellLevel;
    public int HpLevel;
    public int EnergyLevel;
    public int SpeedLevel;
    public int DamageLevel;
    public int ResistLevel;
    public int HighScore;

    public string Id => _id;

    public CellPersistentData(string id)
    {
        _id = id;
    }

    public CellPersistentData(CellPersistentData other)
    {
        _id = other._id;
        Experience = other.Experience;
        CellLevel = other.CellLevel;
        HpLevel = other.HpLevel;
        EnergyLevel = other.EnergyLevel;
        SpeedLevel = other.SpeedLevel;
        DamageLevel = other.DamageLevel;
        ResistLevel = other.ResistLevel;
        HighScore = other.HighScore;
    }
}
