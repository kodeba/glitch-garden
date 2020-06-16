using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
        GameObject target = collision.gameObject;
        if (target.GetComponent<Gravestone>())
        {
            //JumpTrigger();
            Debug.Log("Gravestone");
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        else if (target.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(target);
        }
    }

    private void JumpTrigger()
    {
        var animator = GetComponent<Animator>();
        if (animator)
        {
            animator.SetTrigger("jumpTrigger");
        }
    }

}
