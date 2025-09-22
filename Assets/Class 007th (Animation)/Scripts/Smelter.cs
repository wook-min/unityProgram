using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] private float progress;
    [SerializeField] int count;

    public void Create()
    {
        Debug.Log("Create...");
    }

    // 한번에 입력한 제작 진행률만큼 진행하는 함수
    public void Process(float progress)
    {
        this.progress += progress;
        Debug.Log($"Progress : {this.progress}%");
        if (this.progress >= 100f)
        {
            Debug.Log("Smelt Complete");
        }

        this.progress = this.progress % 100f;
    }

    // 입력한 count 만틈 아이템 강화 시도를 함.
    public void Enhance(int count)
    {
        this.count += count;

        Debug.Log($"Enhance count : {this.count}");
    }
}
