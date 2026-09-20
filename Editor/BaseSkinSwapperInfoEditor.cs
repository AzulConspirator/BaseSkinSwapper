using System.IO;
using UnityEditor;
using UnityEngine;

namespace BaseSkinSwapperBuilder.CustomEditors
{
  [CustomEditor(typeof(BaseSkinSwapperInfo))]
  public class BaseSkinSwapperInfoEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      if (GUILayout.Button("Build"))
      {
        Build(serializedObject.targetObject as BaseSkinSwapperInfo);
      }
    }

    private void Build(BaseSkinSwapperInfo info)
    {
      if (info.assetInfo == null) info.InitializeAssetInfo();

      var path = Path.Combine(info.assetInfo.modFolder, info.modInfo.name + "BaseSkinSwapper.cs");

      var code = new BaseSkinSwapperTemplate(info);
      File.WriteAllText(path, code.TransformText());

      AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);

      Debug.Log("BaseSkinSwapper Build Finished");
    }
  }
}
