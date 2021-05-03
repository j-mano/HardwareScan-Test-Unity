using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDeviceName : MonoBehaviour
{
    public Text Txt_DeviceName;

    // Start is called before the first frame update
    void Start()
    {
        printout(getDeviceName());
    }

    string getDeviceName(){
        string deviceName = SystemInfo.deviceModel;

        switch (deviceName)
        {
            case "PC":
                deviceName = "Generic pc / Custom build pc";
                break;
            default:

                break;
        }

        return deviceName;
    }

    void printout(string DeviceName)
    {
        Txt_DeviceName.text = DeviceName;
    }
}
