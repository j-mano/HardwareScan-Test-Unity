using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Calculate_ram_vram_usage : MonoBehaviour
{
    PerformanceCounter ramCounter;

    void Start()
    {
        string ThrowawayRamNumb = updateRamUsage();
    }

    string updateRamUsage()
    {
        ramCounter = new PerformanceCounter("$$anonymous$$emory", "Available $$anonymous$$Bytes");

        return ramCounter.NextValue() + "$$anonymous$$B";
    }

    float updateVRamUsage()
    {
        float sysram = SystemInfo.systemMemorySize;

        return sysram;
    }

    public string getRamUsage()
    {
        return updateRamUsage();
    }

    string getVRamUsage()
    {
        return updateRamUsage();
    }
}
