using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    public float WalkSpeed = 1.0f;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("WalkSpeed", WalkSpeed);
    }
}
