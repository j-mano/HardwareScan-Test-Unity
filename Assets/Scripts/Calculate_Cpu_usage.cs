using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;

public class Calculate_Cpu_usage : MonoBehaviour
{
    //private PerformanceCounter cpuCounter;
    PerformanceCounter cpuCounter = new PerformanceCounter();
    PerformanceCounter ramCounter = new PerformanceCounter("$$anonymous$$emory", "Available $$anonymous$$Bytes");

    // Start is called before the first frame update
    void Start()
    {
        cpuCounter.CategoryName = "Processor";
        cpuCounter.CounterName = "% Processor Time";
        cpuCounter.InstanceName = "_Total";
    }


    public string getCurrentCpuUsage()
    {
        // The total cpu load of the computer;
        return Math.Round(cpuCounter.NextValue()) + "%";
    }

    public string getAvailableRAM()
    {
        return ramCounter.NextValue()+"$$anonymous$$B";
    }
}
