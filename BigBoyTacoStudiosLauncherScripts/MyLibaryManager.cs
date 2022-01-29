using UnityEngine;
using System;
using System.Diagnostics;

public class MyLibaryManager : MonoBehaviour
{
    //worst scripts ever made by BigBoyTaco https://github.com/BigBoyTaco
    //games installed
    public bool GFPS_Installed = false;
    public bool MPLPFPS_Installed = false;

    public void LaunchGFPS1()
    {
        Process.Start(Application.dataPath + @"\Games\GFPS\GFPS1.exe");
    }

    public void LaunchMLFPS()
    {
        Process.Start(Application.dataPath + @"\Games\MLFPS\MLFPS.exe");
    }
}