using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager
{
    public int levelCount = 1;
    public int levelPartsCount = 5;

    private static LevelManager instance;
    public static LevelManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LevelManager();
            }

            return instance;
        }
    }
}
