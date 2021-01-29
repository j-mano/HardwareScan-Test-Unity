using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_out_Gpu_api_support : MonoBehaviour
{
    public GameObject interfaceCommunication;

    public Text opengl;
    public Text vulkan;
    public Text directX_metal;

    // Update is called once per frame
    void Update()
    {
        // Opengl is planed to be the base of the aplication
        printoutGpuSupportOpenGL(getCurrentRunningApi());
        InterfaceOsAdaptation();
    }

    void InterfaceOsAdaptation(){
        if(isWindows() || isLinux())
            printoutGpuSupportVulkan(getVulkansupport());
        else
            vulkan.text = "";

        if(isWindows())
            printoutGpuSupportDirectX(directXSupport());
        else
            directX_metal.text = "";

        if(isMac())
            printoutGpuSupportMetal(getMetalsupport());
        else
            directX_metal.text = "";
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

    void printoutGpuSupportOpenGL(string openGlSupportString)
    {
        opengl.text = "Currently running api: " + openGlSupportString;
    }

    void printoutGpuSupportVulkan(string vulkanSupportString)
    {
        vulkan.text = "VulkanApi support: " + vulkanSupportString;
    }

    void printoutGpuSupportDirectX(string dxSupportString)
    {
        // windows only
        directX_metal.text = "DirecX Api support version" + dxSupportString;
    }

    void printoutGpuSupportMetal(string metalSupportString)
    {
        // Mac only
        directX_metal.text = "Metal support: " + metalSupportString;
    }
}
