using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    void Update()
    {
        /*if (Input.anyKeyDown)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }
        if(Input.anyKey)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("�������� �����Ͽ����ϴ�.");
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵� ��");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ���߾����ϴ�.");
        }
        if(Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������ ��...");
        }
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("�̻��� �߻�");
        }
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("���� �̻��� �߻�");
        }
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("����");
        }
        if(Input.GetButton("Jump"))
        {
            Debug.Log("���� ������ ��...");
        }
        if(Input.GetButtonUp("Jump"))
        {
            Debug.Log("���� ����!!");
        }
        if(Input.GetButtonDown("SuperFire"))
        {
            Debug.Log("�ʻ��!");
        }*/
        if(Input.GetButton("Horizontal"))
        {
            //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
            //GetAxis�� float Ÿ�� ��ȯ
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));//(����ġ ���� ����, �����ʸ� �ϰ���� ��)
        }
        if(Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
    }
}
