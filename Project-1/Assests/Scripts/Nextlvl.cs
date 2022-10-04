/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: Helps the player to move to next level when triggered with end point. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlvl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Bounce")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
