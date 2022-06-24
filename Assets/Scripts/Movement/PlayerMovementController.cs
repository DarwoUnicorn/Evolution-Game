using UnityEngine;

public class PlayerMovementController : MovementController
{
    private void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        _movement.Move(direction, 1);
        _movement.Rotate(direction);
    }
}
