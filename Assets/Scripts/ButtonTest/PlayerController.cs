using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject bulletPrefab;
    public void Fire()
    {
        if (bulletPrefab == null)
            bulletPrefab = Resources.Load<GameObject>("BulletPrefab");
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }   
}
