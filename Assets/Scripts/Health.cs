using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float currentHealth;
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {


        if (currentHealth > 1)
        {
            currentHealth = currentHealth - 1;
            Debug.Log(currentHealth);
        }
        else
        {

            if (!dead)
            {
                if(gameObject.tag == "Enemy" && collision.gameObject.tag == "Fireball" ) {
                    if(gameObject != null) {    
                    // Do something  
                    Destroy(gameObject);
                    }
                } else if(gameObject.tag == "Player") {
                    SceneManager.LoadScene("GameOverScreen");
                }

            }
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}