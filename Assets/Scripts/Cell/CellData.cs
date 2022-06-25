using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CellData", menuName = "Cell/CellData", order = 1)]
public class CellData : ScriptableObject
{
    [SerializeField]
    private UpgradeData _upgradeData;
    [SerializeField]
    private List<AbilitySocket> _sockets = new List<AbilitySocket>();
    [SerializeField]
    private List<CellData> _friends = new List<CellData>();
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
    private float _physicalResist;
    [SerializeField]
    private float _poisonResist;
    [SerializeField]
    private float _electricityResist;
    [SerializeField]
    private float _coldResist;
    [SerializeField]
    private float _fireResist;
    [SerializeField]
    private float _viewRadius;
    [SerializeField]
    private int _sizeLevel;

    public UpgradeData UpgradeData => _upgradeData;
    public IReadOnlyList<AbilitySocket> Sockets => _sockets;
    public IReadOnlyList<CellData> Friends => _friends;
    public float MaxHp => _maxHp;
    public float MaxEnergy => _maxEnergy;
    public float EnergyRecoverySpeed => _energyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyRecoveryCooldown;
    public float Speed => _speed;
    public float RotateSpeed => _rotateSpeed;
    public float Acceleration => _acceleration;
    public float Deceleration => _deceleration;
    public float Damage => _damage;
    public float PhysicalResist =>_physicalResist;
    public float PoisonResist => _poisonResist;
    public float ElectricityResist => _electricityResist;
    public float ColdResist => _coldResist;
    public float FireResist => _fireResist;
    public float ViewRadius => _viewRadius;
    public int SizeLevel => _sizeLevel;
}
