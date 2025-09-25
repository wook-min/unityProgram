using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] private int count;
    [SerializeField] private float time = 5f;

    [SerializeField] private GameObject prefab;
    
    private List<GameObject> clones = new();
    private float timeCheck;
    private float[] eachTimer = { 0, 0, 0, 0, 0 };
    private int activeCount = 0;

    private void Start()
    {
        timeCheck = 0f;

        if (count > 0)
        {
            int middle = count / 2;
            for (int i = 0; i < count; i++)
            {
                var monster = Instantiate(prefab, transform);
                clones.Add(monster);
                monster.transform.position = new Vector3(i * 2 - 2 * middle, 0, 0);
                monster.SetActive(false);
            }
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= 5.0f)
        {
            Debug.Log("Event Start");
            time = 0.0f;
        }
    }

    void Spawn()
    {
        timeCheck += Time.deltaTime;

        for (int i = 0; i < eachTimer.Length; i++)
        {
            if (clones[i].activeSelf == true)
            {
                eachTimer[i] += Time.deltaTime;
            }

            if (eachTimer[i] >= 4 * time)
            {
                clones[i].SetActive(false);
                Debug.Log($"Monster {i} is ");
                eachTimer[i] = 0f;
            }
        }

        if (timeCheck >= time)
        {
            clones[activeCount].SetActive(true);
            Debug.Log($"Monster {activeCount} is Active");
            timeCheck = 0f;
            activeCount = (activeCount + 1) % count;
        }
    }
}
