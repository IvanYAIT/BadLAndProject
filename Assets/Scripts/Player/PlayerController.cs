using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController
{
    public void Move(Rigidbody2D rb, Transform transform, float speed)
    {
        float axisX = Input.GetAxis("Horizontal");

        transform.position += new Vector3(axisX * speed * Time.deltaTime, 0,0);
    }

    public void Jump(Rigidbody2D rb, float jumpForce) =>
        rb.AddForce(new Vector2(0, 1) * jumpForce, ForceMode2D.Impulse);

    public void Death() =>
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
