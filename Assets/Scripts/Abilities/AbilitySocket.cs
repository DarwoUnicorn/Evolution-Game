public class AbilitySocket
{
    private Ability _ability;
    private AbilityType _type;

    private int _socketLevel;

    public AbilitySocket(AbilityType type, int level)
    {
        _type = type;
        _socketLevel = level;
    }

    public Ability Ability => _ability;
    public AbilityType Type => _type;
    public int SocketLevel => _socketLevel;

    public void SetAbility(Ability ability)
    {
        if(CheckСompatibility(ability) == false)
        {
            throw new System.ArgumentException("Ability does not fit the socket");
        }
        _ability = ability;
    }

    private bool CheckСompatibility(Ability ability)
    {
        return ability.AbilityData.Type == _type;
    }
}