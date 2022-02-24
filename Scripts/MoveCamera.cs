using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to update camera position based on player position
public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform cameraPosition;

    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
