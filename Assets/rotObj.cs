using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    public float rotSpeed = 0.75f;
    public Transform transformToRotate;
    float velocity;
    private void FixedUpdate()
    {
        transformToRotate.RotateAround(transform.up, rotSpeed*velocity*Time.deltaTime);
        velocity *= 0.98f;
    }
    void OnMouseDrag()
    {
        velocity -= Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
    }
}
