using UnityEngine;
using TMPro;

public class InputPanelScript : MonoBehaviour
{
    #region INIT
    
    public bool CommandModeActivated = false;
    public TMP_Text logField;
    public TMP_InputField inputField;

    private void INIT()
    {
        gameObject.SetActive(CommandModeActivated);
    }

    private void Awake()
    {
        INIT();
        _typingLog = logField.text;
    }

    public void SetActive(bool state)
    {
        gameObject.SetActive(state);
    }

    #endregion

    #region FIELDS

    private string typingLine;

    private string _typingLog;
    
    private string typingLog
    {
        get => _typingLog;
        set => _typingLog = _typingLog + "\n" + value + " ";
    }

    #endregion

    #region LOGIC

    public void SwitchToCommandMode()
    {
        BaseInputManager.PlayerMovement.Disable();
        BaseInputManager.Interface.Disable();
        BaseInputManager.CommandMode.Enable();
        PlayerInterface.current.showInteract = false;
        gameObject.SetActive(true);
        inputField.ActivateInputField();
        CanvasScript.current.commandsPanel.SetActive(true);
    }

    public void SwitchFromCommandMode()
    {
        BaseInputManager.PlayerMovement.Enable();
        BaseInputManager.Interface.Enable();
        BaseInputManager.CommandMode.Disable();
        PlayerInterface.current.showInteract = true;
        gameObject.SetActive(false);
        clearTypeLine();
        CanvasScript.current.commandsPanel.SetActive(false);
    }

    public void clearTypeLine()
    {
        inputField.text = "";
        typingLine = "";
    }

    public void type(string value)
    {
        typingLine = value;
    }
    
    public void acceptTyping()
    {
        typingLog = typingLine;
        logField.text = typingLog;
        Commands.current.CheckCommand(typingLine);
        typingLine = "";
        clearTypeLine();
        inputField.ActivateInputField();
    }

    public void WriteToConsole(string value)
    {
        typingLog = value;
        logField.text = typingLog;
    }

    #endregion
    
}
