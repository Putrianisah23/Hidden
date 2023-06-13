using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false;
    public GameObject popUp;
    
    public GameManager gameManager;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // popUp = GameObject.FindGameObjectWithTag("thePlayer");
        popUp = collision.gameObject;
        // popUp = collision.gameObject.;
        int koran = popUp.GetComponent<ItemCollector>().koran;

        if(koran == 4)
        {
            levelCompleted = true;
        }
        if (collision.gameObject.CompareTag("thePlayer") && levelCompleted)
        {
            Debug.Log("Player entered the trigger!");
            finishSound.Play();
            Invoke("CompleteLevel", 2f);
            gameManager.popUp();
            Time.timeScale = 0;   
        }
    }
}