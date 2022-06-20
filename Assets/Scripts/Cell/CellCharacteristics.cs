using System.Collections.Generic;
using UnityEngine;

public class CellCharacteristics : MonoBehaviour
{
    [SerializeField]
    private CellData _data;
    [SerializeField]
    private Upgrade _upgrade;
    [SerializeField]
    private float _hp;
    [SerializeField]
    private float _energy;

    public float MaxHp => _data.MaxHp + _upgrade.MaxHp;
    public float MaxEnergy => _data.MaxEnergy + _upgrade.MaxEnergy;
    public float EnergyRecoverySpeed => _data.EnergyRecoverySpeed + _upgrade.EnergyRecoverySpeed;
    public float EnergyRecoveryCooldown => _data.EnergyRecoveryCooldown - _upgrade.EnergyRecoveryCooldown;
    public float Speed => _data.Speed + _upgrade.Speed;
    public float RotateSpeed => _data.RotateSpeed + _upgrade.RotateSpeed;
    public float ViewRadius => _data.ViewRadius;
    public float PhysicalResist => _data.PhysicalResist + _upgrade.Resist;
    public float PoisonResist => _data.PoisonResist + _upgrade.Resist;
    public float ElectricityResist => _data.ElectricityResist + _upgrade.Resist;
    public float ColdResist => _data.ColdResist + _upgrade.Resist;
    public float FireResist => _data.FireResist + _upgrade.Resist;
    public float Damage => _data.Damage + _upgrade.Damage;
    public int SizeLevel => _data.SizeLevel;
    public float Hp => _hp;
    public float Energy => _energy;
}
