//https://www.youtube.com/watch?v=Xxct2C_1wp4
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bullet;

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    private void Move()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(_speed * Time.deltaTime * Vector3.left);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(_speed * Time.deltaTime * Vector3.right);
        //}

        float translationX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        transform.Translate(translationX, 0, 0);
        float translationY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Translate(0, translationY, 0);

    }

    private void Shot()
    {
        Destroy(Instantiate(_bullet, transform.position, Quaternion.identity),2);
    }
}
