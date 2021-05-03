using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_gpu_api : MonoBehaviour
{
    public GameObject ProgramBackendHardwarecheck;

    public string getRunningApiSupport()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Current_Gpu_api();
    }

    public string getLatestDX()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Latestdxsupport();
    }

    public string getOpenGLSupport()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_OpenGLVersion();
    }

    public string getmetalsupport()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Metal_support();
    }

    public string getVulkansupport()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().get_Vulkan_Support();
    }

    public string getShadersupport()
    {
        return ProgramBackendHardwarecheck.GetComponent<Gpu_api_support>().getShaderLevel();
    }
}
