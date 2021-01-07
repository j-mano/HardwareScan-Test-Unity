using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
public class Get_Hardware : MonoBehaviour
{
    // cpu assumed 64-bit by default due to so many systems today are 64-bit. And this aplication is using unity (wich pushing / forcing 64bit compling on moust of the supported platforms)
    string cpu = "", cpu_arch = "64-Bit", gpu = "", motherboard = "";
    float ram = 0, vram = 0;
    int cpu_cores = 0, cpu_tread = 0;

    // Start is called before the first frame update
    void Start()
    {
        checkGpu();
        checkCpu();
        checkRamVram();
        checkCpuCores();
    }

    void checkCpu(){
        cpu = SystemInfo.processorType;
    }

    void checkCpuCores()
    {
        cpu_cores = SystemInfo.processorCount;
    }

    void checkGpu(){
        gpu = SystemInfo.graphicsDeviceName;
    }

    void checkRamVram(){
        ram = SystemInfo.systemMemorySize;
        vram = SystemInfo.graphicsMemorySize;
    }

    /* Temporaly commented out and is added in when android and ios aplications are developt.
     * void checkCpuArch(){
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

    public int get_cpu_cores(){
        return cpu_cores;
    }
}
