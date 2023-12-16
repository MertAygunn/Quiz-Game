using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Dogru");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Yanlýs");
            quizManager.wrong();
        }
    }
}
