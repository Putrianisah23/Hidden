using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public playerHealth pHealth;
    public float damage;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("thePlayer"))
        {
          other.gameObject.GetComponent<playerHealth>().health -= damage;
        }
    }
}

//             Die();
//             //Health.health - -;
//             //if(Health.health <=0)
//         }
//     }

//     private void Die()
//     {
//         //deathSoundEffect.Play();
//         rb.bodyType = RigidbodyType2D.Static;
//         anim.SetTrigger("death");
//     }
//     private void RestartLevel()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//     }
// }
