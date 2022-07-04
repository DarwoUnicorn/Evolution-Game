using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityData : ScriptableObject
{
    [SerializeField]
    private AbilityType _type;
    [SerializeField]
    private int _maxLevel;
    [SerializeField]
    private List<float> _cooldown;
    [SerializeField]
    private List<float> _castTime;
    [SerializeField]
    private List<float> _duration;
    [SerializeField]
    private List<float> _energyConsumption;

    public AbilityType Type => _type;
    public int MaxLevel => _maxLevel;
    public IReadOnlyList<float> Cooldown => _cooldown;
    public IReadOnlyList<float> CastTime => _castTime;
    public IReadOnlyList<float> Duration => _duration;
    public IReadOnlyList<float> EnergyConsumption => _energyConsumption;
}
