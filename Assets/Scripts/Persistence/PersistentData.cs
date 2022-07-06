using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PersistentData
{
    [SerializeField]
    private PersistentCurrency _dna = new PersistentCurrency();
    [SerializeField]
    private PersistentCurrency _mutagen = new PersistentCurrency();
    [SerializeField]
    private List<AbilityPersistentData> _abilitiesData = new List<AbilityPersistentData>();
    [SerializeField]
    private List<CellPersistentData> _cellsData = new List<CellPersistentData>();

    public bool HasChange { get; private set; }

    public void SetAbilityData(AbilityPersistentData abilityData)
    {
        int index = _abilitiesData.FindIndex(item => item.Id == abilityData.Id);
        if(index == -1)
        {
            throw new System.ArgumentException($"AbilitiesData don't contain element with id { abilityData.Id }");
        }
        _abilitiesData[index] = abilityData;
        HasChange = true;
    }

    public AbilityPersistentData GetAbilityData(string id)
    {
        int index = _abilitiesData.FindIndex(item => item.Id == id);
        if(index == -1)
        {
            _abilitiesData.Add(new AbilityPersistentData(id));
            index = _abilitiesData.Count - 1;
            HasChange = true;
        }
        return new AbilityPersistentData(_abilitiesData[index]);
    }

    public void SetCellData(CellPersistentData cellData)
    {
        int index = _cellsData.FindIndex(item => item.Id == cellData.Id);
        if(index == -1)
        {
            throw new System.ArgumentException($"CellsData don't contain element with id { cellData.Id }");
        }
        _cellsData[index] = cellData;
        HasChange = true;
    }

    public CellPersistentData GetCellData(string id)
    {
        int index = _cellsData.FindIndex(item => item.Id == id);
        if(index == -1)
        {
            _cellsData.Add(new CellPersistentData(id));
            index = _cellsData.Count - 1;
            HasChange = true;
        }
        return new CellPersistentData(_cellsData.Find(item => item.Id == id));
    }

    public void SetDna(PersistentCurrency dna)
    {
        _dna = dna;
        HasChange = true;
    }

    public PersistentCurrency GetDna()
    {
        return new PersistentCurrency(_dna);
    }

    public void SetMutagen(PersistentCurrency mutagen)
    {
        _mutagen = mutagen;
        HasChange = true;
    }

    public PersistentCurrency GetMutagen()
    {
        return new PersistentCurrency(_mutagen);
    }
}