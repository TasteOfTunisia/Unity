using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    // Use this for initialization
    public void Map()
    {
        SceneManager.LoadScene(0);
    }
    public void Gps()
    {
        SceneManager.LoadScene(1);
    }
    public void Game()
    {
        SceneManager.LoadScene(2);
    }
    public void Camera()
    {
        SceneManager.LoadScene(3);
    }
}