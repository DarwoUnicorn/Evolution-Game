using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private CellData _data;
    [SerializeField]
    private List<AbilitySocket> _sockets;

    private List<Effect> _effects;

    public Characteristics Characteristics { get; private set; }
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<Effect> Effects => _effects;

    public void CreateCell(CellData data, Upgrade upgrade)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException("CellData");
        }
        _data = data;
        _effects?.ForEach(item => item.Cancel());
        _effects = new List<Effect>();
        _sockets = new List<AbilitySocket>();
        for(int i = 0; i < _data.Sockets.Count; i++)
        {
            _sockets.Add(new AbilitySocket(_data.Sockets[i], 0));
        }
        Characteristics = new Characteristics(data);
    }

    public void Reset()
    {
        _data = null;
        _effects?.ForEach(item => item.Cancel());
        _effects = null;
        _sockets = null;
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
        if(_effects == null)
        {
            return;
        }
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
}
