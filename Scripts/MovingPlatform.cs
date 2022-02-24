using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform targetA, targetB;
    [SerializeField] private float speed = 1f;
    private Vector3 targetAPosition, targetBPosition, targetPosition, position;
    
    private void Start()
    {
        if(targetA == null || targetB == null)
        {
            Debug.Log("Targets need to be assigned for platform");
        }
        targetAPosition = targetA.position;
        targetBPosition = targetB.position;

    }
    void Update()
    {
        position = transform.position;

        // go to point b
        transform.position = Vector3.MoveTowards(position, targetPosition, speed * Time.deltaTime);

        if (position == targetBPosition)
        {
            targetPosition = targetAPosition;
        }
        else if (position == targetAPosition)
        {
            targetPosition = targetBPosition;
        }
    }
}
