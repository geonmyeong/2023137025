using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void sayHello()                                     //sayHello 함수를 선언
    {
        Debug.Log("Hello");                             //Hello 내용을 console.log에 출력
    }

    void CallName(string name)                          //CallName 함수 선언 (string 변수의 인수(name)를 가짐)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a , int b)                              //Add 함수 선언 (인수 , 반환값, 선언할때 (int)
    {
        int c = a + b;
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        sayHello();
        sayHello();
        CallName("TOM");
        CallName("SAM");
        int answer = Add(2, 5);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
