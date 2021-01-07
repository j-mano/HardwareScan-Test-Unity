using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ram_info_print_out : MonoBehaviour
{
    public GameObject interfaceHardwareApi;
    public Text SysMem;

    void Update()
    {
        printRamAmount(getRamName());
    }

    float getRamName()
    {
        float RamAmount = 0;

        RamAmount = interfaceHardwareApi.GetComponent<Get_hardware_interface>().ramAmount();

        return RamAmount;
    }

    void printRamAmount(float RamamountInput)
    {
        SysMem.text = RamamountInput.ToString() + "MB";
    }
}
