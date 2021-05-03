using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;

public class Calculate_Cpu_usage : MonoBehaviour
{
    // Private PerformanceCounter cpuCounter;
    PerformanceCounter cpuCounter = new PerformanceCounter();

    // Setting up the system parameters.
    void Start()
    {
        cpuCounter.CategoryName = "Processor";
        cpuCounter.CounterName = "% Processor Time";
        cpuCounter.InstanceName = "_Total";
    }

    // The total cpu load of the computer;
    public string getCurrentCpuUsage()
    {
        return Math.Round(cpuCounter.NextValue()) + "%";
    }
}
