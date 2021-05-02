using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This file is meant to be acesspoint betwene the interface and backend calculations/infomation gathering
public class Get_hardware_interface : MonoBehaviour
{
    public GameObject ProgramBackendHardwarecheck;

    public string getCpuModel()
    {
        string cpu = "";

        cpu = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Cpu();

        return cpu;
    }

    public int getCpuCores()
    {
        int cpuCores = 0;

        cpuCores = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_cpu_cores();

        return cpuCores;
    }

    public string getCpuArch()
    {
        string cpuArch = "";

        cpuArch = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Cpu_Arch();

        return cpuArch;
    }

    public string getGpuName()
    {
        string gpu = "";

        gpu = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Gpu();

        return gpu;
    }

    public float getGpuVram()
    {
        float gpuvram = 0;

        gpuvram = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Vram();

        return gpuvram;
    }

    public string getMotherBoard()
    {
        string motherboard = "";

        motherboard = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Motherboard();

        return motherboard;
    }

    public string ramName()
    {
        string ramName = "";

        return ramName;
    }

    public float ramAmount()
    {
        float ramAmount = 0;

        ramAmount = ProgramBackendHardwarecheck.GetComponent<Get_Hardware>().get_Ram();

        return ramAmount;
    }

    public int ramSpeed()
    {
        int ramSpeed = 0;

        return ramSpeed;
    }
}
