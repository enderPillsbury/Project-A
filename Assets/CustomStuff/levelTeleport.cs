using UnityEngine;

public class levelTeleport : MonoBehaviour
{
    public GameObject triggerObject;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entered");
        if (collider.gameObject == triggerObject)
        {
            triggerObject.transform.position = new Vector3(-150, 1, -66);
        }
    }
}
