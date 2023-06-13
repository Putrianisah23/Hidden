using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int koin = 0;
    [SerializeField] private Text koinText;
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private Transform player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("thePlayer").transform;
        GameObject koinGO = GameObject.FindGameObjectWithTag("KoinText");
        Text koinText = koinGO.GetComponent<Text>();

        if (collision.gameObject.CompareTag("Koin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            koin++;
            koinText.text = " " + koin; 
        }
    }
}