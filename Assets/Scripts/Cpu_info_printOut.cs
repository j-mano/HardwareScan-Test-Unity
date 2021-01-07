using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cpu_info_printOut : MonoBehaviour
{
    public GameObject interfaceHardwareApi;
    public Text cpuName;
    public Text cpuCores;

    void Update()
    {
        printCpuName(getCpuname());
        printCpuCore(getCpucores());
    }

    string getCpuname()
    {
        string CpuName = "";

        CpuName = interfaceHardwareApi.GetComponent<Get_hardware_interface>().getCpuModel();

        return CpuName;
    }

    int getCpucores()
    {
        int Cpucores = 0;

        Cpucores = interfaceHardwareApi.GetComponent<Get_hardware_interface>().getCpuCores();

        return Cpucores;
    }


    void printCpuName(string cpuNameinput)
    {
        cpuName.text = cpuNameinput;
    }

    void printCpuCore(int cpucoreinput)
    {
        cpuCores.text = "Number of treads on cpu: " + cpucoreinput.ToString();
    }
}
