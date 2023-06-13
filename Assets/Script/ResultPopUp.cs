using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultPopUp : MonoBehaviour
{
    [SerializeField] GameObject PopupResult;
    [SerializeField] Finish finish;

    private void Start()
    {
        //PopupResult.SetActive(false);

    }

    private void Update()
    {
        if(finish && PopupResult.activeInHierarchy==false)
        {
            PopupResult.SetActive(true);
        }
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

      private void CompleteLevel()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   //  public void Next()
  //  {
  //      SceneManager.LoadScene("Level");
  //  }
}
