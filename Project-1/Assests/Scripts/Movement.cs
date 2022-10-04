/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: Basic written code to check out movements of the player.
 * Status: not used in the game.  
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}