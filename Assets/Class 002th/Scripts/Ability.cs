using UnityEngine;

public class Ability
{
    private int strength;
    public int Strength => strength;
    private int dexterity;
    public int Dexterity => dexterity;

    private int intelligence;
    public int Intelligence => intelligence;

    private int wisdom;
    public int Wisdom => wisdom;


    public void Init(int str, int dex, int Int, int wis)
    {
        strength = str;
        dexterity = dex;
        intelligence = Int;
        wisdom = wis;
    }

}
