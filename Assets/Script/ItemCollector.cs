using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int koran;
    public string itemType;
    [SerializeField] private Text koranText;
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private Transform player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("thePlayer").transform;
        GameObject koranGO = GameObject.FindGameObjectWithTag("KoranText");
        Text koranText = koranGO.GetComponent<Text>();
        if (collision.gameObject.CompareTag("Koran"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            koran++;
            koranText.text = " " + koran;
            
        }
    } 
}