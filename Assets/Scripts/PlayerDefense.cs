using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefense : MonoBehaviour
{
    private Animator animator;

    public bool isDefending = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            StartCoroutine(Shield());
        }
        else
        {
            isDefending = false;
        }
    }

    private IEnumerator Shield()
    {
        isDefending = true;
        animator.SetTrigger("Defend");
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("Idle");
    }
}
