using StarterAssets;
using UnityEditor;
using UnityEngine;

public class itemAttributes : MonoBehaviour
{
    public int healthAmount;
    public int moneyAmount;
    public int gemAmount;
    void OnTriggerEnter(Collider other) 
    {
        healthManager controller = other.GetComponent<healthManager>(); //Ensures that only the player can trigger the effects

        if (controller != null)
        {
            controller.ChangeHealth(healthAmount);
            controller.ChangeMoney(moneyAmount);
            controller.ChangeGems(gemAmount);
            Destroy(gameObject);
        }
    }
    
}
