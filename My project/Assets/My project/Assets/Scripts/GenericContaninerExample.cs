using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContaninerExample : MonoBehaviour
{
    private GenericContanier<int> intcontainer;            //컨테이너 선언 (int)
    private GenericContanier<string> srtingContainer;      //컨테이너 선언 (string)


    private void Start()
    {
        intcontainer = new GenericContanier<int>(10);      //10칸으로 선언
        srtingContainer = new GenericContanier<string>(5); //5칸으로 선언
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))                    //키보드 1을 누르면
        {
            intcontainer.Add(Random.Range(0, 100));             //0~100 랜덤 숫자를 컨테이너에 넣는다.
            DisplayContainerItems(intcontainer);                //함수를 통해서 Debug.log에 보여준다.
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))                   //키보드 1을 누르면
        {
            string randomString = "Item" + +Random.Range(0, 100);           //임의의 문자열을 만들어준다.
            srtingContainer.Add(randomString);                              //0-100 랜덤 문자열 컨테이너에 넣는다.
            DisplayContainerItems(srtingContainer);                         //함수를 통해서 Debug.log에 보여준다.
        }
    }


    private void DisplayContainerItems<T>(GenericContanier<T> contaniner)
    {
        T[] item = contaniner.GetItems();       //아이템 리스트를 받아온다.
        string temp = "";                       //Debug.Log에 보여질 칸 String
        for(int i = 0; i < item.Length; i++)            //컨테이너의 모든 갑을 for문으로 돌면서
        {
            if(item[i] !=null)                  //갑이 NULL 이 아닐 경우
            {
                temp += item[i].ToString() + "/";       //string 형식으로 보여준다.
            }
            else
            {
                temp += "Empty / ";          //NULL일 경우에는 Empty 표현 해준다.
            }
        }
        Debug.Log(temp);
    }
}
