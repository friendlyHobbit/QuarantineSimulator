using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableScript : MonoBehaviour
{
    public string instruction;
    public string instruction2;
    string emptyString = " ";
    public Text UItext;

    GameObject sleepText1;
    GameObject sleepText2;
    GameObject blackOutSprite;
    GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        sleepText1 = GameObject.Find("TextSleep1");
        sleepText1.SetActive(false);

        sleepText2 = GameObject.Find("TextSleep2");
        sleepText2.SetActive(false);

        blackOutSprite = GameObject.Find("BlackOut");
        blackOutSprite.SetActive(false);

        playerObject = GameObject.Find("Player");
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

        StartCoroutine(Sleep());

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        

        print(gameObject.name);
        if (Input.GetKeyDown(KeyCode.E))
        {
            print(gameObject.name);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UItext.text = emptyString;
    }

    IEnumerator Sleep()
    {
        //yield return new WaitForSeconds(0.5f);
        // deactivate character
        playerObject.SetActive(false);
        
        yield return new WaitForSeconds(0.5f);
        // show zzzzz
        sleepText1.SetActive(true);
        
        yield return new WaitForSeconds(1.5f);
        // black out screen for X seconds
        blackOutSprite.SetActive(true);
        
        yield return new WaitForSeconds(1.5f);
        // remove black screen
        blackOutSprite.SetActive(false);
        
        yield return new WaitForSeconds(2.0f);
        // show: press E to wake up
        UItext.text = instruction2;
        
        //yield return null;
    }

    void WakeUp()
    {
        // activate character
        playerObject.SetActive(true);
        sleepText1.SetActive(false);
    }
}
