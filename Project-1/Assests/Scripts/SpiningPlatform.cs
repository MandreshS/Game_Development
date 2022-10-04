/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: Uses coroutines to help move the platform.
 **/

using System.Collections;
using UnityEngine;

public class SpiningPlatform : MonoBehaviour {
    public Transform[] path;
    IEnumerator currentMoveCoroutine;

    void Start () {
        StartCoroutine (FollowPath ());
    }

    void Update() {
        if (Input.GetKey("up")) {

            if (currentMoveCoroutine != null) {
                StopCoroutine (currentMoveCoroutine);
            }

            currentMoveCoroutine = Move (Random.onUnitSphere * 5, 8);
            StartCoroutine (currentMoveCoroutine);
        }
    }

    IEnumerator FollowPath() {
        foreach (Transform waypoint in path) {
            yield return StartCoroutine (Move (waypoint.position, 8));

        }
    }

    IEnumerator Move(Vector3 destination, float speed=3f) {
        while (transform.position != destination) {
            transform.position = Vector3.MoveTowards (transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }
    }
}