using UnityEditor;
using UnityEngine;
using L10n.Editor;

namespace SamplePlugin.Editors
{
    public class SampleSettingsWindow : EditorWindow
    {
        [MenuItem("Tools/SampleWindow")]
        public static void ShowWindow()
        {
            GetWindow<SampleSettingsWindow>("SampleSettingsWindow");
        }
        
        private static LocalizationProvider localizationProvider;
        
        [InitializeOnLoadMethod]
        private static void InitializeOnLoad()
        {
            localizationProvider ??= new LocalizationProvider();
            LocalizationManager.LoadLanguage();
        }
        
        private void OnGUI()
        {
            localizationProvider.OnGUI();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField(L10nHelper.Tr("sampleSettingsLabel"), EditorStyles.boldLabel);
            EditorGUILayout.Space();

            if (GUILayout.Button(L10nHelper.Tr("browseButton"), GUILayout.Width(80)))
            {
                Debug.Log(L10nHelper.Tr("click"));
            }
        }
    }
}
