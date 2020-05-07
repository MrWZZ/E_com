﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace HotFix
{
    public class HotFixEntity : 
        BaseEntity,
        IFilePathEntity,
        IAssetBundleEntity,
        ISceneEntity,
        IPanelEntity
    {
        public FilePathComponent FilePathComponent { get; private set; }
        public AssetBundleComponent AssetBundleComponent { get; private set; }
        public SceneComponent SceneComponent { get; private set; }
        public PanelComponent PanelComponent { get; private set; }

        public void Awake()
        {
            InitEntity();
            gameObject.AddComponent<OriginSceneEntity>().InitScene();
        }

        public override void InitEntity()
        {
            Global._HotFixEntity = this;

            FilePathComponent = Add<FilePathComponent, IFilePathEntity>(this);
            AssetBundleComponent = Add<AssetBundleComponent, IAssetBundleEntity>(this);
            SceneComponent = Add<SceneComponent, ISceneEntity>(this);
            PanelComponent = Add<PanelComponent, IPanelEntity>(this);
        }

    }

}
