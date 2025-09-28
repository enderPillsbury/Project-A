using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
public class UIHandler : MonoBehaviour
{

    public static UIHandler instance { get; private set; }
    private ProgressBar player_Health;
    private IntegerField player_Money;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIDocument uIDocument = GetComponent<UIDocument>();

        player_Health = uIDocument.rootVisualElement.Q<ProgressBar>("HP");
        player_Money = uIDocument.rootVisualElement.Q<IntegerField>("Money");
        SetMoneyValue(0);

    }

    public void SetHealthValue(float current)
    {
        player_Health.value = current;
    }

    public void SetMoneyValue(int current)
    {
        player_Money.value = current;
    }

}
