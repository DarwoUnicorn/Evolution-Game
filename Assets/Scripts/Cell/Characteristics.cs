public class Characteristics
{
    private readonly CellData _data;
    private Upgrade _upgrade;
    private CharacteristicsCoefficient _coefficients = new CharacteristicsCoefficient();
    private float _hp;
    private float _energy;

    public Characteristics(CellData data)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException("data");
        }
        _data = data;
        _upgrade = new Upgrade(data.UpgradeData);
    }

    public float MaxHp => (_data.MaxHp + _upgrade.MaxHp) * _coefficients.MaxHp;
    public float MaxEnergy => (_data.MaxEnergy + _upgrade.MaxEnergy) * _coefficients.MaxEnergy;
    public float EnergyRecoverySpeed => (_data.EnergyRecoverySpeed + _upgrade.EnergyRecoverySpeed) * _coefficients.EnergyRecoverySpeed;
    public float EnergyRecoveryCooldown => (_data.EnergyRecoveryCooldown - _upgrade.EnergyRecoveryCooldown) / _coefficients.EnergyRecoveryCooldown;
    public float Speed => (_data.Speed + _upgrade.Speed) * _coefficients.Speed;
    public float RotateSpeed => (_data.RotateSpeed + _upgrade.RotateSpeed) * _coefficients.RotateSpeed;
    public float Acceleration => (_data.Acceleration + _upgrade.Acceleration) * _coefficients.Acceleration;
    public float Deceleration => (_data.Deceleration + _upgrade.Deceleration) * _coefficients.Deceleration;
    public float ViewRadius => (_data.ViewRadius) * _coefficients.ViewRadius;
    public float PhysicalResist => (_data.PhysicalResist + _upgrade.Resist) * _coefficients.PhysicalResist;
    public float PoisonResist => (_data.PoisonResist + _upgrade.Resist) * _coefficients.PoisonResist;
    public float ElectricityResist => (_data.ElectricityResist + _upgrade.Resist) * _coefficients.ElectricityResist;
    public float ColdResist => (_data.ColdResist + _upgrade.Resist) * _coefficients.ColdResist;
    public float FireResist => (_data.FireResist + _upgrade.Resist) * _coefficients.FireResist;
    public float Damage => (_data.Damage + _upgrade.Damage) * _coefficients.Damage;
    public int SizeLevel => _data.SizeLevel;
    public float Hp => _hp;
    public float Energy => _energy;
}
