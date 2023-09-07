using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContaninerExample : MonoBehaviour
{
    private GenericContanier<int> intcontainer;            //�����̳� ���� (int)
    private GenericContanier<string> srtingContainer;      //�����̳� ���� (string)


    private void Start()
    {
        intcontainer = new GenericContanier<int>(10);      //10ĭ���� ����
        srtingContainer = new GenericContanier<string>(5); //5ĭ���� ����
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))                    //Ű���� 1�� ������
        {
            intcontainer.Add(Random.Range(0, 100));             //0~100 ���� ���ڸ� �����̳ʿ� �ִ´�.
            DisplayContainerItems(intcontainer);                //�Լ��� ���ؼ� Debug.log�� �����ش�.
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))                   //Ű���� 1�� ������
        {
            string randomString = "Item" + +Random.Range(0, 100);           //������ ���ڿ��� ������ش�.
            srtingContainer.Add(randomString);                              //0-100 ���� ���ڿ� �����̳ʿ� �ִ´�.
            DisplayContainerItems(srtingContainer);                         //�Լ��� ���ؼ� Debug.log�� �����ش�.
        }
    }


    private void DisplayContainerItems<T>(GenericContanier<T> contaniner)
    {
        T[] item = contaniner.GetItems();       //������ ����Ʈ�� �޾ƿ´�.
        string temp = "";                       //Debug.Log�� ������ ĭ String
        for(int i = 0; i < item.Length; i++)            //�����̳��� ��� ���� for������ ���鼭
        {
            if(item[i] !=null)                  //���� NULL �� �ƴ� ���
            {
                temp += item[i].ToString() + "/";       //string �������� �����ش�.
            }
            else
            {
                temp += "Empty / ";          //NULL�� ��쿡�� Empty ǥ�� ���ش�.
            }
        }
        Debug.Log(temp);
    }
}
