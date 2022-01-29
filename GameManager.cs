using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void Start()
    {
        //gets active scene
        Scene scene = SceneManager.GetActiveScene();
    }

    //quit game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    //goes to main menu
    public void goToMain()
    {
        SceneManager.LoadScene(0);
    }
}