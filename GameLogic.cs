using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField userInput;
    private int randomNum; 
    public Text gameLabel;
    public int minvalue;
    public int maxvalue;
    public Button gameButton;
    public Button Startgame;
    public Text scoree;
    private bool isgamewon = false;
    int count1 = 0;
    void Start()
    {
        restart();
    }
    private void restart()
    {
        
                printscore(0);
                minvalue = GetRandomNumber(0,6);
                maxvalue = GetRandomNumber(6,11);
                gameLabel.text = "";
                gameLabel.text = "Guess the number between " + (minvalue-1) + " and " + (maxvalue);
                isgamewon = false;
                userInput.text = "";
                randomNum = GetRandomNumber(minvalue,maxvalue);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Startbutton()
    {
        restart();
    }

    public void OnButtonClick()
    {
        //Debug.Log("Who clicked me!?");
        //Debug.Log(userInput.text);
        //Debug.Log("The RandomNumber is " + randomNum);
         string userInputValue = userInput.text;
         int answer; 
         if(userInputValue != "")
         {
            answer = int.Parse(userInputValue);

            if(answer == randomNum)
            {
               //gameLabel.text = "";
               count1++;
               printscore(count1);
               gameLabel.text = "Correct Answer!";
               //gameButton.interactable = false;
               //playagain = true;
               Debug.Log("Correct!");
            }
            else if(answer > randomNum)
            {
                count1++;
                printscore(count1);
                gameLabel.text = "";
                gameLabel.text = "Try Lower!";
              Debug.Log("Try Lower!");
            }
             else
            {
                count1++;
                printscore(count1);
                gameLabel.text = "";
                gameLabel.text = "Try Higher";
               Debug.Log("Try Higher");
             }
         }
         else
         {
            gameLabel.text = "";
            gameLabel.text = "PLEASE ENTER NUMBER TO CHECK ..";
             Debug.Log("PLEASE ENTER NUMBER TO CHECK ..");
         }
         
    }
    
    private int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min,max);
        Debug.Log("min is" + min);
        Debug.Log("max is" + max);
        return random;
    }

    void printscore(int x)
    {
        scoree.text = count1.ToString();
    }
    

}
