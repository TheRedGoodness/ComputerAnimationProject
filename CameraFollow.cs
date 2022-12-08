
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // will find the position of the target 

    public float smoothSpeed = 0.125f;
    public Vector3 offset; 

    void FixedUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; //grabs target location and adds an offset 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //move towards the position slowly over time 
        transform.position = smoothedPosition;
       
    }

}
