using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //light wrk

public class mainmenu : MonoBehaviour
{

    public GameObject creditsPanel;             //creates a public game object for the credits pannel

    public void StartGame()
    {
        SceneManager.LoadScene(1);              //loads scene 1 which should be the first level
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");           //this is purley for test so we can see it return something in the console upon button click
        Application.Quit();                     //this is what exits the game apparently wont wrk until the game is fully compiled
    }

}
