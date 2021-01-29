using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Get_ram : MonoBehaviour
{
    string ram = "";

    public GameObject Ram_Api;

    // Update is called once per frame
    void Update()
    {
        LoadRamloadFromBackend();
    }

    void LoadRamloadFromBackend(){
        ram = Ram_Api.GetComponent<Calculate_ram_vram_usage>().getRamUsage();
    }

    public string GetRamLoad(){
        return ram;
    }
}
