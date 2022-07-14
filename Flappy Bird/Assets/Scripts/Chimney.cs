using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimney : MonoBehaviour
{
    public float ChimneyMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
         gameObject.transform.position = new Vector3(gameObject.transform.position.x,Random.Range(-6,-9),0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(ChimneyMoveSpeed*Time.deltaTime,0,0));
    }
  
    void OnTriggerExit2D(Collider2D other)
    {
        gameObject.transform.position = new Vector3(10,Random.Range(-6,-9),0);
    }
}
