using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetting : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Exit()
    {
        Application.Quit();
    }

    //tombol play
    public void PlayGame(string Level1) 
    {
        SceneManager.LoadScene(Level1);
        Debug.Log("Ini Scene Level 1 Aktif" + Level1);
    }

    public void PlayLevel2(string Level2)
    {
        SceneManager.LoadScene(Level2);
        Debug.Log("Ini Scene Level 2 Aktif" + Level2);
    }

    public void PlayLevel3(string Level3) 
    {
        SceneManager.LoadScene(Level3);
        Debug.Log("Ini Scene Level 3 Aktif" + Level3);
    }
    
    List<int> widths = new List<int>() {440, 550, 570};
    List<int> heights = new List<int>() {640, 960, 720};
    
    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen); 
    }
    public void SetFullScreen (bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }
}