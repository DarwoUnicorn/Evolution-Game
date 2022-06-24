using UnityEngine;

public class Upgrade
{
    private UpgradeData _data;
    private int _cellLevel;
    private int _hpLevel;
    private int _energyLevel;
    private int _speedLevel;
    private int _damageLevel;
    private int _resistLevel;
    
    public float MaxHp => _hpLevel * _data.MaxHp + _cellLevel * 0.2f * _data.MaxHp;
    public float MaxEnergy => _energyLevel * _data.MaxEnergy + _cellLevel * 0.2f * _data.MaxEnergy;
    public float EnergyRecoverySpeed => _energyLevel * _data.EnergyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyLevel * _data.EnergyRecoveryCooldown;
    public float Speed => _speedLevel * _data.Speed + _cellLevel * 0.2f * _data.Speed;
    public float RotateSpeed => _speedLevel * _data.RotateSpeed;
    public float Damage => _damageLevel * _data.Damage + _cellLevel * 0.2f * _data.Damage;
    public float Resist => _resistLevel * _data.Resist + _cellLevel * 0.2f * _data.Resist;

    public void SetData(UpgradeData data)
    {
        _data = data;
    }
}
