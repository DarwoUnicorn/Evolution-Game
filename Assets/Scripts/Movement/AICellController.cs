using UnityEngine;

public class AICellController : CellController
{
    [SerializeField]
    private ObjectPool _pool;

    private EnemyBehaviour _behaviour;
    private float _multiplier;
    private Vector2 _direction;

    public ObjectPool Pool => _pool;

    public void SetBehaviour(EnemyBehaviour behaviour)
    {
        if(behaviour == null)
        {
            throw new System.ArgumentNullException("EnemyBehaviour");
        }
        _behaviour = behaviour;
    }

    public void UnsetBehaviour()
    {
        _behaviour = null;
    }

    private void Update()
    {
        if(_behaviour == null)
        {
            return;
        }
        _direction = _behaviour.GetDirection(Movement.Cell, out _multiplier);
        Movement.SetVelocity(_direction, _multiplier);
        Movement.SetRotation(_direction);
    }
}
