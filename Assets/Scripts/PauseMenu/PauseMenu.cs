using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    bool isPaused = false;

    void Start()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("PauseKey")) {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            gameObject.GetComponent<Canvas>().enabled = true;
        }
        else {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.GetComponent<Canvas>().enabled = false;
        }

    }
}
