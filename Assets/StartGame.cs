using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] Text question;
    [SerializeField] Text option1;
    [SerializeField] Text option2;
    [SerializeField] Text option3;
    [SerializeField] Text option4;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        question.text = state.getStateQuestion();
        option1.text = state.getStateOptions()[0];
        option2.text = state.getStateOptions()[1];
        option3.text = state.getStateOptions()[2];
        option4.text = state.getStateOptions()[3];
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        int correctOption = -1;
        int userAnswer = -1;

        for (int i = 0; i < 4; i++)
        {
            if (state.getCorrectAnswer() == state.getStateOptions()[i])
            {
                correctOption = i;
                break;
            }
        }
        // Debug.Log(correctOption);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            userAnswer = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            userAnswer = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            userAnswer = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            userAnswer = 3;
        }

        if (correctOption == userAnswer)
        {
            // if (state.getNextStates())
            // {
            Debug.Log("Correct" + state.getNextStates()[0]);
            state = state.getNextStates()[0];
            question.text = state.getStateQuestion();
            option1.text = state.getStateOptions()[0];
            option2.text = state.getStateOptions()[1];
            option3.text = state.getStateOptions()[2];
            option4.text = state.getStateOptions()[3];
            // }
        }
    }
}
