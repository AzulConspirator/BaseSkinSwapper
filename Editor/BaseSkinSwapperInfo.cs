using System;
using System.Collections.Generic;
using UnityEngine;
using RoRSkinBuilder.Data;
using RuneFoxMods.RoRSkinBuilderExtension;

namespace BaseSkinSwapperBuilder
{
  [AddComponentMenu("RoR Skins/BaseSkinSwapperInfo")]
  public class BaseSkinSwapperInfo : ExtensionBase
  {
    ////////////////////////////////////////////////
    /// Inherited Override
    private static readonly string _name = "BaseSkinSwapper";
    public override string Name { get { return _name; } }
    ///
    ////////////////////////////////////////////////

    public SkinModInfo modInfo;

    public AssetsInfo assetInfo;

    [SerializeField]
    public List<_Skin> _SkinList = new List<_Skin>();

    [Serializable]
    public class _Skin
    {
      public SkinDefinition skinDef;
      public string CharacterSpawnCardPath;
    }
    // ---

    public BaseSkinSwapperInfo(SkinModInfo modinfo_)
    {
      modInfo = modinfo_;
      InitializeAssetInfo();
    }

    public BaseSkinSwapperInfo(BaseSkinSwapperInfo other)
    {
      modInfo = other.modInfo;
      _SkinList = other._SkinList;
      InitializeAssetInfo();
    }

    public void InitializeAssetInfo()
    {
      assetInfo = new AssetsInfo(modInfo);
    }
  }
}
