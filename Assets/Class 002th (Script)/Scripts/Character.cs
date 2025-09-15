using UnityEngine;

public class Character : MonoBehaviour
{
    // SRP 단일 책임 원칙
    [SerializeField] private Ability ability;

    private void Start()
    {
        Debug.Log("STR : " + ability.Strength);
        Debug.Log("DEX : " + ability.Dexterity);
        Debug.Log("INT : " + ability.Intelligence);
        Debug.Log("WIS : " + ability.Wisdom);
    }
}
