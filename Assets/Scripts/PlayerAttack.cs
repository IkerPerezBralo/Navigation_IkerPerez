using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    private NavMeshAgent agent;
    private Animator animator;

    public bool isAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(HitEnemy());
        }
    }

    private IEnumerator HitEnemy()
    {
        isAttacking = true;
        animator.SetTrigger("Attack 01");
        yield return new WaitForSeconds(0.5f);
        isAttacking = false;
    }
}
