public abstract class Ability
{
    protected AbilityData _abilityData;
    protected Cell Owner;
   
    protected int _abilityLevel;
    public bool IsRecharge { get; protected set; }
    public float TimeBeforeCharge { get; protected set; }

    public Ability(Cell abilityOwner, AbilityData abilityData, int level)
    {
        if(abilityOwner == null)
        {
            throw new System.ArgumentNullException("Cell");
        }
        if(abilityData == null)
        {
            throw new System.ArgumentNullException("AbilityData");
        }
        if(level > abilityData.MaxLevel)
        {
            throw new System.ArgumentException("Ability level cannot be higher than ability max level");
        }
        _abilityLevel = level;
        _abilityData = abilityData;
        if(_abilityData.Cooldown[_abilityLevel] != 0)
        {
            IsRecharge = true;
            TimeBeforeCharge = _abilityData.Cooldown[_abilityLevel];
        }
    }
    
    public int AbilityLevel => _abilityLevel;
    public AbilityData AbilityData => _abilityData;
}
