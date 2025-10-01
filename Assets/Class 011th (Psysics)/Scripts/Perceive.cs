using UnityEngine;

public class Perceive : MonoBehaviour
{
    // 물리 충돌 감지
    // 1. OnCollisionEnter
    // 2. OnCollisionStay
    // 3. OnCollisionExit

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision Enter {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"Collision Stay {collision.gameObject.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"Collision Exit {collision.gameObject.name}");
    }
}
