using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// InputBuffer.cs�����޸ģ��޵�����
public class InputBuffer : MonoBehaviour
{
    [Header("���뻺��ʱ��")]
    public float bufferDuration = 0.2f;

    private List<float> _inputTimestamps = new List<float>();

    private void Update()
    {
        // ����������루����ո����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddInput();
        }
    }

    public void AddInput()
    {
        _inputTimestamps.Add(Time.time);
    }

    public bool HasValidInput()
    {
        ClearExpiredInputs();
        return _inputTimestamps.Count > 0;
    }
    // ��ӹ���������ȡ��������
    public int GetInputCount()
    {
        ClearExpiredInputs();
        return _inputTimestamps.Count;
    }

    // ����������루��ѡ��
    public void ClearExpiredInputs()
    {
        _inputTimestamps.RemoveAll(t => Time.time - t > bufferDuration); 
    }

    // �������������¼
    public void ClearInputs()
    {
        _inputTimestamps.Clear();
    }
}
