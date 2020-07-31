using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPointsParrent;

    private Transform[] _spawnPoints;
    private int _currentPoint = 0;

    private void Awake()
    {
        _spawnPoints = _spawnPointsParrent.GetComponentsInChildren<Transform>();
    }

    public void Spawn()
    {
        if (_currentPoint >= _spawnPoints.Length - 1)
            _currentPoint = 0;
        else
            _currentPoint++;

        Instantiate(_enemyPrefab, _spawnPoints[_currentPoint]);
    }
}
