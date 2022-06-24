using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private Characteristics _characteristics;
    [SerializeField]
    private List<AbilitySocket> _sockets;
    [SerializeField]
    private List<Mutation> _mutations;
    [SerializeField]
    private List<Effect> _effects;
    [SerializeField]
    private Movement _movement;

    public Characteristics Characteristics => _characteristics;
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Mutation> Mutations => _mutations;
    public IReadOnlyList<Effect> Effects => _effects;
    public Movement Movement => _movement;

    public void SetData(CellData data)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException("data");
        }
        _characteristics.SetData(data);
    }

    public void ApplyEffect(Effect effect)
    {

    }
}
