﻿using UnityEngine;

namespace TitleGame
{
    public sealed class TrailParticleBehaviour : ParticleBehaviour
    {
        [SerializeField] TrailRenderer[] trails;

        public override void OnParticleActivated()
        {

        }

        public override void OnParticleDisabled()
        {
            for (int i = 0; i < trails.Length; i++)
            {
                trails[i].Clear();
            }
        }
    }
}