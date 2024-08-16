
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangedLevel : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    public void Click()
    {
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        _menu.SetActive(!_menu.activeSelf);
    }
    
    public void ExitGame()
    {
        //Debug.Log("Exit");
        Application.Quit();
    }
}
