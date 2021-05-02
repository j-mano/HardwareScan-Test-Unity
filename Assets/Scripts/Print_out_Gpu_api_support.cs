using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_out_Gpu_api_support : MonoBehaviour
{
    public GameObject interfaceCommunication;

    // interfacePrintOutText
    public Text CurrentlyRunningApiPrintOut;
    public Text GpuApiMessage;
    public Text TesselationSupport;
    public Text ShaderLVL;

    void Update()
    {
        printoutGpuSupportCurrentlyRunning(getCurrentRunningApi());
        InterfaceOsAdaptation();
        printoutTesselationSupport(SupportTesselation());
        PrintShaderLVL(shaderlvl());
    }

    string shaderlvl()
    {
        int shadeModels = SystemInfo.graphicsShaderLevel;
        string returnstring = "";

        // https://docs.unity3d.com/ScriptReference/SystemInfo-graphicsShaderLevel.html
        // The if code here is if the underlaying unity system is upgraded without taking this to account. An exeption will say
        if (shadeModels > 50)
        {
            returnstring = "Shader Model 5.0 (DX11.0) or above";
        }
        else
        {
            switch (shadeModels)
            {
                case 50:
                    returnstring = "Shader Model 5.0 (DX11.0) or above";
                    break;
                case 46:
                    returnstring = "OpenGL 4.1 capabilities (Shader Model 4.0 + tessellation)";
                    break;
                case 45:
                    returnstring = "Metal / OpenGL ES 3.1 capabilities (Shader Model 3.5 + compute shaders)";
                    break;
                case 40:
                    returnstring = "Shader Model 4.0 (DX10.0)";
                    break;
                case 35:
                    returnstring = "OpenGL ES 3.0 capabilities (Shader Model 3.0 + integers, texture arrays, instancing)";
                    break;
                case 30:
                    returnstring = "Shader Model 3.0";
                    break;
                case 25:
                    returnstring = "Shader Model 2.5 (DX11 feature level 9.3 feature set)";
                    break;
                case 20:
                    returnstring = "Shader Model 2.0.";
                    break;
                default:
                    returnstring = "No shademodel found by unity enginge. Too old or do not have any.";
                break;
            }
        }

        return returnstring;
    }

    // UI interface dependent on wha os you running.
    void InterfaceOsAdaptation(){
        GpuApiMessage.text = "";

        if(isWindows() || isLinux()){

        }

        if(isLinux()){

        }

        if(isWindows()){

        }

        if(isMac()){
            
        }
    }

    bool isMac(){
        return interfaceCommunication.GetComponent<get_os>().get_isMac();
    }

    bool isWindows(){
        return interfaceCommunication.GetComponent<get_os>().get_isWindows();
    }

    bool isLinux(){
        return interfaceCommunication.GetComponent<get_os>().get_isLinux();
    }

    bool SupportTesselation(){
        return SystemInfo.supportsTessellationShaders;
    }

    string getCurrentRunningApi()
    {
        return interfaceCommunication.GetComponent<get_gpu_api>().getRunningApiSupport();
    }

    string getOpenGlsupport()
    {
        return interfaceCommunication.GetComponent<get_gpu_api>().getOpenGLSupport();
    }

    string getVulkansupport()
    {
        return interfaceCommunication.GetComponent<get_gpu_api>().getVulkansupport();
    }

    string directXSupport()
    {
        return interfaceCommunication.GetComponent<get_gpu_api>().getLatestDX();
    }

    string getMetalsupport()
    {
        return interfaceCommunication.GetComponent<get_gpu_api>().getmetalsupport();
    }

    void printoutGpuSupportCurrentlyRunning(string CurrentlyRunningApiSupportString)
    {
        CurrentlyRunningApiPrintOut.text = "Currently running api: " + CurrentlyRunningApiSupportString;
    }

    void printoutTesselationSupport(bool printoutTesselationSupport)
    {
        TesselationSupport.text = "Tesselation Support: " + printoutTesselationSupport;
    }

    void PrintShaderLVL(string inputshaderversion)
    {
        ShaderLVL.text = "ShaderLvl: " + inputshaderversion;
    }

    void printoutGpuSupportOpenGL(string openGlSupportString)
    {
        //opengl.text = "openGlapi support: " + openGlSupportString;
    }

    void printoutGpuSupportVulkan(string vulkanSupportString)
    {
        //vulkan.text = "VulkanApi support: " + vulkanSupportString;
    }

    void printoutGpuSupportDirectX(string dxSupportString)
    {
        // windows only
        //directX_metal.text = "DirecX Api support version" + dxSupportString;
    }

    void printoutGpuSupportMetal(string metalSupportString)
    {
        // Mac only
        //directX_metal.text = "Metal support: " + metalSupportString;
    }
}
