using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacl_os_and_os_Api : MonoBehaviour
{
    // Get The current running system os.
    public string getRunningOs()
    {
        string runningos = "";

        runningos = SystemInfo.operatingSystem;

        return runningos;
    }

    // Validate if system is mac os x 10. OSX 9 and erlier not supported.
    public bool getIsMac()
    {
        string os = getRunningOs();
        string CompareString = "Mac OS X";

        bool returnvalue = false;

        if (os.Contains(CompareString))
            returnvalue = true;
        else
            returnvalue = false;

        return returnvalue;
    }

    // Validate if system is windows. Validates to work with xp and onward.
    public bool getIsWindows()
    {
        string os = getRunningOs();
        string CompareString = "Windows";

        bool returnvalue = false;

        if (os.Contains(CompareString))
            returnvalue = true;
        else
            returnvalue = false;

        return returnvalue;
    }

    // Get specifik version of windows. Windows xp, Vista, 7, 8 or 10.
    public string getWindowsVersion()
    {
        // Checks the os reported by unity and compare it to an list of windows versions. This function is used to trim out exakt version and 64/32 bit version
        string os = getRunningOs();
        bool isWindows = getIsWindows();

        string[] listofWindowsVersions = new string[] { "Windows XP", "Windows Vista", "Windows 7", "Windows 8", "Windows 10" };
        string resturnstring = "";

        if(isWindows == false)
            resturnstring = "not running windows";
        else
        {
            foreach (string windowsVersion in listofWindowsVersions)
            {
                if (os.Contains(windowsVersion))
                {
                    resturnstring = windowsVersion;
                }
            }
        }

        return resturnstring;
    }

    // Validate if system is Modern version of linux. confirmd to work with distros working with unity system.
    public bool getIsLinux()
    {
        string os = getRunningOs();
        string CompareString = "Linux";

        bool returnvalue = false;

        if (os.Contains(CompareString))
            returnvalue = true;
        else
            returnvalue = false;

        return returnvalue;
    }
}
