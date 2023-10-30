using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    
    private GameObject bulletPrefab;

    private Vector3 nowMoveDir;

    private void Update()
    {
        if (nowMoveDir != Vector3.zero)
        {
            // 移动
            transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward);
            // 旋转
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(nowMoveDir),
                rotateSpeed * Time.deltaTime);
        }
    }

    public void Fire()
    {
        if (bulletPrefab == null)
            bulletPrefab = Resources.Load<GameObject>("BulletPrefab");
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    public void ChangeMoveDir(Vector2 dir)
    {
        nowMoveDir.z = dir.y;
        nowMoveDir.x = dir.x;
        nowMoveDir.y = 0;
    }
}
