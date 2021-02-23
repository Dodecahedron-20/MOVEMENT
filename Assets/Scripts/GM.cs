using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GM : MonoBehaviour
{

  [SerializeField]
  private int Health = 3;

  [SerializeField]
  private int points = 0;
  //points gems are worth on collection.
  [SerializeField]
  private int starpoints = 10;
    [SerializeField]
    private int goldstarpoints = 40;



    // the UI text goes here
  [SerializeField]
  private Text HealthText;
  [SerializeField]
  private Text PointsText;
    //[SerializeField]

    //Pause Menu:
    [SerializeField]
    private GameObject pauseMenu = null;
    private bool paused = false;



    //EndgameScreen:
    [SerializeField]
    private GameObject winScreen = null;
    [SerializeField]
    private Text finalPointsText = null;


    //that testing object once more:
    [SerializeField]
    private GameObject Testingtesting = null;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
      PointsText.text = "Points: " + points;
      //HealthText.text = "Health: " + Health;

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
        points += starpoints;
        PointsText.text = "Points: " + points;
        

    }

    public void StarPointsAdd()
    {
        points = +goldstarpoints;
        PointsText.text = "Points: " + points;
    }

    //health and crashing:

    public void Damage()
    {
        Health--;
        HealthText.text = "Health: " + Health;
        //CheckHealth();


    }

    //private void CheckHealth()
    //{
    //    if (Health > 1)
    //    {
    //        Crash();
    //    }
    //}

    //private void Crash()
    //{

    //    Time.timeScale = 0;


    //}

    //public void AddHealth()
    //{
    //    Health++;
    //    HealthText.text = "Health: " + Health;
    //}

    public void WinGame()
    {
        winScreen.SetActive(true);
        finalPointsText.text = "Final Points: " + points;
        Time.timeScale = 0;
    }






}
