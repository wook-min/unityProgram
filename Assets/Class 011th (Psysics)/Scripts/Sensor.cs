using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float addForce;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"TriggerEnter At {gameObject.name}");
        if(other.TryGetComponent<Rigidbody>(out var RB))
        {
            RB.AddForce(direction * addForce, ForceMode.Impulse);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"Trigger Stay At {gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"Trigger Exit At {gameObject.name}");
    }

    // 트리거 이벤트 함수
    // 1. OnTriggerEnter() : 충돌을 했을 때 한번만 호출
    // 2. OnTriggerStay() : 충돌 중 계속해서 호출(프레임마다)
    // 3. OnTeriggerExit() : 충돌이 끝났을 때만 호출
}
