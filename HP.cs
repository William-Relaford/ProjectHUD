using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{

    public int health = 10;
    public Text healthText;
    public Slider healthBar;
    

    void Start()
    {
        health--;
        healthText.GetComponent<Text>().text =
            "Health" + health;
        healthBar.GetComponent<Slider>().value = health;
    }

    void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "enemy")
        {
            healthText.GetComponent<Text>().text =
              "Health" + health;
            healthBar.GetComponent<Slider>().value = health;
            health--;
            if (health <= 0)
                SceneManager.LoadScene("LoseScreen");

                
                
        
        }

        if (collision.gameObject.tag == "heal")
        {
            health += 5;
            Destroy(collision.gameObject);
        }
        
    }


}