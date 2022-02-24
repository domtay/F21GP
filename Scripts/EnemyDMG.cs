using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//method for enemy to DMG player (this is not used in game however presents a nice idea)
public class EnemyDMG : MonoBehaviour
{
    public Transform rifle; //requires a rifle which was not implemented
    public Transform player;
    public float rayDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }

    private void Shoot()
    {
        RaycastHit hit;
        PlayerHealth playerHealth;

        if(Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            playerHealth = hit.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage();
            Debug.Log(playerHealth.health);
        }
    }
}
