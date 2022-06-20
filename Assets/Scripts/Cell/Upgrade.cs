using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField]
    private float _incrementalMaxHp;
    [SerializeField]
    private float _incrementalMaxEnergy;
    [SerializeField]
    private float _incrementalEnergyRecoverySpeed;
    [SerializeField]
    private float _decrementalEnergyRecoveryCooldown;
    [SerializeField]
    private float _incrementalSpeed;
    [SerializeField]
    private float _incrementalRotateSpeed;
    [SerializeField]
    private float _incrementalDamage;
    [SerializeField]
    private float _incrementalResist;
    [SerializeField]
    private int _cellLevel;
    [SerializeField]
    private int _hpLevel;
    [SerializeField]
    private int _energyLevel;
    [SerializeField]
    private int _speedLevel;
    [SerializeField]
    private int _damageLevel;
    [SerializeField]
    private int _resistLevel;
    
    public float MaxHp => _hpLevel * _incrementalMaxHp + _cellLevel * 0.2f * _incrementalMaxHp;
    public float MaxEnergy => _energyLevel * _incrementalMaxEnergy + _cellLevel * 0.2f * _incrementalMaxEnergy;
    public float EnergyRecoverySpeed => _energyLevel * _incrementalEnergyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyLevel * _decrementalEnergyRecoveryCooldown;
    public float Speed => _speedLevel * _incrementalSpeed + _cellLevel * 0.2f * _incrementalSpeed;
    public float RotateSpeed => _speedLevel * _incrementalRotateSpeed;
    public float Damage => _damageLevel * _incrementalDamage + _cellLevel * 0.2f * _incrementalDamage;
    public float Resist => _resistLevel * _incrementalResist + _cellLevel * 0.2f * _incrementalResist;
}
