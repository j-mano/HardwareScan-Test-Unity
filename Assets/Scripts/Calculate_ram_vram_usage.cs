using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate_ram_vram_usage : MonoBehaviour
{
    //private PerformanceCounter ramCounter;

    void Start()
    {
        updateRamUsage();
    }

    float updateRamUsage()
    {
        /*ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

        return UnityEngine.Profiling.Profiler.GetRuntimeMemorySize;*/

        return 0;
    }

    float getRamUsage()
    {
        return updateRamUsage();
    }
}
