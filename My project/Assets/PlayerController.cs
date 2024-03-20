using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;          // �÷��̾ �̵���Ű�� ���� RigidBody
    public int moveSpeed = 10;        // �÷��̾��� �̵��ӵ�

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();          // rb�� ������Ʈ �ȿ� �ִ� rigidBody�� �־���
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
