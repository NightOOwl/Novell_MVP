using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuInput : MonoBehaviour
{
     [SerializeField] private GameObject pauseMenuUI;

    private UIInputActions inputActions;
    private bool isMenuOpen = false;

    private void Awake()
    {
        inputActions = new UIInputActions();
    }

    private void OnEnable()
    {
        inputActions.UI.Enable();
        inputActions.UI.Pause.performed += OnPausePressed;
    }

    private void OnDisable()
    {
        inputActions.UI.Pause.performed -= OnPausePressed;
        inputActions.UI.Disable();
    }

    private void OnPausePressed(InputAction.CallbackContext ctx)
    {
        isMenuOpen = !isMenuOpen;
        pauseMenuUI.SetActive(isMenuOpen);
        Time.timeScale = isMenuOpen ? 0f : 1f;
    }

    public void CloseMenu() // кнопка "Resume"
    {
        isMenuOpen = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
