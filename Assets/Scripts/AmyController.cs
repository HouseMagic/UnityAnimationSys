using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmyController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 100.0f;
    
    private float inputH;
    private float inputV;
    
    private CharacterController characterCtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        characterCtrl = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // playerMove();
        playerMoveTopDown();
    }

    void playerMove()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        characterCtrl.Move(moveSpeed * Time.deltaTime * transform.forward * inputV);
        transform.Rotate(Vector3.up,rotateSpeed * inputH);
    }

    void playerMoveTopDown()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        var dir = new Vector3(inputH, 0, inputV).normalized;
        characterCtrl.Move(moveSpeed * Time.deltaTime * dir);
        
        // 计算旋转
        var mouseToPlayer = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angel = Mathf.Atan2(mouseToPlayer.x, mouseToPlayer.y) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angel, transform.eulerAngles.z);
    }
    
    
}
