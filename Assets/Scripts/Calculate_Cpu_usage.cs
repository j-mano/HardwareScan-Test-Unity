using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate_Cpu_usage : MonoBehaviour
{
    //private PerformanceCounter cpuCounter;
    // Start is called before the first frame update
    void Start()
    {
        InitialiseCPUCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void InitialiseCPUCounter()
    {
        /*cpuCounter = new PerformanceCounter(
        "Processor",
        "% Processor Time",
        "_Total",
        true
        );*/
    }
}
