using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 40f;
    private bool engineIsOn;
    [SerializeField]
    private GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        engineIsOn = false;
        rb = GetComponent<Rigidbody2D>();
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            engineIsOn = true;
            fire.SetActive(true);
        } 
        if (Input.touchCount >0 && Input.GetTouch(0).phase== TouchPhase.Ended)
        {
            engineIsOn = false;
            fire.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        switch (engineIsOn)
        {
            case true:
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
                break;
            case false:
                rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Aster")|| collision.name.Equals("Aster1")|| collision.name.Equals("Aster2")|| collision.name.Equals("Aster3")|| collision.name.Equals("Aster4")|| collision.name.Equals("Aster5")|| collision.name.Equals("Aster6")|| collision.name.Equals("Aster7")
            || collision.name.Equals("Aster8")|| collision.name.Equals("Aster9")|| collision.name.Equals("Aster10"))
        {

            Application.LoadLevel("Over");
            Time.timeScale = 0f;
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Application.LoadLevel("Over");
    }
}
