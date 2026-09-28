using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float followSpeed; 
    [SerializeField] Transform target; 
    Vector3 speed;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position; 
    }

   
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref speed, followSpeed); 
    }
}
