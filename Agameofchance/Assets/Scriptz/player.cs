
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCtrl : MonoBehaviour
{
    //public GameObject HpText;
    //private Text UIText;
    
    public int cash = 0;
    public float movSpeed;
    public Text teller;
    float speedX, speedY;

    Rigidbody2D rb;
    
    //bool cutscene = false;
    // Start is called before the first frame update
    void Start()

    {
        //UIText = HpText.GetComponent<Text>();
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedX, speedY);
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
        }
        
        if (speedX > 0)
        {
            gameObject.transform.localScale = new Vector3((float).4601, (float)0.5378, 1);
        }
        if (speedX < 0)
        {
            gameObject.transform.localScale = new Vector3((float)-.4601, (float)0.5378, 1);
        }
        
        if (cash > 15)
        {
            Object.Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
        



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "coin")
        {
            print("AAAAA");
            
            //transform.GetChild(0).GetChild(0).GetComponent<TheComponent>().theVariable = theValue;
            cash += 5;
            teller.text = "btc: " + cash.ToString();
            //UIText.text = cash.ToString();
        }
      
    }
}
