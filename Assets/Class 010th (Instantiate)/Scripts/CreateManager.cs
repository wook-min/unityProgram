using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateManager : MonoBehaviour
{
    // 중복 없는 랜덤값 뽑기 방식
    // 1. List + Swap(뽑은 값을 마지막 값과 스왑)
    // 탐색에서 최고 효율 List(O(1))의 유일한 단점인 앞의 인덱스 삭제시
    // 뒤의 배열 모두를 덮어쓰는 (O(n))과정을 뽑은 값을 맨 뒤로 보내어 해결하는 방법

    // 2. Queue 활용
    // Queue 초기화 시 랜덤하게 값을 섞어넣고, 그 다음 하나씩 뽑아 쓰는 방식


    [SerializeField] private int count;
    [SerializeField] private float time = 5f;

    [SerializeField] private GameObject prefab;
    [SerializeField] private List<Vector3> randomPosition;
    
    private List<GameObject> list = new();
    private List<int> randomList = new();

    private bool isRunning = true;
    private int coroutineCount = 0;


    private void Start()
    {
        coroutineCount = 0;
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

            var randomIndex = Random.Range(0, randomList.Count);
            Swap<int>(randomList, randomIndex, randomList.Count - 1);
            int index = randomList[randomList.Count - 1];
            
            list[index].SetActive(true);
            randomList.RemoveAt(randomList.Count - 1);

            Debug.Log("Coroutine Exit");
        }
       
    }

    IEnumerator Coroutine(bool check)
    {
        while (coroutineCount < list.Count)
        {
            yield return new WaitForSeconds(5f);

            int index = Random.Range(0, list.Count);
            while (true)
            {
                if (list[index].activeSelf == true)
                {
                    index = (index + 1) % count;
                }
                else
                {
                    break;
                }
            }
            list[index].SetActive(true);
            coroutineCount++;
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

    void Swap<T>(List<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

    // list[index].transform.localPosition = randomPosition[index];
}
