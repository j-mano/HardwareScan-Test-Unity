using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cpu_info_printOut : MonoBehaviour
{
    public GameObject interfaceHardwareApi;
    public Text cpuName;
    public Text cpuCores;
    public Text cpuArch;
    public Text cpuClockSpeedtext;

    void Start()
    {
        // This funktion is setting the Framrate How fast the gui is updating.
        // Is set to lower to make it easier to read.
        // Cpu ClockSpeed can be unreadable on certend cpu models if its updates to fast.
        InvokeRepeating("FixetrateUpdate", 0, 1f);
    }

    void FixetrateUpdate()
    {
        printCpuName(getCpuname());
        printCpuCore(getCpucores());
        printCpuClockspeed(getCpuClockSpeed());
        printCpuArch(getCpuArch());
    }

    string getCpuname()
    {
        string CpuName = "";

        CpuName = interfaceHardwareApi.GetComponent<Get_hardware_interface>().getCpuModel();

        return CpuName;
    }

    string getCpuArch()
    {
        string cpuArch = "";

        cpuArch = interfaceHardwareApi.GetComponent<Get_hardware_interface>().getCpuArch();

        return cpuArch;
    }

    int getCpucores()
    {
        return interfaceHardwareApi.GetComponent<Get_hardware_interface>().getCpuCores();
    }

    // Cpu ClockSpeed can be unreadable on certend cpu models if its updates to fast.
    int getCpuClockSpeed()
    {
        return SystemInfo.processorFrequency;
    }

    void printCpuName(string cpuNameinput)
    {
        cpuName.text = cpuNameinput;
    }

    void printCpuArch(string cpuArchinput)
    {
        cpuArch.text = cpuArchinput;
    }

    // Cpu ClockSpeed can be unreadable on certend cpu models if its updates to fast.
    void printCpuCore(int cpucoreinput)
    {
        cpuCores.text = "Number of treads on cpu: " + cpucoreinput.ToString();
    }

    void printCpuClockspeed(int cpuClockSpeed)
    {
        cpuClockSpeedtext.text = "Current clockSpeed:  " + cpuClockSpeed.ToString();
    }
}
