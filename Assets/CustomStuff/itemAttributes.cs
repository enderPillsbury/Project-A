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
        healthManager controller = other.GetComponent<healthManager>();

        if (controller != null)
        {
            controller.ChangeHealth(healthAmount);
            controller.ChangeMoney(moneyAmount);
            controller.ChangeGems(gemAmount);
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
