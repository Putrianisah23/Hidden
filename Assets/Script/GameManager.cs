using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    public GameObject gameOverUI;
    public GameObject popUpUI;
    [SerializeField] public GameObject[] playerPrefabs;
    int characterIndex;
 
    public void Start(){
        Time.timeScale = 1;
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        string activeSceneName = SceneManager.GetActiveScene().name;
        
        if(activeSceneName=="Level 1"){
            Vector2 position = new Vector2(618f, 310f);
            Instantiate(playerPrefabs[characterIndex], position, Quaternion.identity);
        }
        else if(activeSceneName=="Level 2"){
            Vector2 position = new Vector2(632f, 310f);
            Debug.Log("characterIndex = " + characterIndex);
            Instantiate(playerPrefabs[characterIndex], position, Quaternion.identity);
        }
        else if(activeSceneName=="Level 3"){
            Vector2 position = new Vector2(628f, 315f);
            Instantiate(playerPrefabs[characterIndex], position, Quaternion.identity);
        }

    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void popUp()
    {
        popUpUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
