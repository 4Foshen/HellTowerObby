using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private static CheckPointManager instance;

    public static CheckPointManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CheckPointManager>();
            }
            return instance;
        }
    }

    public Vector3 GetPlayerSpawnPosition()
    {
      
        float checkpointX = PlayerPrefs.GetFloat("CheckpointX");
        float checkpointY = PlayerPrefs.GetFloat("CheckpointY");
        float checkpointZ = PlayerPrefs.GetFloat("CheckpointZ");

        return new Vector3(checkpointX, checkpointY, checkpointZ);
    }

    public void SetPlayerSpawnPosition(Vector3 position)
    {
  
        PlayerPrefs.SetFloat("CheckpointX", position.x);
        PlayerPrefs.SetFloat("CheckpointY", position.y);
        PlayerPrefs.SetFloat("CheckpointZ", position.z);
        PlayerPrefs.Save();
    }
}

