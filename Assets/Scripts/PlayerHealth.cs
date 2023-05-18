using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ghost")
        {
            StartCoroutine(Muerte());
        }
    }

    IEnumerator Muerte()
    {
        animator.Play("Die");
        yield return new WaitForSeconds(0.8f);
        canvas.enabled = true;
    }
}
