using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField userInput;
    [SerializeField]
    public static string playerName;

    void Start() {
        userInput.GetComponent<InputField>().text = PlayerPrefs.GetString("Name");
    }

    public void InputName() {
        playerName = userInput.text;
        PlayerPrefs.SetString("Name", playerName);
    }
}
