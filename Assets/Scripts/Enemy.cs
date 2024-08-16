using System.Collections;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 3;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _explosionPrefab;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _enemyBullet;
    [SerializeField] private Transform _spawnPoint;
    private float _currentTime = 2;
    private float _nextTime = 2;
    private bool _isShooting = false;

    private void Start()
    {
        // старт карутины
        if(!_isShooting)
        {
            _isShooting = true;
            StartCoroutine(ShotBullet());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            //Destroy(gameObject);

            _health--;
            //уничтожение пули при попадании
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        _text.text = _health.ToString();
        if (_health < 0)
        {
            Destroy(Instantiate(_explosionPrefab, transform.position, Quaternion.identity), 2);
            Destroy(gameObject);
        }
        //_currentTime += Time.deltaTime;
        //if (_currentTime >= _nextTime)
        //{
        //    Destroy(Instantiate(_enemyBullet, _spawnPoint.position, Quaternion.identity), 4);
        //    _currentTime = 0;
        //}
        //Shot();
    }

    //private void Shot()
    //{
    //    StartCoroutine(ShotBullet());
    //}

    private IEnumerator ShotBullet()
    {
        while (true)
        {
            Destroy(Instantiate(_enemyBullet, _spawnPoint.position, Quaternion.identity), 4);
            yield return new WaitForSeconds(2);
        }
    }

    //private void OnTriggerStay(Collider other)
    //{

    //}
}
