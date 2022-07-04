using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementController : MovementController, IInitializePotentialDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private float _dragRadius;

    private Vector2 _startDragPosition;

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        _startDragPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        float multiplier = Vector2.Distance(_startDragPosition, eventData.position) / _dragRadius;
        Vector2 direction = eventData.position - _startDragPosition;
        if(multiplier > 1)
        {
            multiplier = 1;
        }
        Movement.SetVelocity(direction.normalized, multiplier);
        Movement.SetRotation(direction);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Movement.SetVelocity(Vector2.zero);
        Movement.StopRotate();
    }
}
