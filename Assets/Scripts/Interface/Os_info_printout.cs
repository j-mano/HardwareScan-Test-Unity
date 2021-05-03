using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Os_info_printout : MonoBehaviour
{
    public GameObject interfacegetOS;
    public Text osName;
    public Text osVersion_kernel;

    void Start()
    {
        printOsName(GetosVersion_kernelName());
        PrintosFamaily(GetOSFamaily());
    }

    string GetosVersion_kernelName()
    {
        return interfacegetOS.GetComponent<get_os>().get_running_operating_system();
    }

    string GetOSFamaily()
    {
        return SystemInfo.operatingSystemFamily.ToString();
    }

    void PrintosFamaily(string OsFamaily)
    {
        osName.text = OsFamaily;
    }

    void printOsName(string osNameInput)
    {
        osVersion_kernel.text = osNameInput;
    }
}
