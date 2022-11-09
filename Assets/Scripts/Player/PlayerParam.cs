using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerParam", menuName = "SO/PlayerParamSO")]
public class PlayerParam : ScriptableObject
{
    public float speed;
    public float jumpForce;
}
