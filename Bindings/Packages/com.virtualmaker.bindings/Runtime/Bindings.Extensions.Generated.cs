using System;
using System.Threading;
using UnityEngine;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindAimVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aimVector = v);
        public static void BindAimVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aimVector = transform(v));
        public static void BindUpVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.upVector = v);
        public static void BindUpVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.upVector = transform(v));
        public static void BindWorldUpType(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Animations.AimConstraint.WorldUpType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpType = v);
        public static void BindWorldUpType<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.AimConstraint.WorldUpType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpType = transform(v));
        public static void BindWorldUpVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpVector = v);
        public static void BindWorldUpVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpVector = transform(v));
        public static void BindWorldUpObject(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpObject = v);
        public static void BindWorldUpObject<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpObject = transform(v));
        public static void BindLocked(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindClip(this Animation obj, IProperty<UnityEngine.AnimationClip> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = v);
        public static void BindClip<T>(this Animation obj, IProperty<T> property, Func<T, UnityEngine.AnimationClip> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = transform(v));
        public static void BindPlayAutomatically(this Animation obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playAutomatically = v);
        public static void BindPlayAutomatically<T>(this Animation obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playAutomatically = transform(v));
        public static void BindAnimatePhysics(this Animation obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.animatePhysics = v);
        public static void BindAnimatePhysics<T>(this Animation obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.animatePhysics = transform(v));
        public static void BindCullingType(this Animation obj, IProperty<UnityEngine.AnimationCullingType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingType = v);
        public static void BindCullingType<T>(this Animation obj, IProperty<T> property, Func<T, UnityEngine.AnimationCullingType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingType = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindRuntimeAnimatorController(this Animator obj, IProperty<UnityEngine.RuntimeAnimatorController> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.runtimeAnimatorController = v);
        public static void BindRuntimeAnimatorController<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.RuntimeAnimatorController> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.runtimeAnimatorController = transform(v));
        public static void BindAvatar(this Animator obj, IProperty<UnityEngine.Avatar> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.avatar = v);
        public static void BindAvatar<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.Avatar> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.avatar = transform(v));
        public static void BindApplyRootMotion(this Animator obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.applyRootMotion = v);
        public static void BindApplyRootMotion<T>(this Animator obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.applyRootMotion = transform(v));
        public static void BindUpdateMode(this Animator obj, IProperty<UnityEngine.AnimatorUpdateMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.updateMode = v);
        public static void BindUpdateMode<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.AnimatorUpdateMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.updateMode = transform(v));
        public static void BindCullingMode(this Animator obj, IProperty<UnityEngine.AnimatorCullingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMode = v);
        public static void BindCullingMode<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.AnimatorCullingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMode = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this AreaEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = transform(v));
        public static void BindColliderMask(this AreaEffector2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = transform(v));
        public static void BindUseGlobalAngle(this AreaEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGlobalAngle = v);
        public static void BindUseGlobalAngle<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGlobalAngle = transform(v));
        public static void BindForceAngle(this AreaEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceAngle = v);
        public static void BindForceAngle<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceAngle = transform(v));
        public static void BindForceMagnitude(this AreaEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMagnitude = v);
        public static void BindForceMagnitude<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMagnitude = transform(v));
        public static void BindForceVariation(this AreaEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceVariation = v);
        public static void BindForceVariation<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceVariation = transform(v));
        public static void BindForceTarget(this AreaEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceTarget = v);
        public static void BindForceTarget<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceTarget = transform(v));
        #if !UNITY_6000_1_OR_NEWER
        public static void BindDrag(this AreaEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = v);
        public static void BindDrag<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = transform(v));
        #endif
        #if !UNITY_6000_1_OR_NEWER
        public static void BindAngularDrag(this AreaEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = transform(v));
        #endif
        #endif


        #if UNITY_2020_3_OR_NEWER&&UNITY_PHYSICS
        public static void BindMass(this ArticulationBody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = v);
        public static void BindMass<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = transform(v));
        public static void BindUseGravity(this ArticulationBody obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = transform(v));
        public static void BindImmovable(this ArticulationBody obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.immovable = v);
        public static void BindImmovable<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.immovable = transform(v));
        public static void BindLinearDamping(this ArticulationBody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = transform(v));
        public static void BindAngularDamping(this ArticulationBody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = transform(v));
        public static void BindCollisionDetectionMode(this ArticulationBody obj, IProperty<UnityEngine.CollisionDetectionMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this ArticulationBody obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindDryMix(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryMix = v);
        public static void BindDryMix<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryMix = transform(v));
        public static void BindWetMix1(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix1 = v);
        public static void BindWetMix1<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix1 = transform(v));
        public static void BindWetMix2(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix2 = v);
        public static void BindWetMix2<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix2 = transform(v));
        public static void BindWetMix3(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix3 = v);
        public static void BindWetMix3<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix3 = transform(v));
        public static void BindDelay(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.delay = v);
        public static void BindDelay<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.delay = transform(v));
        public static void BindRate(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rate = v);
        public static void BindRate<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rate = transform(v));
        public static void BindDepth(this AudioChorusFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.depth = v);
        public static void BindDepth<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.depth = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindDistortionLevel(this AudioDistortionFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distortionLevel = v);
        public static void BindDistortionLevel<T>(this AudioDistortionFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distortionLevel = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindDelay(this AudioEchoFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.delay = v);
        public static void BindDelay<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.delay = transform(v));
        public static void BindDecayRatio(this AudioEchoFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayRatio = v);
        public static void BindDecayRatio<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayRatio = transform(v));
        public static void BindDryMix(this AudioEchoFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryMix = v);
        public static void BindDryMix<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryMix = transform(v));
        public static void BindWetMix(this AudioEchoFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix = v);
        public static void BindWetMix<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wetMix = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindCutoffFrequency(this AudioHighPassFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cutoffFrequency = v);
        public static void BindCutoffFrequency<T>(this AudioHighPassFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cutoffFrequency = transform(v));
        public static void BindHighpassResonanceQ(this AudioHighPassFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highpassResonanceQ = v);
        public static void BindHighpassResonanceQ<T>(this AudioHighPassFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highpassResonanceQ = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindCutoffFrequency(this AudioLowPassFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cutoffFrequency = v);
        public static void BindCutoffFrequency<T>(this AudioLowPassFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cutoffFrequency = transform(v));
        public static void BindLowpassResonanceQ(this AudioLowPassFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowpassResonanceQ = v);
        public static void BindLowpassResonanceQ<T>(this AudioLowPassFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowpassResonanceQ = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindReverbPreset(this AudioReverbFilter obj, IProperty<UnityEngine.AudioReverbPreset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbPreset = v);
        public static void BindReverbPreset<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, UnityEngine.AudioReverbPreset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbPreset = transform(v));
        public static void BindDryLevel(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryLevel = v);
        public static void BindDryLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dryLevel = transform(v));
        public static void BindRoom(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.room = v);
        public static void BindRoom<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.room = transform(v));
        public static void BindRoomHF(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomHF = v);
        public static void BindRoomHF<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomHF = transform(v));
        public static void BindRoomLF(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomLF = v);
        public static void BindRoomLF<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomLF = transform(v));
        public static void BindDecayTime(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayTime = v);
        public static void BindDecayTime<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayTime = transform(v));
        public static void BindDecayHFRatio(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayHFRatio = v);
        public static void BindDecayHFRatio<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayHFRatio = transform(v));
        public static void BindReflectionsLevel(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsLevel = v);
        public static void BindReflectionsLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsLevel = transform(v));
        public static void BindReflectionsDelay(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsDelay = v);
        public static void BindReflectionsDelay<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsDelay = transform(v));
        public static void BindReverbLevel(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbLevel = v);
        public static void BindReverbLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbLevel = transform(v));
        public static void BindReverbDelay(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbDelay = v);
        public static void BindReverbDelay<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbDelay = transform(v));
        public static void BindHfReference(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.hfReference = v);
        public static void BindHfReference<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.hfReference = transform(v));
        public static void BindLfReference(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lfReference = v);
        public static void BindLfReference<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lfReference = transform(v));
        public static void BindDiffusion(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.diffusion = v);
        public static void BindDiffusion<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.diffusion = transform(v));
        public static void BindDensity(this AudioReverbFilter obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = v);
        public static void BindDensity<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindMinDistance(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = transform(v));
        public static void BindMaxDistance(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = transform(v));
        public static void BindReverbPreset(this AudioReverbZone obj, IProperty<UnityEngine.AudioReverbPreset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbPreset = v);
        public static void BindReverbPreset<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, UnityEngine.AudioReverbPreset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbPreset = transform(v));
        public static void BindRoom(this AudioReverbZone obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.room = v);
        public static void BindRoom<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.room = transform(v));
        public static void BindRoomHF(this AudioReverbZone obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomHF = v);
        public static void BindRoomHF<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomHF = transform(v));
        public static void BindRoomLF(this AudioReverbZone obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomLF = v);
        public static void BindRoomLF<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roomLF = transform(v));
        public static void BindDecayTime(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayTime = v);
        public static void BindDecayTime<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayTime = transform(v));
        public static void BindDecayHFRatio(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayHFRatio = v);
        public static void BindDecayHFRatio<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decayHFRatio = transform(v));
        public static void BindReflections(this AudioReverbZone obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflections = v);
        public static void BindReflections<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflections = transform(v));
        public static void BindReflectionsDelay(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsDelay = v);
        public static void BindReflectionsDelay<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionsDelay = transform(v));
        public static void BindReverb(this AudioReverbZone obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverb = v);
        public static void BindReverb<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverb = transform(v));
        public static void BindReverbDelay(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbDelay = v);
        public static void BindReverbDelay<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbDelay = transform(v));
        public static void BindHFReference(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.HFReference = v);
        public static void BindHFReference<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.HFReference = transform(v));
        public static void BindLFReference(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.LFReference = v);
        public static void BindLFReference<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.LFReference = transform(v));
        public static void BindDiffusion(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.diffusion = v);
        public static void BindDiffusion<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.diffusion = transform(v));
        public static void BindDensity(this AudioReverbZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = v);
        public static void BindDensity<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = transform(v));
        #endif


        #if UNITY_AUDIO
        public static void BindClip(this AudioSource obj, IProperty<UnityEngine.AudioClip> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = v);
        public static void BindClip<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.AudioClip> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = transform(v));
        public static void BindOutputAudioMixerGroup(this AudioSource obj, IProperty<UnityEngine.Audio.AudioMixerGroup> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.outputAudioMixerGroup = v);
        public static void BindOutputAudioMixerGroup<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.Audio.AudioMixerGroup> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.outputAudioMixerGroup = transform(v));
        public static void BindMute(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mute = v);
        public static void BindMute<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mute = transform(v));
        public static void BindBypassEffects(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassEffects = v);
        public static void BindBypassEffects<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassEffects = transform(v));
        public static void BindBypassListenerEffects(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassListenerEffects = v);
        public static void BindBypassListenerEffects<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassListenerEffects = transform(v));
        public static void BindBypassReverbZones(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassReverbZones = v);
        public static void BindBypassReverbZones<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bypassReverbZones = transform(v));
        public static void BindPlayOnAwake(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = transform(v));
        public static void BindLoop(this AudioSource obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.loop = v);
        public static void BindLoop<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.loop = transform(v));
        public static void BindPriority(this AudioSource obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.priority = v);
        public static void BindPriority<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.priority = transform(v));
        public static void BindVolume(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.volume = v);
        public static void BindVolume<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.volume = transform(v));
        public static void BindPitch(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pitch = v);
        public static void BindPitch<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pitch = transform(v));
        public static void BindPanStereo(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.panStereo = v);
        public static void BindPanStereo<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.panStereo = transform(v));
        public static void BindSpatialBlend(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spatialBlend = v);
        public static void BindSpatialBlend<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spatialBlend = transform(v));
        public static void BindReverbZoneMix(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbZoneMix = v);
        public static void BindReverbZoneMix<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reverbZoneMix = transform(v));
        public static void BindDopplerLevel(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dopplerLevel = v);
        public static void BindDopplerLevel<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dopplerLevel = transform(v));
        public static void BindSpread(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spread = v);
        public static void BindSpread<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spread = transform(v));
        public static void BindRolloffMode(this AudioSource obj, IProperty<UnityEngine.AudioRolloffMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rolloffMode = v);
        public static void BindRolloffMode<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.AudioRolloffMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rolloffMode = transform(v));
        public static void BindMinDistance(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = transform(v));
        public static void BindMaxDistance(this AudioSource obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this BoxCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this BoxCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this BoxCollider obj, IProperty<PhysicMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this BoxCollider obj, IProperty<PhysicsMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        public static void BindCenter(this BoxCollider obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this BoxCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindSize(this BoxCollider obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this BoxCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this BoxCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this BoxCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this BoxCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this BoxCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this BoxCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this BoxCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindAutoTiling(this BoxCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTiling = v);
        public static void BindAutoTiling<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTiling = transform(v));
        public static void BindSize(this BoxCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindEdgeRadius(this BoxCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = transform(v));
        #endif


        public static void BindBillboard(this BillboardRenderer obj, IProperty<UnityEngine.BillboardAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.billboard = v);
        public static void BindBillboard<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.BillboardAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.billboard = transform(v));
        public static void BindShadowCastingMode(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = transform(v));
        public static void BindReceiveShadows(this BillboardRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = transform(v));
        public static void BindLightProbeUsage(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindMotionVectorGenerationMode(this BillboardRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this BillboardRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = transform(v));


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this BuoyancyEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = transform(v));
        public static void BindColliderMask(this BuoyancyEffector2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = transform(v));
        public static void BindDensity(this BuoyancyEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = v);
        public static void BindDensity<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.density = transform(v));
        public static void BindSurfaceLevel(this BuoyancyEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.surfaceLevel = v);
        public static void BindSurfaceLevel<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.surfaceLevel = transform(v));
        public static void BindFlowAngle(this BuoyancyEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowAngle = v);
        public static void BindFlowAngle<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowAngle = transform(v));
        public static void BindFlowMagnitude(this BuoyancyEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowMagnitude = v);
        public static void BindFlowMagnitude<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowMagnitude = transform(v));
        public static void BindFlowVariation(this BuoyancyEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowVariation = v);
        public static void BindFlowVariation<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flowVariation = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Button obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        #endif


        public static void BindClearFlags(this Camera obj, IProperty<UnityEngine.CameraClearFlags> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clearFlags = v);
        public static void BindClearFlags<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.CameraClearFlags> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clearFlags = transform(v));
        public static void BindBackgroundColor(this Camera obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.backgroundColor = v);
        public static void BindBackgroundColor<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.backgroundColor = transform(v));
        public static void BindCullingMask(this Camera obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this Camera obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = transform(v));
        public static void BindOrthographic(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographic = v);
        public static void BindOrthographic<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographic = transform(v));
        public static void BindFieldOfView(this Camera obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fieldOfView = v);
        public static void BindFieldOfView<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fieldOfView = transform(v));
        public static void BindUsePhysicalProperties(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usePhysicalProperties = v);
        public static void BindUsePhysicalProperties<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usePhysicalProperties = transform(v));
        public static void BindNearClipPlane(this Camera obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = transform(v));
        public static void BindFarClipPlane(this Camera obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = transform(v));
        public static void BindRect(this Camera obj, IProperty<UnityEngine.Rect> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rect = v);
        public static void BindRect<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.Rect> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rect = transform(v));
        public static void BindDepth(this Camera obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.depth = v);
        public static void BindDepth<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.depth = transform(v));
        public static void BindRenderingPath(this Camera obj, IProperty<UnityEngine.RenderingPath> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderingPath = v);
        public static void BindRenderingPath<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.RenderingPath> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderingPath = transform(v));
        public static void BindTargetTexture(this Camera obj, IProperty<UnityEngine.RenderTexture> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetTexture = v);
        public static void BindTargetTexture<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.RenderTexture> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetTexture = transform(v));
        public static void BindUseOcclusionCulling(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOcclusionCulling = v);
        public static void BindUseOcclusionCulling<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOcclusionCulling = transform(v));
        public static void BindAllowHDR(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowHDR = v);
        public static void BindAllowHDR<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowHDR = transform(v));
        public static void BindAllowMSAA(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowMSAA = v);
        public static void BindAllowMSAA<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowMSAA = transform(v));
        public static void BindAllowDynamicResolution(this Camera obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowDynamicResolution = v);
        public static void BindAllowDynamicResolution<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowDynamicResolution = transform(v));
        public static void BindTargetDisplay(this Camera obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetDisplay = v);
        public static void BindTargetDisplay<T>(this Camera obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetDisplay = transform(v));


        #if UNITY_UI
        public static void BindRenderMode(this Canvas obj, IProperty<UnityEngine.RenderMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.RenderMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = transform(v));
        public static void BindWorldCamera(this Canvas obj, IProperty<UnityEngine.Camera> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldCamera = v);
        public static void BindWorldCamera<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.Camera> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldCamera = transform(v));
        public static void BindPixelPerfect(this Canvas obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pixelPerfect = v);
        public static void BindPixelPerfect<T>(this Canvas obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pixelPerfect = transform(v));
        public static void BindSortingOrder(this Canvas obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this Canvas obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));
        public static void BindTargetDisplay(this Canvas obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetDisplay = v);
        public static void BindTargetDisplay<T>(this Canvas obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetDisplay = transform(v));
        public static void BindAdditionalShaderChannels(this Canvas obj, IProperty<UnityEngine.AdditionalCanvasShaderChannels> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.additionalShaderChannels = v);
        public static void BindAdditionalShaderChannels<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.AdditionalCanvasShaderChannels> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.additionalShaderChannels = transform(v));
        #endif


        #if UNITY_UI
        public static void BindAlpha(this CanvasGroup obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alpha = v);
        public static void BindAlpha<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alpha = transform(v));
        public static void BindInteractable(this CanvasGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindBlocksRaycasts(this CanvasGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blocksRaycasts = v);
        public static void BindBlocksRaycasts<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blocksRaycasts = transform(v));
        public static void BindIgnoreParentGroups(this CanvasGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreParentGroups = v);
        public static void BindIgnoreParentGroups<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreParentGroups = transform(v));
        #endif


        #if UNITY_UI
        public static void BindCullTransparentMesh(this CanvasRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullTransparentMesh = v);
        public static void BindCullTransparentMesh<T>(this CanvasRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullTransparentMesh = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindUiScaleMode(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.ScaleMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.uiScaleMode = v);
        public static void BindUiScaleMode<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.ScaleMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.uiScaleMode = transform(v));
        public static void BindScaleFactor(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleFactor = v);
        public static void BindScaleFactor<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleFactor = transform(v));
        public static void BindReferenceResolution(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.referenceResolution = v);
        public static void BindReferenceResolution<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.referenceResolution = transform(v));
        public static void BindScreenMatchMode(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.ScreenMatchMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.screenMatchMode = v);
        public static void BindScreenMatchMode<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.ScreenMatchMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.screenMatchMode = transform(v));
        public static void BindPhysicalUnit(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.Unit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.physicalUnit = v);
        public static void BindPhysicalUnit<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.Unit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.physicalUnit = transform(v));
        public static void BindFallbackScreenDPI(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fallbackScreenDPI = v);
        public static void BindFallbackScreenDPI<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fallbackScreenDPI = transform(v));
        public static void BindDefaultSpriteDPI(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.defaultSpriteDPI = v);
        public static void BindDefaultSpriteDPI<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.defaultSpriteDPI = transform(v));
        public static void BindReferencePixelsPerUnit(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.referencePixelsPerUnit = v);
        public static void BindReferencePixelsPerUnit<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.referencePixelsPerUnit = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this CapsuleCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this CapsuleCollider obj, IProperty<PhysicMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this CapsuleCollider obj, IProperty<PhysicsMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        public static void BindCenter(this CapsuleCollider obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindRadius(this CapsuleCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        public static void BindHeight(this CapsuleCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = v);
        public static void BindHeight<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = transform(v));
        public static void BindDirection(this CapsuleCollider obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = v);
        public static void BindDirection<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CapsuleCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this CapsuleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this CapsuleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CapsuleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CapsuleCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this CapsuleCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindSize(this CapsuleCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindDirection(this CapsuleCollider2D obj, IProperty<UnityEngine.CapsuleDirection2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = v);
        public static void BindDirection<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CapsuleDirection2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindSlopeLimit(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.slopeLimit = v);
        public static void BindSlopeLimit<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.slopeLimit = transform(v));
        public static void BindStepOffset(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stepOffset = v);
        public static void BindStepOffset<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stepOffset = transform(v));
        public static void BindSkinWidth(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.skinWidth = v);
        public static void BindSkinWidth<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.skinWidth = transform(v));
        public static void BindMinMoveDistance(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minMoveDistance = v);
        public static void BindMinMoveDistance<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minMoveDistance = transform(v));
        public static void BindCenter(this CharacterController obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this CharacterController obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindRadius(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        public static void BindHeight(this CharacterController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = v);
        public static void BindHeight<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this CharacterJoint obj, IProperty<UnityEngine.Rigidbody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this CharacterJoint obj, IProperty<UnityEngine.ArticulationBody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = transform(v));
        #endif
        public static void BindAnchor(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindAxis(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = v);
        public static void BindAxis<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this CharacterJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindConnectedAnchor(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindSwingAxis(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swingAxis = v);
        public static void BindSwingAxis<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swingAxis = transform(v));
        public static void BindTwistLimitSpring(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.twistLimitSpring = v);
        public static void BindTwistLimitSpring<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.twistLimitSpring = transform(v));
        public static void BindLowTwistLimit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowTwistLimit = v);
        public static void BindLowTwistLimit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowTwistLimit = transform(v));
        public static void BindHighTwistLimit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highTwistLimit = v);
        public static void BindHighTwistLimit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highTwistLimit = transform(v));
        public static void BindSwingLimitSpring(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swingLimitSpring = v);
        public static void BindSwingLimitSpring<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swingLimitSpring = transform(v));
        public static void BindSwing1Limit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swing1Limit = v);
        public static void BindSwing1Limit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swing1Limit = transform(v));
        public static void BindSwing2Limit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swing2Limit = v);
        public static void BindSwing2Limit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swing2Limit = transform(v));
        public static void BindEnableProjection(this CharacterJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableProjection = v);
        public static void BindEnableProjection<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableProjection = transform(v));
        public static void BindProjectionDistance(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionDistance = v);
        public static void BindProjectionDistance<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionDistance = transform(v));
        public static void BindProjectionAngle(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionAngle = v);
        public static void BindProjectionAngle<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionAngle = transform(v));
        public static void BindBreakForce(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        public static void BindEnableCollision(this CharacterJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindEnablePreprocessing(this CharacterJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = transform(v));
        public static void BindMassScale(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = v);
        public static void BindMassScale<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = transform(v));
        public static void BindConnectedMassScale(this CharacterJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CircleCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this CircleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this CircleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CircleCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CircleCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this CircleCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindRadius(this CircleCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        #endif


        #if UNITY_CLOTH
        public static void BindStretchingStiffness(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stretchingStiffness = v);
        public static void BindStretchingStiffness<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stretchingStiffness = transform(v));
        public static void BindBendingStiffness(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bendingStiffness = v);
        public static void BindBendingStiffness<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bendingStiffness = transform(v));
        public static void BindUseTethers(this Cloth obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useTethers = v);
        public static void BindUseTethers<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useTethers = transform(v));
        public static void BindUseGravity(this Cloth obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = transform(v));
        public static void BindDamping(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.damping = v);
        public static void BindDamping<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.damping = transform(v));
        public static void BindExternalAcceleration(this Cloth obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.externalAcceleration = v);
        public static void BindExternalAcceleration<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.externalAcceleration = transform(v));
        public static void BindRandomAcceleration(this Cloth obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.randomAcceleration = v);
        public static void BindRandomAcceleration<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.randomAcceleration = transform(v));
        public static void BindWorldVelocityScale(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldVelocityScale = v);
        public static void BindWorldVelocityScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldVelocityScale = transform(v));
        public static void BindWorldAccelerationScale(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldAccelerationScale = v);
        public static void BindWorldAccelerationScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldAccelerationScale = transform(v));
        public static void BindFriction(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.friction = v);
        public static void BindFriction<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.friction = transform(v));
        public static void BindCollisionMassScale(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionMassScale = v);
        public static void BindCollisionMassScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionMassScale = transform(v));
        public static void BindEnableContinuousCollision(this Cloth obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableContinuousCollision = v);
        public static void BindEnableContinuousCollision<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableContinuousCollision = transform(v));
        public static void BindUseVirtualParticles(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useVirtualParticles = v);
        public static void BindUseVirtualParticles<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useVirtualParticles = transform(v));
        public static void BindClothSolverFrequency(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clothSolverFrequency = v);
        public static void BindClothSolverFrequency<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clothSolverFrequency = transform(v));
        public static void BindSleepThreshold(this Cloth obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sleepThreshold = v);
        public static void BindSleepThreshold<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sleepThreshold = transform(v));
        public static void BindCapsuleColliders(this Cloth obj, IProperty<UnityEngine.CapsuleCollider[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.capsuleColliders = v);
        public static void BindCapsuleColliders<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.CapsuleCollider[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.capsuleColliders = transform(v));
        public static void BindSphereColliders(this Cloth obj, IProperty<UnityEngine.ClothSphereColliderPair[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sphereColliders = v);
        public static void BindSphereColliders<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.ClothSphereColliderPair[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sphereColliders = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CompositeCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this CompositeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this CompositeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CompositeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CompositeCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this CompositeCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindGeometryType(this CompositeCollider2D obj, IProperty<UnityEngine.CompositeCollider2D.GeometryType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometryType = v);
        public static void BindGeometryType<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CompositeCollider2D.GeometryType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometryType = transform(v));
        public static void BindGenerationType(this CompositeCollider2D obj, IProperty<UnityEngine.CompositeCollider2D.GenerationType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generationType = v);
        public static void BindGenerationType<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CompositeCollider2D.GenerationType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generationType = transform(v));
        public static void BindVertexDistance(this CompositeCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vertexDistance = v);
        public static void BindVertexDistance<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vertexDistance = transform(v));
        public static void BindOffsetDistance(this CompositeCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offsetDistance = v);
        public static void BindOffsetDistance<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offsetDistance = transform(v));
        public static void BindEdgeRadius(this CompositeCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this ConfigurableJoint obj, IProperty<UnityEngine.Rigidbody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this ConfigurableJoint obj, IProperty<UnityEngine.ArticulationBody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = transform(v));
        #endif
        public static void BindAnchor(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindAxis(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = v);
        public static void BindAxis<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this ConfigurableJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindConnectedAnchor(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindXMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.xMotion = v);
        public static void BindXMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.xMotion = transform(v));
        public static void BindYMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.yMotion = v);
        public static void BindYMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.yMotion = transform(v));
        public static void BindZMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.zMotion = v);
        public static void BindZMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.zMotion = transform(v));
        public static void BindAngularXMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXMotion = v);
        public static void BindAngularXMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXMotion = transform(v));
        public static void BindAngularYMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYMotion = v);
        public static void BindAngularYMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYMotion = transform(v));
        public static void BindAngularZMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularZMotion = v);
        public static void BindAngularZMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularZMotion = transform(v));
        public static void BindLinearLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearLimitSpring = v);
        public static void BindLinearLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearLimitSpring = transform(v));
        public static void BindLinearLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearLimit = v);
        public static void BindLinearLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearLimit = transform(v));
        public static void BindAngularXLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXLimitSpring = v);
        public static void BindAngularXLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXLimitSpring = transform(v));
        public static void BindLowAngularXLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowAngularXLimit = v);
        public static void BindLowAngularXLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lowAngularXLimit = transform(v));
        public static void BindHighAngularXLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highAngularXLimit = v);
        public static void BindHighAngularXLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.highAngularXLimit = transform(v));
        public static void BindAngularYZLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYZLimitSpring = v);
        public static void BindAngularYZLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYZLimitSpring = transform(v));
        public static void BindAngularYLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYLimit = v);
        public static void BindAngularYLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYLimit = transform(v));
        public static void BindAngularZLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularZLimit = v);
        public static void BindAngularZLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularZLimit = transform(v));
        public static void BindTargetPosition(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetPosition = v);
        public static void BindTargetPosition<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetPosition = transform(v));
        public static void BindTargetVelocity(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetVelocity = v);
        public static void BindTargetVelocity<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetVelocity = transform(v));
        public static void BindXDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.xDrive = v);
        public static void BindXDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.xDrive = transform(v));
        public static void BindYDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.yDrive = v);
        public static void BindYDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.yDrive = transform(v));
        public static void BindZDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.zDrive = v);
        public static void BindZDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.zDrive = transform(v));
        public static void BindTargetRotation(this ConfigurableJoint obj, IProperty<UnityEngine.Quaternion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetRotation = v);
        public static void BindTargetRotation<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetRotation = transform(v));
        public static void BindTargetAngularVelocity(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetAngularVelocity = v);
        public static void BindTargetAngularVelocity<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetAngularVelocity = transform(v));
        public static void BindRotationDriveMode(this ConfigurableJoint obj, IProperty<UnityEngine.RotationDriveMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationDriveMode = v);
        public static void BindRotationDriveMode<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.RotationDriveMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationDriveMode = transform(v));
        public static void BindAngularXDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXDrive = v);
        public static void BindAngularXDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularXDrive = transform(v));
        public static void BindAngularYZDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYZDrive = v);
        public static void BindAngularYZDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularYZDrive = transform(v));
        public static void BindSlerpDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.slerpDrive = v);
        public static void BindSlerpDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.slerpDrive = transform(v));
        public static void BindProjectionMode(this ConfigurableJoint obj, IProperty<UnityEngine.JointProjectionMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionMode = v);
        public static void BindProjectionMode<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointProjectionMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionMode = transform(v));
        public static void BindProjectionDistance(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionDistance = v);
        public static void BindProjectionDistance<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionDistance = transform(v));
        public static void BindProjectionAngle(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionAngle = v);
        public static void BindProjectionAngle<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.projectionAngle = transform(v));
        public static void BindConfiguredInWorldSpace(this ConfigurableJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.configuredInWorldSpace = v);
        public static void BindConfiguredInWorldSpace<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.configuredInWorldSpace = transform(v));
        public static void BindSwapBodies(this ConfigurableJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swapBodies = v);
        public static void BindSwapBodies<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.swapBodies = transform(v));
        public static void BindBreakForce(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        public static void BindEnableCollision(this ConfigurableJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindEnablePreprocessing(this ConfigurableJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = transform(v));
        public static void BindMassScale(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = v);
        public static void BindMassScale<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = transform(v));
        public static void BindConnectedMassScale(this ConfigurableJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindForce(this ConstantForce obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.force = v);
        public static void BindForce<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.force = transform(v));
        public static void BindRelativeForce(this ConstantForce obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeForce = v);
        public static void BindRelativeForce<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeForce = transform(v));
        public static void BindTorque(this ConstantForce obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.torque = v);
        public static void BindTorque<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.torque = transform(v));
        public static void BindRelativeTorque(this ConstantForce obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeTorque = v);
        public static void BindRelativeTorque<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeTorque = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindForce(this ConstantForce2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.force = v);
        public static void BindForce<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.force = transform(v));
        public static void BindRelativeForce(this ConstantForce2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeForce = v);
        public static void BindRelativeForce<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.relativeForce = transform(v));
        public static void BindTorque(this ConstantForce2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.torque = v);
        public static void BindTorque<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.torque = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindHorizontalFit(this UnityEngine.UI.ContentSizeFitter obj, IProperty<UnityEngine.UI.ContentSizeFitter.FitMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalFit = v);
        public static void BindHorizontalFit<T>(this UnityEngine.UI.ContentSizeFitter obj, IProperty<T> property, Func<T, UnityEngine.UI.ContentSizeFitter.FitMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalFit = transform(v));
        public static void BindVerticalFit(this UnityEngine.UI.ContentSizeFitter obj, IProperty<UnityEngine.UI.ContentSizeFitter.FitMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalFit = v);
        public static void BindVerticalFit<T>(this UnityEngine.UI.ContentSizeFitter obj, IProperty<T> property, Func<T, UnityEngine.UI.ContentSizeFitter.FitMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalFit = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this DistanceJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this DistanceJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this DistanceJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this DistanceJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this DistanceJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindAutoConfigureDistance(this DistanceJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureDistance = v);
        public static void BindAutoConfigureDistance<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureDistance = transform(v));
        public static void BindDistance(this DistanceJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distance = v);
        public static void BindDistance<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distance = transform(v));
        public static void BindMaxDistanceOnly(this DistanceJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistanceOnly = v);
        public static void BindMaxDistanceOnly<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistanceOnly = transform(v));
        public static void BindBreakForce(this DistanceJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Dropdown obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindTemplate(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.template = v);
        public static void BindTemplate<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.template = transform(v));
        public static void BindCaptionText(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionText = v);
        public static void BindCaptionText<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionText = transform(v));
        public static void BindCaptionImage(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Image> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionImage = v);
        public static void BindCaptionImage<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionImage = transform(v));
        public static void BindItemText(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemText = v);
        public static void BindItemText<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemText = transform(v));
        public static void BindItemImage(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Image> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemImage = v);
        public static void BindItemImage<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemImage = transform(v));
        public static void BindValue(this UnityEngine.UI.Dropdown obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = transform(v));
        public static void BindAlphaFadeSpeed(this UnityEngine.UI.Dropdown obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaFadeSpeed = v);
        public static void BindAlphaFadeSpeed<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaFadeSpeed = transform(v));
        public static void BindOptions(this UnityEngine.UI.Dropdown obj, IProperty<System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.options = v);
        public static void BindOptions<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.options = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this EdgeCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this EdgeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this EdgeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this EdgeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this EdgeCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this EdgeCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindEdgeRadius(this EdgeCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.edgeRadius = transform(v));
        public static void BindPoints(this EdgeCollider2D obj, IProperty<UnityEngine.Vector2[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.points = v);
        public static void BindPoints<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.points = transform(v));
        #if UNITY_2020_1_OR_NEWER
        public static void BindUseAdjacentStartPoint(this EdgeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAdjacentStartPoint = v);
        public static void BindUseAdjacentStartPoint<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAdjacentStartPoint = transform(v));
        #endif
        #if UNITY_2020_1_OR_NEWER
        public static void BindUseAdjacentEndPoint(this EdgeCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAdjacentEndPoint = v);
        public static void BindUseAdjacentEndPoint<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAdjacentEndPoint = transform(v));
        #endif
        #endif


        #if UNITY_GUI
        public static void BindFirstSelectedGameObject(this UnityEngine.EventSystems.EventSystem obj, IProperty<UnityEngine.GameObject> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.firstSelectedGameObject = v);
        public static void BindFirstSelectedGameObject<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, UnityEngine.GameObject> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.firstSelectedGameObject = transform(v));
        public static void BindSendNavigationEvents(this UnityEngine.EventSystems.EventSystem obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sendNavigationEvents = v);
        public static void BindSendNavigationEvents<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sendNavigationEvents = transform(v));
        public static void BindPixelDragThreshold(this UnityEngine.EventSystems.EventSystem obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pixelDragThreshold = v);
        public static void BindPixelDragThreshold<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pixelDragThreshold = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this FixedJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this FixedJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this FixedJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this FixedJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this FixedJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindDampingRatio(this FixedJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = transform(v));
        public static void BindFrequency(this FixedJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = v);
        public static void BindFrequency<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = transform(v));
        public static void BindBreakForce(this FixedJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this FixedJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this FrictionJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this FrictionJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this FrictionJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this FrictionJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this FrictionJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindMaxForce(this FrictionJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = transform(v));
        public static void BindMaxTorque(this FrictionJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxTorque = v);
        public static void BindMaxTorque<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxTorque = transform(v));
        public static void BindBreakForce(this FrictionJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this FrictionJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindIgnoreReversedGraphics(this UnityEngine.UI.GraphicRaycaster obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreReversedGraphics = v);
        public static void BindIgnoreReversedGraphics<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreReversedGraphics = transform(v));
        public static void BindBlockingObjects(this UnityEngine.UI.GraphicRaycaster obj, IProperty<UnityEngine.UI.GraphicRaycaster.BlockingObjects> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blockingObjects = v);
        public static void BindBlockingObjects<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, UnityEngine.UI.GraphicRaycaster.BlockingObjects> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blockingObjects = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindBlockingMask(this UnityEngine.UI.GraphicRaycaster obj, IProperty<UnityEngine.LayerMask> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blockingMask = v);
        public static void BindBlockingMask<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blockingMask = transform(v));
        #endif
        #endif


        public static void BindCellSize(this Grid obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSize = v);
        public static void BindCellSize<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSize = transform(v));
        public static void BindCellGap(this Grid obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellGap = v);
        public static void BindCellGap<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellGap = transform(v));
        public static void BindCellLayout(this Grid obj, IProperty<UnityEngine.GridLayout.CellLayout> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellLayout = v);
        public static void BindCellLayout<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.GridLayout.CellLayout> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellLayout = transform(v));
        public static void BindCellSwizzle(this Grid obj, IProperty<UnityEngine.GridLayout.CellSwizzle> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSwizzle = v);
        public static void BindCellSwizzle<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.GridLayout.CellSwizzle> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSwizzle = transform(v));


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.RectOffset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = transform(v));
        public static void BindCellSize(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSize = v);
        public static void BindCellSize<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cellSize = transform(v));
        public static void BindSpacing(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = transform(v));
        public static void BindStartCorner(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Corner> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startCorner = v);
        public static void BindStartCorner<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Corner> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startCorner = transform(v));
        public static void BindStartAxis(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startAxis = v);
        public static void BindStartAxis<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startAxis = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = transform(v));
        public static void BindConstraint(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Constraint> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraint = v);
        public static void BindConstraint<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Constraint> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraint = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this HingeJoint obj, IProperty<UnityEngine.Rigidbody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this HingeJoint obj, IProperty<UnityEngine.ArticulationBody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = transform(v));
        #endif
        public static void BindAnchor(this HingeJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindAxis(this HingeJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = v);
        public static void BindAxis<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindConnectedAnchor(this HingeJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindUseSpring(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSpring = v);
        public static void BindUseSpring<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSpring = transform(v));
        public static void BindSpring(this HingeJoint obj, IProperty<UnityEngine.JointSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spring = v);
        public static void BindSpring<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spring = transform(v));
        public static void BindUseMotor(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = transform(v));
        public static void BindMotor(this HingeJoint obj, IProperty<UnityEngine.JointMotor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = v);
        public static void BindMotor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointMotor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = transform(v));
        public static void BindUseLimits(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = transform(v));
        public static void BindLimits(this HingeJoint obj, IProperty<UnityEngine.JointLimits> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = v);
        public static void BindLimits<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointLimits> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = transform(v));
        public static void BindBreakForce(this HingeJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this HingeJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        public static void BindEnableCollision(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindEnablePreprocessing(this HingeJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = transform(v));
        public static void BindMassScale(this HingeJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = v);
        public static void BindMassScale<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = transform(v));
        public static void BindConnectedMassScale(this HingeJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this HingeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this HingeJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this HingeJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this HingeJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindUseMotor(this HingeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = transform(v));
        public static void BindMotor(this HingeJoint2D obj, IProperty<UnityEngine.JointMotor2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = v);
        public static void BindMotor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = transform(v));
        public static void BindUseLimits(this HingeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = transform(v));
        public static void BindLimits(this HingeJoint2D obj, IProperty<UnityEngine.JointAngleLimits2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = v);
        public static void BindLimits<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointAngleLimits2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = transform(v));
        public static void BindBreakForce(this HingeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this HingeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<UnityEngine.RectOffset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = transform(v));
        public static void BindSpacing(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = transform(v));
        public static void BindChildControlWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlWidth = v);
        public static void BindChildControlWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlWidth = transform(v));
        public static void BindChildControlHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlHeight = v);
        public static void BindChildControlHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlHeight = transform(v));
        public static void BindChildScaleWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleWidth = v);
        public static void BindChildScaleWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleWidth = transform(v));
        public static void BindChildScaleHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleHeight = v);
        public static void BindChildScaleHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleHeight = transform(v));
        public static void BindChildForceExpandWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandWidth = v);
        public static void BindChildForceExpandWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandWidth = transform(v));
        public static void BindChildForceExpandHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandHeight = v);
        public static void BindChildForceExpandHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandHeight = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<UnityEngine.RectOffset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = transform(v));
        public static void BindSpacing(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spacing = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childAlignment = transform(v));
        public static void BindChildControlWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlWidth = v);
        public static void BindChildControlWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlWidth = transform(v));
        public static void BindChildControlHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlHeight = v);
        public static void BindChildControlHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childControlHeight = transform(v));
        public static void BindChildScaleWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleWidth = v);
        public static void BindChildScaleWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleWidth = transform(v));
        public static void BindChildScaleHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleHeight = v);
        public static void BindChildScaleHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childScaleHeight = transform(v));
        public static void BindChildForceExpandWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandWidth = v);
        public static void BindChildForceExpandWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandWidth = transform(v));
        public static void BindChildForceExpandHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandHeight = v);
        public static void BindChildForceExpandHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.childForceExpandHeight = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindSprite(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Sprite> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = v);
        public static void BindSprite<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = transform(v));
        public static void BindMaterial(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Material> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = v);
        public static void BindMaterial<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Material> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = transform(v));
        public static void BindColor(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.Image obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = transform(v));
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = transform(v));
        #endif
        public static void BindMaskable(this UnityEngine.UI.Image obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindTextComponent(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textComponent = v);
        public static void BindTextComponent<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textComponent = transform(v));
        public static void BindText<T2>(this UnityEngine.UI.InputField obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindCharacterLimit(this UnityEngine.UI.InputField obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterLimit = v);
        public static void BindCharacterLimit<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterLimit = transform(v));
        public static void BindContentType(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.InputField.ContentType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.contentType = v);
        public static void BindContentType<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.InputField.ContentType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.contentType = transform(v));
        public static void BindLineType(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.InputField.LineType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineType = v);
        public static void BindLineType<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.InputField.LineType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineType = transform(v));
        public static void BindPlaceholder(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = transform(v));
        public static void BindCaretBlinkRate(this UnityEngine.UI.InputField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretBlinkRate = v);
        public static void BindCaretBlinkRate<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretBlinkRate = transform(v));
        public static void BindCaretWidth(this UnityEngine.UI.InputField obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretWidth = v);
        public static void BindCaretWidth<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretWidth = transform(v));
        public static void BindCustomCaretColor(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.customCaretColor = v);
        public static void BindCustomCaretColor<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.customCaretColor = transform(v));
        public static void BindSelectionColor(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.selectionColor = v);
        public static void BindSelectionColor<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.selectionColor = transform(v));
        public static void BindShouldHideMobileInput(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideMobileInput = v);
        public static void BindShouldHideMobileInput<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideMobileInput = transform(v));
        public static void BindReadOnly(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.readOnly = v);
        public static void BindReadOnly<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.readOnly = transform(v));
        #if UNITY_2020_3_OR_NEWER
        public static void BindShouldActivateOnSelect(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldActivateOnSelect = v);
        public static void BindShouldActivateOnSelect<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldActivateOnSelect = transform(v));
        #endif
        #endif


        #if UNITY_GUI
        public static void BindIgnoreLayout(this UnityEngine.UI.LayoutElement obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreLayout = v);
        public static void BindIgnoreLayout<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreLayout = transform(v));
        public static void BindMinWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minWidth = v);
        public static void BindMinWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minWidth = transform(v));
        public static void BindMinHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minHeight = v);
        public static void BindMinHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minHeight = transform(v));
        public static void BindPreferredWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.preferredWidth = v);
        public static void BindPreferredWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.preferredWidth = transform(v));
        public static void BindPreferredHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.preferredHeight = v);
        public static void BindPreferredHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.preferredHeight = transform(v));
        public static void BindFlexibleWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flexibleWidth = v);
        public static void BindFlexibleWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flexibleWidth = transform(v));
        public static void BindFlexibleHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flexibleHeight = v);
        public static void BindFlexibleHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flexibleHeight = transform(v));
        public static void BindLayoutPriority(this UnityEngine.UI.LayoutElement obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.layoutPriority = v);
        public static void BindLayoutPriority<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.layoutPriority = transform(v));
        #endif


        public static void BindFlare(this LensFlare obj, IProperty<UnityEngine.Flare> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flare = v);
        public static void BindFlare<T>(this LensFlare obj, IProperty<T> property, Func<T, UnityEngine.Flare> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flare = transform(v));
        public static void BindColor(this LensFlare obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this LensFlare obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindBrightness(this LensFlare obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.brightness = v);
        public static void BindBrightness<T>(this LensFlare obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.brightness = transform(v));
        public static void BindFadeSpeed(this LensFlare obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fadeSpeed = v);
        public static void BindFadeSpeed<T>(this LensFlare obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fadeSpeed = transform(v));


        public static void BindType(this Light obj, IProperty<UnityEngine.LightType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.type = v);
        public static void BindType<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.type = transform(v));
        public static void BindRange(this Light obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.range = v);
        public static void BindRange<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.range = transform(v));
        public static void BindSpotAngle(this Light obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spotAngle = v);
        public static void BindSpotAngle<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spotAngle = transform(v));
        public static void BindColor(this Light obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindIntensity(this Light obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.intensity = v);
        public static void BindIntensity<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.intensity = transform(v));
        public static void BindBounceIntensity(this Light obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bounceIntensity = v);
        public static void BindBounceIntensity<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bounceIntensity = transform(v));
        public static void BindShadows(this Light obj, IProperty<UnityEngine.LightShadows> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadows = v);
        public static void BindShadows<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightShadows> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadows = transform(v));
        public static void BindCookie(this Light obj, IProperty<UnityEngine.Texture> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cookie = v);
        public static void BindCookie<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Texture> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cookie = transform(v));
        public static void BindFlare(this Light obj, IProperty<UnityEngine.Flare> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flare = v);
        public static void BindFlare<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Flare> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flare = transform(v));
        public static void BindRenderMode(this Light obj, IProperty<UnityEngine.LightRenderMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightRenderMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = transform(v));
        public static void BindCullingMask(this Light obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this Light obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = transform(v));


        public static void BindRefreshMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.RefreshMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.refreshMode = v);
        public static void BindRefreshMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.RefreshMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.refreshMode = transform(v));
        public static void BindQualityMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.QualityMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.qualityMode = v);
        public static void BindQualityMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.QualityMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.qualityMode = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindDataFormat(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.DataFormat> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dataFormat = v);
        public static void BindDataFormat<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.DataFormat> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dataFormat = transform(v));
        #endif
        public static void BindBoundingBoxMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.BoundingBoxMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.boundingBoxMode = v);
        public static void BindBoundingBoxMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.BoundingBoxMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.boundingBoxMode = transform(v));
        public static void BindResolutionMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.ResolutionMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resolutionMode = v);
        public static void BindResolutionMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.ResolutionMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resolutionMode = transform(v));
        public static void BindProbeDensity(this LightProbeProxyVolume obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probeDensity = v);
        public static void BindProbeDensity<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probeDensity = transform(v));
        public static void BindProbePositionMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.ProbePositionMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probePositionMode = v);
        public static void BindProbePositionMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.ProbePositionMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probePositionMode = transform(v));


        public static void BindLoop(this LineRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.loop = v);
        public static void BindLoop<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.loop = transform(v));
        public static void BindStartColor(this LineRenderer obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startColor = v);
        public static void BindStartColor<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startColor = transform(v));
        public static void BindEndColor(this LineRenderer obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endColor = v);
        public static void BindEndColor<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endColor = transform(v));
        public static void BindNumCornerVertices(this LineRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCornerVertices = v);
        public static void BindNumCornerVertices<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCornerVertices = transform(v));
        public static void BindNumCapVertices(this LineRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCapVertices = v);
        public static void BindNumCapVertices<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCapVertices = transform(v));
        public static void BindAlignment(this LineRenderer obj, IProperty<UnityEngine.LineAlignment> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineAlignment> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        public static void BindTextureMode(this LineRenderer obj, IProperty<UnityEngine.LineTextureMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textureMode = v);
        public static void BindTextureMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineTextureMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textureMode = transform(v));
        public static void BindShadowBias(this LineRenderer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowBias = v);
        public static void BindShadowBias<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowBias = transform(v));
        public static void BindGenerateLightingData(this LineRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generateLightingData = v);
        public static void BindGenerateLightingData<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generateLightingData = transform(v));
        public static void BindUseWorldSpace(this LineRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useWorldSpace = v);
        public static void BindUseWorldSpace<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useWorldSpace = transform(v));
        public static void BindSharedMaterials(this LineRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindShadowCastingMode(this LineRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = transform(v));
        public static void BindReceiveShadows(this LineRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = transform(v));
        public static void BindLightProbeUsage(this LineRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this LineRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindMotionVectorGenerationMode(this LineRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this LineRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindSortingLayerID(this LineRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this LineRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindUseUpObject(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useUpObject = v);
        public static void BindUseUpObject<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useUpObject = transform(v));
        public static void BindRoll(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roll = v);
        public static void BindRoll<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.roll = transform(v));
        public static void BindWorldUpObject(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpObject = v);
        public static void BindWorldUpObject<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.worldUpObject = transform(v));
        public static void BindLocked(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindShowMaskGraphic(this UnityEngine.UI.Mask obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.showMaskGraphic = v);
        public static void BindShowMaskGraphic<T>(this UnityEngine.UI.Mask obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.showMaskGraphic = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindConvex(this MeshCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.convex = v);
        public static void BindConvex<T>(this MeshCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.convex = transform(v));
        public static void BindIsTrigger(this MeshCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this MeshCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindCookingOptions(this MeshCollider obj, IProperty<UnityEngine.MeshColliderCookingOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cookingOptions = v);
        public static void BindCookingOptions<T>(this MeshCollider obj, IProperty<T> property, Func<T, UnityEngine.MeshColliderCookingOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cookingOptions = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this MeshCollider obj, IProperty<PhysicMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this MeshCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this MeshCollider obj, IProperty<PhysicsMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this MeshCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        public static void BindSharedMesh(this MeshCollider obj, IProperty<UnityEngine.Mesh> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this MeshCollider obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = transform(v));
        #endif


        public static void BindSharedMesh(this MeshFilter obj, IProperty<UnityEngine.Mesh> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this MeshFilter obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = transform(v));


        public static void BindSharedMaterials(this MeshRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindShadowCastingMode(this MeshRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = transform(v));
        public static void BindReceiveShadows(this MeshRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this MeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = transform(v));
        public static void BindLightProbeUsage(this MeshRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this MeshRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindProbeAnchor(this MeshRenderer obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probeAnchor = v);
        public static void BindProbeAnchor<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.probeAnchor = transform(v));
        public static void BindMotionVectorGenerationMode(this MeshRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this MeshRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this MeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = transform(v));


        #if UNITY_AI
        public static void BindAgentTypeID(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.agentTypeID = v);
        public static void BindAgentTypeID<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.agentTypeID = transform(v));
        public static void BindBaseOffset(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.baseOffset = v);
        public static void BindBaseOffset<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.baseOffset = transform(v));
        public static void BindSpeed(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speed = v);
        public static void BindSpeed<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speed = transform(v));
        public static void BindAngularSpeed(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularSpeed = v);
        public static void BindAngularSpeed<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularSpeed = transform(v));
        public static void BindAcceleration(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.acceleration = v);
        public static void BindAcceleration<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.acceleration = transform(v));
        public static void BindStoppingDistance(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stoppingDistance = v);
        public static void BindStoppingDistance<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.stoppingDistance = transform(v));
        public static void BindAutoBraking(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoBraking = v);
        public static void BindAutoBraking<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoBraking = transform(v));
        public static void BindRadius(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        public static void BindHeight(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = v);
        public static void BindHeight<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = transform(v));
        public static void BindObstacleAvoidanceType(this UnityEngine.AI.NavMeshAgent obj, IProperty<UnityEngine.AI.ObstacleAvoidanceType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.obstacleAvoidanceType = v);
        public static void BindObstacleAvoidanceType<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, UnityEngine.AI.ObstacleAvoidanceType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.obstacleAvoidanceType = transform(v));
        public static void BindAvoidancePriority(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.avoidancePriority = v);
        public static void BindAvoidancePriority<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.avoidancePriority = transform(v));
        public static void BindAutoTraverseOffMeshLink(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTraverseOffMeshLink = v);
        public static void BindAutoTraverseOffMeshLink<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTraverseOffMeshLink = transform(v));
        public static void BindAutoRepath(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoRepath = v);
        public static void BindAutoRepath<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoRepath = transform(v));
        public static void BindAreaMask(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.areaMask = v);
        public static void BindAreaMask<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.areaMask = transform(v));
        #endif


        #if UNITY_AI
        public static void BindShape(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.AI.NavMeshObstacleShape> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shape = v);
        public static void BindShape<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.AI.NavMeshObstacleShape> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shape = transform(v));
        public static void BindCenter(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindSize(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindCarving(this UnityEngine.AI.NavMeshObstacle obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.carving = v);
        public static void BindCarving<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.carving = transform(v));
        #endif


        public static void BindSize(this OcclusionArea obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this OcclusionArea obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindCenter(this OcclusionArea obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this OcclusionArea obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));


        public static void BindOpen(this OcclusionPortal obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.open = v);
        public static void BindOpen<T>(this OcclusionPortal obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.open = transform(v));


        #if UNITY_AI&&!UNITY_2023_2_OR_NEWER
        public static void BindStartTransform(this UnityEngine.AI.OffMeshLink obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startTransform = v);
        public static void BindStartTransform<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startTransform = transform(v));
        public static void BindEndTransform(this UnityEngine.AI.OffMeshLink obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endTransform = v);
        public static void BindEndTransform<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endTransform = transform(v));
        public static void BindCostOverride(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.costOverride = v);
        public static void BindCostOverride<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.costOverride = transform(v));
        public static void BindBiDirectional(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.biDirectional = v);
        public static void BindBiDirectional<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.biDirectional = transform(v));
        public static void BindActivated(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.activated = v);
        public static void BindActivated<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.activated = transform(v));
        public static void BindAutoUpdatePositions(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoUpdatePositions = v);
        public static void BindAutoUpdatePositions<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoUpdatePositions = transform(v));
        public static void BindArea(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.area = v);
        public static void BindArea<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.area = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindEffectColor(this UnityEngine.UI.Outline obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectColor = v);
        public static void BindEffectColor<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectColor = transform(v));
        public static void BindEffectDistance(this UnityEngine.UI.Outline obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectDistance = v);
        public static void BindEffectDistance<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectDistance = transform(v));
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Outline obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGraphicAlpha = v);
        public static void BindUseGraphicAlpha<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGraphicAlpha = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindLocked(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindTranslationAtRest(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAtRest = v);
        public static void BindTranslationAtRest<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAtRest = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = transform(v));
        public static void BindTranslationOffsets(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationOffsets = v);
        public static void BindTranslationOffsets<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationOffsets = transform(v));
        public static void BindRotationOffsets(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffsets = v);
        public static void BindRotationOffsets<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffsets = transform(v));
        public static void BindTranslationAxis(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAxis = v);
        public static void BindTranslationAxis<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAxis = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = transform(v));
        #endif


        #if UNITY_PARTICLE_SYSTEM
        public static void BindShape(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystemForceFieldShape> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shape = v);
        public static void BindShape<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystemForceFieldShape> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shape = transform(v));
        public static void BindStartRange(this ParticleSystemForceField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startRange = v);
        public static void BindStartRange<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.startRange = transform(v));
        public static void BindEndRange(this ParticleSystemForceField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endRange = v);
        public static void BindEndRange<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.endRange = transform(v));
        public static void BindDirectionX(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionX = v);
        public static void BindDirectionX<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionX = transform(v));
        public static void BindDirectionY(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionY = v);
        public static void BindDirectionY<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionY = transform(v));
        public static void BindDirectionZ(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionZ = v);
        public static void BindDirectionZ<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.directionZ = transform(v));
        public static void BindGravity(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravity = v);
        public static void BindGravity<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravity = transform(v));
        public static void BindGravityFocus(this ParticleSystemForceField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravityFocus = v);
        public static void BindGravityFocus<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravityFocus = transform(v));
        public static void BindRotationSpeed(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationSpeed = v);
        public static void BindRotationSpeed<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationSpeed = transform(v));
        public static void BindRotationAttraction(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAttraction = v);
        public static void BindRotationAttraction<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAttraction = transform(v));
        public static void BindRotationRandomness(this ParticleSystemForceField obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationRandomness = v);
        public static void BindRotationRandomness<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationRandomness = transform(v));
        public static void BindDrag(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = v);
        public static void BindDrag<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = transform(v));
        public static void BindMultiplyDragByParticleSize(this ParticleSystemForceField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.multiplyDragByParticleSize = v);
        public static void BindMultiplyDragByParticleSize<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.multiplyDragByParticleSize = transform(v));
        public static void BindMultiplyDragByParticleVelocity(this ParticleSystemForceField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.multiplyDragByParticleVelocity = v);
        public static void BindMultiplyDragByParticleVelocity<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.multiplyDragByParticleVelocity = transform(v));
        public static void BindVectorField(this ParticleSystemForceField obj, IProperty<UnityEngine.Texture3D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorField = v);
        public static void BindVectorField<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.Texture3D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorField = transform(v));
        public static void BindVectorFieldSpeed(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorFieldSpeed = v);
        public static void BindVectorFieldSpeed<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorFieldSpeed = transform(v));
        public static void BindVectorFieldAttraction(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorFieldAttraction = v);
        public static void BindVectorFieldAttraction<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vectorFieldAttraction = transform(v));
        #if UNITY_2021_3_OR_NEWER
        public static void BindEnabled(this ParticleSystemForceField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enabled = v);
        public static void BindEnabled<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enabled = transform(v));
        #endif
        #endif


        #if UNITY_GUI
        public static void BindEventMask(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<UnityEngine.LayerMask> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.eventMask = v);
        public static void BindEventMask<T>(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.eventMask = transform(v));
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxRayIntersections = v);
        public static void BindMaxRayIntersections<T>(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxRayIntersections = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindEventMask(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<UnityEngine.LayerMask> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.eventMask = v);
        public static void BindEventMask<T>(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.eventMask = transform(v));
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxRayIntersections = v);
        public static void BindMaxRayIntersections<T>(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxRayIntersections = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this PlatformEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = transform(v));
        public static void BindColliderMask(this PlatformEffector2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = transform(v));
        public static void BindRotationalOffset(this PlatformEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationalOffset = v);
        public static void BindRotationalOffset<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationalOffset = transform(v));
        public static void BindUseOneWay(this PlatformEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOneWay = v);
        public static void BindUseOneWay<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOneWay = transform(v));
        public static void BindUseOneWayGrouping(this PlatformEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOneWayGrouping = v);
        public static void BindUseOneWayGrouping<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useOneWayGrouping = transform(v));
        public static void BindSurfaceArc(this PlatformEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.surfaceArc = v);
        public static void BindSurfaceArc<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.surfaceArc = transform(v));
        public static void BindUseSideFriction(this PlatformEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSideFriction = v);
        public static void BindUseSideFriction<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSideFriction = transform(v));
        public static void BindUseSideBounce(this PlatformEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSideBounce = v);
        public static void BindUseSideBounce<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useSideBounce = transform(v));
        public static void BindSideArc(this PlatformEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sideArc = v);
        public static void BindSideArc<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sideArc = transform(v));
        #endif


        #if UNITY_DIRECTOR
        public static void BindPlayableAsset(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.PlayableAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playableAsset = v);
        public static void BindPlayableAsset<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.PlayableAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playableAsset = transform(v));
        public static void BindTimeUpdateMode(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.DirectorUpdateMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.timeUpdateMode = v);
        public static void BindTimeUpdateMode<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.DirectorUpdateMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.timeUpdateMode = transform(v));
        public static void BindPlayOnAwake(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = transform(v));
        public static void BindExtrapolationMode(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.DirectorWrapMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extrapolationMode = v);
        public static void BindExtrapolationMode<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.DirectorWrapMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extrapolationMode = transform(v));
        public static void BindInitialTime(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Double> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.initialTime = v);
        public static void BindInitialTime<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Double> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.initialTime = transform(v));
        public static void BindTime(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Double> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.time = v);
        public static void BindTime<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Double> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.time = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this PointEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = transform(v));
        public static void BindColliderMask(this PointEffector2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = transform(v));
        public static void BindForceMagnitude(this PointEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMagnitude = v);
        public static void BindForceMagnitude<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMagnitude = transform(v));
        public static void BindForceVariation(this PointEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceVariation = v);
        public static void BindForceVariation<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceVariation = transform(v));
        public static void BindDistanceScale(this PointEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distanceScale = v);
        public static void BindDistanceScale<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distanceScale = transform(v));
        public static void BindForceSource(this PointEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceSource = v);
        public static void BindForceSource<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceSource = transform(v));
        public static void BindForceTarget(this PointEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceTarget = v);
        public static void BindForceTarget<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceTarget = transform(v));
        public static void BindForceMode(this PointEffector2D obj, IProperty<UnityEngine.EffectorForceMode2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMode = v);
        public static void BindForceMode<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorForceMode2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceMode = transform(v));
        #if !UNITY_6000_1_OR_NEWER
        public static void BindDrag(this PointEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = v);
        public static void BindDrag<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = transform(v));
        #endif
        #if !UNITY_6000_1_OR_NEWER
        public static void BindAngularDrag(this PointEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = transform(v));
        #endif
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this PolygonCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this PolygonCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this PolygonCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this PolygonCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this PolygonCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindAutoTiling(this PolygonCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTiling = v);
        public static void BindAutoTiling<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoTiling = transform(v));
        public static void BindOffset(this PolygonCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        public static void BindPathCount(this PolygonCollider2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pathCount = v);
        public static void BindPathCount<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pathCount = transform(v));
        public static void BindPoints(this PolygonCollider2D obj, IProperty<UnityEngine.Vector2[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.points = v);
        public static void BindPoints<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.points = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindLocked(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindTranslationAtRest(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAtRest = v);
        public static void BindTranslationAtRest<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAtRest = transform(v));
        public static void BindTranslationOffset(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationOffset = v);
        public static void BindTranslationOffset<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationOffset = transform(v));
        public static void BindTranslationAxis(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAxis = v);
        public static void BindTranslationAxis<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.translationAxis = transform(v));
        #endif


        public static void BindNearClipPlane(this Projector obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = transform(v));
        public static void BindFarClipPlane(this Projector obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = transform(v));
        public static void BindFieldOfView(this Projector obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fieldOfView = v);
        public static void BindFieldOfView<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fieldOfView = transform(v));
        public static void BindAspectRatio(this Projector obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aspectRatio = v);
        public static void BindAspectRatio<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aspectRatio = transform(v));
        public static void BindOrthographic(this Projector obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographic = v);
        public static void BindOrthographic<T>(this Projector obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographic = transform(v));
        public static void BindOrthographicSize(this Projector obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographicSize = v);
        public static void BindOrthographicSize<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orthographicSize = transform(v));
        public static void BindMaterial(this Projector obj, IProperty<UnityEngine.Material> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = v);
        public static void BindMaterial<T>(this Projector obj, IProperty<T> property, Func<T, UnityEngine.Material> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = transform(v));
        public static void BindIgnoreLayers(this Projector obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreLayers = v);
        public static void BindIgnoreLayers<T>(this Projector obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.ignoreLayers = transform(v));


        #if UNITY_GUI
        public static void BindTexture(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Texture> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.texture = v);
        public static void BindTexture<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Texture> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.texture = transform(v));
        public static void BindColor(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.RawImage obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = transform(v));
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = transform(v));
        #endif
        public static void BindMaskable(this UnityEngine.UI.RawImage obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = transform(v));
        public static void BindUvRect(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Rect> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.uvRect = v);
        public static void BindUvRect<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Rect> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.uvRect = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.RectMask2D obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.RectMask2D obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.padding = transform(v));
        public static void BindSoftness(this UnityEngine.UI.RectMask2D obj, IProperty<UnityEngine.Vector2Int> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.softness = v);
        public static void BindSoftness<T>(this UnityEngine.UI.RectMask2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2Int> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.softness = transform(v));
        #endif


        public static void BindLocalPosition(this RectTransform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localPosition = v);
        public static void BindLocalPosition<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localPosition = transform(v));
        public static void BindSizeDelta(this RectTransform obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sizeDelta = v);
        public static void BindSizeDelta<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sizeDelta = transform(v));
        public static void BindAnchorMin(this RectTransform obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorMin = v);
        public static void BindAnchorMin<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorMin = transform(v));
        public static void BindAnchorMax(this RectTransform obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorMax = v);
        public static void BindAnchorMax<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorMax = transform(v));
        public static void BindLocalRotation(this RectTransform obj, IProperty<UnityEngine.Quaternion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localRotation = v);
        public static void BindLocalRotation<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localRotation = transform(v));
        public static void BindLocalScale(this RectTransform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localScale = v);
        public static void BindLocalScale<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localScale = transform(v));
        public static void BindPosition(this RectTransform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.position = v);
        public static void BindPosition<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.position = transform(v));
        public static void BindRotation(this RectTransform obj, IProperty<UnityEngine.Quaternion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotation = v);
        public static void BindRotation<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotation = transform(v));


        public static void BindMode(this ReflectionProbe obj, IProperty<UnityEngine.Rendering.ReflectionProbeMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = v);
        public static void BindMode<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = transform(v));
        public static void BindImportance(this ReflectionProbe obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.importance = v);
        public static void BindImportance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.importance = transform(v));
        public static void BindIntensity(this ReflectionProbe obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.intensity = v);
        public static void BindIntensity<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.intensity = transform(v));
        public static void BindBoxProjection(this ReflectionProbe obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.boxProjection = v);
        public static void BindBoxProjection<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.boxProjection = transform(v));
        public static void BindBlendDistance(this ReflectionProbe obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blendDistance = v);
        public static void BindBlendDistance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.blendDistance = transform(v));
        public static void BindSize(this ReflectionProbe obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindCenter(this ReflectionProbe obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindResolution(this ReflectionProbe obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resolution = v);
        public static void BindResolution<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resolution = transform(v));
        public static void BindHdr(this ReflectionProbe obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.hdr = v);
        public static void BindHdr<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.hdr = transform(v));
        public static void BindShadowDistance(this ReflectionProbe obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowDistance = v);
        public static void BindShadowDistance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowDistance = transform(v));
        public static void BindClearFlags(this ReflectionProbe obj, IProperty<UnityEngine.Rendering.ReflectionProbeClearFlags> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clearFlags = v);
        public static void BindClearFlags<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeClearFlags> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clearFlags = transform(v));
        public static void BindBackgroundColor(this ReflectionProbe obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.backgroundColor = v);
        public static void BindBackgroundColor<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.backgroundColor = transform(v));
        public static void BindCullingMask(this ReflectionProbe obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cullingMask = transform(v));
        public static void BindNearClipPlane(this ReflectionProbe obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.nearClipPlane = transform(v));
        public static void BindFarClipPlane(this ReflectionProbe obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.farClipPlane = transform(v));


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this RelativeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this RelativeJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindMaxForce(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = transform(v));
        public static void BindMaxTorque(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxTorque = v);
        public static void BindMaxTorque<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxTorque = transform(v));
        public static void BindCorrectionScale(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.correctionScale = v);
        public static void BindCorrectionScale<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.correctionScale = transform(v));
        public static void BindAutoConfigureOffset(this RelativeJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureOffset = v);
        public static void BindAutoConfigureOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureOffset = transform(v));
        public static void BindLinearOffset(this RelativeJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearOffset = v);
        public static void BindLinearOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearOffset = transform(v));
        public static void BindAngularOffset(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularOffset = v);
        public static void BindAngularOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularOffset = transform(v));
        public static void BindBreakForce(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this RelativeJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindMass(this Rigidbody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = v);
        public static void BindMass<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindDrag(this Rigidbody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = v);
        public static void BindDrag<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = transform(v));
        #endif
        #if !UNITY_6000_0_OR_NEWER
        public static void BindAngularDrag(this Rigidbody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindLinearDamping(this Rigidbody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindAngularDamping(this Rigidbody obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = transform(v));
        #endif
        public static void BindUseGravity(this Rigidbody obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGravity = transform(v));
        public static void BindIsKinematic(this Rigidbody obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isKinematic = v);
        public static void BindIsKinematic<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isKinematic = transform(v));
        public static void BindInterpolation(this Rigidbody obj, IProperty<UnityEngine.RigidbodyInterpolation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interpolation = v);
        public static void BindInterpolation<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyInterpolation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interpolation = transform(v));
        public static void BindCollisionDetectionMode(this Rigidbody obj, IProperty<UnityEngine.CollisionDetectionMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = transform(v));
        public static void BindConstraints(this Rigidbody obj, IProperty<UnityEngine.RigidbodyConstraints> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraints = v);
        public static void BindConstraints<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyConstraints> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraints = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindBodyType(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyType2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bodyType = v);
        public static void BindBodyType<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyType2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bodyType = transform(v));
        public static void BindSimulated(this Rigidbody2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.simulated = v);
        public static void BindSimulated<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.simulated = transform(v));
        public static void BindUseAutoMass(this Rigidbody2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAutoMass = v);
        public static void BindUseAutoMass<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useAutoMass = transform(v));
        public static void BindMass(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = v);
        public static void BindMass<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindDrag(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = v);
        public static void BindDrag<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drag = transform(v));
        #endif
        #if !UNITY_6000_0_OR_NEWER
        public static void BindAngularDrag(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDrag = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindLinearDamping(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.linearDamping = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindAngularDamping(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angularDamping = transform(v));
        #endif
        public static void BindGravityScale(this Rigidbody2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravityScale = v);
        public static void BindGravityScale<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.gravityScale = transform(v));
        public static void BindCollisionDetectionMode(this Rigidbody2D obj, IProperty<UnityEngine.CollisionDetectionMode2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.collisionDetectionMode = transform(v));
        public static void BindSleepMode(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodySleepMode2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sleepMode = v);
        public static void BindSleepMode<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodySleepMode2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sleepMode = transform(v));
        public static void BindInterpolation(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyInterpolation2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interpolation = v);
        public static void BindInterpolation<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyInterpolation2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interpolation = transform(v));
        public static void BindConstraints(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyConstraints2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraints = v);
        public static void BindConstraints<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyConstraints2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraints = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindLocked(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationOffset = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotationAxis = transform(v));
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.constraintActive = transform(v));
        public static void BindWeight(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.weight = transform(v));
        public static void BindLocked(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.locked = transform(v));
        public static void BindScaleAtRest(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleAtRest = v);
        public static void BindScaleAtRest<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleAtRest = transform(v));
        public static void BindScaleOffset(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleOffset = v);
        public static void BindScaleOffset<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scaleOffset = transform(v));
        public static void BindScalingAxis(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Animations.Axis> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scalingAxis = v);
        public static void BindScalingAxis<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scalingAxis = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Scrollbar obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindHandleRect(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.handleRect = v);
        public static void BindHandleRect<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.handleRect = transform(v));
        public static void BindDirection(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Scrollbar.Direction> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = v);
        public static void BindDirection<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar.Direction> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = transform(v));
        public static void BindValue(this UnityEngine.UI.Scrollbar obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = transform(v));
        public static void BindSize(this UnityEngine.UI.Scrollbar obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = v);
        public static void BindSize<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.size = transform(v));
        public static void BindNumberOfSteps(this UnityEngine.UI.Scrollbar obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numberOfSteps = v);
        public static void BindNumberOfSteps<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numberOfSteps = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindContent(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.content = v);
        public static void BindContent<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.content = transform(v));
        public static void BindHorizontal(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontal = v);
        public static void BindHorizontal<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontal = transform(v));
        public static void BindVertical(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vertical = v);
        public static void BindVertical<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.vertical = transform(v));
        public static void BindMovementType(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.ScrollRect.MovementType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.movementType = v);
        public static void BindMovementType<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.ScrollRect.MovementType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.movementType = transform(v));
        public static void BindElasticity(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.elasticity = v);
        public static void BindElasticity<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.elasticity = transform(v));
        public static void BindInertia(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.inertia = v);
        public static void BindInertia<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.inertia = transform(v));
        public static void BindDecelerationRate(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decelerationRate = v);
        public static void BindDecelerationRate<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.decelerationRate = transform(v));
        public static void BindScrollSensitivity(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scrollSensitivity = v);
        public static void BindScrollSensitivity<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.scrollSensitivity = transform(v));
        public static void BindViewport(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.viewport = v);
        public static void BindViewport<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.viewport = transform(v));
        public static void BindHorizontalScrollbar(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.Scrollbar> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalScrollbar = v);
        public static void BindHorizontalScrollbar<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalScrollbar = transform(v));
        public static void BindVerticalScrollbar(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.Scrollbar> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalScrollbar = v);
        public static void BindVerticalScrollbar<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalScrollbar = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindEffectColor(this UnityEngine.UI.Shadow obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectColor = v);
        public static void BindEffectColor<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectColor = transform(v));
        public static void BindEffectDistance(this UnityEngine.UI.Shadow obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectDistance = v);
        public static void BindEffectDistance<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.effectDistance = transform(v));
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Shadow obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGraphicAlpha = v);
        public static void BindUseGraphicAlpha<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useGraphicAlpha = transform(v));
        #endif


        #if UNITY_2021_2_OR_NEWER
        public static void BindBounds(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Bounds> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bounds = v);
        public static void BindBounds<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Bounds> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.bounds = transform(v));
        #endif
        public static void BindQuality(this SkinnedMeshRenderer obj, IProperty<UnityEngine.SkinQuality> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.quality = v);
        public static void BindQuality<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.SkinQuality> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.quality = transform(v));
        public static void BindUpdateWhenOffscreen(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.updateWhenOffscreen = v);
        public static void BindUpdateWhenOffscreen<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.updateWhenOffscreen = transform(v));
        public static void BindSharedMesh(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Mesh> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMesh = transform(v));
        public static void BindRootBone(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Transform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rootBone = v);
        public static void BindRootBone<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rootBone = transform(v));
        public static void BindSharedMaterials(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindShadowCastingMode(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = transform(v));
        public static void BindReceiveShadows(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = transform(v));
        public static void BindLightProbeUsage(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindMotionVectorGenerationMode(this SkinnedMeshRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = transform(v));


        public static void BindMaterial(this Skybox obj, IProperty<UnityEngine.Material> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = v);
        public static void BindMaterial<T>(this Skybox obj, IProperty<T> property, Func<T, UnityEngine.Material> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.material = transform(v));


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Slider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindFillRect(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fillRect = v);
        public static void BindFillRect<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fillRect = transform(v));
        public static void BindHandleRect(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.handleRect = v);
        public static void BindHandleRect<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.handleRect = transform(v));
        public static void BindDirection(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Slider.Direction> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = v);
        public static void BindDirection<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Slider.Direction> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.direction = transform(v));
        public static void BindMinValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minValue = v);
        public static void BindMinValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minValue = transform(v));
        public static void BindMaxValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxValue = v);
        public static void BindMaxValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxValue = transform(v));
        public static void BindWholeNumbers(this UnityEngine.UI.Slider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wholeNumbers = v);
        public static void BindWholeNumbers<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wholeNumbers = transform(v));
        public static void BindValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this SliderJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this SliderJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SliderJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this SliderJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this SliderJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindAutoConfigureAngle(this SliderJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureAngle = v);
        public static void BindAutoConfigureAngle<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureAngle = transform(v));
        public static void BindAngle(this SliderJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angle = v);
        public static void BindAngle<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.angle = transform(v));
        public static void BindUseMotor(this SliderJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = transform(v));
        public static void BindMotor(this SliderJoint2D obj, IProperty<UnityEngine.JointMotor2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = v);
        public static void BindMotor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = transform(v));
        public static void BindUseLimits(this SliderJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useLimits = transform(v));
        public static void BindLimits(this SliderJoint2D obj, IProperty<UnityEngine.JointTranslationLimits2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = v);
        public static void BindLimits<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointTranslationLimits2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.limits = transform(v));
        public static void BindBreakForce(this SliderJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this SliderJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        public static void BindSortingLayerID(this UnityEngine.Rendering.SortingGroup obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.Rendering.SortingGroup obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this UnityEngine.Rendering.SortingGroup obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.Rendering.SortingGroup obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this SphereCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this SphereCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this SphereCollider obj, IProperty<PhysicMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this SphereCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this SphereCollider obj, IProperty<PhysicsMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this SphereCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        public static void BindCenter(this SphereCollider obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this SphereCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindRadius(this SphereCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this SphereCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this SpringJoint obj, IProperty<UnityEngine.Rigidbody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this SpringJoint obj, IProperty<UnityEngine.ArticulationBody> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedArticulationBody = transform(v));
        #endif
        public static void BindAnchor(this SpringJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindAxis(this SpringJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = v);
        public static void BindAxis<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.axis = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindConnectedAnchor(this SpringJoint obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindSpring(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spring = v);
        public static void BindSpring<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spring = transform(v));
        public static void BindDamper(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.damper = v);
        public static void BindDamper<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.damper = transform(v));
        public static void BindMinDistance(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minDistance = transform(v));
        public static void BindMaxDistance(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxDistance = transform(v));
        public static void BindTolerance(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tolerance = v);
        public static void BindTolerance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tolerance = transform(v));
        public static void BindBreakForce(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        public static void BindEnableCollision(this SpringJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindEnablePreprocessing(this SpringJoint obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enablePreprocessing = transform(v));
        public static void BindMassScale(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = v);
        public static void BindMassScale<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.massScale = transform(v));
        public static void BindConnectedMassScale(this SpringJoint obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedMassScale = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this SpringJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this SpringJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this SpringJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this SpringJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindAutoConfigureDistance(this SpringJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureDistance = v);
        public static void BindAutoConfigureDistance<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureDistance = transform(v));
        public static void BindDistance(this SpringJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distance = v);
        public static void BindDistance<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.distance = transform(v));
        public static void BindDampingRatio(this SpringJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = transform(v));
        public static void BindFrequency(this SpringJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = v);
        public static void BindFrequency<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = transform(v));
        public static void BindBreakForce(this SpringJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        #endif


        public static void BindSprite(this SpriteMask obj, IProperty<UnityEngine.Sprite> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = v);
        public static void BindSprite<T>(this SpriteMask obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = transform(v));
        public static void BindAlphaCutoff(this SpriteMask obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaCutoff = v);
        public static void BindAlphaCutoff<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaCutoff = transform(v));
        public static void BindIsCustomRangeActive(this SpriteMask obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isCustomRangeActive = v);
        public static void BindIsCustomRangeActive<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isCustomRangeActive = transform(v));
        public static void BindFrontSortingOrder(this SpriteMask obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frontSortingOrder = v);
        public static void BindFrontSortingOrder<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frontSortingOrder = transform(v));


        public static void BindSprite(this SpriteRenderer obj, IProperty<UnityEngine.Sprite> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = v);
        public static void BindSprite<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sprite = transform(v));
        public static void BindColor(this SpriteRenderer obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindFlipX(this SpriteRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flipX = v);
        public static void BindFlipX<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flipX = transform(v));
        public static void BindFlipY(this SpriteRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flipY = v);
        public static void BindFlipY<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.flipY = transform(v));
        public static void BindDrawMode(this SpriteRenderer obj, IProperty<UnityEngine.SpriteDrawMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drawMode = v);
        public static void BindDrawMode<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteDrawMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.drawMode = transform(v));
        public static void BindMaskInteraction(this SpriteRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = transform(v));
        public static void BindSpriteSortPoint(this SpriteRenderer obj, IProperty<UnityEngine.SpriteSortPoint> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteSortPoint = v);
        public static void BindSpriteSortPoint<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteSortPoint> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteSortPoint = transform(v));
        public static void BindSharedMaterials(this SpriteRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindSortingLayerID(this SpriteRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this SpriteRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));


        #if UNITY_UI
        public static void BindColor(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindMaskInteraction(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = transform(v));
        public static void BindSharedMaterials(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindSortingLayerID(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindHorizontalAxis<T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalAxis = v.ToString());
        public static void BindHorizontalAxis<T, T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalAxis = transform(v).ToString());
        public static void BindVerticalAxis<T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalAxis = v.ToString());
        public static void BindVerticalAxis<T, T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalAxis = transform(v).ToString());
        public static void BindSubmitButton<T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.submitButton = v.ToString());
        public static void BindSubmitButton<T, T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.submitButton = transform(v).ToString());
        public static void BindCancelButton<T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cancelButton = v.ToString());
        public static void BindCancelButton<T, T2>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.cancelButton = transform(v).ToString());
        public static void BindInputActionsPerSecond(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.inputActionsPerSecond = v);
        public static void BindInputActionsPerSecond<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.inputActionsPerSecond = transform(v));
        public static void BindRepeatDelay(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.repeatDelay = v);
        public static void BindRepeatDelay<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.repeatDelay = transform(v));
        #endif


        public static void BindStreamingMipmapBias(this StreamingController obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.streamingMipmapBias = v);
        public static void BindStreamingMipmapBias<T>(this StreamingController obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.streamingMipmapBias = transform(v));


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this SurfaceEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useColliderMask = transform(v));
        public static void BindColliderMask(this SurfaceEffector2D obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colliderMask = transform(v));
        public static void BindSpeed(this SurfaceEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speed = v);
        public static void BindSpeed<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speed = transform(v));
        public static void BindSpeedVariation(this SurfaceEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speedVariation = v);
        public static void BindSpeedVariation<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.speedVariation = transform(v));
        public static void BindForceScale(this SurfaceEffector2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceScale = v);
        public static void BindForceScale<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceScale = transform(v));
        public static void BindUseContactForce(this SurfaceEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useContactForce = v);
        public static void BindUseContactForce<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useContactForce = transform(v));
        public static void BindUseFriction(this SurfaceEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useFriction = v);
        public static void BindUseFriction<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useFriction = transform(v));
        public static void BindUseBounce(this SurfaceEffector2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useBounce = v);
        public static void BindUseBounce<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useBounce = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindAnchor(this TargetJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindTarget(this TargetJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.target = v);
        public static void BindTarget<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.target = transform(v));
        public static void BindAutoConfigureTarget(this TargetJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureTarget = v);
        public static void BindAutoConfigureTarget<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureTarget = transform(v));
        public static void BindMaxForce(this TargetJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maxForce = transform(v));
        public static void BindDampingRatio(this TargetJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.dampingRatio = transform(v));
        public static void BindFrequency(this TargetJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = v);
        public static void BindFrequency<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.frequency = transform(v));
        public static void BindBreakForce(this TargetJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        #endif


        #if UNITY_TERRAIN_PHYSICS
        public static void BindIsTrigger(this TerrainCollider obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this TerrainCollider obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this TerrainCollider obj, IProperty<PhysicMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this TerrainCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this TerrainCollider obj, IProperty<PhysicsMaterial> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this TerrainCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        #endif
        public static void BindTerrainData(this TerrainCollider obj, IProperty<UnityEngine.TerrainData> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.terrainData = v);
        public static void BindTerrainData<T>(this TerrainCollider obj, IProperty<T> property, Func<T, UnityEngine.TerrainData> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.terrainData = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindText<T2>(this UnityEngine.UI.Text obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindFont(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Font> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = v);
        public static void BindFont<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Font> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = transform(v));
        public static void BindFontStyle(this UnityEngine.UI.Text obj, IProperty<UnityEngine.FontStyle> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.FontStyle> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = transform(v));
        public static void BindFontSize(this UnityEngine.UI.Text obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = transform(v));
        public static void BindLineSpacing(this UnityEngine.UI.Text obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = transform(v));
        public static void BindSupportRichText(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.supportRichText = v);
        public static void BindSupportRichText<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.supportRichText = transform(v));
        public static void BindAlignment(this UnityEngine.UI.Text obj, IProperty<UnityEngine.TextAnchor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        public static void BindAlignByGeometry(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignByGeometry = v);
        public static void BindAlignByGeometry<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignByGeometry = transform(v));
        public static void BindHorizontalOverflow(this UnityEngine.UI.Text obj, IProperty<UnityEngine.HorizontalWrapMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalOverflow = v);
        public static void BindHorizontalOverflow<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.HorizontalWrapMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalOverflow = transform(v));
        public static void BindVerticalOverflow(this UnityEngine.UI.Text obj, IProperty<UnityEngine.VerticalWrapMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalOverflow = v);
        public static void BindVerticalOverflow<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.VerticalWrapMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalOverflow = transform(v));
        public static void BindResizeTextForBestFit(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resizeTextForBestFit = v);
        public static void BindResizeTextForBestFit<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resizeTextForBestFit = transform(v));
        public static void BindColor(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastTarget = transform(v));
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.raycastPadding = transform(v));
        #endif
        public static void BindMaskable(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskable = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindAnchorPosition(this TMPro.TextContainer obj, IProperty<TMPro.TextContainerAnchors> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorPosition = v);
        public static void BindAnchorPosition<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, TMPro.TextContainerAnchors> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchorPosition = transform(v));
        public static void BindWidth(this TMPro.TextContainer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.width = v);
        public static void BindWidth<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.width = transform(v));
        public static void BindHeight(this TMPro.TextContainer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = v);
        public static void BindHeight<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.height = transform(v));
        public static void BindMargins(this TMPro.TextContainer obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margins = v);
        public static void BindMargins<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margins = transform(v));
        #endif


        public static void BindText<T2>(this TextMesh obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this TextMesh obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindOffsetZ(this TextMesh obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offsetZ = v);
        public static void BindOffsetZ<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offsetZ = transform(v));
        public static void BindCharacterSize(this TextMesh obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSize = v);
        public static void BindCharacterSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSize = transform(v));
        public static void BindLineSpacing(this TextMesh obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = transform(v));
        public static void BindAnchor(this TextMesh obj, IProperty<UnityEngine.TextAnchor> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindAlignment(this TextMesh obj, IProperty<UnityEngine.TextAlignment> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.TextAlignment> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        public static void BindTabSize(this TextMesh obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tabSize = v);
        public static void BindTabSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tabSize = transform(v));
        public static void BindFontSize(this TextMesh obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = transform(v));
        public static void BindFontStyle(this TextMesh obj, IProperty<UnityEngine.FontStyle> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.FontStyle> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = transform(v));
        public static void BindRichText(this TextMesh obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = v);
        public static void BindRichText<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = transform(v));
        public static void BindFont(this TextMesh obj, IProperty<UnityEngine.Font> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = v);
        public static void BindFont<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.Font> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = transform(v));
        public static void BindColor(this TextMesh obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));


        #if UNITY_TMPRO
        public static void BindText<T2>(this TMPro.TextMeshPro obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindFont(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_FontAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = v);
        public static void BindFont<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = transform(v));
        public static void BindFontStyle(this TMPro.TextMeshPro obj, IProperty<TMPro.FontStyles> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.FontStyles> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = transform(v));
        public static void BindFontSize(this TMPro.TextMeshPro obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = transform(v));
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoSizeTextContainer = v);
        public static void BindAutoSizeTextContainer<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoSizeTextContainer = transform(v));
        public static void BindColor(this TMPro.TextMeshPro obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindColorGradientPreset(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_ColorGradient> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradientPreset = v);
        public static void BindColorGradientPreset<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_ColorGradient> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradientPreset = transform(v));
        public static void BindColorGradient(this TMPro.TextMeshPro obj, IProperty<TMPro.VertexGradient> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.VertexGradient> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = transform(v));
        public static void BindOverrideColorTags(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overrideColorTags = v);
        public static void BindOverrideColorTags<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overrideColorTags = transform(v));
        public static void BindCharacterSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSpacing = v);
        public static void BindCharacterSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSpacing = transform(v));
        public static void BindWordSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wordSpacing = v);
        public static void BindWordSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wordSpacing = transform(v));
        public static void BindLineSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = transform(v));
        public static void BindParagraphSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.paragraphSpacing = v);
        public static void BindParagraphSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.paragraphSpacing = transform(v));
        public static void BindAlignment(this TMPro.TextMeshPro obj, IProperty<TMPro.TextAlignmentOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextAlignmentOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableWordWrapping(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableWordWrapping = v);
        public static void BindEnableWordWrapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableWordWrapping = transform(v));
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindTextWrappingMode(this TMPro.TextMeshPro obj, IProperty<TMPro.TextWrappingModes> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textWrappingMode = v);
        public static void BindTextWrappingMode<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextWrappingModes> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textWrappingMode = transform(v));
        #endif
        public static void BindOverflowMode(this TMPro.TextMeshPro obj, IProperty<TMPro.TextOverflowModes> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overflowMode = v);
        public static void BindOverflowMode<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextOverflowModes> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overflowMode = transform(v));
        public static void BindHorizontalMapping(this TMPro.TextMeshPro obj, IProperty<TMPro.TextureMappingOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalMapping = v);
        public static void BindHorizontalMapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalMapping = transform(v));
        public static void BindVerticalMapping(this TMPro.TextMeshPro obj, IProperty<TMPro.TextureMappingOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalMapping = v);
        public static void BindVerticalMapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalMapping = transform(v));
        public static void BindMargin(this TMPro.TextMeshPro obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margin = v);
        public static void BindMargin<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margin = transform(v));
        public static void BindSortingLayerID(this TMPro.TextMeshPro obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this TMPro.TextMeshPro obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));
        public static void BindGeometrySortingOrder(this TMPro.TextMeshPro obj, IProperty<TMPro.VertexSortingOrder> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometrySortingOrder = v);
        public static void BindGeometrySortingOrder<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.VertexSortingOrder> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometrySortingOrder = transform(v));
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTextObjectScaleStatic = v);
        public static void BindIsTextObjectScaleStatic<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTextObjectScaleStatic = transform(v));
        public static void BindIsOrthographic(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOrthographic = v);
        public static void BindIsOrthographic<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOrthographic = transform(v));
        public static void BindRichText(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = transform(v));
        public static void BindParseCtrlCharacters(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.parseCtrlCharacters = v);
        public static void BindParseCtrlCharacters<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.parseCtrlCharacters = transform(v));
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMaxVisibleDescender = v);
        public static void BindUseMaxVisibleDescender<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMaxVisibleDescender = transform(v));
        public static void BindSpriteAsset(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_SpriteAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = transform(v));
        public static void BindStyleSheet(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_StyleSheet> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.styleSheet = v);
        public static void BindStyleSheet<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_StyleSheet> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.styleSheet = transform(v));
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableKerning(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableKerning = v);
        public static void BindEnableKerning<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableKerning = transform(v));
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindFontFeatures(this TMPro.TextMeshPro obj, IProperty<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontFeatures = v);
        public static void BindFontFeatures<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontFeatures = transform(v));
        #endif
        public static void BindExtraPadding(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extraPadding = v);
        public static void BindExtraPadding<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extraPadding = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindText<T2>(this TMPro.TextMeshProUGUI obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindFont(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_FontAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = v);
        public static void BindFont<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.font = transform(v));
        public static void BindFontStyle(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.FontStyles> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.FontStyles> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontStyle = transform(v));
        public static void BindFontSize(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontSize = transform(v));
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoSizeTextContainer = v);
        public static void BindAutoSizeTextContainer<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoSizeTextContainer = transform(v));
        public static void BindColor(this TMPro.TextMeshProUGUI obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindColorGradientPreset(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_ColorGradient> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradientPreset = v);
        public static void BindColorGradientPreset<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_ColorGradient> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradientPreset = transform(v));
        public static void BindColorGradient(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.VertexGradient> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.VertexGradient> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = transform(v));
        public static void BindOverrideColorTags(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overrideColorTags = v);
        public static void BindOverrideColorTags<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overrideColorTags = transform(v));
        public static void BindCharacterSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSpacing = v);
        public static void BindCharacterSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterSpacing = transform(v));
        public static void BindWordSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wordSpacing = v);
        public static void BindWordSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wordSpacing = transform(v));
        public static void BindLineSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineSpacing = transform(v));
        public static void BindParagraphSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.paragraphSpacing = v);
        public static void BindParagraphSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.paragraphSpacing = transform(v));
        public static void BindAlignment(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextAlignmentOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextAlignmentOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableWordWrapping(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableWordWrapping = v);
        public static void BindEnableWordWrapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableWordWrapping = transform(v));
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindTextWrappingMode(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextWrappingModes> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textWrappingMode = v);
        public static void BindTextWrappingMode<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextWrappingModes> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textWrappingMode = transform(v));
        #endif
        public static void BindOverflowMode(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextOverflowModes> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overflowMode = v);
        public static void BindOverflowMode<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextOverflowModes> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.overflowMode = transform(v));
        public static void BindHorizontalMapping(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextureMappingOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalMapping = v);
        public static void BindHorizontalMapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.horizontalMapping = transform(v));
        public static void BindVerticalMapping(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextureMappingOptions> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalMapping = v);
        public static void BindVerticalMapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalMapping = transform(v));
        public static void BindMargin(this TMPro.TextMeshProUGUI obj, IProperty<UnityEngine.Vector4> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margin = v);
        public static void BindMargin<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.margin = transform(v));
        public static void BindGeometrySortingOrder(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.VertexSortingOrder> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometrySortingOrder = v);
        public static void BindGeometrySortingOrder<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.VertexSortingOrder> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.geometrySortingOrder = transform(v));
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTextObjectScaleStatic = v);
        public static void BindIsTextObjectScaleStatic<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTextObjectScaleStatic = transform(v));
        public static void BindIsOrthographic(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOrthographic = v);
        public static void BindIsOrthographic<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOrthographic = transform(v));
        public static void BindRichText(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = transform(v));
        public static void BindParseCtrlCharacters(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.parseCtrlCharacters = v);
        public static void BindParseCtrlCharacters<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.parseCtrlCharacters = transform(v));
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMaxVisibleDescender = v);
        public static void BindUseMaxVisibleDescender<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMaxVisibleDescender = transform(v));
        public static void BindSpriteAsset(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_SpriteAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = transform(v));
        public static void BindStyleSheet(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_StyleSheet> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.styleSheet = v);
        public static void BindStyleSheet<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_StyleSheet> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.styleSheet = transform(v));
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableKerning(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableKerning = v);
        public static void BindEnableKerning<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableKerning = transform(v));
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindFontFeatures(this TMPro.TextMeshProUGUI obj, IProperty<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontFeatures = v);
        public static void BindFontFeatures<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontFeatures = transform(v));
        #endif
        public static void BindExtraPadding(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extraPadding = v);
        public static void BindExtraPadding<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extraPadding = transform(v));
        #endif


        #if UNITY_TILEMAP
        public static void BindAnimationFrameRate(this UnityEngine.Tilemaps.Tilemap obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.animationFrameRate = v);
        public static void BindAnimationFrameRate<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.animationFrameRate = transform(v));
        public static void BindColor(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.color = transform(v));
        public static void BindTileAnchor(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tileAnchor = v);
        public static void BindTileAnchor<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.tileAnchor = transform(v));
        public static void BindOrientation(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Tilemaps.Tilemap.Orientation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orientation = v);
        public static void BindOrientation<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.Tilemap.Orientation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.orientation = transform(v));
        #endif


        #if UNITY_TILEMAP
        public static void BindMaximumTileChangeCount(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.UInt32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maximumTileChangeCount = v);
        public static void BindMaximumTileChangeCount<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.UInt32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maximumTileChangeCount = transform(v));
        public static void BindExtrusionFactor(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extrusionFactor = v);
        public static void BindExtrusionFactor<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.extrusionFactor = transform(v));
        public static void BindSharedMaterial(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterial = transform(v));
        public static void BindIsTrigger(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isTrigger = transform(v));
        public static void BindUsedByEffector(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByEffector = transform(v));
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.usedByComposite = transform(v));
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.compositeOperation = transform(v));
        #endif
        public static void BindOffset(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = v);
        public static void BindOffset<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.offset = transform(v));
        #endif


        #if UNITY_TILEMAP
        public static void BindSortOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.SortOrder> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortOrder = v);
        public static void BindSortOrder<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.SortOrder> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortOrder = transform(v));
        public static void BindMode(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.Mode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = v);
        public static void BindMode<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.Mode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = transform(v));
        public static void BindDetectChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.detectChunkCullingBounds = v);
        public static void BindDetectChunkCullingBounds<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.detectChunkCullingBounds = transform(v));
        public static void BindChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.chunkCullingBounds = v);
        public static void BindChunkCullingBounds<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.chunkCullingBounds = transform(v));
        public static void BindMaskInteraction(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.maskInteraction = transform(v));
        public static void BindSharedMaterials(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindSortingLayerID(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindTemplate(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.template = v);
        public static void BindTemplate<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.template = transform(v));
        public static void BindCaptionText(this TMPro.TMP_Dropdown obj, IProperty<TMPro.TMP_Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionText = v);
        public static void BindCaptionText<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionText = transform(v));
        public static void BindCaptionImage(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Image> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionImage = v);
        public static void BindCaptionImage<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.captionImage = transform(v));
        public static void BindPlaceholder(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = transform(v));
        public static void BindItemText(this TMPro.TMP_Dropdown obj, IProperty<TMPro.TMP_Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemText = v);
        public static void BindItemText<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemText = transform(v));
        public static void BindItemImage(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Image> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemImage = v);
        public static void BindItemImage<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.itemImage = transform(v));
        public static void BindValue(this TMPro.TMP_Dropdown obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = v);
        public static void BindValue<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.value = transform(v));
        public static void BindAlphaFadeSpeed(this TMPro.TMP_Dropdown obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaFadeSpeed = v);
        public static void BindAlphaFadeSpeed<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alphaFadeSpeed = transform(v));
        public static void BindOptions(this TMPro.TMP_Dropdown obj, IProperty<System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.options = v);
        public static void BindOptions<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.options = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindInteractable(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindTextViewport(this TMPro.TMP_InputField obj, IProperty<UnityEngine.RectTransform> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textViewport = v);
        public static void BindTextViewport<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textViewport = transform(v));
        public static void BindTextComponent(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_Text> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textComponent = v);
        public static void BindTextComponent<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textComponent = transform(v));
        public static void BindText<T2>(this TMPro.TMP_InputField obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = v.ToString());
        public static void BindText<T, T2>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.text = transform(v).ToString());
        public static void BindFontAsset(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_FontAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = transform(v));
        public static void BindPointSize(this TMPro.TMP_InputField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pointSize = v);
        public static void BindPointSize<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.pointSize = transform(v));
        public static void BindCharacterLimit(this TMPro.TMP_InputField obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterLimit = v);
        public static void BindCharacterLimit<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.characterLimit = transform(v));
        public static void BindContentType(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_InputField.ContentType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.contentType = v);
        public static void BindContentType<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_InputField.ContentType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.contentType = transform(v));
        public static void BindLineType(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_InputField.LineType> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineType = v);
        public static void BindLineType<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_InputField.LineType> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lineType = transform(v));
        public static void BindPlaceholder(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.placeholder = transform(v));
        public static void BindVerticalScrollbar(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Scrollbar> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalScrollbar = v);
        public static void BindVerticalScrollbar<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.verticalScrollbar = transform(v));
        public static void BindCaretBlinkRate(this TMPro.TMP_InputField obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretBlinkRate = v);
        public static void BindCaretBlinkRate<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretBlinkRate = transform(v));
        public static void BindCaretWidth(this TMPro.TMP_InputField obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretWidth = v);
        public static void BindCaretWidth<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.caretWidth = transform(v));
        public static void BindCustomCaretColor(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.customCaretColor = v);
        public static void BindCustomCaretColor<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.customCaretColor = transform(v));
        public static void BindSelectionColor(this TMPro.TMP_InputField obj, IProperty<UnityEngine.Color> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.selectionColor = v);
        public static void BindSelectionColor<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.Color> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.selectionColor = transform(v));
        public static void BindOnFocusSelectAll(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.onFocusSelectAll = v);
        public static void BindOnFocusSelectAll<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.onFocusSelectAll = transform(v));
        public static void BindResetOnDeActivation(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resetOnDeActivation = v);
        public static void BindResetOnDeActivation<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.resetOnDeActivation = transform(v));
        public static void BindRestoreOriginalTextOnEscape(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.restoreOriginalTextOnEscape = v);
        public static void BindRestoreOriginalTextOnEscape<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.restoreOriginalTextOnEscape = transform(v));
        public static void BindShouldHideSoftKeyboard(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideSoftKeyboard = v);
        public static void BindShouldHideSoftKeyboard<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideSoftKeyboard = transform(v));
        public static void BindShouldHideMobileInput(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideMobileInput = v);
        public static void BindShouldHideMobileInput<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shouldHideMobileInput = transform(v));
        public static void BindReadOnly(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.readOnly = v);
        public static void BindReadOnly<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.readOnly = transform(v));
        public static void BindRichText(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.richText = transform(v));
        public static void BindIsRichTextEditingAllowed(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isRichTextEditingAllowed = v);
        public static void BindIsRichTextEditingAllowed<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isRichTextEditingAllowed = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindIsSelected(this TMPro.TMP_ScrollbarEventHandler obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isSelected = v);
        public static void BindIsSelected<T>(this TMPro.TMP_ScrollbarEventHandler obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isSelected = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindFontAsset(this TMPro.TMP_SubMesh obj, IProperty<TMPro.TMP_FontAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_SubMesh obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TMP_SubMesh obj, IProperty<TMPro.TMP_SpriteAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TMP_SubMesh obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = transform(v));
        #endif


        #if UNITY_TMPRO
        public static void BindFontAsset(this TMPro.TMP_SubMeshUI obj, IProperty<TMPro.TMP_FontAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_SubMeshUI obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.fontAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TMP_SubMeshUI obj, IProperty<TMPro.TMP_SpriteAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TMP_SubMeshUI obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.spriteAsset = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Toggle obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.interactable = transform(v));
        public static void BindTransition(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Selectable.Transition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.transition = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetGraphic = transform(v));
        public static void BindColors(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.ColorBlock> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colors = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Navigation> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.navigation = transform(v));
        public static void BindIsOn(this UnityEngine.UI.Toggle obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOn = v);
        public static void BindIsOn<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isOn = transform(v));
        public static void BindToggleTransition(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Toggle.ToggleTransition> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.toggleTransition = v);
        public static void BindToggleTransition<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Toggle.ToggleTransition> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.toggleTransition = transform(v));
        public static void BindGraphic(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Graphic> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.graphic = v);
        public static void BindGraphic<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.graphic = transform(v));
        public static void BindGroup(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.ToggleGroup> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.group = v);
        public static void BindGroup<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.ToggleGroup> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.group = transform(v));
        #endif


        #if UNITY_GUI
        public static void BindAllowSwitchOff(this UnityEngine.UI.ToggleGroup obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowSwitchOff = v);
        public static void BindAllowSwitchOff<T>(this UnityEngine.UI.ToggleGroup obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowSwitchOff = transform(v));
        #endif


        public static void BindTime(this TrailRenderer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.time = v);
        public static void BindTime<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.time = transform(v));
        public static void BindMinVertexDistance(this TrailRenderer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minVertexDistance = v);
        public static void BindMinVertexDistance<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.minVertexDistance = transform(v));
        public static void BindAutodestruct(this TrailRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autodestruct = v);
        public static void BindAutodestruct<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autodestruct = transform(v));
        public static void BindEmitting(this TrailRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.emitting = v);
        public static void BindEmitting<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.emitting = transform(v));
        public static void BindColorGradient(this TrailRenderer obj, IProperty<UnityEngine.Gradient> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Gradient> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.colorGradient = transform(v));
        public static void BindNumCornerVertices(this TrailRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCornerVertices = v);
        public static void BindNumCornerVertices<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCornerVertices = transform(v));
        public static void BindNumCapVertices(this TrailRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCapVertices = v);
        public static void BindNumCapVertices<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.numCapVertices = transform(v));
        public static void BindAlignment(this TrailRenderer obj, IProperty<UnityEngine.LineAlignment> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineAlignment> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.alignment = transform(v));
        public static void BindTextureMode(this TrailRenderer obj, IProperty<UnityEngine.LineTextureMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textureMode = v);
        public static void BindTextureMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineTextureMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.textureMode = transform(v));
        public static void BindGenerateLightingData(this TrailRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generateLightingData = v);
        public static void BindGenerateLightingData<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.generateLightingData = transform(v));
        public static void BindShadowBias(this TrailRenderer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowBias = v);
        public static void BindShadowBias<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowBias = transform(v));
        public static void BindSharedMaterials(this TrailRenderer obj, IProperty<UnityEngine.Material[]> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sharedMaterials = transform(v));
        public static void BindShadowCastingMode(this TrailRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.shadowCastingMode = transform(v));
        public static void BindReceiveShadows(this TrailRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.receiveShadows = transform(v));
        public static void BindLightProbeUsage(this TrailRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.lightProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this TrailRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindMotionVectorGenerationMode(this TrailRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this TrailRenderer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindSortingLayerID(this TrailRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingOrder(this TrailRenderer obj, IProperty<System.Int32> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));


        public static void BindLocalPosition(this Transform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localPosition = v);
        public static void BindLocalPosition<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localPosition = transform(v));
        public static void BindLocalRotation(this Transform obj, IProperty<UnityEngine.Quaternion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localRotation = v);
        public static void BindLocalRotation<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localRotation = transform(v));
        public static void BindLocalScale(this Transform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localScale = v);
        public static void BindLocalScale<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.localScale = transform(v));
        public static void BindPosition(this Transform obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.position = v);
        public static void BindPosition<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.position = transform(v));
        public static void BindRotation(this Transform obj, IProperty<UnityEngine.Quaternion> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotation = v);
        public static void BindRotation<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.rotation = transform(v));


        #if UNITY_2021_2_OR_NEWER&&UNITY_UIELEMENTS
        public static void BindPanelSettings(this UnityEngine.UIElements.UIDocument obj, IProperty<UnityEngine.UIElements.PanelSettings> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.panelSettings = v);
        public static void BindPanelSettings<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, UnityEngine.UIElements.PanelSettings> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.panelSettings = transform(v));
        public static void BindVisualTreeAsset(this UnityEngine.UIElements.UIDocument obj, IProperty<UnityEngine.UIElements.VisualTreeAsset> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.visualTreeAsset = v);
        public static void BindVisualTreeAsset<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, UnityEngine.UIElements.VisualTreeAsset> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.visualTreeAsset = transform(v));
        public static void BindSortingOrder(this UnityEngine.UIElements.UIDocument obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sortingOrder = transform(v));
        #endif


        #if UNITY_VIDEO
        public static void BindSource(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoSource> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.source = v);
        public static void BindSource<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoSource> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.source = transform(v));
        public static void BindClip(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoClip> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = v);
        public static void BindClip<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoClip> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.clip = transform(v));
        public static void BindUrl<T2>(this UnityEngine.Video.VideoPlayer obj, IProperty<T2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.url = v.ToString());
        public static void BindUrl<T, T2>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.url = transform(v).ToString());
        public static void BindPlayOnAwake(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playOnAwake = transform(v));
        public static void BindWaitForFirstFrame(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.waitForFirstFrame = v);
        public static void BindWaitForFirstFrame<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.waitForFirstFrame = transform(v));
        public static void BindIsLooping(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isLooping = v);
        public static void BindIsLooping<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.isLooping = transform(v));
        public static void BindSkipOnDrop(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.skipOnDrop = v);
        public static void BindSkipOnDrop<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.skipOnDrop = transform(v));
        public static void BindPlaybackSpeed(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playbackSpeed = v);
        public static void BindPlaybackSpeed<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.playbackSpeed = transform(v));
        public static void BindRenderMode(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoRenderMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoRenderMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.renderMode = transform(v));
        public static void BindTargetCamera(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Camera> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCamera = v);
        public static void BindTargetCamera<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Camera> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCamera = transform(v));
        public static void BindTargetCameraAlpha(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCameraAlpha = v);
        public static void BindTargetCameraAlpha<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCameraAlpha = transform(v));
        public static void BindTargetCamera3DLayout(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.Video3DLayout> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCamera3DLayout = v);
        public static void BindTargetCamera3DLayout<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.Video3DLayout> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.targetCamera3DLayout = transform(v));
        public static void BindAspectRatio(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoAspectRatio> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aspectRatio = v);
        public static void BindAspectRatio<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoAspectRatio> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.aspectRatio = transform(v));
        public static void BindAudioOutputMode(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoAudioOutputMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.audioOutputMode = v);
        public static void BindAudioOutputMode<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoAudioOutputMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.audioOutputMode = transform(v));
        public static void BindControlledAudioTrackCount(this UnityEngine.Video.VideoPlayer obj, IProperty<System.UInt16> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.controlledAudioTrackCount = v);
        public static void BindControlledAudioTrackCount<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.UInt16> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.controlledAudioTrackCount = transform(v));
        #endif


        #if UNITY_VEHICLES
        public static void BindMass(this WheelCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = v);
        public static void BindMass<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mass = transform(v));
        public static void BindRadius(this WheelCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = v);
        public static void BindRadius<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.radius = transform(v));
        public static void BindWheelDampingRate(this WheelCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wheelDampingRate = v);
        public static void BindWheelDampingRate<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.wheelDampingRate = transform(v));
        public static void BindSuspensionDistance(this WheelCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspensionDistance = v);
        public static void BindSuspensionDistance<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspensionDistance = transform(v));
        public static void BindForceAppPointDistance(this WheelCollider obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceAppPointDistance = v);
        public static void BindForceAppPointDistance<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forceAppPointDistance = transform(v));
        public static void BindCenter(this WheelCollider obj, IProperty<UnityEngine.Vector3> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = v);
        public static void BindCenter<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.center = transform(v));
        public static void BindSuspensionSpring(this WheelCollider obj, IProperty<UnityEngine.JointSpring> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspensionSpring = v);
        public static void BindSuspensionSpring<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.JointSpring> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspensionSpring = transform(v));
        public static void BindForwardFriction(this WheelCollider obj, IProperty<UnityEngine.WheelFrictionCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forwardFriction = v);
        public static void BindForwardFriction<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.WheelFrictionCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.forwardFriction = transform(v));
        public static void BindSidewaysFriction(this WheelCollider obj, IProperty<UnityEngine.WheelFrictionCurve> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sidewaysFriction = v);
        public static void BindSidewaysFriction<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.WheelFrictionCurve> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.sidewaysFriction = transform(v));
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this WheelJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.enableCollision = transform(v));
        public static void BindConnectedBody(this WheelJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedBody = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this WheelJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAnchor(this WheelJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = v);
        public static void BindAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.anchor = transform(v));
        public static void BindConnectedAnchor(this WheelJoint2D obj, IProperty<UnityEngine.Vector2> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.connectedAnchor = transform(v));
        public static void BindSuspension(this WheelJoint2D obj, IProperty<UnityEngine.JointSuspension2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspension = v);
        public static void BindSuspension<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointSuspension2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.suspension = transform(v));
        public static void BindUseMotor(this WheelJoint2D obj, IProperty<System.Boolean> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.useMotor = transform(v));
        public static void BindMotor(this WheelJoint2D obj, IProperty<UnityEngine.JointMotor2D> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = v);
        public static void BindMotor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.motor = transform(v));
        public static void BindBreakForce(this WheelJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakForce = transform(v));
        public static void BindBreakTorque(this WheelJoint2D obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.breakTorque = transform(v));
        #endif


        #if UNITY_WIND
        public static void BindMode(this WindZone obj, IProperty<UnityEngine.WindZoneMode> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = v);
        public static void BindMode<T>(this WindZone obj, IProperty<T> property, Func<T, UnityEngine.WindZoneMode> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.mode = transform(v));
        public static void BindWindMain(this WindZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windMain = v);
        public static void BindWindMain<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windMain = transform(v));
        public static void BindWindTurbulence(this WindZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windTurbulence = v);
        public static void BindWindTurbulence<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windTurbulence = transform(v));
        public static void BindWindPulseMagnitude(this WindZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windPulseMagnitude = v);
        public static void BindWindPulseMagnitude<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windPulseMagnitude = transform(v));
        public static void BindWindPulseFrequency(this WindZone obj, IProperty<System.Single> property, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windPulseFrequency = v);
        public static void BindWindPulseFrequency<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.windPulseFrequency = transform(v));
        #endif
    }
}