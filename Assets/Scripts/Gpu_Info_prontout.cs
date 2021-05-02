using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gpu_Info_prontout : MonoBehaviour
{
    public GameObject innerinterfaceCommunication;
    public Text GpuName;
    public Text GpuVram;

    // Start is called before the first frame update
    void Start()
    {
        printoutGpuName(getGpuName());
        printoutVramAmount(getVram());
    }

    string getGpuName()
    {

        return innerinterfaceCommunication.GetComponent<Get_hardware_interface>().getGpuName();
    }

    float getVram()
    {
        return innerinterfaceCommunication.GetComponent<Get_hardware_interface>().getGpuVram();
    }
    void printoutGpuName(string GpuNameInput)
    {
        GpuName.text = GpuNameInput;
    }

    void printoutVramAmount(float VramInput)
    {
        GpuVram.text = "Amount of videoram: " + VramInput.ToString() + "MB";
    }
}
