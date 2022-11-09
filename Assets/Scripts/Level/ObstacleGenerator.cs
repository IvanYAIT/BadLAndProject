using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    private float count;
    private Transform obstacles;

    void Start()
    {
        obstacles = transform.GetChild(1);
        count = Mathf.Floor(obstacles.childCount / 2);
        for (int i = 0; i < count; i++)
        {
            int rnd = Random.Range(0, obstacles.childCount);
            Destroy(obstacles.GetChild(rnd).gameObject);
        }
    }
}
