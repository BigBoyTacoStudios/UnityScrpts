using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    //more bad scripts made by https://github.com/BigBoyTaco

    //gameObjects
    public GameObject settingsMenuUI;
    public GameObject mainMenuUI;
    public GameObject graphicsSettignsUI;
    public GameObject levelSelectUI;
    public GameObject audioMenu;
    public GameObject Loading;
    public GameObject Store;
    public GameObject Collection;

    //main Munu stuff
    public void levelSelect()
    {
        mainMenuUI.SetActive(false);
        levelSelectUI.SetActive(true);
    }
    public void settingsMenu()
    {
        settingsMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    public void graphicsMenu()
    {
        graphicsSettignsUI.SetActive(true);
        settingsMenuUI.SetActive(false);
    }
    public void MainMunuUI()
    {
        mainMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
    }
    public void backFromgraphics()
    {
        settingsMenuUI.SetActive(true);
        graphicsSettignsUI.SetActive(false);
    }
    public void backFromsettings()
    {
        settingsMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void backFromlevelSelect()
    {
        levelSelectUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void audioSettings()
    {
        settingsMenuUI.SetActive(false);
        audioMenu.SetActive(true);
    }
    public void toStore()
    {
        Store.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    public void backFromStore()
    {
        Store.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void backFromAudio()
    {
        settingsMenuUI.SetActive(true);
        audioMenu.SetActive(false);
    }
    public void toCollection()
    {
        Collection.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    public void backFromCollection()
    {
        Collection.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void loadWasteland()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        Loading.SetActive(true);
    }
    public void laod3021()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);
        Loading.SetActive(true);
    }
    public void loadTest1()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(3);
        Loading.SetActive(true);
    }

    //audio
    public AudioMixer mainMixer;

    public void setLevel(float sliderValue)
    {
        mainMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }
}
