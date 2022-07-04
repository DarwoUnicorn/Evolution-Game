using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Cell _cell;

    private Vector2 _moveDirection;
    private float _rotateAngle;
    private float _multiplier;

    private Rigidbody2D _rigidbody => _cell.Rigidbody;
    
    public void SetVelocity(Vector2 direction, float multiplier = 1)
    {
        _moveDirection = direction;
        _multiplier = multiplier;
    }

    public void SetRotation(Vector2 direction)
    {
        _rotateAngle = Vector2.SignedAngle(Vector2.right, direction);
    }

    public void StopRotate()
    {
        _rotateAngle = _rigidbody.rotation;
    }

    private void Update()
    {
        if(_moveDirection == Vector2.zero)
        {
            _rigidbody.velocity = Vector2.MoveTowards(_rigidbody.velocity, Vector2.zero, _cell.Characteristics.Deceleration * Time.deltaTime);
            return;
        }
        _rigidbody.velocity = Vector2.MoveTowards(_rigidbody.velocity,
                                                  _moveDirection * _cell.Characteristics.Speed * _multiplier,
                                                  _cell.Characteristics.Acceleration * Time.deltaTime);
        _rigidbody.SetRotation(Mathf.MoveTowardsAngle(_rigidbody.rotation, _rotateAngle, _cell.Characteristics.RotateSpeed * Time.deltaTime));
    } 
}
