using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPointsIcon : MonoBehaviour
{
    [Header("HpIcon")]
    [Tooltip("The icon to show")]
    public List<GameObject> UiHealthIcons;
    public List<GameObject> UiLivesIcons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RefreshHealthPointsIcon();
        RefreshLivesPointsIcon();
    }

    private void RefreshHealthPointsIcon()
    {
        for(int i = 0; i < gameObject.GetComponent<Health>().currentHealth; i++)
        {
            if(gameObject.GetComponent<Health>().currentHealth < gameObject.GetComponent<Health>().defaultHealth)
            {
                UiHealthIcons[gameObject.GetComponent<Health>().currentHealth].SetActive(false);
            }
            UiHealthIcons[i].SetActive(true);
        }
    }
    private void RefreshLivesPointsIcon()
    {
        for(int i = 0; i < gameObject.GetComponent<Health>().currentLives; i++)
        {
            if(gameObject.GetComponent<Health>().currentLives < gameObject.GetComponent<Health>().maximumLives)
            {
                UiLivesIcons[gameObject.GetComponent<Health>().currentLives].SetActive(false);
            }
            UiLivesIcons[i].SetActive(true);
        }
    }
}
