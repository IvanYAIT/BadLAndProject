using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelPartList", menuName = "SO/LevelPartSO")]
public class LevelPartList : ScriptableObject
{
    public List<GameObject> levelParts;
}

[Serializable]
public class LevelPart
{
    public GameObject levelPart;
}
