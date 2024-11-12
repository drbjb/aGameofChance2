using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class finale : MonoBehaviour
{
    public AudioSource noiz;
    public SpriteRenderer text;
    public SpriteRenderer text2;
    private int win = Random.Range(-1, 1);
    // Start is called before the first frame update
    void Start()
    {
        noiz = GetComponent<AudioSource>();
        //text = GetComponent<SpriteRenderer>();
        
    }

    private void Awake()
    {
        print(win);
        text = GetComponentInChildren<SpriteRenderer>();
        text2 = GetComponentInChildren<SpriteRenderer>();
        text.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!noiz.isPlaying)
        {
            if (win > 0){
                text.enabled = true;
                print("HIIIIIjefheiyfueiuf");
            }
            else
            {
                text2.enabled = true;
                print("HIIIIIjefheiyfueiuf");
            }


        }
    }
}
