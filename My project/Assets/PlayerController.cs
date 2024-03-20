using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;          // 플레이어를 이동시키기 위한 RigidBody
    public int moveSpeed = 10;        // 플레이어의 이동속도

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();          // rb에 오브젝트 안에 있는 rigidBody를 넣어줌
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerMove01();
        PlayerMove02();
    }

    public void PlayerMove01()
    {
        Vector3 moveInput = new Vector3(0,0,0);

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
        transform.position += moveInput * moveSpeed * Time.deltaTime;
    }


    public void PlayerMove02()
    {
        Vector3 moveInput = new Vector3(0,0,0);

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
    }
}
