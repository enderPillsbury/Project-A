using UnityEngine;
using UnityEngine.Events;

public class Respawn : MonoBehaviour
{
    public GameObject triggerObject;

    private void OnTriggerStay(Collider collider)
    {
        Debug.Log("Entered");
        if (collider.gameObject == triggerObject)
        {
            triggerObject.transform.position = new Vector3(-3, 1, 41);
        }
    }
}
