using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{

    [SerializeField]
    private GM gm;

    [SerializeField]
    private GameObject thisStar = null;

    //[SerializeField]
    //private ParticleSystem collectParticles;
    //[SerializeField]
    //private AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Star");
        gm.PointsAdd();
        Destroy(thisStar);
        //collectParticles.Play();
        //collectSound.Play();
        
    }



}
