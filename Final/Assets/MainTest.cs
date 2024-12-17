using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class MainText : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private TMP_Text targetText; // 변경할 TMP_Text 컴포넌트
    [SerializeField] private string hoverText = "마우스가 올라왔습니다!"; // 마우스 올렸을 때 보여줄 텍스트
    // 마우스가 버튼 위에 올라왔을 때 실행
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetText != null)
        {
            targetText.text = hoverText;
        }
    }
}
