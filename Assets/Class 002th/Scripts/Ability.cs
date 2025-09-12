using UnityEngine;

[System.Serializable]
public class Ability
{
    [SerializeField] private int strength;
    public int Strength => strength;
    [SerializeField] private int dexterity;
    public int Dexterity => dexterity;
    [SerializeField] private int intelligence;
    public int Intelligence => intelligence;
    [SerializeField] private int wisdom;
    public int Wisdom => wisdom;

}
