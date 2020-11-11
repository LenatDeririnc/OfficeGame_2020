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
                },
                {
                    ""name"": ""Keyboard View Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""f8902a71-ff92-4d22-bb40-6ad0b8f1a0d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard View Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""2fb440ec-4edb-457d-8d0e-9baf9d264b72"",
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
                    ""name"": """",
                    ""id"": ""d8e892f2-371a-4d12-b979-0a6fd548ef86"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93743fcf-e3db-4445-ba07-990fda88f652"",
                    ""path"": ""<Touchscreen>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""529bf90f-578f-472d-b295-62968be668f4"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""View Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e8e0dd4-2d94-4828-a95d-5f4b6e98f4b3"",
                    ""path"": ""<Touchscreen>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d9101615-dd78-43a3-8186-da6b91d5d1ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Keyboard View Horizontal"",
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
                    ""action"": ""Keyboard View Horizontal"",
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
                    ""action"": ""Keyboard View Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c670c525-8242-401b-811e-2539f986f10c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Keyboard View Vertical"",
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
                    ""action"": ""Keyboard View Vertical"",
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
                    ""action"": ""Keyboard View Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""87c60993-bca5-41de-bb3c-07019187d630"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HelpMenu"",
                    ""type"": ""Button"",
                    ""id"": ""a9703f17-b6d9-4148-8657-58e17f5431e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec268fe9-b6ef-46b4-8959-8d317c51bb4a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f3a034b-0b65-4020-8bd3-28d55f4ef3fa"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""119d3d71-8334-4eb8-927b-f1a28593b179"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cac8b232-689a-4527-a604-cbedac71a9f3"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HelpMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        },
        {
            ""name"": ""Note"",
            ""id"": ""0efb212b-4ee0-4af9-9418-4037fc00fbb5"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""a8ea57f3-598f-44c0-a8e2-f44417e9acac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c37ef144-5a49-4fd7-8560-953eafcbaaa3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca0a4892-a0bd-43dd-aac6-c322ea2f0d9c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe688ca4-6f3b-4033-9789-fcd8de325322"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
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
                },
                {
                    ""devicePath"": ""<Mouse>"",
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
        m_PlayerMovement_KeyboardViewHorizontal = m_PlayerMovement.FindAction("Keyboard View Horizontal", throwIfNotFound: true);
        m_PlayerMovement_KeyboardViewVertical = m_PlayerMovement.FindAction("Keyboard View Vertical", throwIfNotFound: true);
        // CommandMode
        m_CommandMode = asset.FindActionMap("CommandMode", throwIfNotFound: true);
        m_CommandMode_ExitFromCommandMode = m_CommandMode.FindAction("ExitFromCommandMode", throwIfNotFound: true);
        // Interface
        m_Interface = asset.FindActionMap("Interface", throwIfNotFound: true);
        m_Interface_Pause = m_Interface.FindAction("Pause", throwIfNotFound: true);
        m_Interface_Inventory = m_Interface.FindAction("Inventory", throwIfNotFound: true);
        m_Interface_GotoCommandMode = m_Interface.FindAction("GotoCommandMode", throwIfNotFound: true);
        m_Interface_Interact = m_Interface.FindAction("Interact", throwIfNotFound: true);
        m_Interface_HelpMenu = m_Interface.FindAction("HelpMenu", throwIfNotFound: true);
        // Develop
        m_Develop = asset.FindActionMap("Develop", throwIfNotFound: true);
        m_Develop_UnlockCursorKey = m_Develop.FindAction("UnlockCursorKey", throwIfNotFound: true);
        // Note
        m_Note = asset.FindActionMap("Note", throwIfNotFound: true);
        m_Note_Exit = m_Note.FindAction("Exit", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerMovement_KeyboardViewHorizontal;
    private readonly InputAction m_PlayerMovement_KeyboardViewVertical;
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
        public InputAction @KeyboardViewHorizontal => m_Wrapper.m_PlayerMovement_KeyboardViewHorizontal;
        public InputAction @KeyboardViewVertical => m_Wrapper.m_PlayerMovement_KeyboardViewVertical;
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
                @KeyboardViewHorizontal.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewHorizontal;
                @KeyboardViewHorizontal.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewHorizontal;
                @KeyboardViewHorizontal.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewHorizontal;
                @KeyboardViewVertical.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewVertical;
                @KeyboardViewVertical.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewVertical;
                @KeyboardViewVertical.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnKeyboardViewVertical;
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
                @KeyboardViewHorizontal.started += instance.OnKeyboardViewHorizontal;
                @KeyboardViewHorizontal.performed += instance.OnKeyboardViewHorizontal;
                @KeyboardViewHorizontal.canceled += instance.OnKeyboardViewHorizontal;
                @KeyboardViewVertical.started += instance.OnKeyboardViewVertical;
                @KeyboardViewVertical.performed += instance.OnKeyboardViewVertical;
                @KeyboardViewVertical.canceled += instance.OnKeyboardViewVertical;
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
    private readonly InputAction m_Interface_Interact;
    private readonly InputAction m_Interface_HelpMenu;
    public struct InterfaceActions
    {
        private @CustomCharacterInput m_Wrapper;
        public InterfaceActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Interface_Pause;
        public InputAction @Inventory => m_Wrapper.m_Interface_Inventory;
        public InputAction @GotoCommandMode => m_Wrapper.m_Interface_GotoCommandMode;
        public InputAction @Interact => m_Wrapper.m_Interface_Interact;
        public InputAction @HelpMenu => m_Wrapper.m_Interface_HelpMenu;
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
                @Interact.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnInteract;
                @HelpMenu.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnHelpMenu;
                @HelpMenu.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnHelpMenu;
                @HelpMenu.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnHelpMenu;
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
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @HelpMenu.started += instance.OnHelpMenu;
                @HelpMenu.performed += instance.OnHelpMenu;
                @HelpMenu.canceled += instance.OnHelpMenu;
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

    // Note
    private readonly InputActionMap m_Note;
    private INoteActions m_NoteActionsCallbackInterface;
    private readonly InputAction m_Note_Exit;
    public struct NoteActions
    {
        private @CustomCharacterInput m_Wrapper;
        public NoteActions(@CustomCharacterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Note_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Note; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NoteActions set) { return set.Get(); }
        public void SetCallbacks(INoteActions instance)
        {
            if (m_Wrapper.m_NoteActionsCallbackInterface != null)
            {
                @Exit.started -= m_Wrapper.m_NoteActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_NoteActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_NoteActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_NoteActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public NoteActions @Note => new NoteActions(this);
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
        void OnKeyboardViewHorizontal(InputAction.CallbackContext context);
        void OnKeyboardViewVertical(InputAction.CallbackContext context);
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
        void OnInteract(InputAction.CallbackContext context);
        void OnHelpMenu(InputAction.CallbackContext context);
    }
    public interface IDevelopActions
    {
        void OnUnlockCursorKey(InputAction.CallbackContext context);
    }
    public interface INoteActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
}
