using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    [SerializeField] private Image healthBar;
    string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        Debug.Log(currentScene);
        
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(healthBar.fillAmount == 0) {
             gameObject.SetActive(true);
        }
    }

    public void restartLevel() {
        SceneManager.LoadScene("Level1");
    }
}
