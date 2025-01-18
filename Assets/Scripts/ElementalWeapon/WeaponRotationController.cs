using UnityEngine;

public class WeaponRotationController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public RectTransform rotatablePanel; 
    public Camera canvasCamera;
    private bool isRotating;
    private Vector2 lastMousePos;

    void Update()
    {      
        if (IsPointerWithinPanel())
        {           
            if (Input.GetMouseButtonDown(0))
            {
                isRotating = true;
                lastMousePos = Input.mousePosition;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isRotating = false;
            }
           
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    isRotating = true;
                    lastMousePos = touch.position;
                }
                else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                {
                    isRotating = false;
                }
            }
           
            if (isRotating)
            {
                Vector2 currentMousePos;

                if (Input.touchCount > 0)
                    currentMousePos = Input.GetTouch(0).position; 
                else
                    currentMousePos = Input.mousePosition;

                Vector2 delta = currentMousePos - lastMousePos;
                             
                float rotationX = delta.x * rotationSpeed * Time.deltaTime;
                transform.Rotate(0, -rotationX, 0, Space.World);

                lastMousePos = currentMousePos; 
            }
        }
        else
        {          
            isRotating = false;
        }
    }   

   
    private bool IsPointerWithinPanel()
    {
        Vector2 pointerPos;
      
        if (Input.touchCount > 0)
        {
            pointerPos = Input.GetTouch(0).position;
        }
        else
        {
            pointerPos = Input.mousePosition;
        }
      
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rotatablePanel, pointerPos, canvasCamera, out localPoint);
    
        return rotatablePanel.rect.Contains(localPoint);
    }
}
