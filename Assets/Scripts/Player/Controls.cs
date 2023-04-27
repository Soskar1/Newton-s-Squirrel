// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4585bf2d-5b08-4356-b322-5409a60673ad"",
            ""actions"": [
                {
                    ""name"": ""ChangeGravity"",
                    ""type"": ""Button"",
                    ""id"": ""b41e5b3b-e2aa-47d0-8ecd-d2f317ad02be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FromNegativeToPositive"",
                    ""type"": ""Button"",
                    ""id"": ""775fd059-af6a-4b0a-873d-de197194e254"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FromPositiveToNegative"",
                    ""type"": ""Button"",
                    ""id"": ""5371a45e-7550-4f56-970d-eeef9f722411"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d71a0431-db54-4e03-bf6e-61c63989dd7e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeGravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3798ef3-e63b-448a-b8f6-afc5589a7d7d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FromNegativeToPositive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a575b015-3fc7-4aa0-8be9-329675e49a35"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FromPositiveToNegative"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ChangeGravity = m_Player.FindAction("ChangeGravity", throwIfNotFound: true);
        m_Player_FromNegativeToPositive = m_Player.FindAction("FromNegativeToPositive", throwIfNotFound: true);
        m_Player_FromPositiveToNegative = m_Player.FindAction("FromPositiveToNegative", throwIfNotFound: true);
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
    private readonly InputAction m_Player_ChangeGravity;
    private readonly InputAction m_Player_FromNegativeToPositive;
    private readonly InputAction m_Player_FromPositiveToNegative;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeGravity => m_Wrapper.m_Player_ChangeGravity;
        public InputAction @FromNegativeToPositive => m_Wrapper.m_Player_FromNegativeToPositive;
        public InputAction @FromPositiveToNegative => m_Wrapper.m_Player_FromPositiveToNegative;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ChangeGravity.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeGravity;
                @ChangeGravity.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeGravity;
                @ChangeGravity.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeGravity;
                @FromNegativeToPositive.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromNegativeToPositive;
                @FromNegativeToPositive.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromNegativeToPositive;
                @FromNegativeToPositive.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromNegativeToPositive;
                @FromPositiveToNegative.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromPositiveToNegative;
                @FromPositiveToNegative.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromPositiveToNegative;
                @FromPositiveToNegative.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFromPositiveToNegative;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeGravity.started += instance.OnChangeGravity;
                @ChangeGravity.performed += instance.OnChangeGravity;
                @ChangeGravity.canceled += instance.OnChangeGravity;
                @FromNegativeToPositive.started += instance.OnFromNegativeToPositive;
                @FromNegativeToPositive.performed += instance.OnFromNegativeToPositive;
                @FromNegativeToPositive.canceled += instance.OnFromNegativeToPositive;
                @FromPositiveToNegative.started += instance.OnFromPositiveToNegative;
                @FromPositiveToNegative.performed += instance.OnFromPositiveToNegative;
                @FromPositiveToNegative.canceled += instance.OnFromPositiveToNegative;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnChangeGravity(InputAction.CallbackContext context);
        void OnFromNegativeToPositive(InputAction.CallbackContext context);
        void OnFromPositiveToNegative(InputAction.CallbackContext context);
    }
}
