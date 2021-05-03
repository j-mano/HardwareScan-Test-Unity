using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;

public class get_cpu_load : MonoBehaviour
{
    public GameObject CpuLoad_api;
    string CpuUsage;

    void Update()
    {
        updateStoredCpuLoad();
    }

    void updateStoredCpuLoad()
    {
        CpuUsage = CpuLoad_api.GetComponent<Calculate_Cpu_usage>().getCurrentCpuUsage();
    }

    public string GetCpuLoad(){
        return CpuUsage;
    }
}
