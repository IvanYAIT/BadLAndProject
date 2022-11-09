using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject finishLine;

    private int levelPartsCount;
    private LevelPartList levelPartList;
    private List<GameObject> levelParts;

    void Start()
    {
        levelPartsCount = LevelManager.Instance.levelPartsCount;
        levelPartList = (LevelPartList) Resources.Load("SO/LevelPartList");
        levelParts = levelPartList.levelParts;
        for (int i = 0; i < levelPartsCount; i++)
        {
            int rnd = Random.Range(0, levelParts.Count);
            if (i == 0)
            {
                Instantiate(levelParts[rnd], new Vector3(transform.position.x, transform.position.y), new Quaternion(), transform.parent);
            }
            else
            {
                Instantiate(levelParts[rnd], new Vector3(transform.position.x, transform.position.y), new Quaternion(), transform.parent);
            }
            transform.position = transform.parent.GetChild(i+1).transform.GetChild(0).position;
        }
        Instantiate(finishLine, new Vector3(transform.position.x, transform.position.y), new Quaternion(), transform.parent);
    }
}
