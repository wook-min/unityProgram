using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Mouse : MonoBehaviour
{
    [SerializeField] private Ray ray;
    [SerializeField] private RaycastHit rayCastHit;
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private float distance;
    [SerializeField] private Texture2D texture2D;
    

    [SerializeField] Encampment encampment;

    [SerializeField] Menual menual;

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

            Debug.DrawRay(ray.origin, ray.direction * distance, Color.green, layerMask);

            if (Physics.Raycast(ray, out rayCastHit, 100, layerMask))
            {
                // Debug.Log(rayCastHit.collider.name);

                Debug.DrawLine(ray.origin, rayCastHit.point, Color.red);

                var go = rayCastHit.collider.transform.GetChild(0).gameObject;

                if (go.activeSelf == true)
                {
                    go.SetActive(false);
                }
                else
                {
                    go.SetActive(true);
                }

                if(rayCastHit.collider.TryGetComponent(out encampment))
                {
                    menual.Bind(encampment.Title, encampment.Description);
                }
            }
        }
    }
}
