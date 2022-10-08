using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLogic : MonoBehaviour
{
    public Animator coinAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Martha()
    {
        coinAnimator.SetTrigger("Martha");
    } 

    public void Yes()
    {
        coinAnimator.SetTrigger("Yes");
    }

    public void No()
    {
        coinAnimator.SetTrigger("No");
    }

    public void Abusive()
    {
        coinAnimator.SetTrigger("Abusive");
    }

    public void Angry()
    {
        coinAnimator.SetTrigger("Angry");
    }

    public void Die()
    {
        coinAnimator.SetTrigger("Die");
    }

    public void Blood()
    {
        coinAnimator.SetTrigger("Blood");
    }

    public void Sorry()
    {
        coinAnimator.SetTrigger("Sorry");
    }

    public void Goodbye()
    {
        coinAnimator.SetTrigger("Goodbye");
    }
}
