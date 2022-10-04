/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: This code helps the player to stick around the active platform while it is moving around. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlatformMovement : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bounce")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Bounce")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}