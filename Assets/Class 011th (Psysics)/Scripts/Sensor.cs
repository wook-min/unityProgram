using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"TriggerEnter {other.gameObject.name}");
        if(other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"Trigger Stay {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"Trigger Exit {other.gameObject.name}");
        if(other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Revert();
        }
    }

    // 트리거 이벤트 함수
    // 1. OnTriggerEnter() : 충돌을 했을 때 한번만 호출
    // 2. OnTriggerStay() : 충돌 중 계속해서 호출(프레임마다)
    // 3. OnTeriggerExit() : 충돌이 끝났을 때만 호출
}
