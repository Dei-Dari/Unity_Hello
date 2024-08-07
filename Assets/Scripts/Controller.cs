//https://www.youtube.com/watch?v=Xxct2C_1wp4
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _cameraMain;
    [SerializeField] private GameObject _camera2;
    [SerializeField] private GameObject _light;
    [SerializeField] private Light _light2;

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
        // переключение камер
        if(Input.GetKeyDown(KeyCode.R)) {
            _cameraMain.SetActive(false);
            _camera2.SetActive(true);
        }

        //свет
        //if(Input.GetKeyDown(KeyCode.R)) { 
        //    _light.SetActive(false);
        //}

        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    _light.SetActive(!_light.activeSelf);
        //}

        if (Input.GetKeyDown(KeyCode.Y))
        {
            _light2.intensity = 3;
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
