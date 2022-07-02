public abstract class Effect
{
    public EffectTermination Termination { get; private set; }
    private CharacteristicsCoefficient _coefficients;

    public Effect(EffectTermination termination)
    {
        Termination = termination;
    }

    public abstract void Apply(CharacteristicsCoefficient coefficients);

    public abstract void Cancel();
}
