using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    public AudioSource clockSound;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.z -= 0.1f;

        transform.eulerAngles = rotation;

        if (rotation.z == 90)
        {
            if (clockSound.isPlaying == false)
            {
                clockSound.PlayOneShot(clip);
                
            }

        }
    }
}
