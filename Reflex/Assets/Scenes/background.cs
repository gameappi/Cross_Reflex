using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    [SerializeField]
    private Transform centerBackground;
   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= centerBackground.position.y + 10.94f)
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y + 10.94f);
        else if (transform.position.y <= centerBackground.position.y - 10.94f)
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y - 10.94f);
    }
}
