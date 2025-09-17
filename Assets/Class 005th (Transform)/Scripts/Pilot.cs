using UnityEngine;

public class Pilot : MonoBehaviour
{
    // P = P0 + vt
    // 다음위치 = 현재위치 + 방향 X 시간

    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;


    private void Start()
    {
        // Debug.Log($"Location : {transform.position}");
        // transform.position = new Vector3(1, 1, 1);
    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // GetAxis : Smooth Filtering 존재
        // GetAxisRaw : Smooth Filtering 없음(입력이 멈추면 즉시 값이 0으로)

        direction.Normalize();

        // Time.deltaTime
        // 이전 프레임이 완료되는 시점부터 현재 프레임이 시작되기까지
        // 지난 시간을 반환하는 값입니다.

        transform.position = transform.position + direction * Time.deltaTime * speed;


    }

    private void move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        
    }
}
