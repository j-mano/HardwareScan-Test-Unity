using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintOut_Vr_Ready : MonoBehaviour
{
    public GameObject VrReady_Api;

    public Text Txt_VrReady;

    // Update is called once per frame
    void Update()
    {
        printout();
    }

    void printout(){
        Txt_VrReady.text = "Raytracing ready: " +  VrReady_Api.GetComponent<Get_vr_redy>().getVrReady().ToString();
    }
}
