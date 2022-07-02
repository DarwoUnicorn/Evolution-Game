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
    private Movement _movement;

    private List<Effect> _effects => new List<Effect>();

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
        Characteristics.ApplyEffect(effect);
    }

    public void Update()
    {
        for(int i = 0; i < _effects.Count; i++)
        {
            if(_effects[i].Termination is EffectTimeTermination == false)
            {
                continue;
            }
            if(((EffectTimeTermination)_effects[i].Termination).CheckTime(Time.deltaTime))
            {
                _effects[i].Cancel();
                _effects.RemoveAt(i);
                i--;
            }
        }
    }

    private void Awake()
    {
        SetData(_data);
    }
}
