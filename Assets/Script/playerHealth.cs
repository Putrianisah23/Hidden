using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    private bool isDead;
    public GameManager gameManager;
    // public GameObject dead;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar = GameObject.FindGameObjectWithTag("Player").GetComponent<Image>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <=0 && !isDead)
        
        {
          isDead = true;
          gameManager.gameOver();
          Debug.Log("Dead");
        }
    }
}
