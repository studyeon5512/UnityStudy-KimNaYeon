using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        //getComponent<{type}>;
        rigid = GetComponent<Rigidbody>(); //초기화 완료
        //rigid.velocity = Vector3.right; 현재 이동 속도
        //rigid.velocity = new Vector3(2, 4, 3);
        //rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
