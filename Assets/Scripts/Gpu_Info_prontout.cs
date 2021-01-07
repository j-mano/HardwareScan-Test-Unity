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
        
    }

    // Update is called once per frame
    void Update()
    {
        printoutGpuName(getGpuName());
        printoutVramAmount(getVram());
    }

    string getGpuName()
    {
        string GpuName = "";

        GpuName = innerinterfaceCommunication.GetComponent<Get_hardware_interface>().getGpuName();

        return GpuName;
    }

    float getVram()
    {
        float GpuVram = 0;

        GpuVram = innerinterfaceCommunication.GetComponent<Get_hardware_interface>().getGpuVram();

        return GpuVram;
    }

    void printoutGpuName(string GpuNameInput)
    {
        GpuName.text = GpuNameInput;
    }

    void printoutVramAmount(float VramInput)
    {
        GpuVram.text = VramInput.ToString();
    }
}
