using Unity.Android.Gradle;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private Item[] items;

    int count = 0;

    private void Start()
    {
        Init();
        count = items.Length - 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (items[count].gameObject.activeSelf)
            {
                items[count].Activate();
            }
        }
    }

    private void Init()
    {
        foreach (Item element in items)
        {
            element.gameObject.SetActive(false);
        }
    }

    private void ChangeWeapon()
    {
        items[count].gameObject.SetActive(false);
        count = (count + 1) % items.Length;
        items[count].gameObject.SetActive(true);
    }

}
