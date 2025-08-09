using System.Collections;
using TMPro;
using UnityEngine;

public class TypeWritingEffect : MonoBehaviour
{
    [SerializeField] private TMP_Text textUI;
    [SerializeField] private float charsPerSecond = 600f; 

    private Coroutine _typingCoroutine;

    public void ShowText(string fullText)
    {
        if (_typingCoroutine != null)
        {
            StopCoroutine(_typingCoroutine);
        }

        _typingCoroutine = StartCoroutine(TypeText(fullText));
    }

    private IEnumerator TypeText(string text)
    {
        textUI.text = "";
        var delay = 1f / charsPerSecond;

        foreach (var c in text)
        {
            textUI.text += c;
            yield return new WaitForSeconds(delay);
        }
    }
}
