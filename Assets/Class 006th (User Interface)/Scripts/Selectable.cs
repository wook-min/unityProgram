using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    public void Enter()
    {
        button.GetComponentInChildren<Text>().fontSize = 100;
    }

    public void Exit()
    {
        button.GetComponentInChildren<Text>().fontSize = 75;
    }

    public void Down()
    {
        button.GetComponentInChildren<Text>().fontSize = 50;
    }

    public void Up()
    {
        button.GetComponentInChildren<Text>().fontSize = 100;
    }
}
