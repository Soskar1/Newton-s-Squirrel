using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Obstacle> _obstacles;

    [SerializeField] private float _maxSpawnTime;
    [SerializeField] private float _minSpawnTime;

    private bool _timerIsGoing;

    private void Update()
    {
        if (!_timerIsGoing)
        {
            _timerIsGoing = true;
            float time = Random.Range(_minSpawnTime, _maxSpawnTime);
            StartCoroutine(Timer.Start(time, () => { SpawnRandomObstacle(); _timerIsGoing = false; }));
        }
    }

    private void SpawnRandomObstacle()
    {
        Obstacle randomObstacle = _obstacles[Random.Range(0, _obstacles.Count)];
        Instantiate(randomObstacle, transform.position, Quaternion.identity);
    }
}
