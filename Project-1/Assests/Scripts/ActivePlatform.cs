/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: This code helps to move platform to their specfied waypoint.
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlatform : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    [SerializeField] float speed = 3f;
    int currentWaypointIndex = 0;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}