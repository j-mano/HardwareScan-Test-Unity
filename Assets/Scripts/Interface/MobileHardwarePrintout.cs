using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileHardwarePrintout : MonoBehaviour
{
    public Text GyroText;

    void Start()
    {
        PrintOutGyro(getGyro());
    }

    bool getGyro()
    {
        return SystemInfo.supportsGyroscope;
    }

    void PrintOutGyro(bool InputGyro)
    {
        GyroText.text = "Has Gyroscope: " + InputGyro.ToString();
    }
}
