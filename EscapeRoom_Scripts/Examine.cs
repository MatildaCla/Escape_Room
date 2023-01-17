using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Examine : MonoBehaviour
{
    private bool isColliding = false;

    public string sceneName;
    public Canvas canvas;
    public Canvas uiOverlay;

    private void OnTriggerEnter(Collider other)
    {
        isColliding = true;
        uiOverlay.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isColliding = false;
        uiOverlay.gameObject.SetActive(false);
    }

    private void Update()
    {
        //While Colliding and pressing Space
        if (isColliding && Input.GetKeyDown(KeyCode.Space))
        {
            //Unlock Cursor
            Cursor.lockState = CursorLockMode.None;
            //Load new Scene
            //SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            //Open Canvas
            canvas.gameObject.SetActive(true);
        }
    }
}
