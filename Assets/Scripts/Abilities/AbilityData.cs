using UnityEngine;

public class AbilityData : ScriptableObject
{
    [SerializeField]
    private int _maxLevel;
    [SerializeField]
    private float _cooldown;
    [SerializeField]
    private float _castTime;
    [SerializeField]
    private float _duration;

    public int MaxLevel => _maxLevel;
    public float Cooldown => _cooldown;
    public float CastTime => _castTime;
    public float Duration => _duration;
}
