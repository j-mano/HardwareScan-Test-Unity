using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintoutCpuLoad : MonoBehaviour
{
    public GameObject Cpu_Api;
    public Text Txt_CpuLoad;

    void Start()
    {
        // This funktion is setting the Framrate How fast the gui is updating.
        // Is set to lower to make it easier to read.
        InvokeRepeating("FixetrateUpdate", 0, 1f);
    }

    void FixetrateUpdate()
    {
        PrintOutCpuInfo(GetCpuLoadInfo());
    }

    void PrintOutCpuInfo(string inputCpuLoadString)
    {
        Txt_CpuLoad.text = "Cpu Load: " + inputCpuLoadString;
    }

    string GetCpuLoadInfo()
    {
        return Cpu_Api.GetComponent<get_cpu_load>().GetCpuLoad();
    }
}
