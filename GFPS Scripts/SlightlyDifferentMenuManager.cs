using UnityEngine;
using UnityEngine.SceneManagement;

public class SlightlyDifferentMenuManager : MonoBehaviour
{
    //more bad scripts made by https://github.com/BigBoyTaco
    

    public GameObject Menu;

    private void Update()
    {
        inMenu();
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    
    //menu
    public void inMenu()
    {
            if (Input.GetKey(KeyCode.Escape))
            {
                Debug.Log("should be in menu");
                Menu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
    }

    //resume when in menu
    public void Resume()
    {
        Menu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("outta main");
    }

    //goes to main menu
    public void goToMain()
    {
        SceneManager.LoadScene(0);
    }
}
