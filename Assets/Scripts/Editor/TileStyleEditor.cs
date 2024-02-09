
using System.Linq;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;
using static Codice.Client.Common.Connection.AskCredentialsToUser;

[CustomEditor(typeof(TileStyle))]
public class TileStyleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TileStyle tileStyle = (TileStyle)target;

        EditorGUILayout.Space();

        if (tileStyle.Sprite != null)
        {
            GUILayout.Label("Preview:");
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            Rect previewRect = GUILayoutUtility.GetRect(100, 100);
            EditorGUI.DrawTextureTransparent(GUILayoutUtility.GetLastRect(), AssetPreview.GetAssetPreview(tileStyle.Sprite), ScaleMode.ScaleToFit);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    }
}
