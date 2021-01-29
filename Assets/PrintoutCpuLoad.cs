using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintoutCpuLoad : MonoBehaviour
{
    public GameObject Cpu_Api;
    public Text Txt_CpuLoad;
    public Text Txt_CpuAvarageLoad;

    // Update is called once per frame
    void Update()
    {
        PrintOutCpuInfo(GetCpuLoadInfo(), GetCpuAvarage10SecLoadInfo());
    }

    void PrintOutCpuInfo(string inputCpuLoadString, string inputCpuAvarageLoadString)
    {
        Txt_CpuLoad.text = "Cpu Load: " + inputCpuLoadString;
        Txt_CpuAvarageLoad.text = "Avarage Cpu Load: " + inputCpuAvarageLoadString;
    }

    string GetCpuLoadInfo()
    {
        return Cpu_Api.GetComponent<get_cpu_load>().GetCpuLoad();
    }

    string GetCpuAvarage10SecLoadInfo()
    {
        return Cpu_Api.GetComponent<get_cpu_load>().GetAvarageCpuLoad10sec();
    }
}
