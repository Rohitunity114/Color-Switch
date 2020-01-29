using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public string ColorMatch;
    
    public float MoveSpeed = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sp;

    public Color Sky;
    public Color Yellow;
    public Color Blue;
    public Color Pink;
    void Start()
    {
        SwitchColor();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.up * MoveSpeed;
        }       
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag != ColorMatch)
        {
            Debug.Log("Game Over");
        }    
        if(coll.tag == "ColorChanger")
        {
            SwitchColor();
            Destroy(coll.gameObject);
            return;           
        }
        if(coll.tag == "Win")
        {
            Debug.Log("Game Win!!");
            Destroy(coll.gameObject);
            Destroy(gameObject);
            return;
        }
    }
   
    private void SwitchColor()
    {
        float Number = Random.Range(0, 4);

        switch(Number)
        {
            case 0:
                {
                    ColorMatch = "Sky";
                    sp.color = Sky;
                    break;
                }
            case 1:
                {
                    ColorMatch = "Yellow";
                    sp.color = Yellow;
                    break;
                }
            case 2:
                {
                    ColorMatch = "Blue";
                    sp.color = Blue;
                    break;
                }
            case 3:
                {
                    ColorMatch = "Pink";
                    sp.color = Pink;
                    break;
                }
        }
    }

}
