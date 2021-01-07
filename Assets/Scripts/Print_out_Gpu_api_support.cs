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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        printoutGpuSupportOpenGL(getOpenGlsupport());
        printoutGpuSupportVulkan(getVulkansupport());
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


        return directXSupportString;
    }

    string getMetalsupport()
    {
        string getMetalsupport = "";


        return getMetalsupport;
    }

    void printoutGpuSupportOpenGL(string openGlSupportString)
    {
        opengl.text = openGlSupportString;
    }

    void printoutGpuSupportVulkan(string vulkanSupportString)
    {
        vulkan.text = vulkanSupportString;
    }

    void printoutGpuSupportDirectX()
    {
        // windows only
    }

    void printoutGpuSupportMetal()
    {
        // Mac only
    }
}
