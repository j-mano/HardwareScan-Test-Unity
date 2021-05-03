using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_vr_redy : MonoBehaviour
{
    public GameObject Gpu_api_backend;

    bool vrReady = false;

    // Start is called before the first frame update
    void Start()
    {
        getBasckendVrReady();
    }

    void getBasckendVrReady(){
        vrReady = Gpu_api_backend.GetComponent<Gpu_api_support>().getRayTracing();
    }

    public bool getVrReady(){
        getBasckendVrReady();
        return vrReady;
    }
}
