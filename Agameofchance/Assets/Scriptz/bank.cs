using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bank : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bitcoin;
    bool meow = true;
    public Transform t;
    private int x = 0;
    private int y = 0;
    public float tTime = 5.0f;

    void Start()
    {

        Instantiate(bitcoin);
    }

    private void Awake()
    {
        Instantiate(bitcoin);
    }

    // Update is called once per frame
    void Update()
    {
        tTime -= Time.deltaTime;
        if (tTime <= 0)
        {
            for(int i = 0; i < 10; i++)
            {
                var position = new Vector3(UnityEngine.Random.Range(-10.0f, 10.0f), 0, UnityEngine.Random.Range(-10.0f, 10.0f));
                Instantiate(bitcoin, position, quaternion.identity);
            }
            
            meow = false;
            tTime = 5f;
        }
        

        
    }
}
