
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class dumbPlayerCtrl : MonoBehaviour
{
    public float movSpeed2;
    float speedX2, speedY2;
    Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()

    {
        //UIText = HpText.GetComponent<Text>();
        rb2 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        speedX2 = Input.GetAxisRaw("Horizontal") * movSpeed2;
        speedY2 = Input.GetAxisRaw("Vertical") * movSpeed2;
        

    }
    void FixedUpdate()
    {
        rb2.velocity = new Vector2(speedX2, speedY2);
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "coin")
        {
            print("AAAAA");
            //transform.GetChild(0).GetChild(0).GetComponent<TheComponent>().theVariable = theValue;
            cash += 5;
            //UIText.text = cash.ToString();
        }

    }

    */
}
