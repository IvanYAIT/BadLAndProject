using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private ObstacleType type;
    [SerializeField] float rotationSpeed;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        switch (type)
        {
            case ObstacleType.MOVABLE:
                transform.Rotate(0, 0, rotationSpeed/100, Space.Self);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && type.Equals(ObstacleType.NONSTATIC))
            _rb.bodyType = RigidbodyType2D.Dynamic;
    }
}

enum ObstacleType
{
    STATIC,
    NONSTATIC,
    MOVABLE,
    DEBUFF
}
