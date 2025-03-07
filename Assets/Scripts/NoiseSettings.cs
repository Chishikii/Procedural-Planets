﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// general settings for the noise 

[System.Serializable]
public class NoiseSettings
{
    public enum FilterType { Simple,Ridgid};
    public FilterType filterType;

    public SimpleNoiseSettings simpleNoiseSettings;
    public RidgidNoiseSettings ridgidNoiseSettings;

    [System.Serializable]
    public class SimpleNoiseSettings
    {
        public float strenght = 1;
        [Range(1, 8)]
        public int numLayers = 1;
        public float baseRoughness = 1;
        public float roughness = 2;
        public float persistence = .5f;
        public Vector3 centre;
        public float minValue;
    }

    [System.Serializable]
    public class RidgidNoiseSettings : SimpleNoiseSettings
    {
        public float weightMultiplier = .8f;
    }
}
