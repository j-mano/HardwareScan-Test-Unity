using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gpu_api_support : MonoBehaviour
{
    public GameObject OS_check;

    // Use unitys opengl core to check version 3.3 to 4.5
    public string get_Current_Gpu_api(){
        string Current_Gpu_api = SystemInfo.graphicsDeviceVersion;

        return Current_Gpu_api;
    }

    public string get_OpenGLVersion(){
        string openGL = "No opengl support detected.";

        return openGL;
    }

    public string get_Vulkan_Support()
    {
        string Vulkan = "No vulkan support detected.";

        return Vulkan;
    }

    public string get_DX9_Support(){
        string dxVersion = "";

        if (OS_check.GetComponent<Cacl_os_and_os_Api>().getIsWindows())
            dxVersion = "Sowftware support";

        return dxVersion;
    }

    public string get_DX10_Support(){
        string dxVersion = "";

        string Windowsversion = OS_check.GetComponent<Cacl_os_and_os_Api>().getWindowsVersion();
        // Windows versions supporting dx10.
        string[] listofWindowsVersions = new string[] { "Windows Vista", "Windows 7", "Windows 8", "Windows 10" };

        foreach (string windowsVersion in listofWindowsVersions)
        {
            if (Windowsversion.Contains(windowsVersion))
                dxVersion = "Sowftware support";
        }

        return dxVersion;
    }

    public string get_DX11_Support(){
        string dxVersion = "";

        string Windowsversion = OS_check.GetComponent<Cacl_os_and_os_Api>().getWindowsVersion();
        // Windows versions supporting dx11. Win Vista was added to vista later on https://answers.microsoft.com/en-us/windows/forum/all/how-to-install-directx-11-on-windows-vista/1438c66e-6464-4d06-af26-109ded12c8e5
        string[] listofWindowsVersions = new string[] { "Windows Vista", "Windows 7", "Windows 8", "Windows 10" };

        foreach (string windowsVersion in listofWindowsVersions)
        {
            if (Windowsversion.Contains(windowsVersion))
            {
                dxVersion = "Sowftware support";
            }
        }

        return dxVersion;
    }

    public string get_DX12_support(){
        string dxVersion = "";

        string Windowsversion = OS_check.GetComponent<Cacl_os_and_os_Api>().getWindowsVersion();

        // Windows versions supporting dx11. 
        string[] listofWindowsVersions = new string[] { "Windows 10" };

        foreach (string windowsVersion in listofWindowsVersions)
        {
            if (Windowsversion.Contains(windowsVersion))
            {
                dxVersion = "Sowftware support";
            }
        }

        return dxVersion;
    }

    public string get_Metal_support()
    {
        string metalSupport = "";

        if (OS_check.GetComponent<Cacl_os_and_os_Api>().getIsMac())
            metalSupport = "Software support";

        return metalSupport;
    }

    public string get_Latestdxsupport()
    {
        string dxVersion = "";

        string dx9  = "";
        string dx10 = "";
        string dx11 = "";
        string dx12 = "";

        if (OS_check.GetComponent<Cacl_os_and_os_Api>().getIsWindows())
        {
            dx9 = get_DX9_Support();
            dx10 = get_DX10_Support();
            dx11 = get_DX11_Support();
            dx12 = get_DX12_support();
        }

        if (dx9.Contains("Software support"))
            dxVersion = "Dx 9 Software support";
        if (dx10.Contains("Software support"))
            dxVersion = "Dx 10 Software support";
        if (dx11.Contains("Software support"))
            dxVersion = "Dx 11 Software support";
        if (dx12.Contains("Software support"))
            dxVersion = "Dx 12 Software support";

        if (dx9.Contains("Hardware support"))
            dxVersion = "Dx 9 Hardware support";
        if (dx10.Contains("Hardware support"))
            dxVersion = "Dx 10 Hardware support";
        if (dx11.Contains("Hardware support"))
            dxVersion = "Dx 11 Hardware support";
        if (dx12.Contains("Hardware support"))
            dxVersion = "Dx 12 Hardware support";

        return dxVersion;
    }

    public string getShaderLevel()
    {
        int shaderintLvl = SystemInfo.graphicsShaderLevel;

        string shaderLVLReturn = "";

        // https://docs.unity3d.com/ScriptReference/SystemInfo-graphicsShaderLevel.html
        // The if code here is if the underlaying unity system is upgraded without taking this to account. An exeption will say
        if (shaderintLvl > 50)
        {
            shaderLVLReturn = "Shader Model 5.0 (DX11.0) or above";
        }
        else
        {
            switch (shaderintLvl)
            {
                case 50:
                    shaderLVLReturn = "Shader Model 5.0 (DX11.0) or above";
                    break;
                case 46:
                    shaderLVLReturn = "OpenGL 4.1 capabilities (Shader Model 4.0 + tessellation)";
                    break;
                case 45:
                    shaderLVLReturn = "Metal / OpenGL ES 3.1 capabilities (Shader Model 3.5 + compute shaders)";
                    break;
                case 40:
                    shaderLVLReturn = "Shader Model 4.0 (DX10.0)";
                    break;
                case 35:
                    shaderLVLReturn = "OpenGL ES 3.0 capabilities (Shader Model 3.0 + integers, texture arrays, instancing)";
                    break;
                case 30:
                    shaderLVLReturn = "Shader Model 3.0";
                    break;
                case 25:
                    shaderLVLReturn = "Shader Model 2.5 (DX11 feature level 9.3 feature set)";
                    break;
                case 20:
                    shaderLVLReturn = "Shader Model 2.0.";
                    break;
                default:
                    shaderLVLReturn = "No shademodel found by unity enginge. Too old or do not have any.";
                    break;
            }
        }

        return shaderLVLReturn;
    }

    // Return if the gpu supports unitys versions of raytracing. Going to be dependent of version of unity version to detect if gpu support raytracing.
    public bool getRayTracing(){
        return SystemInfo.supportsRayTracing;
    }
}
