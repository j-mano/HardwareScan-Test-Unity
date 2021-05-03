using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Get_Hardware : MonoBehaviour
{
    // cpu assumed 64-bit by default due to so many systems today are 64-bit. And this aplication is using unity (wich pushing / forcing 64bit compling on moust of the supported platforms)
    public string cpu = "CpuName", cpu_arch = "Archtecture", gpu = "GpuName", motherboard = "MotherBoard";
    float ram = 0, vram = 0;
    int cpu_cores = 0, cpu_tread = 0;

    // Start is called before the first frame update
    void Start()
    {
        checkGpu();
        checkCpu();
        checkRamVram();
        checkCpuCores();
        checkCpuArch();
    }

    void checkCpu()
    {
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

    void MotherBoard()
    {
        motherboard = "MotherBoard";
    }

    void checkCpuArch(){
        try
        {
            // Print out the architecture of the running process.
            // We can use the Environment property Is64BitProcess along with SystemInfo.processorType to figure it out.
            // Do a case insensitive string check.
            if (CultureInfo.InvariantCulture.CompareInfo.IndexOf(SystemInfo.processorType, "ARM", CompareOptions.IgnoreCase) >= 0)
            {
                if (System.Environment.Is64BitProcess)
                    cpu_arch = "ARM64";
                else
                    cpu_arch = "ARM32";
            }
            else
            {
                // Since the unity engienge only support intel / amd x86 and arm is it assumed that it is x86/64 bit intel / amd
                if (System.Environment.Is64BitProcess)
                    cpu_arch = "x86_64";
                else
                    cpu_arch = "x86"; 
            }
        }
        catch
        {
            cpu_arch = "fail to get artcheteture";
        }
    }

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
