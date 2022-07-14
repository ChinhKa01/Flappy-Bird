using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float PowerFly;//Lực bay của con chim , tham chiếu lên trục y
    public GameObject GameController;
    private Animator animator;

    /// </summary>
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.SetFloat("Power Fly",0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,PowerFly));//addforce: thêm lực
            Debug.Log("fly");
        }
        animator.SetFloat("Power Fly",gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag.Equals("Chimney")){
            GameController.GetComponent<GameController>().end();
        }
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.GetComponent<GameController>().SetPoint();
    }
}
