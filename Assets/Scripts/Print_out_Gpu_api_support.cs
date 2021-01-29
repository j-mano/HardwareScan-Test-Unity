using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_out_Gpu_api_support : MonoBehaviour
{
    public GameObject interfaceCommunication;

    public Text opengl;
    public Text vulkan;
    public Text directX;
    public Text metal;

    // Update is called once per frame
    void Update()
    {
        // Opengl is planed to be the base of the aplication
        printoutGpuSupportOpenGL(getCurrentRunningApi());
        printoutGpuSupportVulkan(getVulkansupport());

    }

    string getCurrentRunningApi()
    {
        string CurrentRunningApi = "";

        CurrentRunningApi = interfaceCommunication.GetComponent<get_gpu_api>().getRunningApiSupport();

        return CurrentRunningApi;
    }

    string getOpenGlsupport()
    {
        string openglSupportString = "";

        openglSupportString = interfaceCommunication.GetComponent<get_gpu_api>().getOpenGLSupport();

        return openglSupportString;
    }

    string getVulkansupport()
    {
        string VulkanSupportString = "";

        VulkanSupportString = interfaceCommunication.GetComponent<get_gpu_api>().getVulkansupport();

        return VulkanSupportString;
    }

    string directXSupport()
    {
        string directXSupportString = "";

        directXSupportString = interfaceCommunication.GetComponent<get_gpu_api>().getLatestDX();

        return directXSupportString;
    }

    string getMetalsupport()
    {
        string getMetalsupport = "";

        getMetalsupport = interfaceCommunication.GetComponent<get_gpu_api>().getmetalsupport();

        return getMetalsupport;
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
        directX.text = "DirecX Api support version" + dxSupportString;
    }

    void printoutGpuSupportMetal(string metalSupportString)
    {
        // Mac only
        metal.text = "Metal support: " + metalSupportString;
    }
}
