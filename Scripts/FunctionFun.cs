using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionFun : MonoBehaviour
{
    public int numberOne;
    public int numberTwo;
    public int numberThree;
    int answer;

    public int inputFun;

	// Use this for initialization
	void Start ()
    {
        /*
        MultiplyNumbers(numberOne , numberTwo); //matching the function's parameters, and interchangable with local variables
        ShowMessage ("The Result is: " + answer);
       /* MultiplyNumbers(numberOne, numberThree);
        Debug.Log("The Result is: " + answer);
        MultiplyNumbers(numberTwo, numberThree);
        Debug.Log("The Result is: " + answer);*/

        ShowMessage("The answer is: " + MultiplayNumbers(numberOne, numberTwo)); // using with int MultiplyNumbers function to show the result
    }

   void Update()
    {
        //if (Input.GetKey(KeyCode.T)) //other way to do the same is using "t"; with using KeyCode minimsing the different names for the same key/button in different systems
        if (Input.GetKeyDown (KeyCode.T)) //GetKeyDown is only register the action of key down, without counting on the time
            inputFun++;
        if (Input.GetKeyUp(KeyCode.T))
            inputFun += 20;

        if (Input.GetButtonDown ("Jump"))
            ShowMessage("Jumping");
        if (Input.GetButton("Jump"))
            ShowMessage("in air");
        if (Input.GetButtonUp("Jump"))
            ShowMessage("Jumped");

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(h,0,v);



    }

	// if a funtion is not start with 'void', means it need to have an reture value.
    int MultiplayNumbers (int firstNumber, int secondNumber)
    {
        int newNumber = firstNumber * secondNumber;
        return newNumber;
    }
    /*
// funcions can have the same name with different set parameters
    void MultiplyNumbers (int firstNumber , int secondNumber) //creating local variables, making the function reusable without changes
    {
        answer = firstNumber * secondNumber;
    }
    */

    void ShowMessage (string msg)
    {
        Debug.Log(msg);
    }
}
