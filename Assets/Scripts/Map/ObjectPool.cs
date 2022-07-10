using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    private Cell _player;
    [SerializeField]
    private GameObject _cell;
    [SerializeField]
    private int _poolCount;

    private List<Cell> _activeCells = new List<Cell>();
    private List<Cell> _cellsPool = new List<Cell>();

    public Cell Player => _player;
    public IReadOnlyList<Cell> Cells => _activeCells;

    public void CreateCell(CellData cellData, Upgrade upgrade)
    {
        if(_cellsPool.Count == 0)
        {
            AddObjectToPool();
        }
        _cellsPool[0].CreateCell(cellData, upgrade);
        _activeCells.Add(_cellsPool[0]);
        _cellsPool.RemoveAt(0);
    }

    public void DestroyCell(Cell cell)
    {
        int index = _activeCells.FindIndex(item => item == cell);
        if(index == -1)
        {
            throw new System.ArgumentException("cell is inactive");
        }
        _cellsPool.Add(_activeCells[index]);
        _cellsPool.RemoveAt(index);
    }

    private void Start()
    {
        _activeCells = new List<Cell>(_poolCount);
        _cellsPool = new List<Cell>(_poolCount);
        _activeCells.Add(_player);
        for(int i = 0; i < _cellsPool.Capacity; i++)
        {
            AddObjectToPool();
        }
    }

    private void AddObjectToPool()
    {
        _cellsPool.Add(Instantiate(_cell).GetComponent<Cell>());
    }
}
