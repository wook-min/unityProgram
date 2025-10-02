using UnityEditor;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private Ray ray;
    [SerializeField] private RaycastHit rayCastHit;
    [SerializeField] private float distance;
    [SerializeField] private Texture2D texture2D;
    private void Awake()
    {
        distance = Mathf.Infinity;
        Cursor.SetCursor(texture2D, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스로 찍은 포지션 값을 넣으면, 공간을 변형해서 3차원 hit로 바꿔줌
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);

            if (Physics.Raycast(ray, out rayCastHit, 100))
            {
                Debug.Log(rayCastHit.collider.name);

                Debug.DrawLine(ray.origin, rayCastHit.point, Color.red);
            }
        }
    }
}
