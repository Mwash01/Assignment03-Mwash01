using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    [SerializeField]
    public static int scoreNum = 0;
    [SerializeField]
    public static int playerLives = 1;
    [SerializeField]
    public static int totalLives = 1;
    [SerializeField]
    public static float carSpeed = 5f;
    [SerializeField]
    public static bool music = false;

    public Dropdown Lives;
    public Slider Speed;
    public Toggle MusicToggle;

    public void ToggleMusic() {
        if(MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 1);
            music = true;
        }
        if(!MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 0);
            music = false;
        }
    }

    public void ChangeSpeed() {
        carSpeed = Speed.value;
        PlayerPrefs.SetFloat("Speed", carSpeed);
    }

    public void Start() {
        Lives.GetComponent<Dropdown>().value = PlayerPrefs.GetInt("DropDown");
        Speed.value = PlayerPrefs.GetFloat("Speed");
        
        if(!PlayerPrefs.HasKey("Music")) {
            PlayerPrefs.SetInt("Music", 1);
            MusicToggle.isOn = true;
        }
        else {
            if(PlayerPrefs.GetInt("Music") == 0) {
                MusicToggle.isOn = false;
            }
            else {
                MusicToggle.isOn = true;
            }
        }
    }

    public void LivesMenu() {
        switch (Lives.value) {
            case 1:
                playerLives = 1;
                PlayerPrefs.SetInt("DropDown", Lives.value);
                break;
            case 2:
                playerLives = 3;
                PlayerPrefs.SetInt("DropDown", Lives.value);
                break;
            case 3:
                playerLives = 5;
                PlayerPrefs.SetInt("DropDown", Lives.value);
                break;
        }
    }
}
