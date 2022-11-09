using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private Transform playerTransform;

    public void Constructor(Transform playerTransform)
    {
        this.playerTransform = playerTransform;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x,0,-10);
    }

    
}
