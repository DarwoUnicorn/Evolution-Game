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
    private Upgrade _upgrade;
    [SerializeField]
    private MovementController _controller;
    [SerializeField]
    private float _hp;
    [SerializeField]
    private float _energy;

    public CellData Data => _data;
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Mutation> Mutations => _mutations;
    public IReadOnlyList<Effect> Effects => _effects;
    public Upgrade Upgrade => _upgrade;
    public MovementController Controller => _controller;
    public float Hp => _hp;
    public float Energy => _energy;
}
