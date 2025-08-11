using UnityEngine;

public class CubeMoveScript : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    private Vector3 originalPosition;
    private float dragSpeed = 5.0f;
    //private Vector3 offset;
    private bool isMoving = false;
    private bool smoothMovement = true;

    private void Start()
    {
        originalPosition = transform.position;
        //CalculateObjectBounds();
    }

    //private void CalculateObjectBounds()
    //{
    //    Renderer[] renderers = GetComponentsInChildren<Renderer>();
    //    if (renderers.Length > 0)
    //    {
    //        objectBounds = renderers[0].bounds;
    //        for (int i = 1; i < renderers.Length; i++)
    //        {
    //            objectBounds.Encapsulate(renderers[i].bounds);
    //        }
    //    }
    //    else
    //    {
    //        Collider2D collider = GetComponent<Collider2D>();
    //        if (collider != null)
    //        {
    //            objectBounds = collider.bounds;
    //        }
    //        else
    //        {
    //            objectBounds = new Bounds(transform.position, Vector3.zero);
    //        }
    //    }
    //}


    private void Update()
    {
        if (isMoving)
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = transform.position.z;
            originalPosition = mouseWorldPos;
            //originalPosition = mouseWorldPos + offset;
            //originalPosition = ClampPositionToCameraView(originalPosition);
            if (smoothMovement)
            {
                transform.position = Vector3.Lerp(transform.position, originalPosition, dragSpeed * Time.deltaTime);
                //Debug.Log("wwwtttfff");
            }
        else
            transform.position = originalPosition;
        }
    }

    private void OnMouseDown()
    {
        isMoving = true;
        //HighlightObject(th, true);
    }

    //void OnMouseDown()
    //{
    //    isMoving = true;
    //    //HighlightObject(th, true);
    //}
    private void OnMouseUp()
    {
        isMoving = false;
        //HighlightObject(th, false);
    }


}
