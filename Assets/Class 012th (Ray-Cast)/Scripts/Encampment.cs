using UnityEngine;

public abstract class Encampment : MonoBehaviour
{
    [SerializeField] protected string title;
    public string Title => title;

    [SerializeField] protected string description;
    public string Description => description;
    // public string Descripton {get {return description;}}


    public abstract void Describe();

    protected void Start()
    {
        Describe();
    }
}
