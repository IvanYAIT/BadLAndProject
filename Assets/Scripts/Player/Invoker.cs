using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private PlayerParam param = (PlayerParam)Resources.Load("SO/PlayerParam");
    private PlayerController controller = new PlayerController();

    public void InvokeMove(Rigidbody2D rb, Transform transform) => controller.Move(rb, transform, param.speed);

    public void InvokeJump(Rigidbody2D rb) => controller.Jump(rb, param.jumpForce);

    public void InvokeDeath() => controller.Death();
}
