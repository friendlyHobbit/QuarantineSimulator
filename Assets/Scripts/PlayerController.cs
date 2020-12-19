using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    float playerDir;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayerImput();

        

    }

    void PlayerImput()
    {
        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            // character goes left
            playerDir = -1.0f;
            transform.localScale = new Vector3(playerDir, 1, 1);
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            // character goes right
            playerDir = 1.0f;
            transform.localScale = new Vector3(playerDir, 1, 1);
            transform.position = transform.position + Vector3.right * Time.deltaTime * speed;
        }

    }
}
