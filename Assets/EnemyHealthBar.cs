using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject enemy;
    public Slider HealthBarContainer; 
    public Vector3 Offset; 
    public float maxHealth = 50;

    void Start()
    {
        HealthBarContainer.maxValue = maxHealth;
    }

    void FixedUpdate (){
        HealthBarContainer.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
        HealthBarContainer.value =  enemy.GetComponent<EnemyHealth>().currentHealth;
    }
    
    // public void SetHealth(float currentHealth, float maxHealth)
    // {
    //     Slider.value = currentHealth;
    //     Slider.maxValue = maxHealth;

    //     Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    // }

    // void Update()
    // {
        
    //     Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    // }
}