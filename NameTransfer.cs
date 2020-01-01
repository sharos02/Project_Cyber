using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string Name;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        Name = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + Name + " to the game!";
    }
}
