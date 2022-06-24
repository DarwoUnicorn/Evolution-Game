using UnityEngine;

public class CharacteristicsCoefficient
{
    private float _maxHp = 1;
    private float _maxEnergy = 1;
    private float _energyRecoverySpeed = 1;
    private float _energyRecoveryCooldown = 1;
    private float _speed = 1;
    private float _rotateSpeed = 1;
    private float _damage = 1;
    private float _physicalResist = 1;
    private float _poisonResist = 1;
    private float _electricityResist = 1;
    private float _coldResist = 1;
    private float _fireResist = 1;
    private float _viewRadius = 1;

    public float MaxHp => _maxHp;
    public float MaxEnergy => _maxEnergy;
    public float EnergyRecoverySpeed => _energyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyRecoveryCooldown;
    public float Speed => _speed;
    public float RotateSpeed => _rotateSpeed;
    public float Damage => _damage;
    public float PhysicalResist =>_physicalResist;
    public float PoisonResist => _poisonResist;
    public float ElectricityResist => _electricityResist;
    public float ColdResist => _coldResist;
    public float FireResist => _fireResist;
    public float ViewRadius => _viewRadius;
}
