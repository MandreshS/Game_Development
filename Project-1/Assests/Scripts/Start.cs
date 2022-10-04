/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: Starts the game. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
  }
}
