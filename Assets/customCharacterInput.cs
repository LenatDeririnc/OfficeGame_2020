// GENERATED AUTOMATICALLY FROM 'Assets/customCharacterInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CustomCharacterInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomCharacterInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""customCharacterInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""52a8ccda-c5ff-48d1-95c0-d013594efe02"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""8da70ceb-4a1f-4713-aa3a-8a5f0b0d2122"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""2f29263c-6f59-47d8-ac76-a5c5f939996a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""bf82a42c-5107-42e5-b4c7-8089deaccb83"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""1ec055aa-4f30-4bd1-967d-b899f3ead9ad"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""87429e06-28b5-4a50-8822-07428ecc1c8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""4ba72410-bb36-42ae-ab22-9105baa3cc9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""4de1e9b5-1f34-4dce-8b1d-8e04379f9f86"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cdd30852-b45a-41f8-bc60-7337b21815a2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""436398f6-5933-477b-8209-d8890e5e17ba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""11eef2d4-3172-46d1-bbeb-aadcd99419b5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""314a7eac-a186-49cb-8241-00600658f566"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c609df0a-7b0a-492f-a00c-88f8125bdf37"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""9715384c-169d-48b4-8695-4a58f5c7b397"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ee5be0d0-150f-42a9-bbbe-e8b5ba3b8f9d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""67dea358-16d3-40d8-991d-394bc7ea6f42"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""56f3b805-e60a-451c-aa24-e4e804045835"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""baa10570-a188-4549-b14f-761de35e0b50"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f68371b7-e52e-4531-9060-0628df7b38ea"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d9101615-dd78-43a3-8186-da6b91d5d1ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ffaa16f9-69c9-468c-848f-e39d8268d7bc"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""011220ff-8277-4d27-9172-604300b0ce65"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""61be31c3-f9ce-4fd8-b327-1edad5eb2c69"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c670c525-8242-401b-811e-2539f986f10c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aa677d5c-a3c6-4515-9eb2-2787408421ab"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36291aa9-cdb2-4b03-a655-d66b203f7eec"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee67075f-206d-4250-91ab-e5ca681bd237"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CommandMode"",
            ""id"": ""9d9410fb-83b9-4b6a-a104-c92d852a2880"",
            ""actions"": [
                {
                    ""name"": ""ExitFromCommandMode"",
                    ""type"": ""Button"",
                    ""id"": ""fc3eeaa9-521c-421f-9ca5-35404935103a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef4defa6-da46-4ded-9ff4-09f4e3904dd5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ExitFromCommandMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interface"",
            ""id"": ""cfbc6417-bc86-43c0-87ad-cedd2ea9034b"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""69b171e4-d152-430c-9a31-b7f3f52a3382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""76870123-cb92-48c4-8559-f7df06d89209"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GotoCommandMode"",
                    ""type"": ""Button"",
                    ""id"": ""c5324dba-4cdb-4cdf-a09a-b3724cca4039"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""665ce4ef-4c20-428a-817a-bf55489dad50"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c37d251-7525-44c5-97f2-c64fd642f226"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfd50d62-79eb-4a4d-af02-ffbe5a53a075"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GotoCommandMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1e41784-4447-4997-846b-8c6d1f514a9f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GotoCommandMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""c08e03d1-9444-4f3d-81cb-49efc3c32ff8"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GotoCommandMode"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""d79edddf-8ebf-49f7-bab7-5d979db5ef09"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GotoCommandMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""48263d4c-7944-4efc-a9b7-aa3c87aeb429"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GotoCommandMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Develop"",
            ""id"": ""387135ec-dd02-491d-9cd0-4097144d7734"",
            ""actions"": [
                {
                    ""name"": ""UnlockCursorKey"",
                    ""type"": ""Button"",
                    ""id"": ""4c1ea026-92b1-44a5-9a44-3312972f2fd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ee1e944-fe60-4a7f-9f4b-df97b2fbd0f2"",
                    ""path"": ""<Keyboard>/f12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""UnlockCursorKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Vertical = m_PlayerMovement.FindAction("Vertical", throwIfNotFound: true);
        m_PlayerMovement_Horizontal = m_PlayerMovement.FindAction("Horizontal", throwIfNotFound: true);
        m_PlayerMovement_ViewHorizontal = m_PlayerMovement.FindAction("View Horizontal", throwIfNotFound: true);
        m_PlayerMovement_ViewVertical = m_PlayerMovement.FindAction("View Vertical", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_Run = m_PlayerMovement.FindAction("Run", throwIfNotFound: true);
        // CommandMode
        m_CommandMode = asset.FindActionMap("CommandMode", throwIfNotFound: true);
        m_CommandMode_ExitFromCommandMode = m_CommandMode.FindAction("ExitFromCommandMode", throwIfNotFound: true);
        // Interface
        m_Interface = asset.FindActionMap("Interface", throwIfNotFound: true);
        m_Interface_Pause = m_Interface.FindAction("Pause", throwIfNotFound: true);
        m_Interface_Inventory = m_Interface.FindAction("Inventory", throwIfNotFound: true);
        m_Interface_GotoCommandMode = m_Interface.FindAction("GotoCommandMode", throwIfNotFound: true);
        // Develop
        m_Develop = asset.FindActionMap("Develop", throwIfNotFound: true);
        m_Develop_UnlockCursorKey = m_Develop.FindAction("UnlockCursorKey", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Vertical;
    private readonly InputAction m_PlayerMovement_Horizontal;
    private readonly InputAction m_PlayerMovement_ViewHorizontal;
    private readonly InputAction m_PlayerMovement_ViewVertical;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_Run;
    public struct PlayerMovementActions
    {
        private @CustomCharacterInput m_Wrapper;
        public PlayerMovementActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_PlayerMovement_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_PlayerMovement_Horizontal;
        public InputAction @ViewHorizontal => m_Wrapper.m_PlayerMovement_ViewHorizontal;
        public InputAction @ViewVertical => m_Wrapper.m_PlayerMovement_ViewVertical;
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @Run => m_Wrapper.m_PlayerMovement_Run;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontal;
                @ViewHorizontal.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewHorizontal;
                @ViewHorizontal.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewHorizontal;
                @ViewHorizontal.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewHorizontal;
                @ViewVertical.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewVertical;
                @ViewVertical.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewVertical;
                @ViewVertical.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnViewVertical;
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @ViewHorizontal.started += instance.OnViewHorizontal;
                @ViewHorizontal.performed += instance.OnViewHorizontal;
                @ViewHorizontal.canceled += instance.OnViewHorizontal;
                @ViewVertical.started += instance.OnViewVertical;
                @ViewVertical.performed += instance.OnViewVertical;
                @ViewVertical.canceled += instance.OnViewVertical;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // CommandMode
    private readonly InputActionMap m_CommandMode;
    private ICommandModeActions m_CommandModeActionsCallbackInterface;
    private readonly InputAction m_CommandMode_ExitFromCommandMode;
    public struct CommandModeActions
    {
        private @CustomCharacterInput m_Wrapper;
        public CommandModeActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitFromCommandMode => m_Wrapper.m_CommandMode_ExitFromCommandMode;
        public InputActionMap Get() { return m_Wrapper.m_CommandMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CommandModeActions set) { return set.Get(); }
        public void SetCallbacks(ICommandModeActions instance)
        {
            if (m_Wrapper.m_CommandModeActionsCallbackInterface != null)
            {
                @ExitFromCommandMode.started -= m_Wrapper.m_CommandModeActionsCallbackInterface.OnExitFromCommandMode;
                @ExitFromCommandMode.performed -= m_Wrapper.m_CommandModeActionsCallbackInterface.OnExitFromCommandMode;
                @ExitFromCommandMode.canceled -= m_Wrapper.m_CommandModeActionsCallbackInterface.OnExitFromCommandMode;
            }
            m_Wrapper.m_CommandModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitFromCommandMode.started += instance.OnExitFromCommandMode;
                @ExitFromCommandMode.performed += instance.OnExitFromCommandMode;
                @ExitFromCommandMode.canceled += instance.OnExitFromCommandMode;
            }
        }
    }
    public CommandModeActions @CommandMode => new CommandModeActions(this);

    // Interface
    private readonly InputActionMap m_Interface;
    private IInterfaceActions m_InterfaceActionsCallbackInterface;
    private readonly InputAction m_Interface_Pause;
    private readonly InputAction m_Interface_Inventory;
    private readonly InputAction m_Interface_GotoCommandMode;
    public struct InterfaceActions
    {
        private @CustomCharacterInput m_Wrapper;
        public InterfaceActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Interface_Pause;
        public InputAction @Inventory => m_Wrapper.m_Interface_Inventory;
        public InputAction @GotoCommandMode => m_Wrapper.m_Interface_GotoCommandMode;
        public InputActionMap Get() { return m_Wrapper.m_Interface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InterfaceActions set) { return set.Get(); }
        public void SetCallbacks(IInterfaceActions instance)
        {
            if (m_Wrapper.m_InterfaceActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPause;
                @Inventory.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInventory;
                @GotoCommandMode.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnGotoCommandMode;
                @GotoCommandMode.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnGotoCommandMode;
                @GotoCommandMode.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnGotoCommandMode;
            }
            m_Wrapper.m_InterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @GotoCommandMode.started += instance.OnGotoCommandMode;
                @GotoCommandMode.performed += instance.OnGotoCommandMode;
                @GotoCommandMode.canceled += instance.OnGotoCommandMode;
            }
        }
    }
    public InterfaceActions @Interface => new InterfaceActions(this);

    // Develop
    private readonly InputActionMap m_Develop;
    private IDevelopActions m_DevelopActionsCallbackInterface;
    private readonly InputAction m_Develop_UnlockCursorKey;
    public struct DevelopActions
    {
        private @CustomCharacterInput m_Wrapper;
        public DevelopActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @UnlockCursorKey => m_Wrapper.m_Develop_UnlockCursorKey;
        public InputActionMap Get() { return m_Wrapper.m_Develop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DevelopActions set) { return set.Get(); }
        public void SetCallbacks(IDevelopActions instance)
        {
            if (m_Wrapper.m_DevelopActionsCallbackInterface != null)
            {
                @UnlockCursorKey.started -= m_Wrapper.m_DevelopActionsCallbackInterface.OnUnlockCursorKey;
                @UnlockCursorKey.performed -= m_Wrapper.m_DevelopActionsCallbackInterface.OnUnlockCursorKey;
                @UnlockCursorKey.canceled -= m_Wrapper.m_DevelopActionsCallbackInterface.OnUnlockCursorKey;
            }
            m_Wrapper.m_DevelopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UnlockCursorKey.started += instance.OnUnlockCursorKey;
                @UnlockCursorKey.performed += instance.OnUnlockCursorKey;
                @UnlockCursorKey.canceled += instance.OnUnlockCursorKey;
            }
        }
    }
    public DevelopActions @Develop => new DevelopActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnViewHorizontal(InputAction.CallbackContext context);
        void OnViewVertical(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface ICommandModeActions
    {
        void OnExitFromCommandMode(InputAction.CallbackContext context);
    }
    public interface IInterfaceActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnGotoCommandMode(InputAction.CallbackContext context);
    }
    public interface IDevelopActions
    {
        void OnUnlockCursorKey(InputAction.CallbackContext context);
    }
}
