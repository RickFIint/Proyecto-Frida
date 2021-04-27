using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum QuestionState {WHO, HOW, WHERE, WHEN, WHY, INCORRECT}
public class Question : MonoBehaviour
{
    [TextArea] public TMP_Text QuestionText;
    private List<Question> questions;
    private QuestionState state;

    void Awake()
    {
        if (questions == null) {
            questions = new List<Question>();
        }
        questions.Add(this);

        
    }

    // Update is called once per frame
    void Output() {
        switch(state)
        {
            case QuestionState.WHO:
            {
                break;
            }
            case QuestionState.HOW:
            {
                break;
            }
            case QuestionState.WHERE:
            {
                break;
            }
            case QuestionState.WHEN:
            {
                break;
            }
            case QuestionState.WHY:
            {
                break;
            }
            case QuestionState.INCORRECT:
            {
                break;
            }
            
        }
    }
}
