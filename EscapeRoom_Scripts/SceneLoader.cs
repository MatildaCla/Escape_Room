using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Canvas canvas;

    public void BackToPlayground()
    {
        //Lock Curser
        Cursor.lockState = CursorLockMode.Locked;
        //Load Playground
        //SceneManager.LoadScene(0, LoadSceneMode.Single);
        //Close Canvas
        canvas.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
