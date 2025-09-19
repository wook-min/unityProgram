using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    // [SerializeField] Text titleText;
    private Text text;
    // 캐싱 기법 : 참조 변수로 저장해두고 그 변수로 사용하는 것.(계속 탐색할 때마다 최소 O(n)이 걸리므로)

    private void Awake()
    {
        text = GetComponentInChildren<Text>();
    }

    public void Enter()
    {
        text.fontSize = 100;
    }

    public void Exit()
    {
        text.fontSize = 75;
    }

    public void Down()
    {
        text.fontSize = 50;
    }

    public void Up()
    {
        text.fontSize = 100;
    }
}
