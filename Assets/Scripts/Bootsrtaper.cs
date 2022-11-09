using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bootsrtaper : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private CameraMover cameraMover;
    [SerializeField] private TextMeshProUGUI levelText;

    void Start()
    {
        cameraMover.Constructor(player.transform);
        levelText.text = $"Level {LevelManager.Instance.levelCount}";
    }
}
