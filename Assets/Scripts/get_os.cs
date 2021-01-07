using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_os : MonoBehaviour
{
    public GameObject ProgramBackendHardwarecheck;

    public string get_running_operating_system()
    {
        string os = "";

        os = ProgramBackendHardwarecheck.GetComponent<Cacl_os_and_os_Api>().getRunningOs();

        return os;
    }
}
