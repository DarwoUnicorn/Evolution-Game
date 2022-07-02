public class EffectTimeTermination : EffectBreakTermination
{
    private float _duration;

    public bool CheckTime(float deltaTime)
    {
        _duration -= deltaTime;
        return _duration <= 0;
    }

    EffectTimeTermination(float duration)
    {
        _duration = duration;
    }
}
