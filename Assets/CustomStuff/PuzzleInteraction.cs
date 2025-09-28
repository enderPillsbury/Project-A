using UnityEngine;
using UnityEngine.Events;
public class PuzzleInteraction : MonoBehaviour
{
    public UnityEvent puzzleAdjust;
    public GameObject triggerObject;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == triggerObject)
        {
            Debug.Log("Puzzle Triggered!");
            puzzleAdjust.Invoke();
        }
    }
}
