using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Cell _target;
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
        _offset = Vector2.MoveTowards(_offset, _target.Rigidbody.velocity.normalized * _offsetDistance, _offsetSpeed * Time.deltaTime);
        _camera.transform.position = new Vector3(0, 0, _camera.transform.position.z) + _target.transform.position + (Vector3)_offset;
    }
}
