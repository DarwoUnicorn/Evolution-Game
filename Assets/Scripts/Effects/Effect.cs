public abstract class Effect
{
    private CharacteristicsCoefficient _coefficients;
    
    protected CharacteristicsCoefficient Coefficients => _coefficients;

    public EffectTermination Termination { get; private set; }

    public Effect(EffectTermination termination)
    {
        if(termination == null)
        {
            throw new System.ArgumentNullException("EffectTermination");
        }
        Termination = termination;
    }

    public virtual void Apply(CharacteristicsCoefficient coefficients)
    {
        _coefficients = coefficients;
    }

    public virtual void Cancel()
    {
        _coefficients = null;
    }
}
