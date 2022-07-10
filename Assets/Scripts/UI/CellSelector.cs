using System.Collections.Generic;
using UnityEngine;

public class CellSelector : MonoBehaviour
{
    [SerializeField]
    private List<string> _cellIds;

    private List<CellPersistentData> _cellsData = new List<CellPersistentData>();
    private PersistentData _data;
    private int _selectedCellIndex;

    public IReadOnlyList<CellPersistentData> CellsData => _cellsData;
    public CellPersistentData _selectedData => _cellsData[_selectedCellIndex];

    public void OnDataLoaded(PersistentData data)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException(); 
        }
        _data = data;
        for(int i = 0; i < _cellIds.Count; i++)
        {
            _cellsData.Add(data.GetCellData(_cellIds[i]));
        }
    }

    public void SelectNext()
    {
        if(_selectedCellIndex < _cellsData.Count - 1)
        {
            _selectedCellIndex++;
        }
    }

    public void SelectPrevious()
    {
        if(_selectedCellIndex > 0)
        {
            _selectedCellIndex--;
        }
    }
}
