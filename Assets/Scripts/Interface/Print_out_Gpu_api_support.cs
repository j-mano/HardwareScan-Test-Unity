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
        return interfaceCommunication.GetComponent<get_gpu_api>().getShadersupport();
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
