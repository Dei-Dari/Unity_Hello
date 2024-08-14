using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 3;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _explosionPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            //Destroy(gameObject);

            _health--;
        }
    }

    private void Update()
    {
        _text.text = _health.ToString();
        if (_health < 0)
        {
            Destroy(Instantiate(_explosionPrefab, transform.position, Quaternion.identity),2);
            Destroy(gameObject);
        }
    }

    //private void OnTriggerStay(Collider other)
    //{

    //}
}
