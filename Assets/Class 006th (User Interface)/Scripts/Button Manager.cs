using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button[] buttonList;
    [SerializeField] private string[] textList = { "Execute", "Option", "Quit"};

    private void Start()
    {
        Action[] actions = { Execute, Option, Quit };

        for (int i = 0; i < buttonList.Length; i++)
        {
            // closuer(클로저) 기능 때문에 i로만 인덱스를 처리하면 3까지 증가됨
            int index = i;

            // 람다 문법
            buttonList[i].onClick.AddListener(() => actions[index]());

            buttonList[i].GetComponentInChildren<Text>().text = textList[index];
        }

        

    }

    public void Execute()
    {
        Debug.Log("Play Start");
    }

    public void Option()
    {
        Debug.Log("Open Option");
    }

    public void Quit()
    {
        Debug.Log("Quit Game");
    }
}
