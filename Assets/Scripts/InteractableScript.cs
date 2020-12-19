using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableScript : MonoBehaviour
{
    public string instruction;
    string emptyString = " ";
    public Text UItext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instructions()
    {
        // if player enters trigger
        // show text
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(instruction);
        UItext.text = instruction;

        if (Input.GetKeyDown(KeyCode.E))
        {
            // character does an action
            //print("character should do an action");
            UItext.text = "good food";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UItext.text = emptyString;
    }
}
