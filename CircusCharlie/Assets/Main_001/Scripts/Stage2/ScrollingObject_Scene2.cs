using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject_Scene2 : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager_Scene2.instance.isDead == false)
        {
            if (GameManager_Scene2.instance.gameEnd != true)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
    }
}
