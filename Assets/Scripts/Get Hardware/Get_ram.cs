using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Get_ram : MonoBehaviour
{
    string ram = "";
    string Vram = "";

    public GameObject Ram_Api;

    // Update is called once per frame
    void Update()
    {
        LoadRamloadFromBackend();
    }

    void LoadRamloadFromBackend(){
        ram = Ram_Api.GetComponent<Calculate_ram_vram_usage>().getRamUsage();
        Vram = Ram_Api.GetComponent<Calculate_ram_vram_usage>().getVRamUsage();
    }

    public string GetRamLoad(){
        return ram;
    }

    public string GetVRamLoad()
    {
        return Vram;
    }
}
