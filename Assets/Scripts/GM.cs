using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

  [SerializeField]
  private int Health = 3;

  [SerializeField]
  private int Points = 0;
  //points gems are worth on collection.
  [SerializeField]
  private int Gempoints = 10;




// the UI text goes here
  [SerializeField]
  private Text HealthText;
  [SerializeField]
  private Text PointsText;
  //[SerializeField]






    // Start is called before the first frame update
    void Start()
    {

      PointsText.text = "Points: " + Points;
      HealthText.text = "Health: " + Health;

    }

    // Update is called once per frame
    void Update()
    {

    }




    private void damage()
    {
      Health --;
      HealthText.text = "Health: " + Health;
    }

    private void PointsAdd()
    {
      Points = Points + Gempoints;
      PointsText.text = "Points: " + Points;
    }







}
