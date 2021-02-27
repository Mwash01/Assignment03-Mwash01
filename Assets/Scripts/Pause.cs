using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    private bool pause;
    public GameObject pauseMenu;

    private void Start() {
        pause = false;
        pauseMenu = GameObject.Find("Canvas");
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            pause = !pause;
        }
        if (pause) {
            Time.timeScale = 0;
            pauseMenu.transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (!pause) {
            Time.timeScale = 1;
            pauseMenu.transform.GetChild(3).gameObject.SetActive(false);
        }
    }
}