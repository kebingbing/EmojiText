using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(EmojiText), true)]
[CanEditMultipleObjects]
public class EmojiEditor : GraphicEditor
{
    SerializedProperty m_Text;
    SerializedProperty m_FontData;
    SerializedProperty dletYscale;
    SerializedProperty sizeScale;
    SerializedProperty textasset;
    protected override void OnEnable()
    {
        base.OnEnable();
        m_Text = serializedObject.FindProperty("m_Text");
        m_FontData = serializedObject.FindProperty("m_FontData");
        dletYscale = serializedObject.FindProperty("deltYscale");
        sizeScale = serializedObject.FindProperty("sizeScale");
        textasset = serializedObject.FindProperty("textdata");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(m_Text);
        EditorGUILayout.PropertyField(m_FontData);
        EditorGUILayout.PropertyField(dletYscale);
        EditorGUILayout.PropertyField(sizeScale);
        EditorGUILayout.PropertyField(textasset);
        AppearanceControlsGUI();
        RaycastControlsGUI();
        serializedObject.ApplyModifiedProperties();
    }
}