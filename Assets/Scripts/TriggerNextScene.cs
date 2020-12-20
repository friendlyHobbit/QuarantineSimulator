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
            // Bathroom scene -> kitchen scene
            SceneManager.LoadScene(1);
        }
        else if (sceneID == 1)
        {
            // kitchen scene -> work
            SceneManager.LoadScene(2);
        }
        else if (sceneID == 2)
        {
            // work scene -> kitchen
            SceneManager.LoadScene(3);
        }
        else if (sceneID == 3)
        {
            // kitchen scene -> bedroom
            SceneManager.LoadScene(4);
        }
        else if (sceneID == 4)
        {
            // bedroom -> kitchen
            SceneManager.LoadScene(0);
        }

    }
}
