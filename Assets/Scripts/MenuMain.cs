using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{

    // in menu pages/changes:
    [SerializeField]
    private GameObject Menu = null;
    [SerializeField]
    private GameObject CreditMenu = null;
    [SerializeField]
    private GameObject QuitPrompt = null;


    //Start the Game things:
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



    //Settings Menus:
    //turn Settings menu on
    public void CreditsOn()
    {
        CreditMenu.SetActive(true);
        Menu.SetActive(false);
    }
    //turn settings menu off
    public void CreditsOff()
    {
        CreditMenu.SetActive(false);
        Menu.SetActive(true);
    }



    //Quit things:

    //when selecting the quit button bring up the Quit Yes/no option
    public void QuitPromptOn()
    {
        QuitPrompt.SetActive(true);
        Menu.SetActive(false);
    }

    //selecting No and closing the quit prompt
    public void QuitPromptOff()
    {
        QuitPrompt.SetActive(false);
        Menu.SetActive(true);
    }

    //selecting yes and quitting the game
    public void QuitGame()
    {
        Application.Quit();
    }






}
