// GENERATED AUTOMATICALLY FROM 'Assets/Input Actions/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""517a73c5-1f96-4ec6-8167-e6f7f08c9655"",
            ""actions"": [
                {
                    ""name"": ""MoveNorth"",
                    ""type"": ""Button"",
                    ""id"": ""ab6aa8d2-a23d-4c46-bdbf-2e9aa95caa55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""f34b15cc-6490-4a8f-9eab-54553ee7887e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSouth"",
                    ""type"": ""Button"",
                    ""id"": ""42b021c5-5db7-44d1-8bd4-33d1c19dc0b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""f8a4d5e8-ad01-4fb5-a564-27a1f2c1524b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c8ec9a8d-b23d-4c60-b51c-45ddd847e313"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e142fae3-65b9-43d7-af68-efbd56362341"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""074a9f82-1edf-482d-9776-a42d139e58ba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNorth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55257d93-0a71-4117-9bfd-d60d2b6ca1a5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveNorth = m_Player.FindAction("MoveNorth", throwIfNotFound: true);
        m_Player_MoveLeft = m_Player.FindAction("MoveLeft", throwIfNotFound: true);
        m_Player_MoveSouth = m_Player.FindAction("MoveSouth", throwIfNotFound: true);
        m_Player_MoveRight = m_Player.FindAction("MoveRight", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveNorth;
    private readonly InputAction m_Player_MoveLeft;
    private readonly InputAction m_Player_MoveSouth;
    private readonly InputAction m_Player_MoveRight;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveNorth => m_Wrapper.m_Player_MoveNorth;
        public InputAction @MoveLeft => m_Wrapper.m_Player_MoveLeft;
        public InputAction @MoveSouth => m_Wrapper.m_Player_MoveSouth;
        public InputAction @MoveRight => m_Wrapper.m_Player_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveNorth.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNorth;
                @MoveNorth.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNorth;
                @MoveNorth.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNorth;
                @MoveLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveSouth.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSouth;
                @MoveSouth.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSouth;
                @MoveSouth.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSouth;
                @MoveRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveNorth.started += instance.OnMoveNorth;
                @MoveNorth.performed += instance.OnMoveNorth;
                @MoveNorth.canceled += instance.OnMoveNorth;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveSouth.started += instance.OnMoveSouth;
                @MoveSouth.performed += instance.OnMoveSouth;
                @MoveSouth.canceled += instance.OnMoveSouth;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoveNorth(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveSouth(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
