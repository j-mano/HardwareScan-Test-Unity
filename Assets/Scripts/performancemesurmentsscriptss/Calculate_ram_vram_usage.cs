using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Unity.Profiling;

public class Calculate_ram_vram_usage : MonoBehaviour
{
    string _statsText;
    ProfilerRecorder _totalSystemMemoryRecorder;
    ProfilerRecorder _totalSystemVideoMemoryRecorder;

    void OnEnable()
    {
        _totalSystemMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "System Used Memory");
        _totalSystemVideoMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "Video Reserved Memory");
    }
    void OnDisable()
    {
        _totalSystemMemoryRecorder.Dispose();
    }

    void Start()
    {

    }

    // Total system ramusage including casht ram.
    public string getRamUsage()
    {
        var sb = new System.Text.StringBuilder(500);
        if (_totalSystemMemoryRecorder.Valid)
            {
                sb.AppendLine($"{_totalSystemMemoryRecorder.LastValue}");
            }
            

        return sb.ToString();
        }

    // Vram used by the aplicatione. planed to change it to total system vram when unity engien supports it.
    public string getVRamUsage()
    {
        var sb = new System.Text.StringBuilder(500);
        if (_totalSystemVideoMemoryRecorder.Valid)
        {
            sb.AppendLine($"{_totalSystemVideoMemoryRecorder.LastValue}");
        }

        return sb.ToString();
    }
}
