using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float MoveSpeed;//Tạo biến tốc độ
    Vector3 oldpos;
   
    // Start is called before the first frame update
    void Start()
    {
        oldpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(MoveSpeed*Time.deltaTime,0,0));
        if(Vector3.Distance(oldpos,gameObject.transform.position) > 30){
            gameObject.transform.position = oldpos;
        }
    }   
}
