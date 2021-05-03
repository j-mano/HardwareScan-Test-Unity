using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unityInfromationPrintout : MonoBehaviour
{
    // interfacePrintOutText
    public Text UnityVersionPrintOut;

    void Start()
    {
        // Printing out the text of unity to the front interface.
        UnityVersionPrintOut.text = "Unity version: " + Application.unityVersion;
    }
}
