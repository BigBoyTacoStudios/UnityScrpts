using UnityEditor;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Net;

public class MenuManager : MonoBehaviour
{
    //worst scripts ever made by BigBoyTaco https://github.com/BigBoyTaco
    //variables
    public GameObject Main;
    public GameObject MyLibary;
    public GameObject Store;

    public GameObject MultiplayerLowPolyFPS;

    //bools
    public bool isMultiplayerLowPolyFPSInstalled;
    public bool isGernicFPS1_Installed;

    //My Libary
    public void myLibary()
    {
        Main.SetActive(false);
        MyLibary.SetActive(true);
        if (isMultiplayerLowPolyFPSInstalled == true)
        {
            MultiplayerLowPolyFPS.SetActive(true);
        }
        else
        {
            MultiplayerLowPolyFPS.SetActive(false);
        }
    }
    
    public void store()
    {
        Main.SetActive(false);
        Store.SetActive(true);
    }

    public void readJSON()
    {
        Debug.Log("Read JSON");
    }

    public void backToMain()
    {
        Store.SetActive(false);
        MyLibary.SetActive(false);
        Main.SetActive(true);
    }
}