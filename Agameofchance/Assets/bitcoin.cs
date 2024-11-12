using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;

public class bitcoin : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource audioData;
    //var collectSound : AudioClip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioData = GetComponent<AudioSource>();

    }
    private void Awake()
    {
        
        //.mass = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)


    {
        //var collectSound = new AudioClip();

        //AudioSource.PlayClipAtPoint(collectSound, transform.position);

        Object.Destroy(this.gameObject);
    }
}
