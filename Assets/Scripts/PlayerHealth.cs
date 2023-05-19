using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    private Animator animator;

    private Canvas finalCanvas;


    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        finalCanvas = canvas.GetComponent<Canvas>();
        finalCanvas.enabled = false;
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

    private IEnumerator Muerte()
    {
        animator.SetTrigger("Die");
        yield return new WaitForSeconds(0.8f);
        finalCanvas.enabled = true;
    }
}
