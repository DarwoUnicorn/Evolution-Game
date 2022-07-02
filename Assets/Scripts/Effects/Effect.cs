public abstract class Effect
{
    private CharacteristicsCoefficient _coefficients;
    
    public EffectTermination Termination { get; private set; }

    public Effect(EffectTermination termination)
    {
        if(termination == null)
        {
            throw new System.ArgumentNullException("termination");
        }
        Termination = termination;
    }

    public abstract void Apply(CharacteristicsCoefficient coefficients);

    public abstract void Cancel();
}
