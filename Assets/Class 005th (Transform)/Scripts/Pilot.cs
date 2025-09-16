using UnityEngine;

public class Pilot : MonoBehaviour
{
    // ws >> z축으로 1칸 이동
    // ad >> x축으로 1칸 이동

    private void Start()
    {
        // Debug.Log($"Location : {transform.position}");
        // transform.position = new Vector3(1, 1, 1);
    }

    private void Update()
    {
        move();
    }

    private void move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}
