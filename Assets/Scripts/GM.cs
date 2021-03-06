﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GM : MonoBehaviour
{

  //[SerializeField]
  //private int Health = 3;

  [SerializeField]
  private int stars = 0;
  //points gems are worth on collection.

    [SerializeField]
    private Win win;


    // the UI text goes here
  [SerializeField]
  private Text livesText;
  [SerializeField]
  private Text PointsText;
    [SerializeField]
    private int lives = 3;

    [SerializeField]
    private ParticleSystem dmg;
    [SerializeField]
    private ParticleSystem fire;

    //beginging of the game; "quest" + controls
    [SerializeField]
    private GameObject startScreen = null;

    //Pause Menu:
    [SerializeField]
    private GameObject pauseMenu = null;
    private bool paused = false;



    //EndgameScreen:
    [SerializeField]
    private GameObject canwin = null;
    [SerializeField]
    private GameObject winScreen = null;
    [SerializeField]
    private Text finalStarsText = null;

    [SerializeField]
    private GameObject looseScreen = null;

    //player script:
    [SerializeField]
    private plane3 player;




    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PointsText.text = "Stars: " + stars;
        livesText.text = "Lives: " + lives;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
            {
                PauseMenuON();
            }
            else
            {
                PauseMenuOFF();
            }

        }

    }

    //the beginging of the game:

  public void GameStart()
  {
    startScreen.SetActive(false);
  }



    // Pause Menu things:

    private void PauseMenuON()
    {
        paused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);


    }

    //pause Menu Buttons
    private void PauseMenuOFF()
    {
        paused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void Resume()
    {
        PauseMenuOFF();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Resign()
    {
        SceneManager.LoadScene(0);
    }

    public void Star()
    {
        Debug.Log("Star");
    }





    public void PointsAdd()
    {
        stars ++;
        PointsText.text = "Stars: " + stars;
        win.StarAdd();

    }


    //health and crashing:

    public void LooseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        dmg.Play();
        CheckLife();
    }

    private void CheckLife()
    {
        if (lives < 1)
        {
            Crash();
        }
    }

    private void Crash()
    {
        canwin.SetActive(false);
        dmg.Play();
        fire.Play();
        looseScreen.SetActive(true);
        player.Freeze();

    }


    public void CanWin()
    {
      canwin.SetActive(true);
    }




    public void WinGame()
    {
        canwin.SetActive(false);
        winScreen.SetActive(true);
        finalStarsText.text = "Final Stars: " + stars + "/6";
        Time.timeScale = 0;
    }






}
