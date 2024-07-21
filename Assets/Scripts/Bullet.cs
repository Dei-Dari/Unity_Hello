using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }
}
