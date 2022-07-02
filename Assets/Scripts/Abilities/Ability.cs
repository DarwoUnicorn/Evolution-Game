using UnityEngine;

public abstract class Ability
{
    [SerializeField]
    private AbilityData _abilityData;

    public Ability(AbilityData abilityData)
    {
        if(abilityData == null)
        {
            throw new System.ArgumentNullException("ability data");
        }
        _abilityData = abilityData;
    }
    
    public AbilityData AbilityData => _abilityData;
}
