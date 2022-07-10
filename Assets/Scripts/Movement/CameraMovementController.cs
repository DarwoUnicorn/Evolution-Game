using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private Rigidbody2D _player;
    [SerializeField]
    private float _offsetSpeed;
    [SerializeField]
    private float _offsetDistance;

    private Vector2 _offset;

    private void Update()
    {
        if(_target == null)
        {
            return;
        }
        _offset = Vector2.MoveTowards(_offset, _player.velocity.normalized * _offsetDistance, _offsetSpeed * Time.deltaTime);
        _camera.transform.position = new Vector3(0, 0, _camera.transform.position.z) + _target.position + (Vector3)_offset;
    }
}
