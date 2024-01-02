using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private bool isDragging = false;
    private Vector3 initialPosition;
    private int touchId; // Store the touch ID for this object


    void Start()
    {
        initialPosition = transform.position;
    }

    // public void OnPointerDown(PointerEventData eventData)
    // {
    //     isDragging = true;

    //     // Use touch position for mobile devices
    //     initialPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

    // }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;

        // Use touch position for mobile devices
        if (Input.touchCount > 0)
        {
            // Find the touch that started on this object
            foreach (Touch touch in Input.touches)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform == transform)
                {
                    touchId = touch.fingerId;
                    initialPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    break;
                }
            }
        }
    }

    // public void OnDrag(PointerEventData eventData)
    // {
    //     if (isDragging)
    //     {
    //         // Convert mouse position to world space and set the object's position
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         if (Physics.Raycast(ray, out RaycastHit hit))
    //         {
    //             transform.position = new Vector3(hit.point.x, hit.point.y, 1.5f);
    //         }
    //     }
    // }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // Find the correct touch by iterating through all touches
            foreach (Touch touch in Input.touches)
            {
                if (touch.fingerId == touchId)
                {
                    // Convert touch position to world space and set the object's position
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        transform.position = new Vector3(hit.point.x, hit.point.y, 1.5f);
                    }
                    break;
                }
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;

        // Add your logic for checking if the object is in the correct position here
        // For simplicity, I'll assume a hardcoded target position
        Vector3 targetPosition = new Vector3(0f, -0.05f, 1.5f);

        // Check if the object is close enough to the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Your logic for successful placement here
            Debug.Log("Object placed correctly!");
            Destroy(gameObject);
        }
        else
        {
            // Return the object to its original position
            transform.position = initialPosition;
        }
    }
}