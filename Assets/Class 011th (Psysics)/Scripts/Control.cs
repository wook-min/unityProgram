using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Control : MonoBehaviour
{
    // rigidBody를 이용한 이동
    // 1. AddForce(방향, 힘의 방식)
    // ForceMode(힘의 방식)
    // 1) Force : 지속적인 힘, 질량이 적용(mass)
    // ex) 차량 이동
    // 2) Acceleration : 지속적인 가속도 (질량 적용 x)
    // ex) 마법이나 중력같이 지속적인 움직임
    // 3) Impulse : 순각적인 힘(충격량), 질량 적용 o
    // ex) 대포나 캐릭터 점프 
    // 4) VelocityChange : 순각적인 속도 (무게 x)
    // ex) 대쉬, 텔레포트

    // 물리적인 이동은 FixedUpdate에서 처리하기.(0.02초 고정)

    private Rigidbody RB;
    private Vector3 direction;
    [SerializeField] private float addForce = 5f;
    [SerializeField] private float changeForce = 0.7f;
    [SerializeField] ForceMode forceMode;
    private bool trigger = false;

    [SerializeField] Vector3 soarDir;
    [SerializeField] float soarForce;

    private void Awake()
    {
        forceMode = ForceMode.Acceleration;
        RB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        control(true);
    }

    private void FixedUpdate()
    {
        RB.AddForce(direction * addForce, forceMode);

        //if (trigger)
        //{
        //    Soar();
        //}
    }

    private void control()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
        }

        direction = direction.normalized;
    }

    private void control(bool t)
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    #region 한번만 실행
    public void Soar()
    {
        RB.AddForce(soarDir * soarForce, ForceMode.Impulse);
        trigger = false;
    }
    public void TriggerOn()
    {
        trigger = true;
    }
    #endregion

    public void Soar(bool t)
    {
        direction = Vector3.up;
        forceMode = ForceMode.Impulse;
        addForce = changeForce;
    }

    public void Revert()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
        forceMode = ForceMode.Acceleration;
        addForce = 5f;
    }
}
