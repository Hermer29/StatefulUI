namespace StatefulUI.Editor.Core
{
    public static class ExtensionGenerator
    {
        public static string GenerateStatefulView()
        {
            return new TypeGenerator()
                .AddUsing("StatefulUI.Runtime.Core")
                .AddUsing("StatefulUI.Runtime.References")
                .AddUsing("UnityEngine")
                .AddUsing("UnityEngine.UI")
                .AddUsing("UnityEngine.Video")
                .AddNameSpace("StatefulUISupport.Scripts.Components")
                .SetClass("StatefulView : MonoBehaviour, IStatefulView", true)
                .AddStatement("[SerializeField] private StatefulComponent _statefulComponent;")
                .AddStatement("public StatefulComponent StatefulComponent => _statefulComponent;")
                .AddStatement("public StatefulComponent GetInnerComponent(InnerComponentRole role) => _statefulComponent.GetInnerComponent(role);")
                .AddStatement("public StatefulComponent Get(InnerComponentRole role) => _statefulComponent.GetInnerComponent(role);")
                .AddStatement("public ContainerView GetContainer(ContainerRole role) => _statefulComponent.GetContainer(role).Container;")
                .AddStatement("public ContainerView Get(ContainerRole role) => _statefulComponent.GetContainer(role).Container;")
                .AddStatement("public Toggle GetToggle(ToggleRole role) => _statefulComponent.GetToggle(role).Toggle;")
                .AddStatement("public Toggle Get(ToggleRole role) => _statefulComponent.GetToggle(role).Toggle;")
                .AddStatement("public Slider GetSlider(SliderRole role) => _statefulComponent.GetSlider(role).Slider;")
                .AddStatement("public Slider Get(SliderRole role) => _statefulComponent.GetSlider(role).Slider;")
                .AddStatement("public Button GetButton(ButtonRole role) => _statefulComponent.GetButton(role).Button;")
                .AddStatement("public Button Get(ButtonRole role) => _statefulComponent.GetButton(role).Button;")
                .AddStatement("public GameObject GetObject(ObjectRole role) => _statefulComponent.GetObject(role).Object;")
                .AddStatement("public GameObject Get(ObjectRole role) => _statefulComponent.GetObject(role).Object;")
                .AddStatement("public Image GetImage(ImageRole role) => _statefulComponent.GetImage(role).Image;")
                .AddStatement("public Image Get(ImageRole role) => _statefulComponent.GetImage(role).Image;")
                .AddStatement("public Animator GetAnimator(AnimatorRole role) => _statefulComponent.GetAnimator(role).Animator;")
                .AddStatement("public VideoPlayer GetVideoPlayer(VideoPlayerRole role) => _statefulComponent.GetVideoPlayer(role).VideoPlayer;")
                .AddStatement("public VideoPlayer Get(VideoPlayerRole role) => _statefulComponent.GetVideoPlayer(role).VideoPlayer;")
                .AddStatement("public TextReference GetText(TextRole role) => _statefulComponent.GetText(role);")
                .AddStatement("public TextReference Get(TextRole role) => _statefulComponent.GetText(role);")
                .AddStatement("public TextInputReference GetTextInput(TextInputRole role) => _statefulComponent.GetTextInput(role);")
                .AddStatement("public TextInputReference Get(TextInputRole role) => _statefulComponent.GetTextInput(role);")
                .AddStatement("public DropdownReference GetDropdown(DropdownRole role) => _statefulComponent.GetDropdown(role);")
                .AddStatement("public DropdownReference Get(DropdownRole role) => _statefulComponent.GetDropdown(role);")
                .AddStatement("public bool HasState(StateRole role) => _statefulComponent.HasState((int) role);")
                .AddStatement("public float SetState(StateRole role) => _statefulComponent.SetState((int) role);")
                .AddStatement("public bool HasAnimator(AnimatorRole role) => _statefulComponent.HasAnimator(role);")
                .AddStatement("public bool HasVideoPlayer(VideoPlayerRole role) => _statefulComponent.HasVideoPlayer(role);")
                .AddStatement("public bool HasText(TextRole role) => _statefulComponent.HasText(role);")
                .AddStatement("public bool HasTextInput(TextInputRole role) => _statefulComponent.HasTextInput(role);")
                .AddStatement("public bool HasDropdown(DropdownRole role) => _statefulComponent.HasDropdown(role);")
                .AddStatement("public bool HasToggle(ToggleRole role) => _statefulComponent.HasToggle(role);")
                .AddStatement("public bool HasSlider(SliderRole role) => _statefulComponent.HasSlider(role);")
                .AddStatement("public bool HasButton(ButtonRole role) => _statefulComponent.HasButton(role);")
                .AddStatement("public bool HasObject(ObjectRole role) => _statefulComponent.HasObject(role);")
                .AddStatement("public bool HasImage(ImageRole role) => _statefulComponent.HasImage(role);")
                .AddStatement("public bool HasContainer(ContainerRole role) => _statefulComponent.HasContainer(role);")
                .AddStatement("public bool HasInnerComponent(InnerComponentRole role) => _statefulComponent.HasInnerComponent(role);")
                .AddStatement("public void SetText(TextRole role, object text) => _statefulComponent.SetText(role, text);")
                .AddStatement("public void SetTextValues(TextRole role, params object[] values) => _statefulComponent.SetTextValues(role, values);")
                .AddStatement("public void SetImage(ImageRole role, string spritePath) => _statefulComponent.SetImage(role, spritePath);")
                .AddStatement("public void SetImage(ImageRole role, Sprite sprite) => _statefulComponent.SetImage(role, sprite);")
                .AddStatement("private void OnValidate() => _statefulComponent ??= GetComponent<StatefulComponent>();")
                .AddBottom()
                .ToString();
        }
        
        public static string GenerateStatefulComponentExtensions()
        {
            return new TypeGenerator()
                .AddUsing("StatefulUI.Runtime.Core")
                .AddUsing("StatefulUI.Runtime.References")
                .AddUsing("UnityEngine")
                .AddNameSpace("StatefulUISupport.Scripts.Components")
                .SetStaticClass("StatefulComponentExtensions")
                .AddStatement("public static AnimatorReference GetAnimator(this StatefulComponent view, AnimatorRole role) => view.GetItem<AnimatorReference>((int)role);")
                .AddStatement("public static ButtonReference GetButton(this StatefulComponent view, ButtonRole role) => view.GetItem<ButtonReference>((int)role);")
                .AddStatement("public static ContainerReference GetContainer(this StatefulComponent view, ContainerRole role) => view.GetItem<ContainerReference>((int)role);")
                .AddStatement("public static DropdownReference GetDropdown(this StatefulComponent view, DropdownRole role) => view.GetItem<DropdownReference>((int)role);")
                .AddStatement("public static ImageReference GetImage(this StatefulComponent view, ImageRole role) => view.GetItem<ImageReference>((int)role);")
                .AddStatement("public static InnerComponentReference GetInnerComponentReference(this StatefulComponent view, InnerComponentRole role) => view.GetItem<InnerComponentReference>((int)role);")
                .AddStatement("public static StatefulComponent GetInnerComponent(this StatefulComponent view, InnerComponentRole role) => view.GetItem<InnerComponentReference>((int)role).InnerComponent;")
                .AddStatement("public static ObjectReference GetObject(this StatefulComponent view, ObjectRole role) => view.GetItem<ObjectReference>((int)role);")
                .AddStatement("public static SliderReference GetSlider(this StatefulComponent view, SliderRole role) => view.GetItem<SliderReference>((int)role);")
                .AddStatement("public static TextInputReference GetTextInput(this StatefulComponent view, TextInputRole role) => view.GetItem<TextInputReference>((int)role);")
                .AddStatement("public static TextReference GetText(this StatefulComponent view, TextRole role) => view.GetItem<TextReference>((int)role);")
                .AddStatement("public static ToggleReference GetToggle(this StatefulComponent view, ToggleRole role) => view.GetItem<ToggleReference>((int)role);")
                .AddStatement("public static VideoPlayerReference GetVideoPlayer(this StatefulComponent view, VideoPlayerRole role) => view.GetItem<VideoPlayerReference>((int)role);")
                .AddStatement("public static bool HasButton(this StatefulComponent view, ButtonRole role) => view.HasItem<ButtonReference>((int)role);")
                .AddStatement("public static bool HasContainer(this StatefulComponent view, ContainerRole role) => view.HasItem<ContainerReference>((int)role);")
                .AddStatement("public static bool HasDropdown(this StatefulComponent view, DropdownRole role) => view.HasItem<DropdownReference>((int)role);")
                .AddStatement("public static bool HasImage(this StatefulComponent view, ImageRole role) => view.HasItem<ImageReference>((int)role);")
                .AddStatement("public static bool HasInnerComponent(this StatefulComponent view, InnerComponentRole role) => view.HasItem<InnerComponentReference>((int)role);")
                .AddStatement("public static bool HasObject(this StatefulComponent view, ObjectRole role) => view.HasItem<ObjectReference>((int)role);")
                .AddStatement("public static bool HasSlider(this StatefulComponent view, SliderRole role) => view.HasItem<SliderReference>((int)role);")
                .AddStatement("public static bool HasTextInput(this StatefulComponent view, TextInputRole role) => view.HasItem<TextInputReference>((int)role);")
                .AddStatement("public static bool HasText(this StatefulComponent view, TextRole role) => view.HasItem<TextReference>((int)role);")
                .AddStatement("public static bool HasToggle(this StatefulComponent view, ToggleRole role) => view.HasItem<ToggleReference>((int)role);")
                .AddStatement("public static bool HasVideoPlayer(this StatefulComponent view, VideoPlayerRole role) => view.HasItem<VideoPlayerReference>((int)role);")
                .AddStatement("public static bool HasAnimator(this StatefulComponent view, AnimatorRole role) => view.HasItem<AnimatorReference>((int)role);")
                .AddStatement("public static void SetText(this StatefulComponent view, TextRole role, object text) => view.SetRawTextByRole((int)role, text);")
                .AddStatement("public static void SetTextValues(this StatefulComponent view, TextRole role, params object[] args) => view.SetRawTextValuesByRole((int)role, args);")
                .AddStatement("public static void SetImage(this StatefulComponent view, ImageRole role, string spritePath) => view.SetImageByRawRole((int)role, spritePath);")
                .AddStatement("public static void SetImage(this StatefulComponent view, ImageRole role, Sprite sprite) => view.SetImageByRawRole((int)role, sprite);")
                .AddBottom()
                .ToString();
        }
    }
}