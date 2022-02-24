using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//unimplemented class that tracks player health. Aim was to have health lowered when touch enemies but now it is instant death
public class PlayerHealth : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage()
    {
        health = 0;
    }
}
