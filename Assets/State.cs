using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(4, 5)] [SerializeField] string question;

    [SerializeField] string[] options = new string[4];
    [SerializeField] string correctOption;
    [SerializeField] State[] nextStates;

    public string getStateQuestion()
    {
        return question;
    }

    public string getCorrectAnswer()
    {
        return correctOption;
    }

    public string[] getStateOptions(){
        return options;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }

}
