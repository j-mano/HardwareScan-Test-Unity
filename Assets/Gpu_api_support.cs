using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gpu_api_support : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Use unitys opengl core to check version 3.3 to 4.5
    public string get_Current_Gpu_api(){
        string Current_Gpu_api = SystemInfo.graphicsDeviceVersion;

        return Current_Gpu_api;
    }

    // Use unitys opengl core to check version 3.3 to 4.5
    public string get_OpenGLVersion(){
        string openGL = "";

        return openGL;
    }

    // Just for example may not be implemented in final version
    public string get_DX9_Support(){
        string dxVersion = "";

        return dxVersion;
    }

    // Just for example may not be implemented in final version
    public string get_DX10_Support(){
        string dxVersion = "";

        return dxVersion;
    }

    public string get_DX11_Support(){
        string dxVersion = "";

        return dxVersion;
    }

    public string get_DX12_support(){
        string dxVersion = "";

        return dxVersion;
    }

    public string getCudaVersion(){
        string cudaVersion = "";

        return cudaVersion;
    }

    public string getOpenCLVersion(){
        string OpenCL = "";

        return OpenCL;
    }

    public bool getVrRedy(){
        bool Vrredy = SystemInfo.supportsRayTracing;

        return Vrredy;
    }

    public bool getRayTracing(){
        bool RayTracing = SystemInfo.supportsRayTracing;

        return RayTracing;
    }
}
