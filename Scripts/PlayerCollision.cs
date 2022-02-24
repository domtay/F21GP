﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//class for player collision, if touch enemy go to game over screen, if touch gem go to win screen
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "enemy")
        {
            //Debug.Log("We hit an enemy");
            //movement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(4);

        }
        
        if (collisionInfo.collider.tag == "gem")
        {
            Debug.Log("Game has been won");
            SceneManager.LoadScene(3);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

    }
}
