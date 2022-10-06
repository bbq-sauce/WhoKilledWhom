using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    public Animator animator;
    public float animationSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AnimationSpeed",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AnimationSpeed()
    {
        animationSpeed = Random.Range(0.3f,2);
        animator.speed = animationSpeed;
    }
}
