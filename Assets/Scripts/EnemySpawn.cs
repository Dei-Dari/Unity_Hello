using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;   //переменная хранит префаб противника
    [SerializeField] private float _time;               //интервал появления противника
    [SerializeField] private Transform _transformSpawn;

    private void Update()
    {
        _time -= Time.deltaTime;
        if(_time <= 0 )
        {
            _transformSpawn.position = new Vector3(Random.Range(-10, 10), 10, 0);
            InstantiateEnemy();
            _time = Random.Range(2, 5);
        }
    }
    private void InstantiateEnemy()
    {
        Destroy(Instantiate(_enemyPrefab, _transformSpawn.position, Quaternion.identity),20);
    }
}
