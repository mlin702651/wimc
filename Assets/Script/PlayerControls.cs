// GENERATED AUTOMATICALLY FROM 'Assets/Animator/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""3b98194d-6872-408d-b4e0-7129775af387"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""424fb7f4-c174-40c5-a87f-ef5291792874"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HandMove"",
                    ""type"": ""Value"",
                    ""id"": ""be752f0c-f71c-4818-88bd-a2a0f86f5f57"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""d1af6ecf-61dc-4b10-9661-a355e02da0d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeaponPlus"",
                    ""type"": ""Value"",
                    ""id"": ""6a2355d8-64d4-46c3-aa38-473ffaafb553"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeaponLess"",
                    ""type"": ""Button"",
                    ""id"": ""718c687f-b519-4290-ad9c-664ee87a8ce1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa2ce391-eb13-4bb6-b3bb-175539d4767d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0cfa603f-2c51-4ea2-a5d1-461051f22798"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c43469b1-63b0-41d2-ba5a-49ef98d0f22e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a9e61548-10ac-4a29-a82d-9abd4005ab69"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""481e4f38-32bd-4d93-95ef-2a7ef63ebeb7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be9f7363-2d93-4396-b1e2-a577b4eebd39"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f616c6d-81ef-44d6-a783-8c0f3734818f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HandMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b28b913-4ac0-46d5-b5ea-afb3e226a8eb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4826b007-0052-4fa7-929b-d751e0813914"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46bfa621-ad94-412f-9942-0e35bae4c85e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94749d37-8237-4908-ae0b-eee8bae3704e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f2c92b-9b4b-4cd3-953e-56c0010d8092"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponLess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_Move = m_player.FindAction("Move", throwIfNotFound: true);
        m_player_HandMove = m_player.FindAction("HandMove", throwIfNotFound: true);
        m_player_Shoot = m_player.FindAction("Shoot", throwIfNotFound: true);
        m_player_SwitchWeaponPlus = m_player.FindAction("SwitchWeaponPlus", throwIfNotFound: true);
        m_player_SwitchWeaponLess = m_player.FindAction("SwitchWeaponLess", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_Move;
    private readonly InputAction m_player_HandMove;
    private readonly InputAction m_player_Shoot;
    private readonly InputAction m_player_SwitchWeaponPlus;
    private readonly InputAction m_player_SwitchWeaponLess;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_player_Move;
        public InputAction @HandMove => m_Wrapper.m_player_HandMove;
        public InputAction @Shoot => m_Wrapper.m_player_Shoot;
        public InputAction @SwitchWeaponPlus => m_Wrapper.m_player_SwitchWeaponPlus;
        public InputAction @SwitchWeaponLess => m_Wrapper.m_player_SwitchWeaponLess;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @HandMove.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandMove;
                @HandMove.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandMove;
                @HandMove.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandMove;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @SwitchWeaponPlus.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponPlus;
                @SwitchWeaponPlus.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponPlus;
                @SwitchWeaponPlus.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponPlus;
                @SwitchWeaponLess.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponLess;
                @SwitchWeaponLess.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponLess;
                @SwitchWeaponLess.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponLess;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @HandMove.started += instance.OnHandMove;
                @HandMove.performed += instance.OnHandMove;
                @HandMove.canceled += instance.OnHandMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @SwitchWeaponPlus.started += instance.OnSwitchWeaponPlus;
                @SwitchWeaponPlus.performed += instance.OnSwitchWeaponPlus;
                @SwitchWeaponPlus.canceled += instance.OnSwitchWeaponPlus;
                @SwitchWeaponLess.started += instance.OnSwitchWeaponLess;
                @SwitchWeaponLess.performed += instance.OnSwitchWeaponLess;
                @SwitchWeaponLess.canceled += instance.OnSwitchWeaponLess;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnHandMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSwitchWeaponPlus(InputAction.CallbackContext context);
        void OnSwitchWeaponLess(InputAction.CallbackContext context);
    }
}
