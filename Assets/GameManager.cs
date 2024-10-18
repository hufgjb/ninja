using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //�m��Prefab���ܼ�
    float span = 1.0f; //�ɶ����j
    float delta = 0; //�{�b�w�g�ֿn���ɶ�

    void Update()
    {
        delta += Time.deltaTime; //�C�@�Ӽv��g�L���ɶ��A���֥[��delta��
        if (delta > span)  // �u�ndelta�ֿn��j��span�]�j��1��^�A�N�|���ͤ@�ӽb�Y
        {
            delta = 0;
            int px = Random.Range(-6, 7); // �H�����ͤ@��-6��7�������Ʀr
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity); // ���ͽb�Y����
        }
    }
}