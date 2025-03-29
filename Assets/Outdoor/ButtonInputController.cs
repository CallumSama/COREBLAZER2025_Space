using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInputController : MonoBehaviour
{
    public Button myButton;
    private RectTransform _buttonRect;
    [Header("���뻺������")]
    public InputBuffer inputBuffer; // �ֶ���ק��ֵ

    void Start()
    {
        _buttonRect = myButton.GetComponent<RectTransform>();
        // �󶨵���¼��� Unity �� Button ���
        myButton.onClick.AddListener(OnButtonClick);
    }

    void Update()
    {
        // ��������������¼������ڰ�ť�����ڣ�
        if (Input.GetMouseButtonDown(0) && IsMouseOverButton())
        {
            myButton.onClick.Invoke(); // �����¼�����ɫ + Log��
        }
    }

    bool IsMouseOverButton()
    {
        Vector2 mousePosition = Input.mousePosition;
        return RectTransformUtility.RectangleContainsScreenPoint(_buttonRect, mousePosition);
    }

    void OnButtonClick()
    {
        Debug.Log("��ť��������");
        inputBuffer.AddInput();
    }
}