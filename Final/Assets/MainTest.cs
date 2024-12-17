using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class MainText : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private TMP_Text targetText; // ������ TMP_Text ������Ʈ
    [SerializeField] private string hoverText = "���콺�� �ö�Խ��ϴ�!"; // ���콺 �÷��� �� ������ �ؽ�Ʈ
    // ���콺�� ��ư ���� �ö���� �� ����
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetText != null)
        {
            targetText.text = hoverText;
        }
    }
}
