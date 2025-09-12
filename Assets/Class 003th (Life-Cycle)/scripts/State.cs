using UnityEngine;

public class State : MonoBehaviour
{
    // Life Cycle (Unity에서)

    // 초기화 영역
    // 물리 영역
    // 업데이트 영역
    // 해제 영역

    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되며, 객체가 비활성화 되어있을 때에도
        //         호출되고, 단 한 번만 호출되는 이벤트 함수입니다.
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable : 객체가 활성화되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start : 객체가 생성되었을 때 호출되며, 단 한 번만 호출되는 이벤트 함수입니다.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate : timestep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.
        Debug.Log("FixedUpdate");
        // 물리 충돌 같은 정교한 판정 같은 경우에 고정된 frame이 필요하기 때문에 fixedUpdate 사용
        // 일반적으로 timestep : 0.02
    }

    private void Update()
    {
        // Update : 객체가 활성화되는 동안, 매 프레임마다 호출되는 이벤트 함수입니다.
        Debug.Log("Update");
        // Input System 등 즉각적으로 입력받아 처리할 때 Update 사용
    }

    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다.
        Debug.Log("Late Update");
        // 객체를 따라다니는 카메라 연출 시 사용
    }

    private void OnDisable()
    {
        // OnDisable : 객체가 비활성화되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy : 객체가 삭제되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnDestroy");
    }
}
