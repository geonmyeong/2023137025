using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwipeSystem : MonoBehaviour
{
    private Vector2 initialpos;
    public GameObject Character;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialpos = Input.mousePosition;              //눌렀을 때 마우스 위치를 저장한다.
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    // Update is called once per frame
    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialpos.x = finalPos.x);
        float disY = Mathf.Abs(initialpos.y = finalPos.y);

        if (disX > disY)
        {
            if (initialpos.x > finalPos.x)
            {
                Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
            else
            {
                Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
            }          
        }
        else
        {
            if (initialpos.y > finalPos.y)
            {
                Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
            else
            {
                Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
            }
        }
            
        
    }
}
