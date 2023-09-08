using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviour
{
    private Vector3 spawnPosition;
    [SerializeField] GameObject _playerPrefab;

    private void Awake()
    {
        spawnPosition = CheckPointManager.Instance.GetPlayerSpawnPosition();
        Debug.Log(spawnPosition);
        Instantiate(_playerPrefab, spawnPosition, Quaternion.identity);
    }
}
