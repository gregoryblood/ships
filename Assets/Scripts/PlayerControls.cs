// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""903d7fc9-5cf8-4598-80ec-d107b5023570"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2f3f0b1a-d347-4dab-960c-fef3e4f87248"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slow"",
                    ""type"": ""Button"",
                    ""id"": ""59d506f8-7f21-47b6-b112-cf7cc9396db6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speed"",
                    ""type"": ""Button"",
                    ""id"": ""9b452a02-6a7f-40ba-b9ff-65f97d75231a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cd6ea40-72ad-4058-89cd-5e72e321cf39"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36805d18-5d07-443f-b694-6ceae6a59a30"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abba6295-7961-4152-a1b2-168c0d79bac8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1bdc411-242c-434f-ba1b-98dd9725df24"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shooting"",
            ""id"": ""691b271e-72c9-4e81-80b8-0277e4498718"",
            ""actions"": [
                {
                    ""name"": ""ShootRight"",
                    ""type"": ""Button"",
                    ""id"": ""a772b0ba-e5f1-4da2-8df5-0675d8333f20"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6debe95f-841a-47d2-b3bc-238e6555791b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loading1"",
                    ""type"": ""Button"",
                    ""id"": ""99fd2d7e-079f-4801-ac0a-b25616a75f3f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loading2"",
                    ""type"": ""Button"",
                    ""id"": ""eea338f8-735a-4fa5-89b9-9c213255eecc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loading3"",
                    ""type"": ""Button"",
                    ""id"": ""42805b27-1fb8-4136-8aef-111a825016b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loading4"",
                    ""type"": ""Button"",
                    ""id"": ""2023aa84-db52-4c3b-9cd3-81e5e9ef2dca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loading5"",
                    ""type"": ""Value"",
                    ""id"": ""3d5fcd88-89be-4531-80b6-c59a1db6365c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5616122-e273-46a0-91d2-db6fab9f3417"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78217c0e-89ff-4737-b435-c3b2a716edc5"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c9383f5-dbfa-48ab-929c-5f23b570f4a8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a3d0603-0857-4661-b47d-5a1e54b3a7c6"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cb6dc92-fac5-4fbf-96f4-e3ed71131d06"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f154968-e926-41a8-a269-4048de948be4"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""059b08f7-e1bd-4359-a4c6-48523f84a099"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a8bfd2-ce62-43b9-a2cd-bf2c6dc32557"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d683d47b-bc08-4dca-8984-14edacf1729c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7d8de29-fde3-4f3f-9451-0c978c7c7b87"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cd3539d-3e3f-4c62-b6eb-9eb7b05094d2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""186f144a-a291-4df8-8ebf-d4adb09210be"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88f624e2-9dc5-4f99-97e0-f903d745e5ba"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loading5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moving
        m_Moving = asset.GetActionMap("Moving");
        m_Moving_Move = m_Moving.GetAction("Move");
        m_Moving_Slow = m_Moving.GetAction("Slow");
        m_Moving_Speed = m_Moving.GetAction("Speed");
        // Shooting
        m_Shooting = asset.GetActionMap("Shooting");
        m_Shooting_ShootRight = m_Shooting.GetAction("ShootRight");
        m_Shooting_ShootLeft = m_Shooting.GetAction("ShootLeft");
        m_Shooting_Loading1 = m_Shooting.GetAction("Loading1");
        m_Shooting_Loading2 = m_Shooting.GetAction("Loading2");
        m_Shooting_Loading3 = m_Shooting.GetAction("Loading3");
        m_Shooting_Loading4 = m_Shooting.GetAction("Loading4");
        m_Shooting_Loading5 = m_Shooting.GetAction("Loading5");
    }

    ~PlayerControls()
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

    // Moving
    private readonly InputActionMap m_Moving;
    private IMovingActions m_MovingActionsCallbackInterface;
    private readonly InputAction m_Moving_Move;
    private readonly InputAction m_Moving_Slow;
    private readonly InputAction m_Moving_Speed;
    public struct MovingActions
    {
        private PlayerControls m_Wrapper;
        public MovingActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Moving_Move;
        public InputAction @Slow => m_Wrapper.m_Moving_Slow;
        public InputAction @Speed => m_Wrapper.m_Moving_Speed;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void SetCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                Slow.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlow;
                Slow.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlow;
                Slow.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlow;
                Speed.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnSpeed;
                Speed.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnSpeed;
                Speed.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnSpeed;
            }
            m_Wrapper.m_MovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Slow.started += instance.OnSlow;
                Slow.performed += instance.OnSlow;
                Slow.canceled += instance.OnSlow;
                Speed.started += instance.OnSpeed;
                Speed.performed += instance.OnSpeed;
                Speed.canceled += instance.OnSpeed;
            }
        }
    }
    public MovingActions @Moving => new MovingActions(this);

    // Shooting
    private readonly InputActionMap m_Shooting;
    private IShootingActions m_ShootingActionsCallbackInterface;
    private readonly InputAction m_Shooting_ShootRight;
    private readonly InputAction m_Shooting_ShootLeft;
    private readonly InputAction m_Shooting_Loading1;
    private readonly InputAction m_Shooting_Loading2;
    private readonly InputAction m_Shooting_Loading3;
    private readonly InputAction m_Shooting_Loading4;
    private readonly InputAction m_Shooting_Loading5;
    public struct ShootingActions
    {
        private PlayerControls m_Wrapper;
        public ShootingActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootRight => m_Wrapper.m_Shooting_ShootRight;
        public InputAction @ShootLeft => m_Wrapper.m_Shooting_ShootLeft;
        public InputAction @Loading1 => m_Wrapper.m_Shooting_Loading1;
        public InputAction @Loading2 => m_Wrapper.m_Shooting_Loading2;
        public InputAction @Loading3 => m_Wrapper.m_Shooting_Loading3;
        public InputAction @Loading4 => m_Wrapper.m_Shooting_Loading4;
        public InputAction @Loading5 => m_Wrapper.m_Shooting_Loading5;
        public InputActionMap Get() { return m_Wrapper.m_Shooting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootingActions set) { return set.Get(); }
        public void SetCallbacks(IShootingActions instance)
        {
            if (m_Wrapper.m_ShootingActionsCallbackInterface != null)
            {
                ShootRight.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootRight;
                ShootRight.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootRight;
                ShootRight.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootRight;
                ShootLeft.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootLeft;
                ShootLeft.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootLeft;
                ShootLeft.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShootLeft;
                Loading1.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading1;
                Loading1.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading1;
                Loading1.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading1;
                Loading2.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading2;
                Loading2.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading2;
                Loading2.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading2;
                Loading3.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading3;
                Loading3.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading3;
                Loading3.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading3;
                Loading4.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading4;
                Loading4.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading4;
                Loading4.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading4;
                Loading5.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading5;
                Loading5.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading5;
                Loading5.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnLoading5;
            }
            m_Wrapper.m_ShootingActionsCallbackInterface = instance;
            if (instance != null)
            {
                ShootRight.started += instance.OnShootRight;
                ShootRight.performed += instance.OnShootRight;
                ShootRight.canceled += instance.OnShootRight;
                ShootLeft.started += instance.OnShootLeft;
                ShootLeft.performed += instance.OnShootLeft;
                ShootLeft.canceled += instance.OnShootLeft;
                Loading1.started += instance.OnLoading1;
                Loading1.performed += instance.OnLoading1;
                Loading1.canceled += instance.OnLoading1;
                Loading2.started += instance.OnLoading2;
                Loading2.performed += instance.OnLoading2;
                Loading2.canceled += instance.OnLoading2;
                Loading3.started += instance.OnLoading3;
                Loading3.performed += instance.OnLoading3;
                Loading3.canceled += instance.OnLoading3;
                Loading4.started += instance.OnLoading4;
                Loading4.performed += instance.OnLoading4;
                Loading4.canceled += instance.OnLoading4;
                Loading5.started += instance.OnLoading5;
                Loading5.performed += instance.OnLoading5;
                Loading5.canceled += instance.OnLoading5;
            }
        }
    }
    public ShootingActions @Shooting => new ShootingActions(this);
    public interface IMovingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSlow(InputAction.CallbackContext context);
        void OnSpeed(InputAction.CallbackContext context);
    }
    public interface IShootingActions
    {
        void OnShootRight(InputAction.CallbackContext context);
        void OnShootLeft(InputAction.CallbackContext context);
        void OnLoading1(InputAction.CallbackContext context);
        void OnLoading2(InputAction.CallbackContext context);
        void OnLoading3(InputAction.CallbackContext context);
        void OnLoading4(InputAction.CallbackContext context);
        void OnLoading5(InputAction.CallbackContext context);
    }
}
