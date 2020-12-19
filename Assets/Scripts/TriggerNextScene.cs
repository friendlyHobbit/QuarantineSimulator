using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNextScene : MonoBehaviour
{
    int sceneID;

    // Start is called before the first frame update
    void Start()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        print("sceneID: " + sceneID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(sceneID == 0)
        {
            // kitchen scene -> work scene
            SceneManager.LoadScene(3);
        }
        else if (sceneID == 1)
        {
            // bedroom scene -> bathroom
            SceneManager.LoadScene(2);
        }
        else if (sceneID == 2)
        {
            // bathroom scene -> kitchen
            SceneManager.LoadScene(0);
        }
        else if (sceneID == 3)
        {
            // work scene -> evening kitchen
            SceneManager.LoadScene(4);
        }
        else if (sceneID == 4)
        {
            // evening kitchen -> bedroom
            SceneManager.LoadScene(1);
        }

    }
}
