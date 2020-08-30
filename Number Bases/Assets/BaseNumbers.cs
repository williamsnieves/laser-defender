using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BaseNumbers : MonoBehaviour
{
    public int selectedNumber = 173;
    public string binaryResult = "";
    // Start is called before the first frame update
    void Start()
    {
        var firstResult = selectedNumber / 2;
        var firstRemainder = selectedNumber % 2;
        var secondResult = firstResult / 2;
        var secondRemainder = firstResult % 2;
        var thirdResult = secondResult / 2;
        var thirdRemainder = secondResult % 2;
        var fourthResult = thirdResult / 2;
        var fourthRemainder = thirdResult % 2;
        var fifthResult = fourthResult / 2;
        var fifthRemainder = fourthResult % 2;
        var sixthResult = fifthResult / 2;
        var sixthRemainder = fifthResult % 2;
        var seventhResult = sixthResult / 2;
        var seventhRemainder = sixthResult % 2;

        binaryResult = firstRemainder.ToString()
                       + secondRemainder.ToString()
                       + thirdRemainder.ToString()
                       + fourthRemainder.ToString()
                       + fifthRemainder.ToString()
                       + sixthRemainder.ToString()
                       + seventhRemainder.ToString();

        print("firstResult: " + firstResult);
        print("firstRemainder: " + firstRemainder);
        print("secondResult: " + secondResult);
        print("secondRemainder: " + secondRemainder);
        print("thirdResult: " + thirdResult);
        print("thirdRemainder: " + thirdRemainder);
        print("fourthResult: " + fourthResult);
        print("fourthRemainder: " + fourthRemainder);
        print("fifthResult: " + fifthResult);
        print("fifthRemainder: " + fifthRemainder);
        print("sixthResult: " + sixthResult);
        print("sixthRemainder: " + sixthRemainder);
        print("seventhResult: " + seventhResult);
        print("seventhRemainder: " + seventhRemainder);

        print("binaryResult: " + binaryResult);
        print("Back to decimal: " + Convert.ToInt32(binaryResult, 2));

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
