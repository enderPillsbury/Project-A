using UnityEngine;

public class levelTeleport : MonoBehaviour
{
    public GameObject triggerObject;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == triggerObject)
        {
            triggerObject.transform.position = new Vector3(-150, 1, -66);
        }
    }
}
