using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacl_os_and_os_Api : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string getRunningOs()
    {
        string runningos = "";

        runningos = SystemInfo.operatingSystem;

        return runningos;
    }
}
