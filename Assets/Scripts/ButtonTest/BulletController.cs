using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
        AudioSource audio;
        if (TryGetComponent<AudioSource>(out audio))
        {
            ToggleTest.Instance.PlayAudio(audio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(10 * Time.deltaTime * Vector3.forward);
    }
}
