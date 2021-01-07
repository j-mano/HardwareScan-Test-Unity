using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_gpu_api : MonoBehaviour
{
    public GameObject ProgramBackendHardwarecheck;

    public string getOpenGLSupport()
    {
        string openGlVersion = "";

        openGlVersion = ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_OpenGLVersion();

        return openGlVersion;
    }

    public string getmetalsupport()
    {
        string metalsupport = "";

        metalsupport = ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Vulkan_Support();

        return metalsupport;
    }

    public string getVulkansupport()
    {
        string vulkansupport = "";

        vulkansupport = ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Metal_support();

        return vulkansupport;
    }
}
