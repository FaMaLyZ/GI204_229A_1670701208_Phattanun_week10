using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 3, -8);
    public float smoothSpeed = 5f;
    

    private void Start()
    {
        
    }
    private void LateUpdate()
    {
        
        transform.position = (target.position + offset);
       
    }
}
