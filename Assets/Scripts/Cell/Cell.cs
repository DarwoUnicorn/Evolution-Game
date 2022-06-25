using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private CellData _data;
    [SerializeField]
    private List<AbilitySocket> _sockets;
    [SerializeField]
    private List<Mutation> _mutations;
    [SerializeField]
    private List<Effect> _effects;
    [SerializeField]
    private Movement _movement;

    public Characteristics Characteristics { get; private set; }
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Mutation> Mutations => _mutations;
    public IReadOnlyList<Effect> Effects => _effects;
    public Movement Movement => _movement;

    public void SetData(CellData data)
    {
        _data = data;
        Characteristics = new Characteristics(data);
    }

    public void ApplyEffect(Effect effect)
    {

    }

    private void Awake()
    {
        SetData(_data);
    }
}
