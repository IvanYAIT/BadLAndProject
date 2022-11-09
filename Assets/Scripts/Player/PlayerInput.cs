using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _isGrounded = false;
    private Invoker invoker;

    void Start()
    {
        _rb = transform.GetComponent<Rigidbody2D>();
        invoker = new Invoker();
    }

    void Update()
    {
        invoker.InvokeMove(_rb, transform);
        
        if (Input.GetKeyDown(KeyCode.Space))
            invoker.InvokeJump(_rb);

        if (!_isGrounded)
        {
            transform.rotation = new Quaternion().normalized;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("BigRock") && !collision.CompareTag("SmallRock") && !collision.CompareTag("Gear"))
            _isGrounded = true;
        if ((collision.CompareTag("BigRock") && _isGrounded) || collision.CompareTag("Chainsaw") || collision.CompareTag("Spike"))
            invoker.InvokeDeath();
        if (_isGrounded && collision.CompareTag("Gear"))
            invoker.InvokeDeath();

        if (collision.CompareTag("Finish"))
        {
            invoker.InvokeDeath();
            LevelManager.Instance.levelCount++;
            LevelManager.Instance.levelPartsCount +=2;
        }
        if (collision.CompareTag("Beehave"))
        {
            transform.localScale *= 1.5f;
            _rb.mass *= 2;
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Cone"))
        {
            transform.localScale /= 1.5f;
            _rb.mass /= 2;
            Destroy(collision.gameObject);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGrounded = false;
    }

}
