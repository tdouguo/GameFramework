﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace UnityGameFramework
{
    public abstract class Entity : EntityLogic
    {
        [SerializeField]
        private EntityData m_EntityData = null;

        public int Id
        {
            get
            {
                return Entity.Id;
            }
        }

        public Animation CachedAnimation
        {
            get;
            private set;
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnInit(object userData)
#else
        protected internal override void OnInit(object userData)
#endif
        {
            base.OnInit(userData);
            CachedAnimation = GetComponent<Animation>();
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnShow(object userData)
#else
        protected internal override void OnShow(object userData)
#endif
        {
            base.OnShow(userData);

            m_EntityData = userData as EntityData;
            if (m_EntityData == null)
            {
                Log.Error("Entity data is invalid.");
                return;
            }

            Name = Utility.Text.Format("[Entity {0}]", Id.ToString());
            CachedTransform.localPosition = m_EntityData.Position;
            CachedTransform.localRotation = m_EntityData.Rotation;
            CachedTransform.localScale = Vector3.one;
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnHide(object userData)
#else
        protected internal override void OnHide(object userData)
#endif
        {
            base.OnHide(userData);
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
#else
        protected internal override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
#endif
        {
            base.OnAttached(childEntity, parentTransform, userData);
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnDetached(EntityLogic childEntity, object userData)
#else
        protected internal override void OnDetached(EntityLogic childEntity, object userData)
#endif
        {
            base.OnDetached(childEntity, userData);
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
#else
        protected internal override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
#endif
        {
            base.OnAttachTo(parentEntity, parentTransform, userData);
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnDetachFrom(EntityLogic parentEntity, object userData)
#else
        protected internal override void OnDetachFrom(EntityLogic parentEntity, object userData)
#endif
        {
            base.OnDetachFrom(parentEntity, userData);
        }

#if OVERRIDE_NO_INTERNAL
        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds) 
#else
        protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
#endif
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }
    }
}