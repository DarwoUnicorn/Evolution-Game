using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "Cell/UpgradeData", order = 1)]
public class UpgradeData : ScriptableObject
{
    [SerializeField]
    private float _maxHp;
    [SerializeField]
    private float _maxEnergy;
    [SerializeField]
    private float _energyRecoverySpeed;
    [SerializeField]
    private float _energyRecoveryCooldown;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotateSpeed;
    [SerializeField]
    private float _acceleration;
    [SerializeField]
    private float _deceleration;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _resist;

    public float MaxHp => _maxHp;
    public float MaxEnergy => _maxEnergy;
    public float EnergyRecoverySpeed => _energyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyRecoveryCooldown;
    public float Speed => _speed;
    public float RotateSpeed => _rotateSpeed;
    public float Acceleration => _acceleration;
    public float Deceleration => _deceleration;
    public float Damage => _damage;
    public float Resist => _resist;
}
