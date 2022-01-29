using UnityEngine;

public class MoveCamera : MonoBehaviour 
{
    //more bad scripts made by https://github.com/BigBoyTaco

    //variables
    public Transform player;
    public Vector3 offset;

    //set camera position
    void Update() 
    {
        transform.position = player.transform.position + offset;
    }
}
