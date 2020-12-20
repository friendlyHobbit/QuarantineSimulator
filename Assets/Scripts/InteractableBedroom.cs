using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableBedroom : MonoBehaviour
{
    public string instruction;
    public string instruction2;
    string emptyString = " ";
    public Text UItext;

    GameObject sleepText1;
    GameObject sleepText2;
    GameObject blackOutSprite;
    GameObject playerObject;

    bool isInBed = false;

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

    private void Update()
    {
        if(isInBed == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Sleep());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(instruction);
        UItext.text = instruction;
        isInBed = true;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        UItext.text = emptyString;
        isInBed = false;
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
        //UItext.text = instruction2;

        WakeUp();
    }

    void WakeUp()
    {
        //put the character next to bed
        playerObject.transform.position = new Vector2(4.42f, playerObject.transform.position.y);
        isInBed = false;
        // activate character
        playerObject.SetActive(true);
        sleepText1.SetActive(false);

        // increment day counter
        GameManager.DayCounter++;
        print(" GameManager.DayCounter: " + GameManager.DayCounter);
    }
}
