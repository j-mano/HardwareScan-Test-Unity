using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Cpu_Load : MonoBehaviour
{
    public GameObject CpuLoad_api;
    string CpuUsage;


    // Update is called once per frame
    void Update()
    {
        printOutCpuLoad(getCpuLoad());
    }

    void printOutCpuLoad(string CpuLoad)
    {

    }

    string getCpuLoad()
    {
        return CpuLoad_api.GetComponent<Calculate_Cpu_usage>().getCurrentCpuUsage();
    }

}