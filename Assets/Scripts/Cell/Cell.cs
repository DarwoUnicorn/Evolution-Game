using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private CellCharacteristics _characteristics;
    [SerializeField]
    private List<AbilitySocket> _sockets;
    [SerializeField]
    private List<Mutation> _mutations;
    [SerializeField]
    private List<Effect> _effects;
    [SerializeField]
    private MovementController _controller;

    public CellCharacteristics Characteristics => _characteristics;
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Mutation> Mutations => _mutations;
    public IReadOnlyList<Effect> Effects => _effects;
    public MovementController Controller => _controller;

    public void ApplyEffect(Effect effect)
    {

    }
}
