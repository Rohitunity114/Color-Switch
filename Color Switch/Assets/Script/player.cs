using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public ScanFeder feder;
    public string ColorMatch;
    public GameObject winEffect;
    public GameObject winEffect2;
    public GameObject gameOverScreen;
    public Text scoreText;
   

    public float MoveSpeed = 10f;
    public int Score;
    

    public Rigidbody2D rb;
    public SpriteRenderer sp;

    public Color Sky;
    public Color Yellow;
    public Color Blue;
    public Color Pink;
    void Start()
    {        
        SwitchColor();
        Score = 0;
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
        if (coll.tag == "ColorChanger")
        {
            SwitchColor();
            Score += 10;
            scoreText.text = Score.ToString();
            Destroy(coll.gameObject);
            return;
        }
        if (coll.tag == "Win")
        {
            Debug.Log("Game Win!!");
            Instantiate(winEffect, transform.position, Quaternion.identity);
            Instantiate(winEffect2, transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(gameObject);
            return;
        }
        if (coll.tag != ColorMatch)
        {
            //Debug.Log("Game Over");
            gameOverScreen.SetActive(value: true);            
            return;
        }    
       
       
    }
    //public void FadeGameOver(string screenName)
    //{
    //    feder.FadeTo(screenName);
    //}
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
    public void Restart()
    {
       feder.FadeTo(SceneManager.GetActiveScene().name);
    }
    public void Menu(string LevelName)
    {
        feder.FadeTo(LevelName);
    }
}
