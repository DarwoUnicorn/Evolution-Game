using UnityEngine;

public class EnemyBehaviour : ScriptableObject
{
    protected Transform _target;

    public Vector2 GetDirection(Cell cell, out float multiplier)
    {
        Vector2 direction = new Vector2();
        multiplier = 1;
        return direction;
    }

}
