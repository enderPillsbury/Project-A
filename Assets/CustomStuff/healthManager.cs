using System.Xml.Serialization;
using UnityEngine;

public class healthManager : MonoBehaviour
{   
    public int maxHealth = 10;

    public int currentMoney = 0;

    public int currentGems = 0;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)        //Health and Money Display codes altered from Unity's 2D Game Tutorial
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        UIHandler.instance.SetHealthValue(currentHealth);
    }

    public void ChangeMoney(int amount)
    {
        currentMoney += amount;
        UIHandler.instance.SetMoneyValue(currentMoney);
    }

    public void ChangeGems(int amount)
    {
        currentGems += amount;
        
    }
    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

}
