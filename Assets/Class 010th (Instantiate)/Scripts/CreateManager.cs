using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] private int count;
    [SerializeField] private float time = 5f;

    [SerializeField] private GameObject prefab;
    
    private List<GameObject> list = new();
    private List<int> randomList = new();

    private bool isRunning = true;

    HashSet<int> hash = new();

    private void Start()
    {
        isRunning = true;

        Create();

        StartCoroutine(Coroutine());
    }

    

    private void Update()
    {
        
    }

    IEnumerator Coroutine()
    {
        while (isRunning)
        {
            if (randomList.Count <= 0)
            {
                isRunning = false;
                yield break;
            }

            Debug.Log("Coroutine Start");
            
            yield return new WaitForSeconds(5f);

            int randomIndex = Random.Range(0, randomList.Count);

            int index = randomList[randomIndex];
            
            list[index].SetActive(true);
            randomList.RemoveAt(randomIndex);

            Debug.Log("Coroutine Exit");
        }
       
    }

    void Create()
    {
        if (count > 0)
        {
            int middle = count / 2;
            for (int i = 0; i < count; i++)
            {
                var monster = Instantiate(prefab, transform);
                list.Add(monster);
                monster.transform.position = new Vector3(i * 2 - 2 * middle, 0, 0);
                monster.SetActive(false);

                randomList.Add(i);
            }
        }
    }
}
