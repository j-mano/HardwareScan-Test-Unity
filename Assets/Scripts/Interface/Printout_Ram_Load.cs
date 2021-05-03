using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Printout_Ram_Load : MonoBehaviour
{
    public GameObject Ram_Api;

    public Text Txt_RamLoad;
    public Text Txt_VramLoad;

    void Start()
    {
        // This funktion is setting the Framrate How fast the gui is updating.
        // Is set to lower to make it easier to read.
        InvokeRepeating("FixetrateUpdate", 0, 1f);
    }

    void FixetrateUpdate()
    {
        printoutRam(getRam());
        printoutVRam(getVRam());
    }

    void printoutRam(string usedRam)
    {
        Txt_RamLoad.text = "Ram Load (in Bytes): " + usedRam;
    }

    string getRam(){
        return Ram_Api.GetComponent<Get_ram>().GetRamLoad();
    }

    void printoutVRam(string usedVRam)
    {
        Txt_VramLoad.text = "VRam Loaded by unity (in Bytes): " + usedVRam;
    }

    string getVRam()
    {
        return Ram_Api.GetComponent<Get_ram>().GetVRamLoad();
    }
}
