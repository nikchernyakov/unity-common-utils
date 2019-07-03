/*
using UnityEditor;
using UnityEngine;

namespace Editor.Inspector
{
    [CustomEditor(typeof(Script))]
    public class TemplateEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
        
            var script = (Script) target;
            if(GUILayout.Button("Button name"))
            {
                script.foo();
            }
            
        }
    }
}
*/