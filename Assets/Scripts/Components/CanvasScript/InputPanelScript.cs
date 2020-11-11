using UnityEngine;
using TMPro;

public class InputPanelScript : MonoBehaviour, IInit
{
    #region INIT

    private GameObject _gameObject;
    public bool CommandModeActivated = false;
    public TMP_Text logField;
    public TMP_InputField inputField;

    public void INIT()
    {
        _gameObject = gameObject;
        _typingLog = logField.text;
    }

    public void GET()
    {
        // throw new System.NotImplementedException();
    }

    public void AFTER_INIT()
    {
        SetActive(CommandModeActivated);
    }

    public void SetActive(bool state)
    {
        _gameObject.SetActive(state);
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
        SetActive(true);
        inputField.ActivateInputField();
        CanvasScript.current.commandsPanel.SetActive(true);
        CanvasScript.current.bashScript.SetActive(true);
        CanvasScript.current.minimapCamera.SetActive(false);
    }

    public void SwitchFromCommandMode()
    {
        BaseInputManager.PlayerMovement.Enable();
        BaseInputManager.Interface.Enable();
        BaseInputManager.CommandMode.Disable();
        PlayerInterface.current.showInteract = true;
        SetActive(false);
        clearTypeLine();
        CanvasScript.current.commandsPanel.SetActive(false);
        CanvasScript.current.bashScript.SetActive(false);
        CanvasScript.current.minimapCamera.SetActive(true);
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
