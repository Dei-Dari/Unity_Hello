
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _menu.SetActive(!_menu.activeSelf);
        }

        if(_menu.activeSelf)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
