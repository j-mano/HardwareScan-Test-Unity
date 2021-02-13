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
    string evenCpuUsage;

    List<float> MyList = new List<float>;

    void Start()
    {
        Task asynUpdateAvarageCpuLoad = Task.Run(() => { updateStoredEvenCpuLoad(); });
    }

    // Update is called once per frame
    void Update()
    {
        updateStoredCpuLoad();
    }

    void updateStoredCpuLoad()
    {
        CpuUsage = CpuLoad_api.GetComponent<Calculate_Cpu_usage>().getCurrentCpuUsage();
    }

    void updateStoredEvenCpuLoad()
    {
        // Taking mesure over 10 secounds.
        evenCpuUsage = CpuUsage;
        System.Threading.Thread.Sleep(3000);
        evenCpuUsage = CpuUsage;
        System.Threading.Thread.Sleep(3000);
        evenCpuUsage = CpuUsage;
        System.Threading.Thread.Sleep(3000);
        evenCpuUsage = CpuUsage;

        updateStoredEvenCpuLoad();
    }

    public string GetCpuLoad(){
        return CpuUsage;
    }

    public string GetAvarageCpuLoad10sec()
    {
        return evenCpuUsage;
    }
}
