using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.tag != "Fireball") {
            if(SceneManager.GetActiveScene().name == "Level1") {
                SceneManager.LoadScene("Level2");
            } else {
                SceneManager.LoadScene("YouWon");
            }
         }
    }
}
