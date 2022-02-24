using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to control Ai of enemies
public class AIController : MonoBehaviour
{
    public float sensorLength = 5f;
    public float enemySpeed = 10f;
    public float directionValue = 1f;
    float turnValue = 0f;
    float turnSpeed = 50f;
    Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myCollider = transform.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        int flag = 0;
        //right sensor for if hitting something
        if(Physics.Raycast(transform.position, transform.right, out hit, (sensorLength + transform.localScale.x)))
        {
            if(hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }

            turnValue -= 1;
            flag++;
        }
        //left sensor if hitting something
        if(Physics.Raycast(transform.position, -transform.right, out hit, (sensorLength + transform.localScale.x)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }

            turnValue += 1;
            flag++;
        }

        //front sensor if hitting something
        if (Physics.Raycast(transform.position, transform.forward, out hit, (sensorLength + transform.localScale.z)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
                Debug.Log("Hit wall");
            }

            if (directionValue == 1f)
            {
                directionValue = -1;
            }
            flag++;
        }

        //back sensor if hitting something
        if (Physics.Raycast(transform.position, -transform.forward, out hit, (sensorLength + transform.localScale.z)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }
            if (directionValue == -1f)
            {
                directionValue = 1;
            }
            flag++;

        }

        if (flag == 0)
        {
            turnValue = 0;
        }

        transform.Rotate(Vector3.up * (turnSpeed * turnValue) * Time.deltaTime);

        transform.position += transform.forward * (enemySpeed *directionValue) * Time.deltaTime;
    }

    //initialise sensors
    void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.forward * (sensorLength + transform.localScale.z)); //forward sensor
        Gizmos.DrawRay(transform.position, -transform.forward * (sensorLength + transform.localScale.z)); //backward sensor
        Gizmos.DrawRay(transform.position, transform.right * (sensorLength + transform.localScale.x)); //right sensor
        Gizmos.DrawRay(transform.position, -transform.right * (sensorLength + transform.localScale.x)); //left sensor
    }
}
