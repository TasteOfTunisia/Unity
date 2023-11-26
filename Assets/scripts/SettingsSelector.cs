using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSelector : MonoBehaviour
{
    public void SelectSwipe()
    {
        PlayerPrefs.SetInt("SETTING", 1);
        StartCoroutine(LoadMainScene());
    }

    public void SelectTilt()
    {
        PlayerPrefs.SetInt("SETTING", 2);
        StartCoroutine(LoadMainScene());
    }

    private IEnumerator LoadMainScene() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
