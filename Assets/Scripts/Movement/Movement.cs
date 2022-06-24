using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Cell _cell;
    [SerializeField]
    private Rigidbody2D _rigidbody;

    public void Move(Vector2 direction, float multiplier)
    {
        _rigidbody.velocity = Vector2.Lerp(_rigidbody.velocity, direction * _cell.Characteristics.Speed * multiplier, 0.6f);
    }

    public void Rotate(Vector2 direction)
    {
        _rigidbody.MoveRotation(Vector2.SignedAngle(transform.right, direction));
    }
}
