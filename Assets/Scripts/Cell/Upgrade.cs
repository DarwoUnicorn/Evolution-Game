public class Upgrade
{
    private UpgradeData _data;
    private int _cellLevel;
    private int _hpLevel;
    private int _energyLevel;
    private int _speedLevel;
    private int _damageLevel;
    private int _resistLevel;
    private int _maxCellLevel;
    private int _maxCharacteristicsLevel;

    public Upgrade(UpgradeData data)
    {
        if(data == null)
        {
            throw new System.ArgumentNullException("data");
        }
        _data = data;
    }

    public float MaxHp => _hpLevel * _data.MaxHp + _cellLevel * 0.2f * _data.MaxHp;
    public float MaxEnergy => _energyLevel * _data.MaxEnergy + _cellLevel * 0.2f * _data.MaxEnergy;
    public float EnergyRecoverySpeed => _energyLevel * _data.EnergyRecoverySpeed;
    public float EnergyRecoveryCooldown => _energyLevel * _data.EnergyRecoveryCooldown;
    public float Speed => _speedLevel * _data.Speed + _cellLevel * 0.2f * _data.Speed;
    public float RotateSpeed => _speedLevel * _data.RotateSpeed;
    public float Acceleration => _speedLevel * _data.Acceleration;
    public float Deceleration => _speedLevel * _data.Deceleration;
    public float Damage => _damageLevel * _data.Damage + _cellLevel * 0.2f * _data.Damage;
    public float Resist => _resistLevel * _data.Resist + _cellLevel * 0.2f * _data.Resist;

    public void SetCellLevel(int level)
    {
        CheckLevel(level, _maxCellLevel);
        _cellLevel = level;
    }

    public void SetHpLevel(int level)
    {
        CheckLevel(level, _maxCharacteristicsLevel);
        _hpLevel = level;
    }

    public void SetEnergyLevel(int level)
    {
        CheckLevel(level, _maxCharacteristicsLevel);
        _energyLevel = level;
    }

    public void SetSpeedLevel(int level)
    {
        CheckLevel(level, _maxCharacteristicsLevel);
        _speedLevel = level;
    }

    public void SetDamageLevel(int level)
    {
        CheckLevel(level, _maxCharacteristicsLevel);
        _damageLevel = level;
    }

    public void SetResistLevel(int level)
    {
        CheckLevel(level, _maxCharacteristicsLevel);
        _resistLevel = level;
    }

    private void CheckLevel(int level, int maxLevel)
    {
        if(level > maxLevel)
        {
            throw new System.ArgumentException("Cell level cannat be higher than 10");
        }
    }
}
