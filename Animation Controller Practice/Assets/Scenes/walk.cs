using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        animator.SetInteger("horizontal", Mathf.RoundToInt(Input.GetAxisRaw("Horizontal")));
    }
}
