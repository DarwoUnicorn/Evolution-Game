using UnityEngine;

public abstract class AbilitySocket : MonoBehaviour
{
    [SerializeField]
    private Ability _ability;

    private int _socketLevel;

    public Ability Ability => _ability;
    public int SocketLevel => _socketLevel;

    public void SetAbility(Ability ability)
    {
        if(CheckAbilityType(ability) == false)
        {
            throw new System.ArgumentException("Ability does not fit the socket");
        }
        _ability = ability;
    }

    public void SetSocketLevel(int level)
    {
        if(level > 3)
        {
            throw new System.ArgumentException("socket level cannot be higher than 3");
        }
        _socketLevel = level;
    }

    protected abstract bool CheckAbilityType(Ability ability);
}