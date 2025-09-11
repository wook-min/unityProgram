using UnityEngine;

public class Character : MonoBehaviour
{
    // SRP 단일 책임 원칙
    public Ability ability;

    private void Awake()
    {
        ability = new Ability();
        ability.Init(10, 10, 10, 10);
    }

    private void Start()
    {
        Debug.Log("STR : " + ability.Strength);
        Debug.Log("DEX : " + ability.Dexterity);
        Debug.Log("INT : " + ability.Intelligence);
        Debug.Log("WIS : " + ability.Wisdom);
    }
}
