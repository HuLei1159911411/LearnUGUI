using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ModelCameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 dir;

    private void Start()
    {
        dir = transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.position + dir;
    }
}
