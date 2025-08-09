using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private TypeWritingEffect typewriter;
    [SerializeField] private List<string> sceneLines;
    private int currentLine = 0;

    void Start()
    {
        if (sceneLines.Count > 0)
            ShowCurrentLine();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            NextLine();
        }
    }

    void ShowCurrentLine()
    {
        typewriter.ShowText(sceneLines[currentLine]);
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void NextLine()
    {
        if (currentLine < sceneLines.Count - 1)
        {
            currentLine++;
            ShowCurrentLine();
        }
        else
        {
            Debug.Log("Диалог в этой сцене закончен");
            // Здесь можно триггерить событие или переход к выбору ответа
        }
    }
}
