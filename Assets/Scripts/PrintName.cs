using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintName : MonoBehaviour
{
    public Text printedName;
    void Start()
    {
        printedName.text = "Player: " + Name.playerName;
    }

}
