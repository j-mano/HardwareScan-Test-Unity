using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Hardware : MonoBehaviour
{
    string cpu = "", cpu_arch = "64-Bit", gpu = "", motherboard = "";
    float ram = 0, vram = 0, cpu_cores = 0, cpu_tread = 0;

    // Start is called before the first frame update
    void Start()
    {
        checkGpu();
        checkCpu();
        checkRamVram();
    }

    void checkCpu(){
        cpu = SystemInfo.processorType;
    }

    void checkGpu(){
        gpu = SystemInfo.graphicsDeviceName;
    }

    void checkRamVram(){
        ram = SystemInfo.systemMemorySize;
        vram = SystemInfo.graphicsMemorySize;
    }

    /*void checkCpuArch(){
        if (CultureInfo.InvariantCulture.CompareInfo.IndexOf(SystemInfo.processorType, "ARM", CompareOptions.IgnoreCase) >= 0)
        {
            if (Environment.Is64BitProcess)
                cpu_arch = "ARM64";
            else
                cpu_arch = "ARM";
        }
        else
        {
            // Must be in the x86 family.
            if (Environment.Is64BitProcess)
                cpu_arch = "64-Bit";
            else
                cpu_arch = "32-Bit";
        }
    }*/

    public string get_Gpu(){
        return gpu;
    }

    public string get_Cpu(){
        return cpu;
    }

    public string get_Cpu_Arch(){
        return cpu_arch;
    }

    public float get_Ram(){
        return ram;
    }

    public float get_Vram(){
        return vram;
    }

    public string get_Motherboard(){
        return motherboard;
    }

    public float get_cpu_cores(){
        return cpu_cores;
    }

    // Work in progress. Put in last
    public float get_Bluetooth(){
        return cpu_cores;
    }

    // Work in progress. Put in last
    public float get_Wifi(){
        return cpu_cores;
    }
}
