using UnityEngine;
using UnityEngine.SceneManagement;

public class GraphicsMenu : MonoBehaviour
{
    //gameobjects
    public GameObject lowCam;
    public GameObject medCam;
    public GameObject highCam;

    private void Start()
    {
        //gets quality level
        int qualityLevel = QualitySettings.GetQualityLevel();

        //disables cameras
        lowCam.SetActive(false);
        medCam.SetActive(false);
        highCam.SetActive(false);
        
        //gets scene info
        Scene scene = SceneManager.GetActiveScene();


        //set graphics level
        if (qualityLevel == 0)
        {
            lowCam.SetActive(true);
            medCam.SetActive(false);
            highCam.SetActive(false);
        }
        if (qualityLevel == 1)
        {
            lowCam.SetActive(false);
            medCam.SetActive(true);
            highCam.SetActive(false);
        }
        if (qualityLevel == 2)
        {
            lowCam.SetActive(false);
            medCam.SetActive(false);
            highCam.SetActive(true);
        }

    }


    public void SetQuality(int qualityIndex)
    {
        //states scene info and puts it into a variable, how nice :)
        Scene scene = SceneManager.GetActiveScene();

        //called when in main menu
        if(scene.buildIndex == 0)
        {
            //sets quality level represented in dropdown
            QualitySettings.SetQualityLevel(qualityIndex);
        }
        
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}