using NUnit.Framework.Constraints;
using NUnit.Framework.Internal.Execution;
using UnityEngine;
using UnityEngine.UI;

public class Menual : MonoBehaviour
{
    [SerializeField] Text titleText;
    [SerializeField] Text descriptionText;

    private void OnEnable()
    {
        titleText.text = "None";
        descriptionText.text = "Empty";
    }

    public void Bind(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}
