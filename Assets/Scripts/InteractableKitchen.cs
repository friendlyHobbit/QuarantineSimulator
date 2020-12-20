using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableKitchen : MonoBehaviour
{
    public string instruction;
    string emptyString = " ";
    public Text UItext;

    public GameObject FeedbackText;
    GameObject playerObject;

    bool isColliding = false;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        FeedbackText.SetActive(false);
    }

    private void Update()
    {
        if (isColliding == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(ActionRoutine());
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(instruction);
        UItext.text = instruction;
        isColliding = true;

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        UItext.text = emptyString;
        isColliding = false;
    }

    IEnumerator ActionRoutine()
    {
        UItext.text = emptyString;

        yield return new WaitForSeconds(0.5f);
        // show feedback
        FeedbackText.SetActive(true);

        yield return new WaitForSeconds(2.0f);
        // hide feedback
        FeedbackText.SetActive(false);
        UItext.text = instruction;

    }
}
