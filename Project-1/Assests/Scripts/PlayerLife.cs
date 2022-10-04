/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: This code kills the ball and reloads the level when it falls off play area. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // [SerializeField] AudioSource deathSound;
    //bool dead = false;

    private void Update()
    {
        // deathSound=GetComponent<AudioSource>();
        if (transform.position.y < -1f)// && !dead)
        {
            Die();
        }
    }

    void Die()
    { 
        Invoke(nameof(ReloadLevel), 1f);
        //dead = true;
        // deathSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}