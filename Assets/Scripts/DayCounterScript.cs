using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounterScript : MonoBehaviour
{
    Text counterText;
    string counterString;
    int counterInt;

    // Start is called before the first frame update
    void Start()
    {
        //get day counter text
        counterInt = GameManager.DayCounter;
        counterString = "Quarantine day " + counterInt;

        //set day counter text
        counterText = gameObject.GetComponent<Text>();
        counterText.text = counterString;
    }

}
