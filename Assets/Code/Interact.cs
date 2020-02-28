using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Interact : MonoBehaviour
{
    public void StartGame(string level)
    {

     Application.LoadLevel("Game");
        
    }

    public void Level2(string level)
    {

        Application.LoadLevel("Level2");

    }

    public void Level3(string level)
    {

        Application.LoadLevel("Level3");

    }

    public void Levels(string level)
    {

        Application.LoadLevel("Levels");

    }
}
