﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using Microsoft.MixedReality.Toolkit.Utilities;
using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Input
{
    [Serializable]
    public struct MixedRealityInputDataProviderConfiguration : IMixedRealityServiceConfiguration
    {
        [SerializeField]
        [Implements(typeof(IMixedRealityInputDeviceManager), TypeGrouping.ByNamespaceFlat)]
        private SystemType componentType;

        /// <inheritdoc />
        public SystemType ComponentType => componentType;

        [SerializeField]
        private string componentName;

        /// <inheritdoc />
        public string ComponentName => componentName;

        [SerializeField]
        private uint priority;

        /// <inheritdoc />
        public uint Priority => priority;

        [SerializeField]
        [EnumFlags]
        private SupportedPlatforms runtimePlatform;

        /// <inheritdoc />
        public SupportedPlatforms RuntimePlatform => runtimePlatform;

        [SerializeField]
        private BaseMixedRealityProfile deviceManagerProfile;

        /// <summary>
        /// Device manager specific configuration profile.
        /// </summary>
        public BaseMixedRealityProfile DeviceManagerProfile => deviceManagerProfile;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="componentType"></param>
        /// <param name="componentName"></param>
        /// <param name="priority"></param>
        /// <param name="runtimePlatform"></param>
        /// <param name="profile"></param>
        public MixedRealityInputDataProviderConfiguration(
            SystemType componentType,
            string componentName,
            uint priority,
            SupportedPlatforms runtimePlatform,
            BaseMixedRealityProfile profile)
        {
            this.componentType = componentType;
            this.componentName = componentName;
            this.priority = priority;
            this.runtimePlatform = runtimePlatform;
            deviceManagerProfile = profile;
        }
    }
}