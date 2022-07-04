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
    [SerializeField]
    private Rigidbody2D _rigidbody;

    private List<Effect> _effects;

    public Characteristics Characteristics { get; private set; }
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Mutation> Mutations => _mutations;
    public IReadOnlyList<Effect> Effects => _effects;
    public Movement Movement => _movement;
    public Rigidbody2D Rigidbody => _rigidbody;

    public void SetData(CellData data)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException("CellData");
        }
        _data = data;
        _effects?.ForEach(item => item.Cancel());
        _effects = new List<Effect>();
        _mutations = new List<Mutation>();
        _sockets = new List<AbilitySocket>();
        for(int i = 0; i < _data.Sockets.Count; i++)
        {
            _sockets.Add(new AbilitySocket(_data.Sockets[i], 0));
        }
        Characteristics = new Characteristics(data);
    }

    public void ApplyEffect(Effect effect)
    {
        if(effect == null)
        {
            throw new System.ArgumentNullException("Effect");
        }
        Characteristics.ApplyEffect(effect);
    }

    private void Update()
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
