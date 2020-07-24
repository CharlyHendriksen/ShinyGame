using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public bool bounds;
    public Vector3 MinCameraPos;
    public Vector3 MaxCameraPos;

    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        transform.position = target.position + offset;

        
        if(bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinCameraPos.x, MaxCameraPos.x),
                Mathf.Clamp(transform.position.y, MinCameraPos.y, MaxCameraPos.y),
                Mathf.Clamp(transform.position.z, MinCameraPos.z, MaxCameraPos.z));
        }


    }
}
