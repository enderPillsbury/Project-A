using UnityEngine;
using UnityEngine.Events;
public class GameMenu : MonoBehaviour
{
    public UnityEvent menuOpen;
    public GameObject triggerObject;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == triggerObject)
        {
            Debug.Log("Triggered!");
            menuOpen.Invoke();
        }
    }

}
