/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: This code helps to move player with hor and vert movements instead of key bindings. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed =0.125f;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition= target.position+offset;
        Vector3 smoothedPosition= Vector3.Lerp(target.position,desiredPosition,smoothSpeed);
        transform.position = smoothedPosition;
    }
}
