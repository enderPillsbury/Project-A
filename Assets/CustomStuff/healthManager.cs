using System.Xml.Serialization;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    public int maxHealth = 5;

    public int currentMoney = 0;

    public int currentGems = 0;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

    public void ChangeMoney(int amount)
    {

    }

    public void ChangeGems(int amount)
    {
        
    }

}
