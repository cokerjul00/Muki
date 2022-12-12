using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{

    public GameObject Axe;

    public bool CanAttack = true;

    public float AttackCooldown = 1.0f;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CanAttack)
            {
                AxeAttack();
            }
        }

    }


    public void AxeAttack()
    {
        CanAttack = false;
        Animator animator = Axe.GetComponent<Animator>();
        animator.SetTrigger("Attack");
        StartCoroutine(ResetAttackCoolDown());

    }




    IEnumerator ResetAttackCoolDown()
    {
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }
}
