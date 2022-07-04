using UnityEngine;

public abstract class MovementController : MonoBehaviour
{
    [SerializeField]
    private Movement _movement;

    protected Movement Movement => _movement;
}
