using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_os : MonoBehaviour
{
    public GameObject ProgramBackendHardwarecheck;

    public string get_running_operating_system()
    {
        return ProgramBackendHardwarecheck.GetComponent<Cacl_os_and_os_Api>().getRunningOs();
    }

    public bool get_isMac()
    {
        return ProgramBackendHardwarecheck.GetComponent<Cacl_os_and_os_Api>().getIsMac();
    }

    public bool get_isWindows()
    {
        return ProgramBackendHardwarecheck.GetComponent<Cacl_os_and_os_Api>().getIsWindows();
    }

    public bool get_isLinux()
    {
        return ProgramBackendHardwarecheck.GetComponent<Cacl_os_and_os_Api>().getIsLinux();
    }
}
