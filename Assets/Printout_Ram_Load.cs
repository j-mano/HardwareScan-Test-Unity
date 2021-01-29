using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Printout_Ram_Load : MonoBehaviour
{
    public GameObject Ram_Api;

    public Text Txt_RamLoad;

    // Update is called once per frame
    void Update()
    {
        printoutRam(getRam());
    }

    void printoutRam(string usedRam)
    {
        Txt_RamLoad.text = "Ram Load (in mb): " + usedRam;
    }

    string getRam(){
        return Ram_Api.GetComponent<Get_ram>().GetRamLoad();
    }
}
