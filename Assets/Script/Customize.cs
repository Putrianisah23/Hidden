using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customize : MonoBehaviour
{
    // public GameObject Scrollbar;
    // float scroll_pos = 0;
    // float[]pos;
    public Transform characters;
    public int selectedCharacter;

    // Start is called before the first frame update
    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach(Transform player in characters){
            player.gameObject.SetActive(false);
        }

        characters.GetChild(selectedCharacter).gameObject.SetActive(true);
    }

    public void NextBtn(){
        characters.GetChild(selectedCharacter).gameObject.SetActive(true);
        selectedCharacter++;
        if(selectedCharacter==characters.transform.childCount){
            selectedCharacter = 0;
            characters.GetChild(characters.transform.childCount-1).gameObject.SetActive(false);
        }
        else{
            characters.GetChild(selectedCharacter-1).gameObject.SetActive(false);
        }
        characters.GetChild(selectedCharacter).gameObject.SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }

    public void PreviousBtn(){
        characters.GetChild(selectedCharacter).gameObject.SetActive(true);
        selectedCharacter--;
        if(selectedCharacter==-1){
            selectedCharacter = characters.transform.childCount-1;
            characters.GetChild(0).gameObject.SetActive(false);
        }
        else{
            characters.GetChild(selectedCharacter+1).gameObject.SetActive(false);
        }
        characters.GetChild(selectedCharacter).gameObject.SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     pos = new float[transform.childCount];
    //     float distance = 1f / (pos.Length - 1f);
    //     for (int i = 0; i < pos.Length; i++)
    //         {
    //             pos[i] = distance * i;
    //         }
    //     if (Input.GetMouseButton (0))
    //         {
    //             scroll_pos = Scrollbar.GetComponent<Scrollbar> ().value;
    //         }
    //         else
    //             {
    //                 for (int i = 0; i < pos.Length; i++)
    //                 {
    //                     if(scroll_pos < pos[i] + (distance/2) && scroll_pos > pos[i] - (distance/2))
    //                     {
    //                         Scrollbar.GetComponent<Scrollbar> ().value = Mathf.Lerp (Scrollbar.GetComponent<Scrollbar> ().value, pos[i], 0.1f);
    //                     }
    //                 }
    //             }
    //     for (int i = 0; i < pos.Length; i++)
    //         {
    //             if (scroll_pos < pos[i] + (distance/2) && scroll_pos > pos[i] - (distance/2))
    //             {
    //                 transform.GetChild (i).localScale = Vector2.Lerp (transform.GetChild(i).localScale, new Vector2(1f,1f), 0.1f);
    //                 for (int a = 0; a < pos.Length; a++)
    //                     {
    //                         if (a != i)
    //                         {
    //                             transform.GetChild (a).localScale = Vector2.Lerp (transform.GetChild(a).localScale, new Vector2(0.8f,0.8f), 0.1f);
    //                         }
    //                     }
    //             }
    //         }
    //     Debug.Log("scroll pos berapa = " + scroll_pos.ToString());
    //     SelectBtn((int)scroll_pos);

    // }
}