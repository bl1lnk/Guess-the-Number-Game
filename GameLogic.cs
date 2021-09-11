using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;
    public int minNumber = 0;
    public int maxNumber = 10;
    private int attempt;


    private int randomNum;

    // Start is called before the first frame update
    void Start()
    {

        randomNum = GetRandomNumber(minNumber, maxNumber);
        gameLabel.text = "";
        Debug.Log("Generated Number : " + randomNum);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnButtonClick()
    {
        string userInputValue = userInput.text;
        if(userInputValue != "")
        {
            attempt += 1;
            int answer = int.Parse(userInputValue);
            if (answer == randomNum)
            {
                gameLabel.text = "Correct! After "+ attempt+ " attempt";
                attempt = 0;
                randomNum = GetRandomNumber(minNumber, maxNumber);
                Debug.Log("Generated Number : " + randomNum);
               


            }
            else if (answer > randomNum)
            {
                gameLabel.text = "Try Lower :c";
            }
            else
            {
                gameLabel.text = "Try Higher :D ";
            }
        }
        else
        {
            Debug.Log("Please Enter answer !");
        }
       

      
    }

    public int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }
}
