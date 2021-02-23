using System.Collections;
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

    //Pause Menu:
    [SerializeField]
    private GameObject pauseMenu = null;
    private bool paused = false;



    //EndgameScreen:
    [SerializeField]
    private GameObject winScreen = null;
    [SerializeField]
    private Text finalStarsText = null;





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
        Debug.Log("Star! Collect!");
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
    }

    //public void Damage()
    //{
    //    Health--;
    //    HealthText.text = "Health: " + Health;
    //    //CheckHealth();


    //}

   

    public void WinGame()
    {
        winScreen.SetActive(true);
        finalStarsText.text = "Final Stars: " + stars;
        Time.timeScale = 0;
    }






}
