using UnityEngine;

public abstract class CellController : MonoBehaviour
{
    [SerializeField]
    private Movement _movement;

    public Movement Movement => _movement;
    public Cell Cell => _movement.Cell;
}
