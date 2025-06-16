using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DOTWeenAnima : MonoBehaviour
{
    public Text dialogue;
    public void doDiaLogue()
    {
        dialogue.DOText("【戴夫】：\n你最好给我小心点，不给我三连，\n我就吃掉你的脑子！！！！", 4);
        DOTween.To(() => dialogue.color, x => dialogue.color = x, Color.red, 2).OnComplete(() => dialogue.color = Color.white);
    }
    public void shakeScreen()
    {
        Camera.main.transform.DOShakePosition(1, 1);
    }
}
