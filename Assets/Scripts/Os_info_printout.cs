using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Os_info_printout : MonoBehaviour
{
    public GameObject interfacegetOS;
    public Text osName;
    public Text osVersion_kernel;

    // Update is called once per frame
    void Update()
    {
        printOsName(getOsName());
    }

    string getOsName()
    {
        string OsName = "";

        OsName = interfacegetOS.GetComponent<get_os>().get_running_operating_system();

        return OsName;
    }

    void printOsName(string osNameInput)
    {
        osName.text = osNameInput;
    }
}
