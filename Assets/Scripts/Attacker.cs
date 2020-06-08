using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float damage = 100f;

    float currentSpeed = 0f;

    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        SetIsAttackingAnimate(true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget()
    {
        if (currentTarget)
        {
            var health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            SetIsAttackingAnimate(false);
        }
    }

    private void SetIsAttackingAnimate(bool isAttacking)
    {
        GetComponent<Animator>().SetBool("isAttacking", isAttacking);
    }

}
