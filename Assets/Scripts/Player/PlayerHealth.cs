using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    private static PlayerHealth instance;
    public int maxHealth = 250;
    public int currentHealth;
    //public Gethealth charHealth;
    public HealthBar healthBar;
    //public GameObject floatingTextPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }
    

    private void Awake() {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
     
    // private void Update() {
    //     BoxCollider2D childCollider = GetComponentInChildren<BoxCollider2D>();
    //     BoxCollider2D parentCollider = GetComponent<BoxCollider2D>();
    //     parentCollider.size = childCollider.size;
    //     parentCollider.offset = childCollider.offset;
    // }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <=0)
        {
            SceneManager.LoadScene("GameOver");
            currentHealth = maxHealth;
            
        }

        healthBar.SetHealth(currentHealth);
    }

    public void Heal(int heal)
    {
        // ShowHeal(heal.ToString());
        currentHealth += heal;
        if(currentHealth >= maxHealth)
        {
            maxHealth = currentHealth;
        }
        healthBar.SetHealth(currentHealth);
    }

    // void ShowHeal(string text)
    // {
    //     if(floatingTextPrefab)
    //     {
    //         GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
    //         prefab.GetComponent<TextMeshProUGUI>().text = text;
    //     }
    // }
}
