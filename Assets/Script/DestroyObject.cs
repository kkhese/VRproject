using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DestroyObject : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip clipx;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            Destroy(collision.gameObject);
            source.PlayOneShot(clip);
        }
        else if (collision.gameObject.CompareTag("Bblock"))
        {
            Destroy(collision.gameObject);
            source.PlayOneShot(clipx);
        }
        else if (collision.gameObject.CompareTag("menu"))
        {
            source.PlayOneShot(clip2);
        }
    }
}