using UnityEditor;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using UnityEngine.UI;
using System.Diagnostics;
using Newtonsoft.Json;

public class StoreManager : MonoBehaviour
{
    //worst scripts ever made by BigBoyTaco https://github.com/BigBoyTaco
    //strings
    private string installDirectory;
    private string nameOfGame;
    //game Objects
    public GameObject gameInstallLocationUI;
    public GameObject LoadingTXT;
    public GameObject Store;
    //input field
    public InputField gameInstallLocation;
    //text
    public Text whatGameToInstall;
    
    //start
    public void Start()
    {
        installDirectory = Application.dataPath + @"/Games";
        //MakeJson();
    }

    //ignore all this... or don't
    /*
    public void DownloadMultiplayerLowPolyFPS()
    {
        //Get Install Location
        nameOfGame = "/MultiplayerLowPolyFPS";

        installDirectory = installDirectory + nameOfGame;

        whatGameToInstall.text = installDirectory;

        gameInstallLocationUI.SetActive(true);

        gameInstallLocation.text = installDirectory;

        UnityEngine.Debug.Log("download Multiplayer Low Poly FPS");
        //version.txt download link: https://cdn-122.anonfiles.com/p3z8j3B4xf/cb89c472-1642116705/Version.txt
        //build.zip download link: https://drive.google.com/uc?export=download&id=1nWfcqrv_Y1o1MTXTqyXkw1zp9zhNhYdG
        //Creates a webclient
        WebClient webClient = new WebClient();
        //Defines the URL and destination directory for the downloaded file
        webClient.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1nWfcqrv_Y1o1MTXTqyXkw1zp9zhNhYdG"), @"C:\Users\s28410058\Desktop\Builds\MultiplayerLowPolyFPS.zip");
        //webClient.DownloadFileAsync(new Uri(""), installDirectory);
        UnityEngine.Debug.Log("yar");
    }

    public void DownloadGenericFPS()
    {
        //Get Install Location
        nameOfGame = "/GernicFPS1";
        installDirectory = installDirectory + nameOfGame;
        whatGameToInstall.text = installDirectory;
        gameInstallLocationUI.SetActive(true);
        gameInstallLocation.text = installDirectory;
        UnityEngine.Debug.Log("yar");
        
        UnityEngine.Debug.Log("downloading GernicFPS");
        //Version.txt donwlaod link:
        //Game File download Link:
        // Creates a webclient
        WebClient webClient = new WebClient();
        //Version TXT downlaod
        webClient.DownloadFileAsync(new Uri(""), "@" + installDirectory);
        //Game File donwlaod
        webClient.DownloadFileAsync(new Uri(""), "@" + installDirectory);
    }
    */

    //insatll GFPS1
    public void installGFPS1()
    {
        installDirectory = null;
        installDirectory = Application.dataPath;

        UnityEngine.Debug.Log(installDirectory);

        UnityEngine.Debug.Log(installDirectory + @"/Installers/GenericFPS1Installer.exe");

        //start process
        Store.SetActive(false);
        LoadingTXT.SetActive(true);
        Process p = new Process();
        p.StartInfo.FileName = installDirectory + @"\Installers\GenericFPS1Installer.exe";
        p.StartInfo.Arguments = "";
        p.StartInfo.UseShellExecute = true;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.RedirectStandardOutput = false;
        p.StartInfo.Verb = "runas";
        p.Start();
        Store.SetActive(true);
        LoadingTXT.SetActive(false);

        //Process.Start(installDirectory + @"\Installers\GenericFPS1Installer.exe");
    }

    //Install MLFPS
    public void installMLFPS()
    {
        installDirectory = null;

        installDirectory = Application.dataPath;

        UnityEngine.Debug.Log(installDirectory + @"/Installers/MLFPSInstaller.exe");

        //start process
        Store.SetActive(false);
        LoadingTXT.SetActive(true);
        Process yar = new Process();
        yar.StartInfo.FileName = installDirectory + @"\Installers\GenericFPS1Installer.exe";
        yar.StartInfo.Arguments = "";
        yar.StartInfo.UseShellExecute = true;
        yar.StartInfo.CreateNoWindow = true;
        yar.StartInfo.RedirectStandardOutput = false;
        yar.StartInfo.Verb = "runas";
        yar.Start();
        Store.SetActive(true);
        LoadingTXT.SetActive(false);
    }

    //ignore this... or don't your life ig
    /*
    public void closeInstall()
    {
        installDirectory = Application.dataPath + @"/Games";
        gameInstallLocationUI.SetActive(false);
    }
    private void AltInstall()
    {
        Process.Start("cmd.exe", "/C" + "mkdir Files");
        Process.Start("cmd.exe", "/C" + "cd Files");
        Process.Start("cmd.exe", "/C" + "mkdir GFPS1");
    }
    private void MakeJson(JsonWriter writer)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("IsGFPSInstalled");
        writer.WriteValue("IsGFPSInstalled");

        if (!string.IsNullOrEmpty(RelevantText))
        {
            writer.WritePropertyName("true");
            writer.WriteValue("true");
        }
        writer.WriteEndObject();
    }
    */
}