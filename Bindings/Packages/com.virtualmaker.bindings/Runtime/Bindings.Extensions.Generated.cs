using System;
using UnityEngine;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.AimConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.AimConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindAimVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.aimVector = v);
        public static void BindAimVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.aimVector = transform(v));
        public static void BindAimVector(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.aimVector = transform());
        public static void BindAimVectorInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.aimVector = transform());
        public static void BindAimVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.aimVector = Vector3.Lerp(obj.aimVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAimVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.aimVector = Vector3.Lerp(obj.aimVector, transform(), speed * Time.smoothDeltaTime));
        public static void BindAimVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.aimVector = Vector3.MoveTowards(obj.aimVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAimVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.aimVector = Vector3.MoveTowards(obj.aimVector, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAimVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.aimVector = Vector3.Lerp(start, end, t));
        public static void AnimateAimVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAimVector(obj, obj.aimVector, end, curve);
        public static void BindUpVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.upVector = v);
        public static void BindUpVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.upVector = transform(v));
        public static void BindUpVector(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.upVector = transform());
        public static void BindUpVectorInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.upVector = transform());
        public static void BindUpVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.upVector = Vector3.Lerp(obj.upVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindUpVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.upVector = Vector3.Lerp(obj.upVector, transform(), speed * Time.smoothDeltaTime));
        public static void BindUpVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.upVector = Vector3.MoveTowards(obj.upVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindUpVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.upVector = Vector3.MoveTowards(obj.upVector, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateUpVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.upVector = Vector3.Lerp(start, end, t));
        public static void AnimateUpVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateUpVector(obj, obj.upVector, end, curve);
        public static void BindWorldUpType(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Animations.AimConstraint.WorldUpType> property)
            => Bindings2._scope.Bind(property, v => obj.worldUpType = v);
        public static void BindWorldUpType<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.AimConstraint.WorldUpType> transform)
            => Bindings2._scope.Bind(property, v => obj.worldUpType = transform(v));
        public static void BindWorldUpType(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Animations.AimConstraint.WorldUpType> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpType = transform());
        public static void BindWorldUpTypeInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Animations.AimConstraint.WorldUpType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldUpType = transform());
        public static void BindWorldUpVector(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.worldUpVector = v);
        public static void BindWorldUpVector<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.worldUpVector = transform(v));
        public static void BindWorldUpVector(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpVector = transform());
        public static void BindWorldUpVectorInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldUpVector = transform());
        public static void BindWorldUpVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.worldUpVector = Vector3.Lerp(obj.worldUpVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindWorldUpVectorLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpVector = Vector3.Lerp(obj.worldUpVector, transform(), speed * Time.smoothDeltaTime));
        public static void BindWorldUpVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.worldUpVector = Vector3.MoveTowards(obj.worldUpVector, property.Value, speed * Time.smoothDeltaTime));
        public static void BindWorldUpVectorTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpVector = Vector3.MoveTowards(obj.worldUpVector, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateWorldUpVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.worldUpVector = Vector3.Lerp(start, end, t));
        public static void AnimateWorldUpVector(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateWorldUpVector(obj, obj.worldUpVector, end, curve);
        public static void BindWorldUpObject(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.worldUpObject = v);
        public static void BindWorldUpObject<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.worldUpObject = transform(v));
        public static void BindWorldUpObject(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpObject = transform());
        public static void BindWorldUpObjectInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldUpObject = transform());
        public static void BindLocked(this UnityEngine.Animations.AimConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.AimConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindRotationAtRest(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = transform());
        public static void BindRotationAtRestInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAtRest = transform());
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationAtRest(obj, obj.rotationAtRest, end, curve);
        public static void BindRotationOffset(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = transform());
        public static void BindRotationOffsetInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationOffset = transform());
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.AimConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationOffset(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationOffset = Vector3.Lerp(start, end, t));
        public static void AnimateRotationOffset(this UnityEngine.Animations.AimConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationOffset(obj, obj.rotationOffset, end, curve);
        public static void BindRotationAxis(this UnityEngine.Animations.AimConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.AimConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.AimConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAxis = transform());
        public static void BindRotationAxisInterval(this UnityEngine.Animations.AimConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAxis = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindClip(this Animation obj, IProperty<UnityEngine.AnimationClip> property)
            => Bindings2._scope.Bind(property, v => obj.clip = v);
        public static void BindClip<T>(this Animation obj, IProperty<T> property, Func<T, UnityEngine.AnimationClip> transform)
            => Bindings2._scope.Bind(property, v => obj.clip = transform(v));
        public static void BindClip(this Animation obj, Func<UnityEngine.AnimationClip> transform)
            => Bindings2._scope.BindUpdate(() => obj.clip = transform());
        public static void BindClipInterval(this Animation obj, float seconds, Func<UnityEngine.AnimationClip> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clip = transform());
        public static void BindPlayAutomatically(this Animation obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.playAutomatically = v);
        public static void BindPlayAutomatically<T>(this Animation obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.playAutomatically = transform(v));
        public static void BindPlayAutomatically(this Animation obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.playAutomatically = transform());
        public static void BindPlayAutomaticallyInterval(this Animation obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playAutomatically = transform());
        public static void BindAnimatePhysics(this Animation obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.animatePhysics = v);
        public static void BindAnimatePhysics<T>(this Animation obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.animatePhysics = transform(v));
        public static void BindAnimatePhysics(this Animation obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.animatePhysics = transform());
        public static void BindAnimatePhysicsInterval(this Animation obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.animatePhysics = transform());
        public static void BindCullingType(this Animation obj, IProperty<UnityEngine.AnimationCullingType> property)
            => Bindings2._scope.Bind(property, v => obj.cullingType = v);
        public static void BindCullingType<T>(this Animation obj, IProperty<T> property, Func<T, UnityEngine.AnimationCullingType> transform)
            => Bindings2._scope.Bind(property, v => obj.cullingType = transform(v));
        public static void BindCullingType(this Animation obj, Func<UnityEngine.AnimationCullingType> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullingType = transform());
        public static void BindCullingTypeInterval(this Animation obj, float seconds, Func<UnityEngine.AnimationCullingType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullingType = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindRuntimeAnimatorController(this Animator obj, IProperty<UnityEngine.RuntimeAnimatorController> property)
            => Bindings2._scope.Bind(property, v => obj.runtimeAnimatorController = v);
        public static void BindRuntimeAnimatorController<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.RuntimeAnimatorController> transform)
            => Bindings2._scope.Bind(property, v => obj.runtimeAnimatorController = transform(v));
        public static void BindRuntimeAnimatorController(this Animator obj, Func<UnityEngine.RuntimeAnimatorController> transform)
            => Bindings2._scope.BindUpdate(() => obj.runtimeAnimatorController = transform());
        public static void BindRuntimeAnimatorControllerInterval(this Animator obj, float seconds, Func<UnityEngine.RuntimeAnimatorController> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.runtimeAnimatorController = transform());
        public static void BindAvatar(this Animator obj, IProperty<UnityEngine.Avatar> property)
            => Bindings2._scope.Bind(property, v => obj.avatar = v);
        public static void BindAvatar<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.Avatar> transform)
            => Bindings2._scope.Bind(property, v => obj.avatar = transform(v));
        public static void BindAvatar(this Animator obj, Func<UnityEngine.Avatar> transform)
            => Bindings2._scope.BindUpdate(() => obj.avatar = transform());
        public static void BindAvatarInterval(this Animator obj, float seconds, Func<UnityEngine.Avatar> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.avatar = transform());
        public static void BindApplyRootMotion(this Animator obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.applyRootMotion = v);
        public static void BindApplyRootMotion<T>(this Animator obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.applyRootMotion = transform(v));
        public static void BindApplyRootMotion(this Animator obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.applyRootMotion = transform());
        public static void BindApplyRootMotionInterval(this Animator obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.applyRootMotion = transform());
        public static void BindUpdateMode(this Animator obj, IProperty<UnityEngine.AnimatorUpdateMode> property)
            => Bindings2._scope.Bind(property, v => obj.updateMode = v);
        public static void BindUpdateMode<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.AnimatorUpdateMode> transform)
            => Bindings2._scope.Bind(property, v => obj.updateMode = transform(v));
        public static void BindUpdateMode(this Animator obj, Func<UnityEngine.AnimatorUpdateMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.updateMode = transform());
        public static void BindUpdateModeInterval(this Animator obj, float seconds, Func<UnityEngine.AnimatorUpdateMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.updateMode = transform());
        public static void BindCullingMode(this Animator obj, IProperty<UnityEngine.AnimatorCullingMode> property)
            => Bindings2._scope.Bind(property, v => obj.cullingMode = v);
        public static void BindCullingMode<T>(this Animator obj, IProperty<T> property, Func<T, UnityEngine.AnimatorCullingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.cullingMode = transform(v));
        public static void BindCullingMode(this Animator obj, Func<UnityEngine.AnimatorCullingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullingMode = transform());
        public static void BindCullingModeInterval(this Animator obj, float seconds, Func<UnityEngine.AnimatorCullingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullingMode = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this AreaEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = transform(v));
        public static void BindUseColliderMask(this AreaEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useColliderMask = transform());
        public static void BindUseColliderMaskInterval(this AreaEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useColliderMask = transform());
        public static void BindColliderMask(this AreaEffector2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = transform(v));
        public static void BindColliderMask(this AreaEffector2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.colliderMask = transform());
        public static void BindColliderMaskInterval(this AreaEffector2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colliderMask = transform());
        public static void BindUseGlobalAngle(this AreaEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGlobalAngle = v);
        public static void BindUseGlobalAngle<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGlobalAngle = transform(v));
        public static void BindUseGlobalAngle(this AreaEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGlobalAngle = transform());
        public static void BindUseGlobalAngleInterval(this AreaEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGlobalAngle = transform());
        public static void BindForceAngle(this AreaEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceAngle = v);
        public static void BindForceAngle<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceAngle = transform(v));
        public static void BindForceAngle(this AreaEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceAngle = transform());
        public static void BindForceAngleInterval(this AreaEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceAngle = transform());
        public static void BindForceMagnitude(this AreaEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceMagnitude = v);
        public static void BindForceMagnitude<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceMagnitude = transform(v));
        public static void BindForceMagnitude(this AreaEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceMagnitude = transform());
        public static void BindForceMagnitudeInterval(this AreaEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceMagnitude = transform());
        public static void BindForceVariation(this AreaEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceVariation = v);
        public static void BindForceVariation<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceVariation = transform(v));
        public static void BindForceVariation(this AreaEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceVariation = transform());
        public static void BindForceVariationInterval(this AreaEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceVariation = transform());
        public static void BindForceTarget(this AreaEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property)
            => Bindings2._scope.Bind(property, v => obj.forceTarget = v);
        public static void BindForceTarget<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.Bind(property, v => obj.forceTarget = transform(v));
        public static void BindForceTarget(this AreaEffector2D obj, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceTarget = transform());
        public static void BindForceTargetInterval(this AreaEffector2D obj, float seconds, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceTarget = transform());
        #if !UNITY_6000_1_OR_NEWER
        public static void BindDrag(this AreaEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.drag = v);
        public static void BindDrag<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.drag = transform(v));
        public static void BindDrag(this AreaEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.drag = transform());
        public static void BindDragInterval(this AreaEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drag = transform());
        #endif
        #if !UNITY_6000_1_OR_NEWER
        public static void BindAngularDrag(this AreaEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this AreaEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = transform(v));
        public static void BindAngularDrag(this AreaEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDrag = transform());
        public static void BindAngularDragInterval(this AreaEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDrag = transform());
        #endif
        #endif


        #if UNITY_2020_3_OR_NEWER&&UNITY_PHYSICS
        public static void BindMass(this ArticulationBody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.mass = v);
        public static void BindMass<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.mass = transform(v));
        public static void BindMass(this ArticulationBody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.mass = transform());
        public static void BindMassInterval(this ArticulationBody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mass = transform());
        public static void BindUseGravity(this ArticulationBody obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGravity = transform(v));
        public static void BindUseGravity(this ArticulationBody obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGravity = transform());
        public static void BindUseGravityInterval(this ArticulationBody obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGravity = transform());
        public static void BindImmovable(this ArticulationBody obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.immovable = v);
        public static void BindImmovable<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.immovable = transform(v));
        public static void BindImmovable(this ArticulationBody obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.immovable = transform());
        public static void BindImmovableInterval(this ArticulationBody obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.immovable = transform());
        public static void BindLinearDamping(this ArticulationBody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = transform(v));
        public static void BindLinearDamping(this ArticulationBody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearDamping = transform());
        public static void BindLinearDampingInterval(this ArticulationBody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearDamping = transform());
        public static void BindAngularDamping(this ArticulationBody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this ArticulationBody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = transform(v));
        public static void BindAngularDamping(this ArticulationBody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDamping = transform());
        public static void BindAngularDampingInterval(this ArticulationBody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDamping = transform());
        public static void BindCollisionDetectionMode(this ArticulationBody obj, IProperty<UnityEngine.CollisionDetectionMode> property)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this ArticulationBody obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = transform(v));
        public static void BindCollisionDetectionMode(this ArticulationBody obj, Func<UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.collisionDetectionMode = transform());
        public static void BindCollisionDetectionModeInterval(this ArticulationBody obj, float seconds, Func<UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.collisionDetectionMode = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindDryMix(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dryMix = v);
        public static void BindDryMix<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dryMix = transform(v));
        public static void BindDryMix(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dryMix = transform());
        public static void BindDryMixInterval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dryMix = transform());
        public static void BindWetMix1(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wetMix1 = v);
        public static void BindWetMix1<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wetMix1 = transform(v));
        public static void BindWetMix1(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wetMix1 = transform());
        public static void BindWetMix1Interval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wetMix1 = transform());
        public static void BindWetMix2(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wetMix2 = v);
        public static void BindWetMix2<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wetMix2 = transform(v));
        public static void BindWetMix2(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wetMix2 = transform());
        public static void BindWetMix2Interval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wetMix2 = transform());
        public static void BindWetMix3(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wetMix3 = v);
        public static void BindWetMix3<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wetMix3 = transform(v));
        public static void BindWetMix3(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wetMix3 = transform());
        public static void BindWetMix3Interval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wetMix3 = transform());
        public static void BindDelay(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.delay = v);
        public static void BindDelay<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.delay = transform(v));
        public static void BindDelay(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.delay = transform());
        public static void BindDelayInterval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.delay = transform());
        public static void BindRate(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.rate = v);
        public static void BindRate<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.rate = transform(v));
        public static void BindRate(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.rate = transform());
        public static void BindRateInterval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rate = transform());
        public static void BindDepth(this AudioChorusFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.depth = v);
        public static void BindDepth<T>(this AudioChorusFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.depth = transform(v));
        public static void BindDepth(this AudioChorusFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.depth = transform());
        public static void BindDepthInterval(this AudioChorusFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.depth = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindDistortionLevel(this AudioDistortionFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.distortionLevel = v);
        public static void BindDistortionLevel<T>(this AudioDistortionFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.distortionLevel = transform(v));
        public static void BindDistortionLevel(this AudioDistortionFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.distortionLevel = transform());
        public static void BindDistortionLevelInterval(this AudioDistortionFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.distortionLevel = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindDelay(this AudioEchoFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.delay = v);
        public static void BindDelay<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.delay = transform(v));
        public static void BindDelay(this AudioEchoFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.delay = transform());
        public static void BindDelayInterval(this AudioEchoFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.delay = transform());
        public static void BindDecayRatio(this AudioEchoFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decayRatio = v);
        public static void BindDecayRatio<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decayRatio = transform(v));
        public static void BindDecayRatio(this AudioEchoFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decayRatio = transform());
        public static void BindDecayRatioInterval(this AudioEchoFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decayRatio = transform());
        public static void BindDryMix(this AudioEchoFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dryMix = v);
        public static void BindDryMix<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dryMix = transform(v));
        public static void BindDryMix(this AudioEchoFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dryMix = transform());
        public static void BindDryMixInterval(this AudioEchoFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dryMix = transform());
        public static void BindWetMix(this AudioEchoFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wetMix = v);
        public static void BindWetMix<T>(this AudioEchoFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wetMix = transform(v));
        public static void BindWetMix(this AudioEchoFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wetMix = transform());
        public static void BindWetMixInterval(this AudioEchoFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wetMix = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindCutoffFrequency(this AudioHighPassFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.cutoffFrequency = v);
        public static void BindCutoffFrequency<T>(this AudioHighPassFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.cutoffFrequency = transform(v));
        public static void BindCutoffFrequency(this AudioHighPassFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.cutoffFrequency = transform());
        public static void BindCutoffFrequencyInterval(this AudioHighPassFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cutoffFrequency = transform());
        public static void BindHighpassResonanceQ(this AudioHighPassFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.highpassResonanceQ = v);
        public static void BindHighpassResonanceQ<T>(this AudioHighPassFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.highpassResonanceQ = transform(v));
        public static void BindHighpassResonanceQ(this AudioHighPassFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.highpassResonanceQ = transform());
        public static void BindHighpassResonanceQInterval(this AudioHighPassFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.highpassResonanceQ = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindCutoffFrequency(this AudioLowPassFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.cutoffFrequency = v);
        public static void BindCutoffFrequency<T>(this AudioLowPassFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.cutoffFrequency = transform(v));
        public static void BindCutoffFrequency(this AudioLowPassFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.cutoffFrequency = transform());
        public static void BindCutoffFrequencyInterval(this AudioLowPassFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cutoffFrequency = transform());
        public static void BindLowpassResonanceQ(this AudioLowPassFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lowpassResonanceQ = v);
        public static void BindLowpassResonanceQ<T>(this AudioLowPassFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lowpassResonanceQ = transform(v));
        public static void BindLowpassResonanceQ(this AudioLowPassFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lowpassResonanceQ = transform());
        public static void BindLowpassResonanceQInterval(this AudioLowPassFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lowpassResonanceQ = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindReverbPreset(this AudioReverbFilter obj, IProperty<UnityEngine.AudioReverbPreset> property)
            => Bindings2._scope.Bind(property, v => obj.reverbPreset = v);
        public static void BindReverbPreset<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbPreset = transform(v));
        public static void BindReverbPreset(this AudioReverbFilter obj, Func<UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbPreset = transform());
        public static void BindReverbPresetInterval(this AudioReverbFilter obj, float seconds, Func<UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbPreset = transform());
        public static void BindDryLevel(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dryLevel = v);
        public static void BindDryLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dryLevel = transform(v));
        public static void BindDryLevel(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dryLevel = transform());
        public static void BindDryLevelInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dryLevel = transform());
        public static void BindRoom(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.room = v);
        public static void BindRoom<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.room = transform(v));
        public static void BindRoom(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.room = transform());
        public static void BindRoomInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.room = transform());
        public static void BindRoomHF(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.roomHF = v);
        public static void BindRoomHF<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.roomHF = transform(v));
        public static void BindRoomHF(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.roomHF = transform());
        public static void BindRoomHFInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.roomHF = transform());
        public static void BindRoomLF(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.roomLF = v);
        public static void BindRoomLF<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.roomLF = transform(v));
        public static void BindRoomLF(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.roomLF = transform());
        public static void BindRoomLFInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.roomLF = transform());
        public static void BindDecayTime(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decayTime = v);
        public static void BindDecayTime<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decayTime = transform(v));
        public static void BindDecayTime(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decayTime = transform());
        public static void BindDecayTimeInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decayTime = transform());
        public static void BindDecayHFRatio(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decayHFRatio = v);
        public static void BindDecayHFRatio<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decayHFRatio = transform(v));
        public static void BindDecayHFRatio(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decayHFRatio = transform());
        public static void BindDecayHFRatioInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decayHFRatio = transform());
        public static void BindReflectionsLevel(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionsLevel = v);
        public static void BindReflectionsLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionsLevel = transform(v));
        public static void BindReflectionsLevel(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionsLevel = transform());
        public static void BindReflectionsLevelInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionsLevel = transform());
        public static void BindReflectionsDelay(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionsDelay = v);
        public static void BindReflectionsDelay<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionsDelay = transform(v));
        public static void BindReflectionsDelay(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionsDelay = transform());
        public static void BindReflectionsDelayInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionsDelay = transform());
        public static void BindReverbLevel(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reverbLevel = v);
        public static void BindReverbLevel<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbLevel = transform(v));
        public static void BindReverbLevel(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbLevel = transform());
        public static void BindReverbLevelInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbLevel = transform());
        public static void BindReverbDelay(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reverbDelay = v);
        public static void BindReverbDelay<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbDelay = transform(v));
        public static void BindReverbDelay(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbDelay = transform());
        public static void BindReverbDelayInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbDelay = transform());
        public static void BindHfReference(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.hfReference = v);
        public static void BindHfReference<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.hfReference = transform(v));
        public static void BindHfReference(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.hfReference = transform());
        public static void BindHfReferenceInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.hfReference = transform());
        public static void BindLfReference(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lfReference = v);
        public static void BindLfReference<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lfReference = transform(v));
        public static void BindLfReference(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lfReference = transform());
        public static void BindLfReferenceInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lfReference = transform());
        public static void BindDiffusion(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.diffusion = v);
        public static void BindDiffusion<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.diffusion = transform(v));
        public static void BindDiffusion(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.diffusion = transform());
        public static void BindDiffusionInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.diffusion = transform());
        public static void BindDensity(this AudioReverbFilter obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.density = v);
        public static void BindDensity<T>(this AudioReverbFilter obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.density = transform(v));
        public static void BindDensity(this AudioReverbFilter obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.density = transform());
        public static void BindDensityInterval(this AudioReverbFilter obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.density = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindMinDistance(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minDistance = transform(v));
        public static void BindMinDistance(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minDistance = transform());
        public static void BindMinDistanceInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minDistance = transform());
        public static void BindMaxDistance(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = transform(v));
        public static void BindMaxDistance(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxDistance = transform());
        public static void BindMaxDistanceInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxDistance = transform());
        public static void BindReverbPreset(this AudioReverbZone obj, IProperty<UnityEngine.AudioReverbPreset> property)
            => Bindings2._scope.Bind(property, v => obj.reverbPreset = v);
        public static void BindReverbPreset<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbPreset = transform(v));
        public static void BindReverbPreset(this AudioReverbZone obj, Func<UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbPreset = transform());
        public static void BindReverbPresetInterval(this AudioReverbZone obj, float seconds, Func<UnityEngine.AudioReverbPreset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbPreset = transform());
        public static void BindRoom(this AudioReverbZone obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.room = v);
        public static void BindRoom<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.room = transform(v));
        public static void BindRoom(this AudioReverbZone obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.room = transform());
        public static void BindRoomInterval(this AudioReverbZone obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.room = transform());
        public static void BindRoomHF(this AudioReverbZone obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.roomHF = v);
        public static void BindRoomHF<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.roomHF = transform(v));
        public static void BindRoomHF(this AudioReverbZone obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.roomHF = transform());
        public static void BindRoomHFInterval(this AudioReverbZone obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.roomHF = transform());
        public static void BindRoomLF(this AudioReverbZone obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.roomLF = v);
        public static void BindRoomLF<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.roomLF = transform(v));
        public static void BindRoomLF(this AudioReverbZone obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.roomLF = transform());
        public static void BindRoomLFInterval(this AudioReverbZone obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.roomLF = transform());
        public static void BindDecayTime(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decayTime = v);
        public static void BindDecayTime<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decayTime = transform(v));
        public static void BindDecayTime(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decayTime = transform());
        public static void BindDecayTimeInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decayTime = transform());
        public static void BindDecayHFRatio(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decayHFRatio = v);
        public static void BindDecayHFRatio<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decayHFRatio = transform(v));
        public static void BindDecayHFRatio(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decayHFRatio = transform());
        public static void BindDecayHFRatioInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decayHFRatio = transform());
        public static void BindReflections(this AudioReverbZone obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.reflections = v);
        public static void BindReflections<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.reflections = transform(v));
        public static void BindReflections(this AudioReverbZone obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflections = transform());
        public static void BindReflectionsInterval(this AudioReverbZone obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflections = transform());
        public static void BindReflectionsDelay(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionsDelay = v);
        public static void BindReflectionsDelay<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionsDelay = transform(v));
        public static void BindReflectionsDelay(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionsDelay = transform());
        public static void BindReflectionsDelayInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionsDelay = transform());
        public static void BindReverb(this AudioReverbZone obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.reverb = v);
        public static void BindReverb<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.reverb = transform(v));
        public static void BindReverb(this AudioReverbZone obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverb = transform());
        public static void BindReverbInterval(this AudioReverbZone obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverb = transform());
        public static void BindReverbDelay(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reverbDelay = v);
        public static void BindReverbDelay<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbDelay = transform(v));
        public static void BindReverbDelay(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbDelay = transform());
        public static void BindReverbDelayInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbDelay = transform());
        public static void BindHFReference(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.HFReference = v);
        public static void BindHFReference<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.HFReference = transform(v));
        public static void BindHFReference(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.HFReference = transform());
        public static void BindHFReferenceInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.HFReference = transform());
        public static void BindLFReference(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.LFReference = v);
        public static void BindLFReference<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.LFReference = transform(v));
        public static void BindLFReference(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.LFReference = transform());
        public static void BindLFReferenceInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.LFReference = transform());
        public static void BindDiffusion(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.diffusion = v);
        public static void BindDiffusion<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.diffusion = transform(v));
        public static void BindDiffusion(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.diffusion = transform());
        public static void BindDiffusionInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.diffusion = transform());
        public static void BindDensity(this AudioReverbZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.density = v);
        public static void BindDensity<T>(this AudioReverbZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.density = transform(v));
        public static void BindDensity(this AudioReverbZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.density = transform());
        public static void BindDensityInterval(this AudioReverbZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.density = transform());
        #endif


        #if UNITY_AUDIO
        public static void BindClip(this AudioSource obj, IProperty<UnityEngine.AudioClip> property)
            => Bindings2._scope.Bind(property, v => obj.clip = v);
        public static void BindClip<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.AudioClip> transform)
            => Bindings2._scope.Bind(property, v => obj.clip = transform(v));
        public static void BindClip(this AudioSource obj, Func<UnityEngine.AudioClip> transform)
            => Bindings2._scope.BindUpdate(() => obj.clip = transform());
        public static void BindClipInterval(this AudioSource obj, float seconds, Func<UnityEngine.AudioClip> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clip = transform());
        public static void BindOutputAudioMixerGroup(this AudioSource obj, IProperty<UnityEngine.Audio.AudioMixerGroup> property)
            => Bindings2._scope.Bind(property, v => obj.outputAudioMixerGroup = v);
        public static void BindOutputAudioMixerGroup<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.Audio.AudioMixerGroup> transform)
            => Bindings2._scope.Bind(property, v => obj.outputAudioMixerGroup = transform(v));
        public static void BindOutputAudioMixerGroup(this AudioSource obj, Func<UnityEngine.Audio.AudioMixerGroup> transform)
            => Bindings2._scope.BindUpdate(() => obj.outputAudioMixerGroup = transform());
        public static void BindOutputAudioMixerGroupInterval(this AudioSource obj, float seconds, Func<UnityEngine.Audio.AudioMixerGroup> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.outputAudioMixerGroup = transform());
        public static void BindMute(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.mute = v);
        public static void BindMute<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.mute = transform(v));
        public static void BindMute(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.mute = transform());
        public static void BindMuteInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mute = transform());
        public static void BindBypassEffects(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.bypassEffects = v);
        public static void BindBypassEffects<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.bypassEffects = transform(v));
        public static void BindBypassEffects(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.bypassEffects = transform());
        public static void BindBypassEffectsInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bypassEffects = transform());
        public static void BindBypassListenerEffects(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.bypassListenerEffects = v);
        public static void BindBypassListenerEffects<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.bypassListenerEffects = transform(v));
        public static void BindBypassListenerEffects(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.bypassListenerEffects = transform());
        public static void BindBypassListenerEffectsInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bypassListenerEffects = transform());
        public static void BindBypassReverbZones(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.bypassReverbZones = v);
        public static void BindBypassReverbZones<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.bypassReverbZones = transform(v));
        public static void BindBypassReverbZones(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.bypassReverbZones = transform());
        public static void BindBypassReverbZonesInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bypassReverbZones = transform());
        public static void BindPlayOnAwake(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = transform(v));
        public static void BindPlayOnAwake(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.playOnAwake = transform());
        public static void BindPlayOnAwakeInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playOnAwake = transform());
        public static void BindLoop(this AudioSource obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.loop = v);
        public static void BindLoop<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.loop = transform(v));
        public static void BindLoop(this AudioSource obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.loop = transform());
        public static void BindLoopInterval(this AudioSource obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.loop = transform());
        public static void BindPriority(this AudioSource obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.priority = v);
        public static void BindPriority<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.priority = transform(v));
        public static void BindPriority(this AudioSource obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.priority = transform());
        public static void BindPriorityInterval(this AudioSource obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.priority = transform());
        public static void BindVolume(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.volume = v);
        public static void BindVolume<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.volume = transform(v));
        public static void BindVolume(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.volume = transform());
        public static void BindVolumeInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.volume = transform());
        public static void BindPitch(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.pitch = v);
        public static void BindPitch<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.pitch = transform(v));
        public static void BindPitch(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.pitch = transform());
        public static void BindPitchInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.pitch = transform());
        public static void BindPanStereo(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.panStereo = v);
        public static void BindPanStereo<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.panStereo = transform(v));
        public static void BindPanStereo(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.panStereo = transform());
        public static void BindPanStereoInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.panStereo = transform());
        public static void BindSpatialBlend(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spatialBlend = v);
        public static void BindSpatialBlend<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spatialBlend = transform(v));
        public static void BindSpatialBlend(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spatialBlend = transform());
        public static void BindSpatialBlendInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spatialBlend = transform());
        public static void BindReverbZoneMix(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.reverbZoneMix = v);
        public static void BindReverbZoneMix<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.reverbZoneMix = transform(v));
        public static void BindReverbZoneMix(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.reverbZoneMix = transform());
        public static void BindReverbZoneMixInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reverbZoneMix = transform());
        public static void BindDopplerLevel(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dopplerLevel = v);
        public static void BindDopplerLevel<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dopplerLevel = transform(v));
        public static void BindDopplerLevel(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dopplerLevel = transform());
        public static void BindDopplerLevelInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dopplerLevel = transform());
        public static void BindSpread(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spread = v);
        public static void BindSpread<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spread = transform(v));
        public static void BindSpread(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spread = transform());
        public static void BindSpreadInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spread = transform());
        public static void BindRolloffMode(this AudioSource obj, IProperty<UnityEngine.AudioRolloffMode> property)
            => Bindings2._scope.Bind(property, v => obj.rolloffMode = v);
        public static void BindRolloffMode<T>(this AudioSource obj, IProperty<T> property, Func<T, UnityEngine.AudioRolloffMode> transform)
            => Bindings2._scope.Bind(property, v => obj.rolloffMode = transform(v));
        public static void BindRolloffMode(this AudioSource obj, Func<UnityEngine.AudioRolloffMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.rolloffMode = transform());
        public static void BindRolloffModeInterval(this AudioSource obj, float seconds, Func<UnityEngine.AudioRolloffMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rolloffMode = transform());
        public static void BindMinDistance(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minDistance = transform(v));
        public static void BindMinDistance(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minDistance = transform());
        public static void BindMinDistanceInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minDistance = transform());
        public static void BindMaxDistance(this AudioSource obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this AudioSource obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = transform(v));
        public static void BindMaxDistance(this AudioSource obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxDistance = transform());
        public static void BindMaxDistanceInterval(this AudioSource obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxDistance = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this BoxCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this BoxCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this BoxCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this BoxCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this BoxCollider obj, IProperty<PhysicMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this BoxCollider obj, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this BoxCollider obj, float seconds, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this BoxCollider obj, IProperty<PhysicsMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this BoxCollider obj, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this BoxCollider obj, float seconds, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        public static void BindCenter(this BoxCollider obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this BoxCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this BoxCollider obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this BoxCollider obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this BoxCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this BoxCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this BoxCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this BoxCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this BoxCollider obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this BoxCollider obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindSize(this BoxCollider obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this BoxCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this BoxCollider obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this BoxCollider obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindSizeLerp(this BoxCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeLerp(this BoxCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this BoxCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this BoxCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateSize(this BoxCollider obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.size = Vector3.Lerp(start, end, t));
        public static void AnimateSize(this BoxCollider obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateSize(obj, obj.size, end, curve);
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this BoxCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this BoxCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this BoxCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this BoxCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this BoxCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this BoxCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this BoxCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this BoxCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this BoxCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this BoxCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this BoxCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this BoxCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this BoxCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this BoxCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this BoxCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this BoxCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this BoxCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this BoxCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindAutoTiling(this BoxCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoTiling = v);
        public static void BindAutoTiling<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoTiling = transform(v));
        public static void BindAutoTiling(this BoxCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoTiling = transform());
        public static void BindAutoTilingInterval(this BoxCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoTiling = transform());
        public static void BindSize(this BoxCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this BoxCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this BoxCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindEdgeRadius(this BoxCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this BoxCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = transform(v));
        public static void BindEdgeRadius(this BoxCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.edgeRadius = transform());
        public static void BindEdgeRadiusInterval(this BoxCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.edgeRadius = transform());
        #endif


        public static void BindBillboard(this BillboardRenderer obj, IProperty<UnityEngine.BillboardAsset> property)
            => Bindings2._scope.Bind(property, v => obj.billboard = v);
        public static void BindBillboard<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.BillboardAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.billboard = transform(v));
        public static void BindBillboard(this BillboardRenderer obj, Func<UnityEngine.BillboardAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.billboard = transform());
        public static void BindBillboardInterval(this BillboardRenderer obj, float seconds, Func<UnityEngine.BillboardAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.billboard = transform());
        public static void BindShadowCastingMode(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = transform(v));
        public static void BindShadowCastingMode(this BillboardRenderer obj, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowCastingMode = transform());
        public static void BindShadowCastingModeInterval(this BillboardRenderer obj, float seconds, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowCastingMode = transform());
        public static void BindReceiveShadows(this BillboardRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = transform(v));
        public static void BindReceiveShadows(this BillboardRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.receiveShadows = transform());
        public static void BindReceiveShadowsInterval(this BillboardRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.receiveShadows = transform());
        public static void BindLightProbeUsage(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = transform(v));
        public static void BindLightProbeUsage(this BillboardRenderer obj, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.lightProbeUsage = transform());
        public static void BindLightProbeUsageInterval(this BillboardRenderer obj, float seconds, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lightProbeUsage = transform());
        public static void BindReflectionProbeUsage(this BillboardRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this BillboardRenderer obj, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionProbeUsage = transform());
        public static void BindReflectionProbeUsageInterval(this BillboardRenderer obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionProbeUsage = transform());
        public static void BindMotionVectorGenerationMode(this BillboardRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindMotionVectorGenerationMode(this BillboardRenderer obj, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.motionVectorGenerationMode = transform());
        public static void BindMotionVectorGenerationModeInterval(this BillboardRenderer obj, float seconds, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motionVectorGenerationMode = transform());
        public static void BindAllowOcclusionWhenDynamic(this BillboardRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this BillboardRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this BillboardRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowOcclusionWhenDynamic = transform());
        public static void BindAllowOcclusionWhenDynamicInterval(this BillboardRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowOcclusionWhenDynamic = transform());


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this BuoyancyEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = transform(v));
        public static void BindUseColliderMask(this BuoyancyEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useColliderMask = transform());
        public static void BindUseColliderMaskInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useColliderMask = transform());
        public static void BindColliderMask(this BuoyancyEffector2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = transform(v));
        public static void BindColliderMask(this BuoyancyEffector2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.colliderMask = transform());
        public static void BindColliderMaskInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colliderMask = transform());
        public static void BindDensity(this BuoyancyEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.density = v);
        public static void BindDensity<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.density = transform(v));
        public static void BindDensity(this BuoyancyEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.density = transform());
        public static void BindDensityInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.density = transform());
        public static void BindSurfaceLevel(this BuoyancyEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.surfaceLevel = v);
        public static void BindSurfaceLevel<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.surfaceLevel = transform(v));
        public static void BindSurfaceLevel(this BuoyancyEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.surfaceLevel = transform());
        public static void BindSurfaceLevelInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.surfaceLevel = transform());
        public static void BindFlowAngle(this BuoyancyEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.flowAngle = v);
        public static void BindFlowAngle<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.flowAngle = transform(v));
        public static void BindFlowAngle(this BuoyancyEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.flowAngle = transform());
        public static void BindFlowAngleInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flowAngle = transform());
        public static void BindFlowMagnitude(this BuoyancyEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.flowMagnitude = v);
        public static void BindFlowMagnitude<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.flowMagnitude = transform(v));
        public static void BindFlowMagnitude(this BuoyancyEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.flowMagnitude = transform());
        public static void BindFlowMagnitudeInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flowMagnitude = transform());
        public static void BindFlowVariation(this BuoyancyEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.flowVariation = v);
        public static void BindFlowVariation<T>(this BuoyancyEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.flowVariation = transform(v));
        public static void BindFlowVariation(this BuoyancyEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.flowVariation = transform());
        public static void BindFlowVariationInterval(this BuoyancyEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flowVariation = transform());
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Button obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.Button obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.Button obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.Button obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.Button obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Button obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.Button obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.Button obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.Button obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.Button obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Button obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Button obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.Button obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        #endif


        public static void BindClearFlags(this Camera obj, IProperty<UnityEngine.CameraClearFlags> property)
            => Bindings2._scope.Bind(property, v => obj.clearFlags = v);
        public static void BindClearFlags<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.CameraClearFlags> transform)
            => Bindings2._scope.Bind(property, v => obj.clearFlags = transform(v));
        public static void BindClearFlags(this Camera obj, Func<UnityEngine.CameraClearFlags> transform)
            => Bindings2._scope.BindUpdate(() => obj.clearFlags = transform());
        public static void BindClearFlagsInterval(this Camera obj, float seconds, Func<UnityEngine.CameraClearFlags> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clearFlags = transform());
        public static void BindBackgroundColor(this Camera obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.backgroundColor = v);
        public static void BindBackgroundColor<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.backgroundColor = transform(v));
        public static void BindBackgroundColor(this Camera obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.backgroundColor = transform());
        public static void BindBackgroundColorInterval(this Camera obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.backgroundColor = transform());
        public static void BindCullingMask(this Camera obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this Camera obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = transform(v));
        public static void BindCullingMask(this Camera obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullingMask = transform());
        public static void BindCullingMaskInterval(this Camera obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullingMask = transform());
        public static void BindOrthographic(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.orthographic = v);
        public static void BindOrthographic<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.orthographic = transform(v));
        public static void BindOrthographic(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.orthographic = transform());
        public static void BindOrthographicInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.orthographic = transform());
        public static void BindFieldOfView(this Camera obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fieldOfView = v);
        public static void BindFieldOfView<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fieldOfView = transform(v));
        public static void BindFieldOfView(this Camera obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fieldOfView = transform());
        public static void BindFieldOfViewInterval(this Camera obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fieldOfView = transform());
        public static void BindUsePhysicalProperties(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usePhysicalProperties = v);
        public static void BindUsePhysicalProperties<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usePhysicalProperties = transform(v));
        public static void BindUsePhysicalProperties(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usePhysicalProperties = transform());
        public static void BindUsePhysicalPropertiesInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usePhysicalProperties = transform());
        public static void BindNearClipPlane(this Camera obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = transform(v));
        public static void BindNearClipPlane(this Camera obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.nearClipPlane = transform());
        public static void BindNearClipPlaneInterval(this Camera obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.nearClipPlane = transform());
        public static void BindFarClipPlane(this Camera obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = transform(v));
        public static void BindFarClipPlane(this Camera obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.farClipPlane = transform());
        public static void BindFarClipPlaneInterval(this Camera obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.farClipPlane = transform());
        public static void BindRect(this Camera obj, IProperty<UnityEngine.Rect> property)
            => Bindings2._scope.Bind(property, v => obj.rect = v);
        public static void BindRect<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.Rect> transform)
            => Bindings2._scope.Bind(property, v => obj.rect = transform(v));
        public static void BindRect(this Camera obj, Func<UnityEngine.Rect> transform)
            => Bindings2._scope.BindUpdate(() => obj.rect = transform());
        public static void BindRectInterval(this Camera obj, float seconds, Func<UnityEngine.Rect> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rect = transform());
        public static void BindDepth(this Camera obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.depth = v);
        public static void BindDepth<T>(this Camera obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.depth = transform(v));
        public static void BindDepth(this Camera obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.depth = transform());
        public static void BindDepthInterval(this Camera obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.depth = transform());
        public static void BindRenderingPath(this Camera obj, IProperty<UnityEngine.RenderingPath> property)
            => Bindings2._scope.Bind(property, v => obj.renderingPath = v);
        public static void BindRenderingPath<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.RenderingPath> transform)
            => Bindings2._scope.Bind(property, v => obj.renderingPath = transform(v));
        public static void BindRenderingPath(this Camera obj, Func<UnityEngine.RenderingPath> transform)
            => Bindings2._scope.BindUpdate(() => obj.renderingPath = transform());
        public static void BindRenderingPathInterval(this Camera obj, float seconds, Func<UnityEngine.RenderingPath> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.renderingPath = transform());
        public static void BindTargetTexture(this Camera obj, IProperty<UnityEngine.RenderTexture> property)
            => Bindings2._scope.Bind(property, v => obj.targetTexture = v);
        public static void BindTargetTexture<T>(this Camera obj, IProperty<T> property, Func<T, UnityEngine.RenderTexture> transform)
            => Bindings2._scope.Bind(property, v => obj.targetTexture = transform(v));
        public static void BindTargetTexture(this Camera obj, Func<UnityEngine.RenderTexture> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetTexture = transform());
        public static void BindTargetTextureInterval(this Camera obj, float seconds, Func<UnityEngine.RenderTexture> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetTexture = transform());
        public static void BindUseOcclusionCulling(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useOcclusionCulling = v);
        public static void BindUseOcclusionCulling<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useOcclusionCulling = transform(v));
        public static void BindUseOcclusionCulling(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useOcclusionCulling = transform());
        public static void BindUseOcclusionCullingInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useOcclusionCulling = transform());
        public static void BindAllowHDR(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowHDR = v);
        public static void BindAllowHDR<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowHDR = transform(v));
        public static void BindAllowHDR(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowHDR = transform());
        public static void BindAllowHDRInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowHDR = transform());
        public static void BindAllowMSAA(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowMSAA = v);
        public static void BindAllowMSAA<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowMSAA = transform(v));
        public static void BindAllowMSAA(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowMSAA = transform());
        public static void BindAllowMSAAInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowMSAA = transform());
        public static void BindAllowDynamicResolution(this Camera obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowDynamicResolution = v);
        public static void BindAllowDynamicResolution<T>(this Camera obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowDynamicResolution = transform(v));
        public static void BindAllowDynamicResolution(this Camera obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowDynamicResolution = transform());
        public static void BindAllowDynamicResolutionInterval(this Camera obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowDynamicResolution = transform());
        public static void BindTargetDisplay(this Camera obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.targetDisplay = v);
        public static void BindTargetDisplay<T>(this Camera obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.targetDisplay = transform(v));
        public static void BindTargetDisplay(this Camera obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetDisplay = transform());
        public static void BindTargetDisplayInterval(this Camera obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetDisplay = transform());


        #if UNITY_UI
        public static void BindRenderMode(this Canvas obj, IProperty<UnityEngine.RenderMode> property)
            => Bindings2._scope.Bind(property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.RenderMode> transform)
            => Bindings2._scope.Bind(property, v => obj.renderMode = transform(v));
        public static void BindRenderMode(this Canvas obj, Func<UnityEngine.RenderMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.renderMode = transform());
        public static void BindRenderModeInterval(this Canvas obj, float seconds, Func<UnityEngine.RenderMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.renderMode = transform());
        public static void BindWorldCamera(this Canvas obj, IProperty<UnityEngine.Camera> property)
            => Bindings2._scope.Bind(property, v => obj.worldCamera = v);
        public static void BindWorldCamera<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.Camera> transform)
            => Bindings2._scope.Bind(property, v => obj.worldCamera = transform(v));
        public static void BindWorldCamera(this Canvas obj, Func<UnityEngine.Camera> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldCamera = transform());
        public static void BindWorldCameraInterval(this Canvas obj, float seconds, Func<UnityEngine.Camera> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldCamera = transform());
        public static void BindPixelPerfect(this Canvas obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.pixelPerfect = v);
        public static void BindPixelPerfect<T>(this Canvas obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.pixelPerfect = transform(v));
        public static void BindPixelPerfect(this Canvas obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.pixelPerfect = transform());
        public static void BindPixelPerfectInterval(this Canvas obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.pixelPerfect = transform());
        public static void BindSortingOrder(this Canvas obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this Canvas obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this Canvas obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this Canvas obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());
        public static void BindTargetDisplay(this Canvas obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.targetDisplay = v);
        public static void BindTargetDisplay<T>(this Canvas obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.targetDisplay = transform(v));
        public static void BindTargetDisplay(this Canvas obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetDisplay = transform());
        public static void BindTargetDisplayInterval(this Canvas obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetDisplay = transform());
        public static void BindAdditionalShaderChannels(this Canvas obj, IProperty<UnityEngine.AdditionalCanvasShaderChannels> property)
            => Bindings2._scope.Bind(property, v => obj.additionalShaderChannels = v);
        public static void BindAdditionalShaderChannels<T>(this Canvas obj, IProperty<T> property, Func<T, UnityEngine.AdditionalCanvasShaderChannels> transform)
            => Bindings2._scope.Bind(property, v => obj.additionalShaderChannels = transform(v));
        public static void BindAdditionalShaderChannels(this Canvas obj, Func<UnityEngine.AdditionalCanvasShaderChannels> transform)
            => Bindings2._scope.BindUpdate(() => obj.additionalShaderChannels = transform());
        public static void BindAdditionalShaderChannelsInterval(this Canvas obj, float seconds, Func<UnityEngine.AdditionalCanvasShaderChannels> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.additionalShaderChannels = transform());
        #endif


        #if UNITY_UI
        public static void BindAlpha(this CanvasGroup obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.alpha = v);
        public static void BindAlpha<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.alpha = transform(v));
        public static void BindAlpha(this CanvasGroup obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.alpha = transform());
        public static void BindAlphaInterval(this CanvasGroup obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alpha = transform());
        public static void BindInteractable(this CanvasGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this CanvasGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this CanvasGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindBlocksRaycasts(this CanvasGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.blocksRaycasts = v);
        public static void BindBlocksRaycasts<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.blocksRaycasts = transform(v));
        public static void BindBlocksRaycasts(this CanvasGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.blocksRaycasts = transform());
        public static void BindBlocksRaycastsInterval(this CanvasGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.blocksRaycasts = transform());
        public static void BindIgnoreParentGroups(this CanvasGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.ignoreParentGroups = v);
        public static void BindIgnoreParentGroups<T>(this CanvasGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.ignoreParentGroups = transform(v));
        public static void BindIgnoreParentGroups(this CanvasGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.ignoreParentGroups = transform());
        public static void BindIgnoreParentGroupsInterval(this CanvasGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.ignoreParentGroups = transform());
        #endif


        #if UNITY_UI
        public static void BindCullTransparentMesh(this CanvasRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.cullTransparentMesh = v);
        public static void BindCullTransparentMesh<T>(this CanvasRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.cullTransparentMesh = transform(v));
        public static void BindCullTransparentMesh(this CanvasRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullTransparentMesh = transform());
        public static void BindCullTransparentMeshInterval(this CanvasRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullTransparentMesh = transform());
        #endif


        #if UNITY_GUI
        public static void BindUiScaleMode(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.ScaleMode> property)
            => Bindings2._scope.Bind(property, v => obj.uiScaleMode = v);
        public static void BindUiScaleMode<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.ScaleMode> transform)
            => Bindings2._scope.Bind(property, v => obj.uiScaleMode = transform(v));
        public static void BindUiScaleMode(this UnityEngine.UI.CanvasScaler obj, Func<UnityEngine.UI.CanvasScaler.ScaleMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.uiScaleMode = transform());
        public static void BindUiScaleModeInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<UnityEngine.UI.CanvasScaler.ScaleMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.uiScaleMode = transform());
        public static void BindScaleFactor(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.scaleFactor = v);
        public static void BindScaleFactor<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.scaleFactor = transform(v));
        public static void BindScaleFactor(this UnityEngine.UI.CanvasScaler obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleFactor = transform());
        public static void BindScaleFactorInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.scaleFactor = transform());
        public static void BindReferenceResolution(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.referenceResolution = v);
        public static void BindReferenceResolution<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.referenceResolution = transform(v));
        public static void BindReferenceResolution(this UnityEngine.UI.CanvasScaler obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.referenceResolution = transform());
        public static void BindReferenceResolutionInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.referenceResolution = transform());
        public static void BindScreenMatchMode(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.ScreenMatchMode> property)
            => Bindings2._scope.Bind(property, v => obj.screenMatchMode = v);
        public static void BindScreenMatchMode<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.ScreenMatchMode> transform)
            => Bindings2._scope.Bind(property, v => obj.screenMatchMode = transform(v));
        public static void BindScreenMatchMode(this UnityEngine.UI.CanvasScaler obj, Func<UnityEngine.UI.CanvasScaler.ScreenMatchMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.screenMatchMode = transform());
        public static void BindScreenMatchModeInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<UnityEngine.UI.CanvasScaler.ScreenMatchMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.screenMatchMode = transform());
        public static void BindPhysicalUnit(this UnityEngine.UI.CanvasScaler obj, IProperty<UnityEngine.UI.CanvasScaler.Unit> property)
            => Bindings2._scope.Bind(property, v => obj.physicalUnit = v);
        public static void BindPhysicalUnit<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, UnityEngine.UI.CanvasScaler.Unit> transform)
            => Bindings2._scope.Bind(property, v => obj.physicalUnit = transform(v));
        public static void BindPhysicalUnit(this UnityEngine.UI.CanvasScaler obj, Func<UnityEngine.UI.CanvasScaler.Unit> transform)
            => Bindings2._scope.BindUpdate(() => obj.physicalUnit = transform());
        public static void BindPhysicalUnitInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<UnityEngine.UI.CanvasScaler.Unit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.physicalUnit = transform());
        public static void BindFallbackScreenDPI(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fallbackScreenDPI = v);
        public static void BindFallbackScreenDPI<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fallbackScreenDPI = transform(v));
        public static void BindFallbackScreenDPI(this UnityEngine.UI.CanvasScaler obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fallbackScreenDPI = transform());
        public static void BindFallbackScreenDPIInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fallbackScreenDPI = transform());
        public static void BindDefaultSpriteDPI(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.defaultSpriteDPI = v);
        public static void BindDefaultSpriteDPI<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.defaultSpriteDPI = transform(v));
        public static void BindDefaultSpriteDPI(this UnityEngine.UI.CanvasScaler obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.defaultSpriteDPI = transform());
        public static void BindDefaultSpriteDPIInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.defaultSpriteDPI = transform());
        public static void BindReferencePixelsPerUnit(this UnityEngine.UI.CanvasScaler obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.referencePixelsPerUnit = v);
        public static void BindReferencePixelsPerUnit<T>(this UnityEngine.UI.CanvasScaler obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.referencePixelsPerUnit = transform(v));
        public static void BindReferencePixelsPerUnit(this UnityEngine.UI.CanvasScaler obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.referencePixelsPerUnit = transform());
        public static void BindReferencePixelsPerUnitInterval(this UnityEngine.UI.CanvasScaler obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.referencePixelsPerUnit = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this CapsuleCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this CapsuleCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this CapsuleCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this CapsuleCollider obj, IProperty<PhysicMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this CapsuleCollider obj, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this CapsuleCollider obj, float seconds, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this CapsuleCollider obj, IProperty<PhysicsMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this CapsuleCollider obj, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this CapsuleCollider obj, float seconds, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        public static void BindCenter(this CapsuleCollider obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this CapsuleCollider obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this CapsuleCollider obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this CapsuleCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this CapsuleCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this CapsuleCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this CapsuleCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this CapsuleCollider obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this CapsuleCollider obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindRadius(this CapsuleCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this CapsuleCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this CapsuleCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        public static void BindHeight(this CapsuleCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.height = v);
        public static void BindHeight<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.height = transform(v));
        public static void BindHeight(this CapsuleCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.height = transform());
        public static void BindHeightInterval(this CapsuleCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.height = transform());
        public static void BindDirection(this CapsuleCollider obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.direction = v);
        public static void BindDirection<T>(this CapsuleCollider obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.direction = transform(v));
        public static void BindDirection(this CapsuleCollider obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.direction = transform());
        public static void BindDirectionInterval(this CapsuleCollider obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.direction = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CapsuleCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this CapsuleCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this CapsuleCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this CapsuleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this CapsuleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this CapsuleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this CapsuleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this CapsuleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this CapsuleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CapsuleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this CapsuleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this CapsuleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CapsuleCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this CapsuleCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this CapsuleCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this CapsuleCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this CapsuleCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this CapsuleCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindSize(this CapsuleCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this CapsuleCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this CapsuleCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindDirection(this CapsuleCollider2D obj, IProperty<UnityEngine.CapsuleDirection2D> property)
            => Bindings2._scope.Bind(property, v => obj.direction = v);
        public static void BindDirection<T>(this CapsuleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CapsuleDirection2D> transform)
            => Bindings2._scope.Bind(property, v => obj.direction = transform(v));
        public static void BindDirection(this CapsuleCollider2D obj, Func<UnityEngine.CapsuleDirection2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.direction = transform());
        public static void BindDirectionInterval(this CapsuleCollider2D obj, float seconds, Func<UnityEngine.CapsuleDirection2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.direction = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindSlopeLimit(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.slopeLimit = v);
        public static void BindSlopeLimit<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.slopeLimit = transform(v));
        public static void BindSlopeLimit(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.slopeLimit = transform());
        public static void BindSlopeLimitInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.slopeLimit = transform());
        public static void BindStepOffset(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.stepOffset = v);
        public static void BindStepOffset<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.stepOffset = transform(v));
        public static void BindStepOffset(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.stepOffset = transform());
        public static void BindStepOffsetInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.stepOffset = transform());
        public static void BindSkinWidth(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.skinWidth = v);
        public static void BindSkinWidth<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.skinWidth = transform(v));
        public static void BindSkinWidth(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.skinWidth = transform());
        public static void BindSkinWidthInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.skinWidth = transform());
        public static void BindMinMoveDistance(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minMoveDistance = v);
        public static void BindMinMoveDistance<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minMoveDistance = transform(v));
        public static void BindMinMoveDistance(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minMoveDistance = transform());
        public static void BindMinMoveDistanceInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minMoveDistance = transform());
        public static void BindCenter(this CharacterController obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this CharacterController obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this CharacterController obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this CharacterController obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this CharacterController obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this CharacterController obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this CharacterController obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this CharacterController obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this CharacterController obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this CharacterController obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindRadius(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        public static void BindHeight(this CharacterController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.height = v);
        public static void BindHeight<T>(this CharacterController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.height = transform(v));
        public static void BindHeight(this CharacterController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.height = transform());
        public static void BindHeightInterval(this CharacterController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.height = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this CharacterJoint obj, IProperty<UnityEngine.Rigidbody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this CharacterJoint obj, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this CharacterJoint obj, IProperty<UnityEngine.ArticulationBody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = transform(v));
        public static void BindConnectedArticulationBody(this CharacterJoint obj, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedArticulationBody = transform());
        public static void BindConnectedArticulationBodyInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedArticulationBody = transform());
        #endif
        public static void BindAnchor(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this CharacterJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindAnchorLerp(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorLerp(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAnchor(this CharacterJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.anchor = Vector3.Lerp(start, end, t));
        public static void AnimateAnchor(this CharacterJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAnchor(obj, obj.anchor, end, curve);
        public static void BindAxis(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.axis = v);
        public static void BindAxis<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.axis = transform(v));
        public static void BindAxis(this CharacterJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = transform());
        public static void BindAxisInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.axis = transform());
        public static void BindAxisLerp(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisLerp(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAxis(this CharacterJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.axis = Vector3.Lerp(start, end, t));
        public static void AnimateAxis(this CharacterJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAxis(obj, obj.axis, end, curve);
        public static void BindAutoConfigureConnectedAnchor(this CharacterJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this CharacterJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this CharacterJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindConnectedAnchor(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this CharacterJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorLerp(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorLerp(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateConnectedAnchor(this CharacterJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.connectedAnchor = Vector3.Lerp(start, end, t));
        public static void AnimateConnectedAnchor(this CharacterJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateConnectedAnchor(obj, obj.connectedAnchor, end, curve);
        public static void BindSwingAxis(this CharacterJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.swingAxis = v);
        public static void BindSwingAxis<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.swingAxis = transform(v));
        public static void BindSwingAxis(this CharacterJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.swingAxis = transform());
        public static void BindSwingAxisInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.swingAxis = transform());
        public static void BindSwingAxisLerp(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.swingAxis = Vector3.Lerp(obj.swingAxis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSwingAxisLerp(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.swingAxis = Vector3.Lerp(obj.swingAxis, transform(), speed * Time.smoothDeltaTime));
        public static void BindSwingAxisTowards(this CharacterJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.swingAxis = Vector3.MoveTowards(obj.swingAxis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSwingAxisTowards(this CharacterJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.swingAxis = Vector3.MoveTowards(obj.swingAxis, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateSwingAxis(this CharacterJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.swingAxis = Vector3.Lerp(start, end, t));
        public static void AnimateSwingAxis(this CharacterJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateSwingAxis(obj, obj.swingAxis, end, curve);
        public static void BindTwistLimitSpring(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property)
            => Bindings2._scope.Bind(property, v => obj.twistLimitSpring = v);
        public static void BindTwistLimitSpring<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.twistLimitSpring = transform(v));
        public static void BindTwistLimitSpring(this CharacterJoint obj, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.twistLimitSpring = transform());
        public static void BindTwistLimitSpringInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.twistLimitSpring = transform());
        public static void BindLowTwistLimit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.lowTwistLimit = v);
        public static void BindLowTwistLimit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.lowTwistLimit = transform(v));
        public static void BindLowTwistLimit(this CharacterJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.lowTwistLimit = transform());
        public static void BindLowTwistLimitInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lowTwistLimit = transform());
        public static void BindHighTwistLimit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.highTwistLimit = v);
        public static void BindHighTwistLimit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.highTwistLimit = transform(v));
        public static void BindHighTwistLimit(this CharacterJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.highTwistLimit = transform());
        public static void BindHighTwistLimitInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.highTwistLimit = transform());
        public static void BindSwingLimitSpring(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property)
            => Bindings2._scope.Bind(property, v => obj.swingLimitSpring = v);
        public static void BindSwingLimitSpring<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.swingLimitSpring = transform(v));
        public static void BindSwingLimitSpring(this CharacterJoint obj, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.swingLimitSpring = transform());
        public static void BindSwingLimitSpringInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.swingLimitSpring = transform());
        public static void BindSwing1Limit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.swing1Limit = v);
        public static void BindSwing1Limit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.swing1Limit = transform(v));
        public static void BindSwing1Limit(this CharacterJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.swing1Limit = transform());
        public static void BindSwing1LimitInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.swing1Limit = transform());
        public static void BindSwing2Limit(this CharacterJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.swing2Limit = v);
        public static void BindSwing2Limit<T>(this CharacterJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.swing2Limit = transform(v));
        public static void BindSwing2Limit(this CharacterJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.swing2Limit = transform());
        public static void BindSwing2LimitInterval(this CharacterJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.swing2Limit = transform());
        public static void BindEnableProjection(this CharacterJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableProjection = v);
        public static void BindEnableProjection<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableProjection = transform(v));
        public static void BindEnableProjection(this CharacterJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableProjection = transform());
        public static void BindEnableProjectionInterval(this CharacterJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableProjection = transform());
        public static void BindProjectionDistance(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.projectionDistance = v);
        public static void BindProjectionDistance<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.projectionDistance = transform(v));
        public static void BindProjectionDistance(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.projectionDistance = transform());
        public static void BindProjectionDistanceInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.projectionDistance = transform());
        public static void BindProjectionAngle(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.projectionAngle = v);
        public static void BindProjectionAngle<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.projectionAngle = transform(v));
        public static void BindProjectionAngle(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.projectionAngle = transform());
        public static void BindProjectionAngleInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.projectionAngle = transform());
        public static void BindBreakForce(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        public static void BindEnableCollision(this CharacterJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this CharacterJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this CharacterJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindEnablePreprocessing(this CharacterJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = transform(v));
        public static void BindEnablePreprocessing(this CharacterJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enablePreprocessing = transform());
        public static void BindEnablePreprocessingInterval(this CharacterJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enablePreprocessing = transform());
        public static void BindMassScale(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.massScale = v);
        public static void BindMassScale<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.massScale = transform(v));
        public static void BindMassScale(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.massScale = transform());
        public static void BindMassScaleInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.massScale = transform());
        public static void BindConnectedMassScale(this CharacterJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this CharacterJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = transform(v));
        public static void BindConnectedMassScale(this CharacterJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedMassScale = transform());
        public static void BindConnectedMassScaleInterval(this CharacterJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedMassScale = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CircleCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this CircleCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this CircleCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this CircleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this CircleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this CircleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this CircleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this CircleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this CircleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CircleCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this CircleCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this CircleCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CircleCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this CircleCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this CircleCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this CircleCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this CircleCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this CircleCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindRadius(this CircleCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this CircleCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this CircleCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this CircleCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        #endif


        #if UNITY_CLOTH
        public static void BindStretchingStiffness(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.stretchingStiffness = v);
        public static void BindStretchingStiffness<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.stretchingStiffness = transform(v));
        public static void BindStretchingStiffness(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.stretchingStiffness = transform());
        public static void BindStretchingStiffnessInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.stretchingStiffness = transform());
        public static void BindBendingStiffness(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.bendingStiffness = v);
        public static void BindBendingStiffness<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.bendingStiffness = transform(v));
        public static void BindBendingStiffness(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.bendingStiffness = transform());
        public static void BindBendingStiffnessInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bendingStiffness = transform());
        public static void BindUseTethers(this Cloth obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useTethers = v);
        public static void BindUseTethers<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useTethers = transform(v));
        public static void BindUseTethers(this Cloth obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useTethers = transform());
        public static void BindUseTethersInterval(this Cloth obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useTethers = transform());
        public static void BindUseGravity(this Cloth obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGravity = transform(v));
        public static void BindUseGravity(this Cloth obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGravity = transform());
        public static void BindUseGravityInterval(this Cloth obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGravity = transform());
        public static void BindDamping(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.damping = v);
        public static void BindDamping<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.damping = transform(v));
        public static void BindDamping(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.damping = transform());
        public static void BindDampingInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.damping = transform());
        public static void BindExternalAcceleration(this Cloth obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.externalAcceleration = v);
        public static void BindExternalAcceleration<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.externalAcceleration = transform(v));
        public static void BindExternalAcceleration(this Cloth obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.externalAcceleration = transform());
        public static void BindExternalAccelerationInterval(this Cloth obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.externalAcceleration = transform());
        public static void BindExternalAccelerationLerp(this Cloth obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.externalAcceleration = Vector3.Lerp(obj.externalAcceleration, property.Value, speed * Time.smoothDeltaTime));
        public static void BindExternalAccelerationLerp(this Cloth obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.externalAcceleration = Vector3.Lerp(obj.externalAcceleration, transform(), speed * Time.smoothDeltaTime));
        public static void BindExternalAccelerationTowards(this Cloth obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.externalAcceleration = Vector3.MoveTowards(obj.externalAcceleration, property.Value, speed * Time.smoothDeltaTime));
        public static void BindExternalAccelerationTowards(this Cloth obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.externalAcceleration = Vector3.MoveTowards(obj.externalAcceleration, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateExternalAcceleration(this Cloth obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.externalAcceleration = Vector3.Lerp(start, end, t));
        public static void AnimateExternalAcceleration(this Cloth obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateExternalAcceleration(obj, obj.externalAcceleration, end, curve);
        public static void BindRandomAcceleration(this Cloth obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.randomAcceleration = v);
        public static void BindRandomAcceleration<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.randomAcceleration = transform(v));
        public static void BindRandomAcceleration(this Cloth obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.randomAcceleration = transform());
        public static void BindRandomAccelerationInterval(this Cloth obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.randomAcceleration = transform());
        public static void BindRandomAccelerationLerp(this Cloth obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.randomAcceleration = Vector3.Lerp(obj.randomAcceleration, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRandomAccelerationLerp(this Cloth obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.randomAcceleration = Vector3.Lerp(obj.randomAcceleration, transform(), speed * Time.smoothDeltaTime));
        public static void BindRandomAccelerationTowards(this Cloth obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.randomAcceleration = Vector3.MoveTowards(obj.randomAcceleration, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRandomAccelerationTowards(this Cloth obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.randomAcceleration = Vector3.MoveTowards(obj.randomAcceleration, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRandomAcceleration(this Cloth obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.randomAcceleration = Vector3.Lerp(start, end, t));
        public static void AnimateRandomAcceleration(this Cloth obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRandomAcceleration(obj, obj.randomAcceleration, end, curve);
        public static void BindWorldVelocityScale(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.worldVelocityScale = v);
        public static void BindWorldVelocityScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.worldVelocityScale = transform(v));
        public static void BindWorldVelocityScale(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldVelocityScale = transform());
        public static void BindWorldVelocityScaleInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldVelocityScale = transform());
        public static void BindWorldAccelerationScale(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.worldAccelerationScale = v);
        public static void BindWorldAccelerationScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.worldAccelerationScale = transform(v));
        public static void BindWorldAccelerationScale(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldAccelerationScale = transform());
        public static void BindWorldAccelerationScaleInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldAccelerationScale = transform());
        public static void BindFriction(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.friction = v);
        public static void BindFriction<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.friction = transform(v));
        public static void BindFriction(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.friction = transform());
        public static void BindFrictionInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.friction = transform());
        public static void BindCollisionMassScale(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.collisionMassScale = v);
        public static void BindCollisionMassScale<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.collisionMassScale = transform(v));
        public static void BindCollisionMassScale(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.collisionMassScale = transform());
        public static void BindCollisionMassScaleInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.collisionMassScale = transform());
        public static void BindEnableContinuousCollision(this Cloth obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableContinuousCollision = v);
        public static void BindEnableContinuousCollision<T>(this Cloth obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableContinuousCollision = transform(v));
        public static void BindEnableContinuousCollision(this Cloth obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableContinuousCollision = transform());
        public static void BindEnableContinuousCollisionInterval(this Cloth obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableContinuousCollision = transform());
        public static void BindUseVirtualParticles(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.useVirtualParticles = v);
        public static void BindUseVirtualParticles<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.useVirtualParticles = transform(v));
        public static void BindUseVirtualParticles(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.useVirtualParticles = transform());
        public static void BindUseVirtualParticlesInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useVirtualParticles = transform());
        public static void BindClothSolverFrequency(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.clothSolverFrequency = v);
        public static void BindClothSolverFrequency<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.clothSolverFrequency = transform(v));
        public static void BindClothSolverFrequency(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.clothSolverFrequency = transform());
        public static void BindClothSolverFrequencyInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clothSolverFrequency = transform());
        public static void BindSleepThreshold(this Cloth obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.sleepThreshold = v);
        public static void BindSleepThreshold<T>(this Cloth obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.sleepThreshold = transform(v));
        public static void BindSleepThreshold(this Cloth obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.sleepThreshold = transform());
        public static void BindSleepThresholdInterval(this Cloth obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sleepThreshold = transform());
        public static void BindCapsuleColliders(this Cloth obj, IProperty<UnityEngine.CapsuleCollider[]> property)
            => Bindings2._scope.Bind(property, v => obj.capsuleColliders = v);
        public static void BindCapsuleColliders<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.CapsuleCollider[]> transform)
            => Bindings2._scope.Bind(property, v => obj.capsuleColliders = transform(v));
        public static void BindCapsuleColliders(this Cloth obj, Func<UnityEngine.CapsuleCollider[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.capsuleColliders = transform());
        public static void BindCapsuleCollidersInterval(this Cloth obj, float seconds, Func<UnityEngine.CapsuleCollider[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.capsuleColliders = transform());
        public static void BindSphereColliders(this Cloth obj, IProperty<UnityEngine.ClothSphereColliderPair[]> property)
            => Bindings2._scope.Bind(property, v => obj.sphereColliders = v);
        public static void BindSphereColliders<T>(this Cloth obj, IProperty<T> property, Func<T, UnityEngine.ClothSphereColliderPair[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sphereColliders = transform(v));
        public static void BindSphereColliders(this Cloth obj, Func<UnityEngine.ClothSphereColliderPair[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sphereColliders = transform());
        public static void BindSphereCollidersInterval(this Cloth obj, float seconds, Func<UnityEngine.ClothSphereColliderPair[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sphereColliders = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this CompositeCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this CompositeCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this CompositeCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this CompositeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this CompositeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this CompositeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this CompositeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this CompositeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this CompositeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this CompositeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this CompositeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this CompositeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this CompositeCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this CompositeCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this CompositeCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this CompositeCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this CompositeCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this CompositeCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindGeometryType(this CompositeCollider2D obj, IProperty<UnityEngine.CompositeCollider2D.GeometryType> property)
            => Bindings2._scope.Bind(property, v => obj.geometryType = v);
        public static void BindGeometryType<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CompositeCollider2D.GeometryType> transform)
            => Bindings2._scope.Bind(property, v => obj.geometryType = transform(v));
        public static void BindGeometryType(this CompositeCollider2D obj, Func<UnityEngine.CompositeCollider2D.GeometryType> transform)
            => Bindings2._scope.BindUpdate(() => obj.geometryType = transform());
        public static void BindGeometryTypeInterval(this CompositeCollider2D obj, float seconds, Func<UnityEngine.CompositeCollider2D.GeometryType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.geometryType = transform());
        public static void BindGenerationType(this CompositeCollider2D obj, IProperty<UnityEngine.CompositeCollider2D.GenerationType> property)
            => Bindings2._scope.Bind(property, v => obj.generationType = v);
        public static void BindGenerationType<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.CompositeCollider2D.GenerationType> transform)
            => Bindings2._scope.Bind(property, v => obj.generationType = transform(v));
        public static void BindGenerationType(this CompositeCollider2D obj, Func<UnityEngine.CompositeCollider2D.GenerationType> transform)
            => Bindings2._scope.BindUpdate(() => obj.generationType = transform());
        public static void BindGenerationTypeInterval(this CompositeCollider2D obj, float seconds, Func<UnityEngine.CompositeCollider2D.GenerationType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.generationType = transform());
        public static void BindVertexDistance(this CompositeCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.vertexDistance = v);
        public static void BindVertexDistance<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.vertexDistance = transform(v));
        public static void BindVertexDistance(this CompositeCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.vertexDistance = transform());
        public static void BindVertexDistanceInterval(this CompositeCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.vertexDistance = transform());
        public static void BindOffsetDistance(this CompositeCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.offsetDistance = v);
        public static void BindOffsetDistance<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.offsetDistance = transform(v));
        public static void BindOffsetDistance(this CompositeCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.offsetDistance = transform());
        public static void BindOffsetDistanceInterval(this CompositeCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offsetDistance = transform());
        public static void BindEdgeRadius(this CompositeCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this CompositeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = transform(v));
        public static void BindEdgeRadius(this CompositeCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.edgeRadius = transform());
        public static void BindEdgeRadiusInterval(this CompositeCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.edgeRadius = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this ConfigurableJoint obj, IProperty<UnityEngine.Rigidbody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this ConfigurableJoint obj, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this ConfigurableJoint obj, IProperty<UnityEngine.ArticulationBody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = transform(v));
        public static void BindConnectedArticulationBody(this ConfigurableJoint obj, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedArticulationBody = transform());
        public static void BindConnectedArticulationBodyInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedArticulationBody = transform());
        #endif
        public static void BindAnchor(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindAnchorLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAnchor(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.anchor = Vector3.Lerp(start, end, t));
        public static void AnimateAnchor(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAnchor(obj, obj.anchor, end, curve);
        public static void BindAxis(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.axis = v);
        public static void BindAxis<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.axis = transform(v));
        public static void BindAxis(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = transform());
        public static void BindAxisInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.axis = transform());
        public static void BindAxisLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAxis(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.axis = Vector3.Lerp(start, end, t));
        public static void AnimateAxis(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAxis(obj, obj.axis, end, curve);
        public static void BindAutoConfigureConnectedAnchor(this ConfigurableJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this ConfigurableJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this ConfigurableJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindConnectedAnchor(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateConnectedAnchor(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.connectedAnchor = Vector3.Lerp(start, end, t));
        public static void AnimateConnectedAnchor(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateConnectedAnchor(obj, obj.connectedAnchor, end, curve);
        public static void BindXMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.xMotion = v);
        public static void BindXMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.xMotion = transform(v));
        public static void BindXMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.xMotion = transform());
        public static void BindXMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.xMotion = transform());
        public static void BindYMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.yMotion = v);
        public static void BindYMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.yMotion = transform(v));
        public static void BindYMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.yMotion = transform());
        public static void BindYMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.yMotion = transform());
        public static void BindZMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.zMotion = v);
        public static void BindZMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.zMotion = transform(v));
        public static void BindZMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.zMotion = transform());
        public static void BindZMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.zMotion = transform());
        public static void BindAngularXMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.angularXMotion = v);
        public static void BindAngularXMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.angularXMotion = transform(v));
        public static void BindAngularXMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularXMotion = transform());
        public static void BindAngularXMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularXMotion = transform());
        public static void BindAngularYMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.angularYMotion = v);
        public static void BindAngularYMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.angularYMotion = transform(v));
        public static void BindAngularYMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularYMotion = transform());
        public static void BindAngularYMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularYMotion = transform());
        public static void BindAngularZMotion(this ConfigurableJoint obj, IProperty<UnityEngine.ConfigurableJointMotion> property)
            => Bindings2._scope.Bind(property, v => obj.angularZMotion = v);
        public static void BindAngularZMotion<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.Bind(property, v => obj.angularZMotion = transform(v));
        public static void BindAngularZMotion(this ConfigurableJoint obj, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularZMotion = transform());
        public static void BindAngularZMotionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.ConfigurableJointMotion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularZMotion = transform());
        public static void BindLinearLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property)
            => Bindings2._scope.Bind(property, v => obj.linearLimitSpring = v);
        public static void BindLinearLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.linearLimitSpring = transform(v));
        public static void BindLinearLimitSpring(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearLimitSpring = transform());
        public static void BindLinearLimitSpringInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearLimitSpring = transform());
        public static void BindLinearLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.linearLimit = v);
        public static void BindLinearLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.linearLimit = transform(v));
        public static void BindLinearLimit(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearLimit = transform());
        public static void BindLinearLimitInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearLimit = transform());
        public static void BindAngularXLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property)
            => Bindings2._scope.Bind(property, v => obj.angularXLimitSpring = v);
        public static void BindAngularXLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.angularXLimitSpring = transform(v));
        public static void BindAngularXLimitSpring(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularXLimitSpring = transform());
        public static void BindAngularXLimitSpringInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularXLimitSpring = transform());
        public static void BindLowAngularXLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.lowAngularXLimit = v);
        public static void BindLowAngularXLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.lowAngularXLimit = transform(v));
        public static void BindLowAngularXLimit(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.lowAngularXLimit = transform());
        public static void BindLowAngularXLimitInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lowAngularXLimit = transform());
        public static void BindHighAngularXLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.highAngularXLimit = v);
        public static void BindHighAngularXLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.highAngularXLimit = transform(v));
        public static void BindHighAngularXLimit(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.highAngularXLimit = transform());
        public static void BindHighAngularXLimitInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.highAngularXLimit = transform());
        public static void BindAngularYZLimitSpring(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimitSpring> property)
            => Bindings2._scope.Bind(property, v => obj.angularYZLimitSpring = v);
        public static void BindAngularYZLimitSpring<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.angularYZLimitSpring = transform(v));
        public static void BindAngularYZLimitSpring(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularYZLimitSpring = transform());
        public static void BindAngularYZLimitSpringInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimitSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularYZLimitSpring = transform());
        public static void BindAngularYLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.angularYLimit = v);
        public static void BindAngularYLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.angularYLimit = transform(v));
        public static void BindAngularYLimit(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularYLimit = transform());
        public static void BindAngularYLimitInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularYLimit = transform());
        public static void BindAngularZLimit(this ConfigurableJoint obj, IProperty<UnityEngine.SoftJointLimit> property)
            => Bindings2._scope.Bind(property, v => obj.angularZLimit = v);
        public static void BindAngularZLimit<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.Bind(property, v => obj.angularZLimit = transform(v));
        public static void BindAngularZLimit(this ConfigurableJoint obj, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularZLimit = transform());
        public static void BindAngularZLimitInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.SoftJointLimit> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularZLimit = transform());
        public static void BindTargetPosition(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.targetPosition = v);
        public static void BindTargetPosition<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.targetPosition = transform(v));
        public static void BindTargetPosition(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetPosition = transform());
        public static void BindTargetPositionInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetPosition = transform());
        public static void BindTargetPositionLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetPosition = Vector3.Lerp(obj.targetPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetPositionLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetPosition = Vector3.Lerp(obj.targetPosition, transform(), speed * Time.smoothDeltaTime));
        public static void BindTargetPositionTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetPosition = Vector3.MoveTowards(obj.targetPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetPositionTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetPosition = Vector3.MoveTowards(obj.targetPosition, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTargetPosition(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.targetPosition = Vector3.Lerp(start, end, t));
        public static void AnimateTargetPosition(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTargetPosition(obj, obj.targetPosition, end, curve);
        public static void BindTargetVelocity(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.targetVelocity = v);
        public static void BindTargetVelocity<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.targetVelocity = transform(v));
        public static void BindTargetVelocity(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetVelocity = transform());
        public static void BindTargetVelocityInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetVelocity = transform());
        public static void BindTargetVelocityLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetVelocity = Vector3.Lerp(obj.targetVelocity, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetVelocityLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetVelocity = Vector3.Lerp(obj.targetVelocity, transform(), speed * Time.smoothDeltaTime));
        public static void BindTargetVelocityTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetVelocity = Vector3.MoveTowards(obj.targetVelocity, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetVelocityTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetVelocity = Vector3.MoveTowards(obj.targetVelocity, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTargetVelocity(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.targetVelocity = Vector3.Lerp(start, end, t));
        public static void AnimateTargetVelocity(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTargetVelocity(obj, obj.targetVelocity, end, curve);
        public static void BindXDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.xDrive = v);
        public static void BindXDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.xDrive = transform(v));
        public static void BindXDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.xDrive = transform());
        public static void BindXDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.xDrive = transform());
        public static void BindYDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.yDrive = v);
        public static void BindYDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.yDrive = transform(v));
        public static void BindYDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.yDrive = transform());
        public static void BindYDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.yDrive = transform());
        public static void BindZDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.zDrive = v);
        public static void BindZDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.zDrive = transform(v));
        public static void BindZDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.zDrive = transform());
        public static void BindZDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.zDrive = transform());
        public static void BindTargetRotation(this ConfigurableJoint obj, IProperty<UnityEngine.Quaternion> property)
            => Bindings2._scope.Bind(property, v => obj.targetRotation = v);
        public static void BindTargetRotation<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform)
            => Bindings2._scope.Bind(property, v => obj.targetRotation = transform(v));
        public static void BindTargetRotation(this ConfigurableJoint obj, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetRotation = transform());
        public static void BindTargetRotationInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetRotation = transform());
        public static void BindTargetAngularVelocity(this ConfigurableJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.targetAngularVelocity = v);
        public static void BindTargetAngularVelocity<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.targetAngularVelocity = transform(v));
        public static void BindTargetAngularVelocity(this ConfigurableJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetAngularVelocity = transform());
        public static void BindTargetAngularVelocityInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetAngularVelocity = transform());
        public static void BindTargetAngularVelocityLerp(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetAngularVelocity = Vector3.Lerp(obj.targetAngularVelocity, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetAngularVelocityLerp(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetAngularVelocity = Vector3.Lerp(obj.targetAngularVelocity, transform(), speed * Time.smoothDeltaTime));
        public static void BindTargetAngularVelocityTowards(this ConfigurableJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.targetAngularVelocity = Vector3.MoveTowards(obj.targetAngularVelocity, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTargetAngularVelocityTowards(this ConfigurableJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetAngularVelocity = Vector3.MoveTowards(obj.targetAngularVelocity, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTargetAngularVelocity(this ConfigurableJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.targetAngularVelocity = Vector3.Lerp(start, end, t));
        public static void AnimateTargetAngularVelocity(this ConfigurableJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTargetAngularVelocity(obj, obj.targetAngularVelocity, end, curve);
        public static void BindRotationDriveMode(this ConfigurableJoint obj, IProperty<UnityEngine.RotationDriveMode> property)
            => Bindings2._scope.Bind(property, v => obj.rotationDriveMode = v);
        public static void BindRotationDriveMode<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.RotationDriveMode> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationDriveMode = transform(v));
        public static void BindRotationDriveMode(this ConfigurableJoint obj, Func<UnityEngine.RotationDriveMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationDriveMode = transform());
        public static void BindRotationDriveModeInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.RotationDriveMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationDriveMode = transform());
        public static void BindAngularXDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.angularXDrive = v);
        public static void BindAngularXDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.angularXDrive = transform(v));
        public static void BindAngularXDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularXDrive = transform());
        public static void BindAngularXDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularXDrive = transform());
        public static void BindAngularYZDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.angularYZDrive = v);
        public static void BindAngularYZDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.angularYZDrive = transform(v));
        public static void BindAngularYZDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularYZDrive = transform());
        public static void BindAngularYZDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularYZDrive = transform());
        public static void BindSlerpDrive(this ConfigurableJoint obj, IProperty<UnityEngine.JointDrive> property)
            => Bindings2._scope.Bind(property, v => obj.slerpDrive = v);
        public static void BindSlerpDrive<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointDrive> transform)
            => Bindings2._scope.Bind(property, v => obj.slerpDrive = transform(v));
        public static void BindSlerpDrive(this ConfigurableJoint obj, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindUpdate(() => obj.slerpDrive = transform());
        public static void BindSlerpDriveInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointDrive> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.slerpDrive = transform());
        public static void BindProjectionMode(this ConfigurableJoint obj, IProperty<UnityEngine.JointProjectionMode> property)
            => Bindings2._scope.Bind(property, v => obj.projectionMode = v);
        public static void BindProjectionMode<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, UnityEngine.JointProjectionMode> transform)
            => Bindings2._scope.Bind(property, v => obj.projectionMode = transform(v));
        public static void BindProjectionMode(this ConfigurableJoint obj, Func<UnityEngine.JointProjectionMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.projectionMode = transform());
        public static void BindProjectionModeInterval(this ConfigurableJoint obj, float seconds, Func<UnityEngine.JointProjectionMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.projectionMode = transform());
        public static void BindProjectionDistance(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.projectionDistance = v);
        public static void BindProjectionDistance<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.projectionDistance = transform(v));
        public static void BindProjectionDistance(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.projectionDistance = transform());
        public static void BindProjectionDistanceInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.projectionDistance = transform());
        public static void BindProjectionAngle(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.projectionAngle = v);
        public static void BindProjectionAngle<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.projectionAngle = transform(v));
        public static void BindProjectionAngle(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.projectionAngle = transform());
        public static void BindProjectionAngleInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.projectionAngle = transform());
        public static void BindConfiguredInWorldSpace(this ConfigurableJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.configuredInWorldSpace = v);
        public static void BindConfiguredInWorldSpace<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.configuredInWorldSpace = transform(v));
        public static void BindConfiguredInWorldSpace(this ConfigurableJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.configuredInWorldSpace = transform());
        public static void BindConfiguredInWorldSpaceInterval(this ConfigurableJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.configuredInWorldSpace = transform());
        public static void BindSwapBodies(this ConfigurableJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.swapBodies = v);
        public static void BindSwapBodies<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.swapBodies = transform(v));
        public static void BindSwapBodies(this ConfigurableJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.swapBodies = transform());
        public static void BindSwapBodiesInterval(this ConfigurableJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.swapBodies = transform());
        public static void BindBreakForce(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        public static void BindEnableCollision(this ConfigurableJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this ConfigurableJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this ConfigurableJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindEnablePreprocessing(this ConfigurableJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = transform(v));
        public static void BindEnablePreprocessing(this ConfigurableJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enablePreprocessing = transform());
        public static void BindEnablePreprocessingInterval(this ConfigurableJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enablePreprocessing = transform());
        public static void BindMassScale(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.massScale = v);
        public static void BindMassScale<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.massScale = transform(v));
        public static void BindMassScale(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.massScale = transform());
        public static void BindMassScaleInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.massScale = transform());
        public static void BindConnectedMassScale(this ConfigurableJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this ConfigurableJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = transform(v));
        public static void BindConnectedMassScale(this ConfigurableJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedMassScale = transform());
        public static void BindConnectedMassScaleInterval(this ConfigurableJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedMassScale = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindForce(this ConstantForce obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.force = v);
        public static void BindForce<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.force = transform(v));
        public static void BindForce(this ConstantForce obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.force = transform());
        public static void BindForceInterval(this ConstantForce obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.force = transform());
        public static void BindForceLerp(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.force = Vector3.Lerp(obj.force, property.Value, speed * Time.smoothDeltaTime));
        public static void BindForceLerp(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.force = Vector3.Lerp(obj.force, transform(), speed * Time.smoothDeltaTime));
        public static void BindForceTowards(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.force = Vector3.MoveTowards(obj.force, property.Value, speed * Time.smoothDeltaTime));
        public static void BindForceTowards(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.force = Vector3.MoveTowards(obj.force, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateForce(this ConstantForce obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.force = Vector3.Lerp(start, end, t));
        public static void AnimateForce(this ConstantForce obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateForce(obj, obj.force, end, curve);
        public static void BindRelativeForce(this ConstantForce obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.relativeForce = v);
        public static void BindRelativeForce<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.relativeForce = transform(v));
        public static void BindRelativeForce(this ConstantForce obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = transform());
        public static void BindRelativeForceInterval(this ConstantForce obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.relativeForce = transform());
        public static void BindRelativeForceLerp(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = Vector3.Lerp(obj.relativeForce, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRelativeForceLerp(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = Vector3.Lerp(obj.relativeForce, transform(), speed * Time.smoothDeltaTime));
        public static void BindRelativeForceTowards(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = Vector3.MoveTowards(obj.relativeForce, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRelativeForceTowards(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = Vector3.MoveTowards(obj.relativeForce, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRelativeForce(this ConstantForce obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.relativeForce = Vector3.Lerp(start, end, t));
        public static void AnimateRelativeForce(this ConstantForce obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRelativeForce(obj, obj.relativeForce, end, curve);
        public static void BindTorque(this ConstantForce obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.torque = v);
        public static void BindTorque<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.torque = transform(v));
        public static void BindTorque(this ConstantForce obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.torque = transform());
        public static void BindTorqueInterval(this ConstantForce obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.torque = transform());
        public static void BindTorqueLerp(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.torque = Vector3.Lerp(obj.torque, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTorqueLerp(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.torque = Vector3.Lerp(obj.torque, transform(), speed * Time.smoothDeltaTime));
        public static void BindTorqueTowards(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.torque = Vector3.MoveTowards(obj.torque, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTorqueTowards(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.torque = Vector3.MoveTowards(obj.torque, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTorque(this ConstantForce obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.torque = Vector3.Lerp(start, end, t));
        public static void AnimateTorque(this ConstantForce obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTorque(obj, obj.torque, end, curve);
        public static void BindRelativeTorque(this ConstantForce obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.relativeTorque = v);
        public static void BindRelativeTorque<T>(this ConstantForce obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.relativeTorque = transform(v));
        public static void BindRelativeTorque(this ConstantForce obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeTorque = transform());
        public static void BindRelativeTorqueInterval(this ConstantForce obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.relativeTorque = transform());
        public static void BindRelativeTorqueLerp(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.relativeTorque = Vector3.Lerp(obj.relativeTorque, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRelativeTorqueLerp(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeTorque = Vector3.Lerp(obj.relativeTorque, transform(), speed * Time.smoothDeltaTime));
        public static void BindRelativeTorqueTowards(this ConstantForce obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.relativeTorque = Vector3.MoveTowards(obj.relativeTorque, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRelativeTorqueTowards(this ConstantForce obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeTorque = Vector3.MoveTowards(obj.relativeTorque, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRelativeTorque(this ConstantForce obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.relativeTorque = Vector3.Lerp(start, end, t));
        public static void AnimateRelativeTorque(this ConstantForce obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRelativeTorque(obj, obj.relativeTorque, end, curve);
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindForce(this ConstantForce2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.force = v);
        public static void BindForce<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.force = transform(v));
        public static void BindForce(this ConstantForce2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.force = transform());
        public static void BindForceInterval(this ConstantForce2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.force = transform());
        public static void BindRelativeForce(this ConstantForce2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.relativeForce = v);
        public static void BindRelativeForce<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.relativeForce = transform(v));
        public static void BindRelativeForce(this ConstantForce2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.relativeForce = transform());
        public static void BindRelativeForceInterval(this ConstantForce2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.relativeForce = transform());
        public static void BindTorque(this ConstantForce2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.torque = v);
        public static void BindTorque<T>(this ConstantForce2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.torque = transform(v));
        public static void BindTorque(this ConstantForce2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.torque = transform());
        public static void BindTorqueInterval(this ConstantForce2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.torque = transform());
        #endif


        #if UNITY_GUI
        public static void BindHorizontalFit(this UnityEngine.UI.ContentSizeFitter obj, IProperty<UnityEngine.UI.ContentSizeFitter.FitMode> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalFit = v);
        public static void BindHorizontalFit<T>(this UnityEngine.UI.ContentSizeFitter obj, IProperty<T> property, Func<T, UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalFit = transform(v));
        public static void BindHorizontalFit(this UnityEngine.UI.ContentSizeFitter obj, Func<UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalFit = transform());
        public static void BindHorizontalFitInterval(this UnityEngine.UI.ContentSizeFitter obj, float seconds, Func<UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalFit = transform());
        public static void BindVerticalFit(this UnityEngine.UI.ContentSizeFitter obj, IProperty<UnityEngine.UI.ContentSizeFitter.FitMode> property)
            => Bindings2._scope.Bind(property, v => obj.verticalFit = v);
        public static void BindVerticalFit<T>(this UnityEngine.UI.ContentSizeFitter obj, IProperty<T> property, Func<T, UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalFit = transform(v));
        public static void BindVerticalFit(this UnityEngine.UI.ContentSizeFitter obj, Func<UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalFit = transform());
        public static void BindVerticalFitInterval(this UnityEngine.UI.ContentSizeFitter obj, float seconds, Func<UnityEngine.UI.ContentSizeFitter.FitMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalFit = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this DistanceJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this DistanceJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this DistanceJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this DistanceJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this DistanceJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this DistanceJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this DistanceJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this DistanceJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this DistanceJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this DistanceJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this DistanceJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this DistanceJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this DistanceJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this DistanceJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this DistanceJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindAutoConfigureDistance(this DistanceJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureDistance = v);
        public static void BindAutoConfigureDistance<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureDistance = transform(v));
        public static void BindAutoConfigureDistance(this DistanceJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureDistance = transform());
        public static void BindAutoConfigureDistanceInterval(this DistanceJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureDistance = transform());
        public static void BindDistance(this DistanceJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.distance = v);
        public static void BindDistance<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.distance = transform(v));
        public static void BindDistance(this DistanceJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.distance = transform());
        public static void BindDistanceInterval(this DistanceJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.distance = transform());
        public static void BindMaxDistanceOnly(this DistanceJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.maxDistanceOnly = v);
        public static void BindMaxDistanceOnly<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.maxDistanceOnly = transform(v));
        public static void BindMaxDistanceOnly(this DistanceJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxDistanceOnly = transform());
        public static void BindMaxDistanceOnlyInterval(this DistanceJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxDistanceOnly = transform());
        public static void BindBreakForce(this DistanceJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this DistanceJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this DistanceJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this DistanceJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Dropdown obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.Dropdown obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindTemplate(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.template = v);
        public static void BindTemplate<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.template = transform(v));
        public static void BindTemplate(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.template = transform());
        public static void BindTemplateInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.template = transform());
        public static void BindCaptionText(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Text> property)
            => Bindings2._scope.Bind(property, v => obj.captionText = v);
        public static void BindCaptionText<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform)
            => Bindings2._scope.Bind(property, v => obj.captionText = transform(v));
        public static void BindCaptionText(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.captionText = transform());
        public static void BindCaptionTextInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.captionText = transform());
        public static void BindCaptionImage(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Image> property)
            => Bindings2._scope.Bind(property, v => obj.captionImage = v);
        public static void BindCaptionImage<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform)
            => Bindings2._scope.Bind(property, v => obj.captionImage = transform(v));
        public static void BindCaptionImage(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindUpdate(() => obj.captionImage = transform());
        public static void BindCaptionImageInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.captionImage = transform());
        public static void BindItemText(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Text> property)
            => Bindings2._scope.Bind(property, v => obj.itemText = v);
        public static void BindItemText<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform)
            => Bindings2._scope.Bind(property, v => obj.itemText = transform(v));
        public static void BindItemText(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.itemText = transform());
        public static void BindItemTextInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.itemText = transform());
        public static void BindItemImage(this UnityEngine.UI.Dropdown obj, IProperty<UnityEngine.UI.Image> property)
            => Bindings2._scope.Bind(property, v => obj.itemImage = v);
        public static void BindItemImage<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform)
            => Bindings2._scope.Bind(property, v => obj.itemImage = transform(v));
        public static void BindItemImage(this UnityEngine.UI.Dropdown obj, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindUpdate(() => obj.itemImage = transform());
        public static void BindItemImageInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.itemImage = transform());
        public static void BindValue(this UnityEngine.UI.Dropdown obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.value = transform(v));
        public static void BindValue(this UnityEngine.UI.Dropdown obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.value = transform());
        public static void BindValueInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.value = transform());
        public static void BindAlphaFadeSpeed(this UnityEngine.UI.Dropdown obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.alphaFadeSpeed = v);
        public static void BindAlphaFadeSpeed<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.alphaFadeSpeed = transform(v));
        public static void BindAlphaFadeSpeed(this UnityEngine.UI.Dropdown obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.alphaFadeSpeed = transform());
        public static void BindAlphaFadeSpeedInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alphaFadeSpeed = transform());
        public static void BindOptions(this UnityEngine.UI.Dropdown obj, IProperty<System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> property)
            => Bindings2._scope.Bind(property, v => obj.options = v);
        public static void BindOptions<T>(this UnityEngine.UI.Dropdown obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> transform)
            => Bindings2._scope.Bind(property, v => obj.options = transform(v));
        public static void BindOptions(this UnityEngine.UI.Dropdown obj, Func<System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> transform)
            => Bindings2._scope.BindUpdate(() => obj.options = transform());
        public static void BindOptionsInterval(this UnityEngine.UI.Dropdown obj, float seconds, Func<System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.options = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this EdgeCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this EdgeCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this EdgeCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this EdgeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this EdgeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this EdgeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this EdgeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this EdgeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this EdgeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this EdgeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this EdgeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this EdgeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this EdgeCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this EdgeCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this EdgeCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this EdgeCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this EdgeCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this EdgeCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindEdgeRadius(this EdgeCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = v);
        public static void BindEdgeRadius<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.edgeRadius = transform(v));
        public static void BindEdgeRadius(this EdgeCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.edgeRadius = transform());
        public static void BindEdgeRadiusInterval(this EdgeCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.edgeRadius = transform());
        public static void BindPoints(this EdgeCollider2D obj, IProperty<UnityEngine.Vector2[]> property)
            => Bindings2._scope.Bind(property, v => obj.points = v);
        public static void BindPoints<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2[]> transform)
            => Bindings2._scope.Bind(property, v => obj.points = transform(v));
        public static void BindPoints(this EdgeCollider2D obj, Func<UnityEngine.Vector2[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.points = transform());
        public static void BindPointsInterval(this EdgeCollider2D obj, float seconds, Func<UnityEngine.Vector2[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.points = transform());
        #if UNITY_2020_1_OR_NEWER
        public static void BindUseAdjacentStartPoint(this EdgeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useAdjacentStartPoint = v);
        public static void BindUseAdjacentStartPoint<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useAdjacentStartPoint = transform(v));
        public static void BindUseAdjacentStartPoint(this EdgeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useAdjacentStartPoint = transform());
        public static void BindUseAdjacentStartPointInterval(this EdgeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useAdjacentStartPoint = transform());
        #endif
        #if UNITY_2020_1_OR_NEWER
        public static void BindUseAdjacentEndPoint(this EdgeCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useAdjacentEndPoint = v);
        public static void BindUseAdjacentEndPoint<T>(this EdgeCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useAdjacentEndPoint = transform(v));
        public static void BindUseAdjacentEndPoint(this EdgeCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useAdjacentEndPoint = transform());
        public static void BindUseAdjacentEndPointInterval(this EdgeCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useAdjacentEndPoint = transform());
        #endif
        #endif


        #if UNITY_GUI
        public static void BindFirstSelectedGameObject(this UnityEngine.EventSystems.EventSystem obj, IProperty<UnityEngine.GameObject> property)
            => Bindings2._scope.Bind(property, v => obj.firstSelectedGameObject = v);
        public static void BindFirstSelectedGameObject<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, UnityEngine.GameObject> transform)
            => Bindings2._scope.Bind(property, v => obj.firstSelectedGameObject = transform(v));
        public static void BindFirstSelectedGameObject(this UnityEngine.EventSystems.EventSystem obj, Func<UnityEngine.GameObject> transform)
            => Bindings2._scope.BindUpdate(() => obj.firstSelectedGameObject = transform());
        public static void BindFirstSelectedGameObjectInterval(this UnityEngine.EventSystems.EventSystem obj, float seconds, Func<UnityEngine.GameObject> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.firstSelectedGameObject = transform());
        public static void BindSendNavigationEvents(this UnityEngine.EventSystems.EventSystem obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.sendNavigationEvents = v);
        public static void BindSendNavigationEvents<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.sendNavigationEvents = transform(v));
        public static void BindSendNavigationEvents(this UnityEngine.EventSystems.EventSystem obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.sendNavigationEvents = transform());
        public static void BindSendNavigationEventsInterval(this UnityEngine.EventSystems.EventSystem obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sendNavigationEvents = transform());
        public static void BindPixelDragThreshold(this UnityEngine.EventSystems.EventSystem obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.pixelDragThreshold = v);
        public static void BindPixelDragThreshold<T>(this UnityEngine.EventSystems.EventSystem obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.pixelDragThreshold = transform(v));
        public static void BindPixelDragThreshold(this UnityEngine.EventSystems.EventSystem obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.pixelDragThreshold = transform());
        public static void BindPixelDragThresholdInterval(this UnityEngine.EventSystems.EventSystem obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.pixelDragThreshold = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this FixedJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this FixedJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this FixedJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this FixedJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this FixedJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this FixedJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this FixedJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this FixedJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this FixedJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this FixedJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this FixedJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this FixedJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this FixedJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this FixedJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this FixedJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindDampingRatio(this FixedJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = transform(v));
        public static void BindDampingRatio(this FixedJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dampingRatio = transform());
        public static void BindDampingRatioInterval(this FixedJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dampingRatio = transform());
        public static void BindFrequency(this FixedJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.frequency = v);
        public static void BindFrequency<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.frequency = transform(v));
        public static void BindFrequency(this FixedJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.frequency = transform());
        public static void BindFrequencyInterval(this FixedJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.frequency = transform());
        public static void BindBreakForce(this FixedJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this FixedJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this FixedJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this FixedJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this FixedJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this FixedJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this FixedJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this FrictionJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this FrictionJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this FrictionJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this FrictionJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this FrictionJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this FrictionJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this FrictionJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this FrictionJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this FrictionJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this FrictionJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this FrictionJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this FrictionJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this FrictionJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this FrictionJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this FrictionJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindMaxForce(this FrictionJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxForce = transform(v));
        public static void BindMaxForce(this FrictionJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxForce = transform());
        public static void BindMaxForceInterval(this FrictionJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxForce = transform());
        public static void BindMaxTorque(this FrictionJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxTorque = v);
        public static void BindMaxTorque<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxTorque = transform(v));
        public static void BindMaxTorque(this FrictionJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxTorque = transform());
        public static void BindMaxTorqueInterval(this FrictionJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxTorque = transform());
        public static void BindBreakForce(this FrictionJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this FrictionJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this FrictionJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this FrictionJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this FrictionJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this FrictionJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this FrictionJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        #if UNITY_GUI
        public static void BindIgnoreReversedGraphics(this UnityEngine.UI.GraphicRaycaster obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.ignoreReversedGraphics = v);
        public static void BindIgnoreReversedGraphics<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.ignoreReversedGraphics = transform(v));
        public static void BindIgnoreReversedGraphics(this UnityEngine.UI.GraphicRaycaster obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.ignoreReversedGraphics = transform());
        public static void BindIgnoreReversedGraphicsInterval(this UnityEngine.UI.GraphicRaycaster obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.ignoreReversedGraphics = transform());
        public static void BindBlockingObjects(this UnityEngine.UI.GraphicRaycaster obj, IProperty<UnityEngine.UI.GraphicRaycaster.BlockingObjects> property)
            => Bindings2._scope.Bind(property, v => obj.blockingObjects = v);
        public static void BindBlockingObjects<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, UnityEngine.UI.GraphicRaycaster.BlockingObjects> transform)
            => Bindings2._scope.Bind(property, v => obj.blockingObjects = transform(v));
        public static void BindBlockingObjects(this UnityEngine.UI.GraphicRaycaster obj, Func<UnityEngine.UI.GraphicRaycaster.BlockingObjects> transform)
            => Bindings2._scope.BindUpdate(() => obj.blockingObjects = transform());
        public static void BindBlockingObjectsInterval(this UnityEngine.UI.GraphicRaycaster obj, float seconds, Func<UnityEngine.UI.GraphicRaycaster.BlockingObjects> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.blockingObjects = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindBlockingMask(this UnityEngine.UI.GraphicRaycaster obj, IProperty<UnityEngine.LayerMask> property)
            => Bindings2._scope.Bind(property, v => obj.blockingMask = v);
        public static void BindBlockingMask<T>(this UnityEngine.UI.GraphicRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform)
            => Bindings2._scope.Bind(property, v => obj.blockingMask = transform(v));
        public static void BindBlockingMask(this UnityEngine.UI.GraphicRaycaster obj, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindUpdate(() => obj.blockingMask = transform());
        public static void BindBlockingMaskInterval(this UnityEngine.UI.GraphicRaycaster obj, float seconds, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.blockingMask = transform());
        #endif
        #endif


        public static void BindCellSize(this Grid obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.cellSize = v);
        public static void BindCellSize<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.cellSize = transform(v));
        public static void BindCellSize(this Grid obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = transform());
        public static void BindCellSizeInterval(this Grid obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cellSize = transform());
        public static void BindCellSizeLerp(this Grid obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = Vector3.Lerp(obj.cellSize, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCellSizeLerp(this Grid obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = Vector3.Lerp(obj.cellSize, transform(), speed * Time.smoothDeltaTime));
        public static void BindCellSizeTowards(this Grid obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = Vector3.MoveTowards(obj.cellSize, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCellSizeTowards(this Grid obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = Vector3.MoveTowards(obj.cellSize, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCellSize(this Grid obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.cellSize = Vector3.Lerp(start, end, t));
        public static void AnimateCellSize(this Grid obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCellSize(obj, obj.cellSize, end, curve);
        public static void BindCellGap(this Grid obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.cellGap = v);
        public static void BindCellGap<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.cellGap = transform(v));
        public static void BindCellGap(this Grid obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellGap = transform());
        public static void BindCellGapInterval(this Grid obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cellGap = transform());
        public static void BindCellGapLerp(this Grid obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.cellGap = Vector3.Lerp(obj.cellGap, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCellGapLerp(this Grid obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellGap = Vector3.Lerp(obj.cellGap, transform(), speed * Time.smoothDeltaTime));
        public static void BindCellGapTowards(this Grid obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.cellGap = Vector3.MoveTowards(obj.cellGap, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCellGapTowards(this Grid obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellGap = Vector3.MoveTowards(obj.cellGap, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCellGap(this Grid obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.cellGap = Vector3.Lerp(start, end, t));
        public static void AnimateCellGap(this Grid obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCellGap(obj, obj.cellGap, end, curve);
        public static void BindCellLayout(this Grid obj, IProperty<UnityEngine.GridLayout.CellLayout> property)
            => Bindings2._scope.Bind(property, v => obj.cellLayout = v);
        public static void BindCellLayout<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.GridLayout.CellLayout> transform)
            => Bindings2._scope.Bind(property, v => obj.cellLayout = transform(v));
        public static void BindCellLayout(this Grid obj, Func<UnityEngine.GridLayout.CellLayout> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellLayout = transform());
        public static void BindCellLayoutInterval(this Grid obj, float seconds, Func<UnityEngine.GridLayout.CellLayout> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cellLayout = transform());
        public static void BindCellSwizzle(this Grid obj, IProperty<UnityEngine.GridLayout.CellSwizzle> property)
            => Bindings2._scope.Bind(property, v => obj.cellSwizzle = v);
        public static void BindCellSwizzle<T>(this Grid obj, IProperty<T> property, Func<T, UnityEngine.GridLayout.CellSwizzle> transform)
            => Bindings2._scope.Bind(property, v => obj.cellSwizzle = transform(v));
        public static void BindCellSwizzle(this Grid obj, Func<UnityEngine.GridLayout.CellSwizzle> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellSwizzle = transform());
        public static void BindCellSwizzleInterval(this Grid obj, float seconds, Func<UnityEngine.GridLayout.CellSwizzle> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cellSwizzle = transform());


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.RectOffset> property)
            => Bindings2._scope.Bind(property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform)
            => Bindings2._scope.Bind(property, v => obj.padding = transform(v));
        public static void BindPadding(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindUpdate(() => obj.padding = transform());
        public static void BindPaddingInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.padding = transform());
        public static void BindCellSize(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.cellSize = v);
        public static void BindCellSize<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.cellSize = transform(v));
        public static void BindCellSize(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.cellSize = transform());
        public static void BindCellSizeInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cellSize = transform());
        public static void BindSpacing(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.spacing = transform(v));
        public static void BindSpacing(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.spacing = transform());
        public static void BindSpacingInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spacing = transform());
        public static void BindStartCorner(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Corner> property)
            => Bindings2._scope.Bind(property, v => obj.startCorner = v);
        public static void BindStartCorner<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Corner> transform)
            => Bindings2._scope.Bind(property, v => obj.startCorner = transform(v));
        public static void BindStartCorner(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.UI.GridLayoutGroup.Corner> transform)
            => Bindings2._scope.BindUpdate(() => obj.startCorner = transform());
        public static void BindStartCornerInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.UI.GridLayoutGroup.Corner> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.startCorner = transform());
        public static void BindStartAxis(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.startAxis = v);
        public static void BindStartAxis<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.startAxis = transform(v));
        public static void BindStartAxis(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.UI.GridLayoutGroup.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.startAxis = transform());
        public static void BindStartAxisInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.UI.GridLayoutGroup.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.startAxis = transform());
        public static void BindChildAlignment(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindUpdate(() => obj.childAlignment = transform());
        public static void BindChildAlignmentInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childAlignment = transform());
        public static void BindConstraint(this UnityEngine.UI.GridLayoutGroup obj, IProperty<UnityEngine.UI.GridLayoutGroup.Constraint> property)
            => Bindings2._scope.Bind(property, v => obj.constraint = v);
        public static void BindConstraint<T>(this UnityEngine.UI.GridLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.UI.GridLayoutGroup.Constraint> transform)
            => Bindings2._scope.Bind(property, v => obj.constraint = transform(v));
        public static void BindConstraint(this UnityEngine.UI.GridLayoutGroup obj, Func<UnityEngine.UI.GridLayoutGroup.Constraint> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraint = transform());
        public static void BindConstraintInterval(this UnityEngine.UI.GridLayoutGroup obj, float seconds, Func<UnityEngine.UI.GridLayoutGroup.Constraint> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraint = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this HingeJoint obj, IProperty<UnityEngine.Rigidbody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this HingeJoint obj, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this HingeJoint obj, float seconds, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this HingeJoint obj, IProperty<UnityEngine.ArticulationBody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = transform(v));
        public static void BindConnectedArticulationBody(this HingeJoint obj, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedArticulationBody = transform());
        public static void BindConnectedArticulationBodyInterval(this HingeJoint obj, float seconds, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedArticulationBody = transform());
        #endif
        public static void BindAnchor(this HingeJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this HingeJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this HingeJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindAnchorLerp(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorLerp(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAnchor(this HingeJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.anchor = Vector3.Lerp(start, end, t));
        public static void AnimateAnchor(this HingeJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAnchor(obj, obj.anchor, end, curve);
        public static void BindAxis(this HingeJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.axis = v);
        public static void BindAxis<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.axis = transform(v));
        public static void BindAxis(this HingeJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = transform());
        public static void BindAxisInterval(this HingeJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.axis = transform());
        public static void BindAxisLerp(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisLerp(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAxis(this HingeJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.axis = Vector3.Lerp(start, end, t));
        public static void AnimateAxis(this HingeJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAxis(obj, obj.axis, end, curve);
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindConnectedAnchor(this HingeJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this HingeJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this HingeJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorLerp(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorLerp(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this HingeJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this HingeJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateConnectedAnchor(this HingeJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.connectedAnchor = Vector3.Lerp(start, end, t));
        public static void AnimateConnectedAnchor(this HingeJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateConnectedAnchor(obj, obj.connectedAnchor, end, curve);
        public static void BindUseSpring(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useSpring = v);
        public static void BindUseSpring<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useSpring = transform(v));
        public static void BindUseSpring(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useSpring = transform());
        public static void BindUseSpringInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useSpring = transform());
        public static void BindSpring(this HingeJoint obj, IProperty<UnityEngine.JointSpring> property)
            => Bindings2._scope.Bind(property, v => obj.spring = v);
        public static void BindSpring<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.spring = transform(v));
        public static void BindSpring(this HingeJoint obj, Func<UnityEngine.JointSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.spring = transform());
        public static void BindSpringInterval(this HingeJoint obj, float seconds, Func<UnityEngine.JointSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spring = transform());
        public static void BindUseMotor(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMotor = transform(v));
        public static void BindUseMotor(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMotor = transform());
        public static void BindUseMotorInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMotor = transform());
        public static void BindMotor(this HingeJoint obj, IProperty<UnityEngine.JointMotor> property)
            => Bindings2._scope.Bind(property, v => obj.motor = v);
        public static void BindMotor<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointMotor> transform)
            => Bindings2._scope.Bind(property, v => obj.motor = transform(v));
        public static void BindMotor(this HingeJoint obj, Func<UnityEngine.JointMotor> transform)
            => Bindings2._scope.BindUpdate(() => obj.motor = transform());
        public static void BindMotorInterval(this HingeJoint obj, float seconds, Func<UnityEngine.JointMotor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motor = transform());
        public static void BindUseLimits(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useLimits = transform(v));
        public static void BindUseLimits(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useLimits = transform());
        public static void BindUseLimitsInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useLimits = transform());
        public static void BindLimits(this HingeJoint obj, IProperty<UnityEngine.JointLimits> property)
            => Bindings2._scope.Bind(property, v => obj.limits = v);
        public static void BindLimits<T>(this HingeJoint obj, IProperty<T> property, Func<T, UnityEngine.JointLimits> transform)
            => Bindings2._scope.Bind(property, v => obj.limits = transform(v));
        public static void BindLimits(this HingeJoint obj, Func<UnityEngine.JointLimits> transform)
            => Bindings2._scope.BindUpdate(() => obj.limits = transform());
        public static void BindLimitsInterval(this HingeJoint obj, float seconds, Func<UnityEngine.JointLimits> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.limits = transform());
        public static void BindBreakForce(this HingeJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this HingeJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this HingeJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this HingeJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this HingeJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this HingeJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        public static void BindEnableCollision(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindEnablePreprocessing(this HingeJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = transform(v));
        public static void BindEnablePreprocessing(this HingeJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enablePreprocessing = transform());
        public static void BindEnablePreprocessingInterval(this HingeJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enablePreprocessing = transform());
        public static void BindMassScale(this HingeJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.massScale = v);
        public static void BindMassScale<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.massScale = transform(v));
        public static void BindMassScale(this HingeJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.massScale = transform());
        public static void BindMassScaleInterval(this HingeJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.massScale = transform());
        public static void BindConnectedMassScale(this HingeJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this HingeJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = transform(v));
        public static void BindConnectedMassScale(this HingeJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedMassScale = transform());
        public static void BindConnectedMassScaleInterval(this HingeJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedMassScale = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this HingeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this HingeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this HingeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this HingeJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this HingeJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this HingeJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this HingeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this HingeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this HingeJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this HingeJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this HingeJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this HingeJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this HingeJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this HingeJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindUseMotor(this HingeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMotor = transform(v));
        public static void BindUseMotor(this HingeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMotor = transform());
        public static void BindUseMotorInterval(this HingeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMotor = transform());
        public static void BindMotor(this HingeJoint2D obj, IProperty<UnityEngine.JointMotor2D> property)
            => Bindings2._scope.Bind(property, v => obj.motor = v);
        public static void BindMotor<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.Bind(property, v => obj.motor = transform(v));
        public static void BindMotor(this HingeJoint2D obj, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.motor = transform());
        public static void BindMotorInterval(this HingeJoint2D obj, float seconds, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motor = transform());
        public static void BindUseLimits(this HingeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useLimits = transform(v));
        public static void BindUseLimits(this HingeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useLimits = transform());
        public static void BindUseLimitsInterval(this HingeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useLimits = transform());
        public static void BindLimits(this HingeJoint2D obj, IProperty<UnityEngine.JointAngleLimits2D> property)
            => Bindings2._scope.Bind(property, v => obj.limits = v);
        public static void BindLimits<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointAngleLimits2D> transform)
            => Bindings2._scope.Bind(property, v => obj.limits = transform(v));
        public static void BindLimits(this HingeJoint2D obj, Func<UnityEngine.JointAngleLimits2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.limits = transform());
        public static void BindLimitsInterval(this HingeJoint2D obj, float seconds, Func<UnityEngine.JointAngleLimits2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.limits = transform());
        public static void BindBreakForce(this HingeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this HingeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this HingeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this HingeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this HingeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this HingeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this HingeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<UnityEngine.RectOffset> property)
            => Bindings2._scope.Bind(property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform)
            => Bindings2._scope.Bind(property, v => obj.padding = transform(v));
        public static void BindPadding(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindUpdate(() => obj.padding = transform());
        public static void BindPaddingInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.padding = transform());
        public static void BindSpacing(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spacing = transform(v));
        public static void BindSpacing(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spacing = transform());
        public static void BindSpacingInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spacing = transform());
        public static void BindChildAlignment(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindUpdate(() => obj.childAlignment = transform());
        public static void BindChildAlignmentInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childAlignment = transform());
        public static void BindChildControlWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childControlWidth = v);
        public static void BindChildControlWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childControlWidth = transform(v));
        public static void BindChildControlWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childControlWidth = transform());
        public static void BindChildControlWidthInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childControlWidth = transform());
        public static void BindChildControlHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childControlHeight = v);
        public static void BindChildControlHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childControlHeight = transform(v));
        public static void BindChildControlHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childControlHeight = transform());
        public static void BindChildControlHeightInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childControlHeight = transform());
        public static void BindChildScaleWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childScaleWidth = v);
        public static void BindChildScaleWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childScaleWidth = transform(v));
        public static void BindChildScaleWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childScaleWidth = transform());
        public static void BindChildScaleWidthInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childScaleWidth = transform());
        public static void BindChildScaleHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childScaleHeight = v);
        public static void BindChildScaleHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childScaleHeight = transform(v));
        public static void BindChildScaleHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childScaleHeight = transform());
        public static void BindChildScaleHeightInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childScaleHeight = transform());
        public static void BindChildForceExpandWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandWidth = v);
        public static void BindChildForceExpandWidth<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandWidth = transform(v));
        public static void BindChildForceExpandWidth(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childForceExpandWidth = transform());
        public static void BindChildForceExpandWidthInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childForceExpandWidth = transform());
        public static void BindChildForceExpandHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandHeight = v);
        public static void BindChildForceExpandHeight<T>(this UnityEngine.UI.HorizontalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandHeight = transform(v));
        public static void BindChildForceExpandHeight(this UnityEngine.UI.HorizontalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childForceExpandHeight = transform());
        public static void BindChildForceExpandHeightInterval(this UnityEngine.UI.HorizontalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childForceExpandHeight = transform());
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<UnityEngine.RectOffset> property)
            => Bindings2._scope.Bind(property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.RectOffset> transform)
            => Bindings2._scope.Bind(property, v => obj.padding = transform(v));
        public static void BindPadding(this UnityEngine.UI.VerticalLayoutGroup obj, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindUpdate(() => obj.padding = transform());
        public static void BindPaddingInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<UnityEngine.RectOffset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.padding = transform());
        public static void BindSpacing(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spacing = v);
        public static void BindSpacing<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spacing = transform(v));
        public static void BindSpacing(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spacing = transform());
        public static void BindSpacingInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spacing = transform());
        public static void BindChildAlignment(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<UnityEngine.TextAnchor> property)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = v);
        public static void BindChildAlignment<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform)
            => Bindings2._scope.Bind(property, v => obj.childAlignment = transform(v));
        public static void BindChildAlignment(this UnityEngine.UI.VerticalLayoutGroup obj, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindUpdate(() => obj.childAlignment = transform());
        public static void BindChildAlignmentInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childAlignment = transform());
        public static void BindChildControlWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childControlWidth = v);
        public static void BindChildControlWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childControlWidth = transform(v));
        public static void BindChildControlWidth(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childControlWidth = transform());
        public static void BindChildControlWidthInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childControlWidth = transform());
        public static void BindChildControlHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childControlHeight = v);
        public static void BindChildControlHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childControlHeight = transform(v));
        public static void BindChildControlHeight(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childControlHeight = transform());
        public static void BindChildControlHeightInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childControlHeight = transform());
        public static void BindChildScaleWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childScaleWidth = v);
        public static void BindChildScaleWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childScaleWidth = transform(v));
        public static void BindChildScaleWidth(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childScaleWidth = transform());
        public static void BindChildScaleWidthInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childScaleWidth = transform());
        public static void BindChildScaleHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childScaleHeight = v);
        public static void BindChildScaleHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childScaleHeight = transform(v));
        public static void BindChildScaleHeight(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childScaleHeight = transform());
        public static void BindChildScaleHeightInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childScaleHeight = transform());
        public static void BindChildForceExpandWidth(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandWidth = v);
        public static void BindChildForceExpandWidth<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandWidth = transform(v));
        public static void BindChildForceExpandWidth(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childForceExpandWidth = transform());
        public static void BindChildForceExpandWidthInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childForceExpandWidth = transform());
        public static void BindChildForceExpandHeight(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandHeight = v);
        public static void BindChildForceExpandHeight<T>(this UnityEngine.UI.VerticalLayoutGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.childForceExpandHeight = transform(v));
        public static void BindChildForceExpandHeight(this UnityEngine.UI.VerticalLayoutGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.childForceExpandHeight = transform());
        public static void BindChildForceExpandHeightInterval(this UnityEngine.UI.VerticalLayoutGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.childForceExpandHeight = transform());
        #endif


        #if UNITY_GUI
        public static void BindSprite(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Sprite> property)
            => Bindings2._scope.Bind(property, v => obj.sprite = v);
        public static void BindSprite<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform)
            => Bindings2._scope.Bind(property, v => obj.sprite = transform(v));
        public static void BindSprite(this UnityEngine.UI.Image obj, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindUpdate(() => obj.sprite = transform());
        public static void BindSpriteInterval(this UnityEngine.UI.Image obj, float seconds, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sprite = transform());
        public static void BindMaterial(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Material> property)
            => Bindings2._scope.Bind(property, v => obj.material = v);
        public static void BindMaterial<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Material> transform)
            => Bindings2._scope.Bind(property, v => obj.material = transform(v));
        public static void BindMaterial(this UnityEngine.UI.Image obj, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindUpdate(() => obj.material = transform());
        public static void BindMaterialInterval(this UnityEngine.UI.Image obj, float seconds, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.material = transform());
        public static void BindColor(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this UnityEngine.UI.Image obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this UnityEngine.UI.Image obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindRaycastTarget(this UnityEngine.UI.Image obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.Image obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastTarget = transform());
        public static void BindRaycastTargetInterval(this UnityEngine.UI.Image obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastTarget = transform());
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.Image obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = transform(v));
        public static void BindRaycastPadding(this UnityEngine.UI.Image obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastPadding = transform());
        public static void BindRaycastPaddingInterval(this UnityEngine.UI.Image obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastPadding = transform());
        #endif
        public static void BindMaskable(this UnityEngine.UI.Image obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.Image obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.maskable = transform(v));
        public static void BindMaskable(this UnityEngine.UI.Image obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskable = transform());
        public static void BindMaskableInterval(this UnityEngine.UI.Image obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskable = transform());
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindTextComponent(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Text> property)
            => Bindings2._scope.Bind(property, v => obj.textComponent = v);
        public static void BindTextComponent<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Text> transform)
            => Bindings2._scope.Bind(property, v => obj.textComponent = transform(v));
        public static void BindTextComponent(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.textComponent = transform());
        public static void BindTextComponentInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textComponent = transform());
        public static void BindText<T>(this UnityEngine.UI.InputField obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this UnityEngine.UI.InputField obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this UnityEngine.UI.InputField obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindCharacterLimit(this UnityEngine.UI.InputField obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.characterLimit = v);
        public static void BindCharacterLimit<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.characterLimit = transform(v));
        public static void BindCharacterLimit(this UnityEngine.UI.InputField obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.characterLimit = transform());
        public static void BindCharacterLimitInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.characterLimit = transform());
        public static void BindContentType(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.InputField.ContentType> property)
            => Bindings2._scope.Bind(property, v => obj.contentType = v);
        public static void BindContentType<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.InputField.ContentType> transform)
            => Bindings2._scope.Bind(property, v => obj.contentType = transform(v));
        public static void BindContentType(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.InputField.ContentType> transform)
            => Bindings2._scope.BindUpdate(() => obj.contentType = transform());
        public static void BindContentTypeInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.InputField.ContentType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.contentType = transform());
        public static void BindLineType(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.InputField.LineType> property)
            => Bindings2._scope.Bind(property, v => obj.lineType = v);
        public static void BindLineType<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.InputField.LineType> transform)
            => Bindings2._scope.Bind(property, v => obj.lineType = transform(v));
        public static void BindLineType(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.InputField.LineType> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineType = transform());
        public static void BindLineTypeInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.InputField.LineType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineType = transform());
        public static void BindPlaceholder(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.placeholder = transform(v));
        public static void BindPlaceholder(this UnityEngine.UI.InputField obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.placeholder = transform());
        public static void BindPlaceholderInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.placeholder = transform());
        public static void BindCaretBlinkRate(this UnityEngine.UI.InputField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.caretBlinkRate = v);
        public static void BindCaretBlinkRate<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.caretBlinkRate = transform(v));
        public static void BindCaretBlinkRate(this UnityEngine.UI.InputField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.caretBlinkRate = transform());
        public static void BindCaretBlinkRateInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.caretBlinkRate = transform());
        public static void BindCaretWidth(this UnityEngine.UI.InputField obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.caretWidth = v);
        public static void BindCaretWidth<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.caretWidth = transform(v));
        public static void BindCaretWidth(this UnityEngine.UI.InputField obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.caretWidth = transform());
        public static void BindCaretWidthInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.caretWidth = transform());
        public static void BindCustomCaretColor(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.customCaretColor = v);
        public static void BindCustomCaretColor<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.customCaretColor = transform(v));
        public static void BindCustomCaretColor(this UnityEngine.UI.InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.customCaretColor = transform());
        public static void BindCustomCaretColorInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.customCaretColor = transform());
        public static void BindSelectionColor(this UnityEngine.UI.InputField obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.selectionColor = v);
        public static void BindSelectionColor<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.selectionColor = transform(v));
        public static void BindSelectionColor(this UnityEngine.UI.InputField obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.selectionColor = transform());
        public static void BindSelectionColorInterval(this UnityEngine.UI.InputField obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.selectionColor = transform());
        public static void BindShouldHideMobileInput(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.shouldHideMobileInput = v);
        public static void BindShouldHideMobileInput<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.shouldHideMobileInput = transform(v));
        public static void BindShouldHideMobileInput(this UnityEngine.UI.InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.shouldHideMobileInput = transform());
        public static void BindShouldHideMobileInputInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shouldHideMobileInput = transform());
        public static void BindReadOnly(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.readOnly = v);
        public static void BindReadOnly<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.readOnly = transform(v));
        public static void BindReadOnly(this UnityEngine.UI.InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.readOnly = transform());
        public static void BindReadOnlyInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.readOnly = transform());
        #if UNITY_2020_3_OR_NEWER
        public static void BindShouldActivateOnSelect(this UnityEngine.UI.InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.shouldActivateOnSelect = v);
        public static void BindShouldActivateOnSelect<T>(this UnityEngine.UI.InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.shouldActivateOnSelect = transform(v));
        public static void BindShouldActivateOnSelect(this UnityEngine.UI.InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.shouldActivateOnSelect = transform());
        public static void BindShouldActivateOnSelectInterval(this UnityEngine.UI.InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shouldActivateOnSelect = transform());
        #endif
        #endif


        #if UNITY_GUI
        public static void BindIgnoreLayout(this UnityEngine.UI.LayoutElement obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.ignoreLayout = v);
        public static void BindIgnoreLayout<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.ignoreLayout = transform(v));
        public static void BindIgnoreLayout(this UnityEngine.UI.LayoutElement obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.ignoreLayout = transform());
        public static void BindIgnoreLayoutInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.ignoreLayout = transform());
        public static void BindMinWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minWidth = v);
        public static void BindMinWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minWidth = transform(v));
        public static void BindMinWidth(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minWidth = transform());
        public static void BindMinWidthInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minWidth = transform());
        public static void BindMinHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minHeight = v);
        public static void BindMinHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minHeight = transform(v));
        public static void BindMinHeight(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minHeight = transform());
        public static void BindMinHeightInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minHeight = transform());
        public static void BindPreferredWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.preferredWidth = v);
        public static void BindPreferredWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.preferredWidth = transform(v));
        public static void BindPreferredWidth(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.preferredWidth = transform());
        public static void BindPreferredWidthInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.preferredWidth = transform());
        public static void BindPreferredHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.preferredHeight = v);
        public static void BindPreferredHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.preferredHeight = transform(v));
        public static void BindPreferredHeight(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.preferredHeight = transform());
        public static void BindPreferredHeightInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.preferredHeight = transform());
        public static void BindFlexibleWidth(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.flexibleWidth = v);
        public static void BindFlexibleWidth<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.flexibleWidth = transform(v));
        public static void BindFlexibleWidth(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.flexibleWidth = transform());
        public static void BindFlexibleWidthInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flexibleWidth = transform());
        public static void BindFlexibleHeight(this UnityEngine.UI.LayoutElement obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.flexibleHeight = v);
        public static void BindFlexibleHeight<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.flexibleHeight = transform(v));
        public static void BindFlexibleHeight(this UnityEngine.UI.LayoutElement obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.flexibleHeight = transform());
        public static void BindFlexibleHeightInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flexibleHeight = transform());
        public static void BindLayoutPriority(this UnityEngine.UI.LayoutElement obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.layoutPriority = v);
        public static void BindLayoutPriority<T>(this UnityEngine.UI.LayoutElement obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.layoutPriority = transform(v));
        public static void BindLayoutPriority(this UnityEngine.UI.LayoutElement obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.layoutPriority = transform());
        public static void BindLayoutPriorityInterval(this UnityEngine.UI.LayoutElement obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.layoutPriority = transform());
        #endif


        public static void BindFlare(this LensFlare obj, IProperty<UnityEngine.Flare> property)
            => Bindings2._scope.Bind(property, v => obj.flare = v);
        public static void BindFlare<T>(this LensFlare obj, IProperty<T> property, Func<T, UnityEngine.Flare> transform)
            => Bindings2._scope.Bind(property, v => obj.flare = transform(v));
        public static void BindFlare(this LensFlare obj, Func<UnityEngine.Flare> transform)
            => Bindings2._scope.BindUpdate(() => obj.flare = transform());
        public static void BindFlareInterval(this LensFlare obj, float seconds, Func<UnityEngine.Flare> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flare = transform());
        public static void BindColor(this LensFlare obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this LensFlare obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this LensFlare obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this LensFlare obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindBrightness(this LensFlare obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.brightness = v);
        public static void BindBrightness<T>(this LensFlare obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.brightness = transform(v));
        public static void BindBrightness(this LensFlare obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.brightness = transform());
        public static void BindBrightnessInterval(this LensFlare obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.brightness = transform());
        public static void BindFadeSpeed(this LensFlare obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fadeSpeed = v);
        public static void BindFadeSpeed<T>(this LensFlare obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fadeSpeed = transform(v));
        public static void BindFadeSpeed(this LensFlare obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fadeSpeed = transform());
        public static void BindFadeSpeedInterval(this LensFlare obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fadeSpeed = transform());


        public static void BindType(this Light obj, IProperty<UnityEngine.LightType> property)
            => Bindings2._scope.Bind(property, v => obj.type = v);
        public static void BindType<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightType> transform)
            => Bindings2._scope.Bind(property, v => obj.type = transform(v));
        public static void BindType(this Light obj, Func<UnityEngine.LightType> transform)
            => Bindings2._scope.BindUpdate(() => obj.type = transform());
        public static void BindTypeInterval(this Light obj, float seconds, Func<UnityEngine.LightType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.type = transform());
        public static void BindRange(this Light obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.range = v);
        public static void BindRange<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.range = transform(v));
        public static void BindRange(this Light obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.range = transform());
        public static void BindRangeInterval(this Light obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.range = transform());
        public static void BindSpotAngle(this Light obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spotAngle = v);
        public static void BindSpotAngle<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spotAngle = transform(v));
        public static void BindSpotAngle(this Light obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spotAngle = transform());
        public static void BindSpotAngleInterval(this Light obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spotAngle = transform());
        public static void BindColor(this Light obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this Light obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this Light obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindIntensity(this Light obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.intensity = v);
        public static void BindIntensity<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.intensity = transform(v));
        public static void BindIntensity(this Light obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.intensity = transform());
        public static void BindIntensityInterval(this Light obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.intensity = transform());
        public static void BindBounceIntensity(this Light obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.bounceIntensity = v);
        public static void BindBounceIntensity<T>(this Light obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.bounceIntensity = transform(v));
        public static void BindBounceIntensity(this Light obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.bounceIntensity = transform());
        public static void BindBounceIntensityInterval(this Light obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bounceIntensity = transform());
        public static void BindShadows(this Light obj, IProperty<UnityEngine.LightShadows> property)
            => Bindings2._scope.Bind(property, v => obj.shadows = v);
        public static void BindShadows<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightShadows> transform)
            => Bindings2._scope.Bind(property, v => obj.shadows = transform(v));
        public static void BindShadows(this Light obj, Func<UnityEngine.LightShadows> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadows = transform());
        public static void BindShadowsInterval(this Light obj, float seconds, Func<UnityEngine.LightShadows> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadows = transform());
        public static void BindCookie(this Light obj, IProperty<UnityEngine.Texture> property)
            => Bindings2._scope.Bind(property, v => obj.cookie = v);
        public static void BindCookie<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Texture> transform)
            => Bindings2._scope.Bind(property, v => obj.cookie = transform(v));
        public static void BindCookie(this Light obj, Func<UnityEngine.Texture> transform)
            => Bindings2._scope.BindUpdate(() => obj.cookie = transform());
        public static void BindCookieInterval(this Light obj, float seconds, Func<UnityEngine.Texture> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cookie = transform());
        public static void BindFlare(this Light obj, IProperty<UnityEngine.Flare> property)
            => Bindings2._scope.Bind(property, v => obj.flare = v);
        public static void BindFlare<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.Flare> transform)
            => Bindings2._scope.Bind(property, v => obj.flare = transform(v));
        public static void BindFlare(this Light obj, Func<UnityEngine.Flare> transform)
            => Bindings2._scope.BindUpdate(() => obj.flare = transform());
        public static void BindFlareInterval(this Light obj, float seconds, Func<UnityEngine.Flare> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flare = transform());
        public static void BindRenderMode(this Light obj, IProperty<UnityEngine.LightRenderMode> property)
            => Bindings2._scope.Bind(property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this Light obj, IProperty<T> property, Func<T, UnityEngine.LightRenderMode> transform)
            => Bindings2._scope.Bind(property, v => obj.renderMode = transform(v));
        public static void BindRenderMode(this Light obj, Func<UnityEngine.LightRenderMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.renderMode = transform());
        public static void BindRenderModeInterval(this Light obj, float seconds, Func<UnityEngine.LightRenderMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.renderMode = transform());
        public static void BindCullingMask(this Light obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this Light obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = transform(v));
        public static void BindCullingMask(this Light obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullingMask = transform());
        public static void BindCullingMaskInterval(this Light obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullingMask = transform());


        public static void BindRefreshMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.RefreshMode> property)
            => Bindings2._scope.Bind(property, v => obj.refreshMode = v);
        public static void BindRefreshMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.RefreshMode> transform)
            => Bindings2._scope.Bind(property, v => obj.refreshMode = transform(v));
        public static void BindRefreshMode(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.RefreshMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.refreshMode = transform());
        public static void BindRefreshModeInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.RefreshMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.refreshMode = transform());
        public static void BindQualityMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.QualityMode> property)
            => Bindings2._scope.Bind(property, v => obj.qualityMode = v);
        public static void BindQualityMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.QualityMode> transform)
            => Bindings2._scope.Bind(property, v => obj.qualityMode = transform(v));
        public static void BindQualityMode(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.QualityMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.qualityMode = transform());
        public static void BindQualityModeInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.QualityMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.qualityMode = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindDataFormat(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.DataFormat> property)
            => Bindings2._scope.Bind(property, v => obj.dataFormat = v);
        public static void BindDataFormat<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.DataFormat> transform)
            => Bindings2._scope.Bind(property, v => obj.dataFormat = transform(v));
        public static void BindDataFormat(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.DataFormat> transform)
            => Bindings2._scope.BindUpdate(() => obj.dataFormat = transform());
        public static void BindDataFormatInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.DataFormat> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dataFormat = transform());
        #endif
        public static void BindBoundingBoxMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.BoundingBoxMode> property)
            => Bindings2._scope.Bind(property, v => obj.boundingBoxMode = v);
        public static void BindBoundingBoxMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.BoundingBoxMode> transform)
            => Bindings2._scope.Bind(property, v => obj.boundingBoxMode = transform(v));
        public static void BindBoundingBoxMode(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.BoundingBoxMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.boundingBoxMode = transform());
        public static void BindBoundingBoxModeInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.BoundingBoxMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.boundingBoxMode = transform());
        public static void BindResolutionMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.ResolutionMode> property)
            => Bindings2._scope.Bind(property, v => obj.resolutionMode = v);
        public static void BindResolutionMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.ResolutionMode> transform)
            => Bindings2._scope.Bind(property, v => obj.resolutionMode = transform(v));
        public static void BindResolutionMode(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.ResolutionMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.resolutionMode = transform());
        public static void BindResolutionModeInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.ResolutionMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.resolutionMode = transform());
        public static void BindProbeDensity(this LightProbeProxyVolume obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.probeDensity = v);
        public static void BindProbeDensity<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.probeDensity = transform(v));
        public static void BindProbeDensity(this LightProbeProxyVolume obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.probeDensity = transform());
        public static void BindProbeDensityInterval(this LightProbeProxyVolume obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.probeDensity = transform());
        public static void BindProbePositionMode(this LightProbeProxyVolume obj, IProperty<UnityEngine.LightProbeProxyVolume.ProbePositionMode> property)
            => Bindings2._scope.Bind(property, v => obj.probePositionMode = v);
        public static void BindProbePositionMode<T>(this LightProbeProxyVolume obj, IProperty<T> property, Func<T, UnityEngine.LightProbeProxyVolume.ProbePositionMode> transform)
            => Bindings2._scope.Bind(property, v => obj.probePositionMode = transform(v));
        public static void BindProbePositionMode(this LightProbeProxyVolume obj, Func<UnityEngine.LightProbeProxyVolume.ProbePositionMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.probePositionMode = transform());
        public static void BindProbePositionModeInterval(this LightProbeProxyVolume obj, float seconds, Func<UnityEngine.LightProbeProxyVolume.ProbePositionMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.probePositionMode = transform());


        public static void BindLoop(this LineRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.loop = v);
        public static void BindLoop<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.loop = transform(v));
        public static void BindLoop(this LineRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.loop = transform());
        public static void BindLoopInterval(this LineRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.loop = transform());
        public static void BindStartColor(this LineRenderer obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.startColor = v);
        public static void BindStartColor<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.startColor = transform(v));
        public static void BindStartColor(this LineRenderer obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.startColor = transform());
        public static void BindStartColorInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.startColor = transform());
        public static void BindEndColor(this LineRenderer obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.endColor = v);
        public static void BindEndColor<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.endColor = transform(v));
        public static void BindEndColor(this LineRenderer obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.endColor = transform());
        public static void BindEndColorInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.endColor = transform());
        public static void BindNumCornerVertices(this LineRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.numCornerVertices = v);
        public static void BindNumCornerVertices<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.numCornerVertices = transform(v));
        public static void BindNumCornerVertices(this LineRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.numCornerVertices = transform());
        public static void BindNumCornerVerticesInterval(this LineRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.numCornerVertices = transform());
        public static void BindNumCapVertices(this LineRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.numCapVertices = v);
        public static void BindNumCapVertices<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.numCapVertices = transform(v));
        public static void BindNumCapVertices(this LineRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.numCapVertices = transform());
        public static void BindNumCapVerticesInterval(this LineRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.numCapVertices = transform());
        public static void BindAlignment(this LineRenderer obj, IProperty<UnityEngine.LineAlignment> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineAlignment> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this LineRenderer obj, Func<UnityEngine.LineAlignment> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this LineRenderer obj, float seconds, Func<UnityEngine.LineAlignment> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        public static void BindTextureMode(this LineRenderer obj, IProperty<UnityEngine.LineTextureMode> property)
            => Bindings2._scope.Bind(property, v => obj.textureMode = v);
        public static void BindTextureMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.Bind(property, v => obj.textureMode = transform(v));
        public static void BindTextureMode(this LineRenderer obj, Func<UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.textureMode = transform());
        public static void BindTextureModeInterval(this LineRenderer obj, float seconds, Func<UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textureMode = transform());
        public static void BindShadowBias(this LineRenderer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.shadowBias = v);
        public static void BindShadowBias<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowBias = transform(v));
        public static void BindShadowBias(this LineRenderer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowBias = transform());
        public static void BindShadowBiasInterval(this LineRenderer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowBias = transform());
        public static void BindGenerateLightingData(this LineRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.generateLightingData = v);
        public static void BindGenerateLightingData<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.generateLightingData = transform(v));
        public static void BindGenerateLightingData(this LineRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.generateLightingData = transform());
        public static void BindGenerateLightingDataInterval(this LineRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.generateLightingData = transform());
        public static void BindUseWorldSpace(this LineRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useWorldSpace = v);
        public static void BindUseWorldSpace<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useWorldSpace = transform(v));
        public static void BindUseWorldSpace(this LineRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useWorldSpace = transform());
        public static void BindUseWorldSpaceInterval(this LineRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useWorldSpace = transform());
        public static void BindSharedMaterials(this LineRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this LineRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindShadowCastingMode(this LineRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = transform(v));
        public static void BindShadowCastingMode(this LineRenderer obj, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowCastingMode = transform());
        public static void BindShadowCastingModeInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowCastingMode = transform());
        public static void BindReceiveShadows(this LineRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = transform(v));
        public static void BindReceiveShadows(this LineRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.receiveShadows = transform());
        public static void BindReceiveShadowsInterval(this LineRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.receiveShadows = transform());
        public static void BindLightProbeUsage(this LineRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = transform(v));
        public static void BindLightProbeUsage(this LineRenderer obj, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.lightProbeUsage = transform());
        public static void BindLightProbeUsageInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lightProbeUsage = transform());
        public static void BindReflectionProbeUsage(this LineRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this LineRenderer obj, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionProbeUsage = transform());
        public static void BindReflectionProbeUsageInterval(this LineRenderer obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionProbeUsage = transform());
        public static void BindMotionVectorGenerationMode(this LineRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this LineRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindMotionVectorGenerationMode(this LineRenderer obj, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.motionVectorGenerationMode = transform());
        public static void BindMotionVectorGenerationModeInterval(this LineRenderer obj, float seconds, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motionVectorGenerationMode = transform());
        public static void BindAllowOcclusionWhenDynamic(this LineRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this LineRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowOcclusionWhenDynamic = transform());
        public static void BindAllowOcclusionWhenDynamicInterval(this LineRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowOcclusionWhenDynamic = transform());
        public static void BindSortingLayerID(this LineRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this LineRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this LineRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this LineRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this LineRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this LineRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this LineRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.LookAtConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.LookAtConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindUseUpObject(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useUpObject = v);
        public static void BindUseUpObject<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useUpObject = transform(v));
        public static void BindUseUpObject(this UnityEngine.Animations.LookAtConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useUpObject = transform());
        public static void BindUseUpObjectInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useUpObject = transform());
        public static void BindRoll(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.roll = v);
        public static void BindRoll<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.roll = transform(v));
        public static void BindRoll(this UnityEngine.Animations.LookAtConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.roll = transform());
        public static void BindRollInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.roll = transform());
        public static void BindWorldUpObject(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.worldUpObject = v);
        public static void BindWorldUpObject<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.worldUpObject = transform(v));
        public static void BindWorldUpObject(this UnityEngine.Animations.LookAtConstraint obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.worldUpObject = transform());
        public static void BindWorldUpObjectInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.worldUpObject = transform());
        public static void BindLocked(this UnityEngine.Animations.LookAtConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.LookAtConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindRotationAtRest(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.LookAtConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = transform());
        public static void BindRotationAtRestInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAtRest = transform());
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.LookAtConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.LookAtConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.LookAtConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.LookAtConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.LookAtConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.LookAtConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationAtRest(obj, obj.rotationAtRest, end, curve);
        public static void BindRotationOffset(this UnityEngine.Animations.LookAtConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.LookAtConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.LookAtConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = transform());
        public static void BindRotationOffsetInterval(this UnityEngine.Animations.LookAtConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationOffset = transform());
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.LookAtConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.LookAtConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.LookAtConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.LookAtConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationOffset(this UnityEngine.Animations.LookAtConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationOffset = Vector3.Lerp(start, end, t));
        public static void AnimateRotationOffset(this UnityEngine.Animations.LookAtConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationOffset(obj, obj.rotationOffset, end, curve);
        #endif


        #if UNITY_GUI
        public static void BindShowMaskGraphic(this UnityEngine.UI.Mask obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.showMaskGraphic = v);
        public static void BindShowMaskGraphic<T>(this UnityEngine.UI.Mask obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.showMaskGraphic = transform(v));
        public static void BindShowMaskGraphic(this UnityEngine.UI.Mask obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.showMaskGraphic = transform());
        public static void BindShowMaskGraphicInterval(this UnityEngine.UI.Mask obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.showMaskGraphic = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindConvex(this MeshCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.convex = v);
        public static void BindConvex<T>(this MeshCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.convex = transform(v));
        public static void BindConvex(this MeshCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.convex = transform());
        public static void BindConvexInterval(this MeshCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.convex = transform());
        public static void BindIsTrigger(this MeshCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this MeshCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this MeshCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this MeshCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindCookingOptions(this MeshCollider obj, IProperty<UnityEngine.MeshColliderCookingOptions> property)
            => Bindings2._scope.Bind(property, v => obj.cookingOptions = v);
        public static void BindCookingOptions<T>(this MeshCollider obj, IProperty<T> property, Func<T, UnityEngine.MeshColliderCookingOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.cookingOptions = transform(v));
        public static void BindCookingOptions(this MeshCollider obj, Func<UnityEngine.MeshColliderCookingOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.cookingOptions = transform());
        public static void BindCookingOptionsInterval(this MeshCollider obj, float seconds, Func<UnityEngine.MeshColliderCookingOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cookingOptions = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this MeshCollider obj, IProperty<PhysicMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this MeshCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this MeshCollider obj, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this MeshCollider obj, float seconds, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this MeshCollider obj, IProperty<PhysicsMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this MeshCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this MeshCollider obj, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this MeshCollider obj, float seconds, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        public static void BindSharedMesh(this MeshCollider obj, IProperty<UnityEngine.Mesh> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this MeshCollider obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = transform(v));
        public static void BindSharedMesh(this MeshCollider obj, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMesh = transform());
        public static void BindSharedMeshInterval(this MeshCollider obj, float seconds, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMesh = transform());
        #endif


        public static void BindSharedMesh(this MeshFilter obj, IProperty<UnityEngine.Mesh> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this MeshFilter obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = transform(v));
        public static void BindSharedMesh(this MeshFilter obj, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMesh = transform());
        public static void BindSharedMeshInterval(this MeshFilter obj, float seconds, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMesh = transform());


        public static void BindSharedMaterials(this MeshRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this MeshRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindShadowCastingMode(this MeshRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = transform(v));
        public static void BindShadowCastingMode(this MeshRenderer obj, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowCastingMode = transform());
        public static void BindShadowCastingModeInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowCastingMode = transform());
        public static void BindReceiveShadows(this MeshRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this MeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = transform(v));
        public static void BindReceiveShadows(this MeshRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.receiveShadows = transform());
        public static void BindReceiveShadowsInterval(this MeshRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.receiveShadows = transform());
        public static void BindLightProbeUsage(this MeshRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = transform(v));
        public static void BindLightProbeUsage(this MeshRenderer obj, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.lightProbeUsage = transform());
        public static void BindLightProbeUsageInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lightProbeUsage = transform());
        public static void BindReflectionProbeUsage(this MeshRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this MeshRenderer obj, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionProbeUsage = transform());
        public static void BindReflectionProbeUsageInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionProbeUsage = transform());
        public static void BindProbeAnchor(this MeshRenderer obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.probeAnchor = v);
        public static void BindProbeAnchor<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.probeAnchor = transform(v));
        public static void BindProbeAnchor(this MeshRenderer obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.probeAnchor = transform());
        public static void BindProbeAnchorInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.probeAnchor = transform());
        public static void BindMotionVectorGenerationMode(this MeshRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this MeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindMotionVectorGenerationMode(this MeshRenderer obj, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.motionVectorGenerationMode = transform());
        public static void BindMotionVectorGenerationModeInterval(this MeshRenderer obj, float seconds, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motionVectorGenerationMode = transform());
        public static void BindAllowOcclusionWhenDynamic(this MeshRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this MeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this MeshRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowOcclusionWhenDynamic = transform());
        public static void BindAllowOcclusionWhenDynamicInterval(this MeshRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowOcclusionWhenDynamic = transform());


        #if UNITY_AI
        public static void BindAgentTypeID(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.agentTypeID = v);
        public static void BindAgentTypeID<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.agentTypeID = transform(v));
        public static void BindAgentTypeID(this UnityEngine.AI.NavMeshAgent obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.agentTypeID = transform());
        public static void BindAgentTypeIDInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.agentTypeID = transform());
        public static void BindBaseOffset(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.baseOffset = v);
        public static void BindBaseOffset<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.baseOffset = transform(v));
        public static void BindBaseOffset(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.baseOffset = transform());
        public static void BindBaseOffsetInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.baseOffset = transform());
        public static void BindSpeed(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.speed = v);
        public static void BindSpeed<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.speed = transform(v));
        public static void BindSpeed(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.speed = transform());
        public static void BindSpeedInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.speed = transform());
        public static void BindAngularSpeed(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularSpeed = v);
        public static void BindAngularSpeed<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularSpeed = transform(v));
        public static void BindAngularSpeed(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularSpeed = transform());
        public static void BindAngularSpeedInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularSpeed = transform());
        public static void BindAcceleration(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.acceleration = v);
        public static void BindAcceleration<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.acceleration = transform(v));
        public static void BindAcceleration(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.acceleration = transform());
        public static void BindAccelerationInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.acceleration = transform());
        public static void BindStoppingDistance(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.stoppingDistance = v);
        public static void BindStoppingDistance<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.stoppingDistance = transform(v));
        public static void BindStoppingDistance(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.stoppingDistance = transform());
        public static void BindStoppingDistanceInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.stoppingDistance = transform());
        public static void BindAutoBraking(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoBraking = v);
        public static void BindAutoBraking<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoBraking = transform(v));
        public static void BindAutoBraking(this UnityEngine.AI.NavMeshAgent obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoBraking = transform());
        public static void BindAutoBrakingInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoBraking = transform());
        public static void BindRadius(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        public static void BindHeight(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.height = v);
        public static void BindHeight<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.height = transform(v));
        public static void BindHeight(this UnityEngine.AI.NavMeshAgent obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.height = transform());
        public static void BindHeightInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.height = transform());
        public static void BindObstacleAvoidanceType(this UnityEngine.AI.NavMeshAgent obj, IProperty<UnityEngine.AI.ObstacleAvoidanceType> property)
            => Bindings2._scope.Bind(property, v => obj.obstacleAvoidanceType = v);
        public static void BindObstacleAvoidanceType<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, UnityEngine.AI.ObstacleAvoidanceType> transform)
            => Bindings2._scope.Bind(property, v => obj.obstacleAvoidanceType = transform(v));
        public static void BindObstacleAvoidanceType(this UnityEngine.AI.NavMeshAgent obj, Func<UnityEngine.AI.ObstacleAvoidanceType> transform)
            => Bindings2._scope.BindUpdate(() => obj.obstacleAvoidanceType = transform());
        public static void BindObstacleAvoidanceTypeInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<UnityEngine.AI.ObstacleAvoidanceType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.obstacleAvoidanceType = transform());
        public static void BindAvoidancePriority(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.avoidancePriority = v);
        public static void BindAvoidancePriority<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.avoidancePriority = transform(v));
        public static void BindAvoidancePriority(this UnityEngine.AI.NavMeshAgent obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.avoidancePriority = transform());
        public static void BindAvoidancePriorityInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.avoidancePriority = transform());
        public static void BindAutoTraverseOffMeshLink(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoTraverseOffMeshLink = v);
        public static void BindAutoTraverseOffMeshLink<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoTraverseOffMeshLink = transform(v));
        public static void BindAutoTraverseOffMeshLink(this UnityEngine.AI.NavMeshAgent obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoTraverseOffMeshLink = transform());
        public static void BindAutoTraverseOffMeshLinkInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoTraverseOffMeshLink = transform());
        public static void BindAutoRepath(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoRepath = v);
        public static void BindAutoRepath<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoRepath = transform(v));
        public static void BindAutoRepath(this UnityEngine.AI.NavMeshAgent obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoRepath = transform());
        public static void BindAutoRepathInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoRepath = transform());
        public static void BindAreaMask(this UnityEngine.AI.NavMeshAgent obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.areaMask = v);
        public static void BindAreaMask<T>(this UnityEngine.AI.NavMeshAgent obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.areaMask = transform(v));
        public static void BindAreaMask(this UnityEngine.AI.NavMeshAgent obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.areaMask = transform());
        public static void BindAreaMaskInterval(this UnityEngine.AI.NavMeshAgent obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.areaMask = transform());
        #endif


        #if UNITY_AI
        public static void BindShape(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.AI.NavMeshObstacleShape> property)
            => Bindings2._scope.Bind(property, v => obj.shape = v);
        public static void BindShape<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.AI.NavMeshObstacleShape> transform)
            => Bindings2._scope.Bind(property, v => obj.shape = transform(v));
        public static void BindShape(this UnityEngine.AI.NavMeshObstacle obj, Func<UnityEngine.AI.NavMeshObstacleShape> transform)
            => Bindings2._scope.BindUpdate(() => obj.shape = transform());
        public static void BindShapeInterval(this UnityEngine.AI.NavMeshObstacle obj, float seconds, Func<UnityEngine.AI.NavMeshObstacleShape> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shape = transform());
        public static void BindCenter(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this UnityEngine.AI.NavMeshObstacle obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this UnityEngine.AI.NavMeshObstacle obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this UnityEngine.AI.NavMeshObstacle obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this UnityEngine.AI.NavMeshObstacle obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this UnityEngine.AI.NavMeshObstacle obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this UnityEngine.AI.NavMeshObstacle obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this UnityEngine.AI.NavMeshObstacle obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this UnityEngine.AI.NavMeshObstacle obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindSize(this UnityEngine.AI.NavMeshObstacle obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this UnityEngine.AI.NavMeshObstacle obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this UnityEngine.AI.NavMeshObstacle obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindSizeLerp(this UnityEngine.AI.NavMeshObstacle obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeLerp(this UnityEngine.AI.NavMeshObstacle obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this UnityEngine.AI.NavMeshObstacle obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this UnityEngine.AI.NavMeshObstacle obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateSize(this UnityEngine.AI.NavMeshObstacle obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.size = Vector3.Lerp(start, end, t));
        public static void AnimateSize(this UnityEngine.AI.NavMeshObstacle obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateSize(obj, obj.size, end, curve);
        public static void BindCarving(this UnityEngine.AI.NavMeshObstacle obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.carving = v);
        public static void BindCarving<T>(this UnityEngine.AI.NavMeshObstacle obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.carving = transform(v));
        public static void BindCarving(this UnityEngine.AI.NavMeshObstacle obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.carving = transform());
        public static void BindCarvingInterval(this UnityEngine.AI.NavMeshObstacle obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.carving = transform());
        #endif


        public static void BindSize(this OcclusionArea obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this OcclusionArea obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this OcclusionArea obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this OcclusionArea obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindSizeLerp(this OcclusionArea obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeLerp(this OcclusionArea obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this OcclusionArea obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this OcclusionArea obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateSize(this OcclusionArea obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.size = Vector3.Lerp(start, end, t));
        public static void AnimateSize(this OcclusionArea obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateSize(obj, obj.size, end, curve);
        public static void BindCenter(this OcclusionArea obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this OcclusionArea obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this OcclusionArea obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this OcclusionArea obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this OcclusionArea obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this OcclusionArea obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this OcclusionArea obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this OcclusionArea obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this OcclusionArea obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this OcclusionArea obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);


        public static void BindOpen(this OcclusionPortal obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.open = v);
        public static void BindOpen<T>(this OcclusionPortal obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.open = transform(v));
        public static void BindOpen(this OcclusionPortal obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.open = transform());
        public static void BindOpenInterval(this OcclusionPortal obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.open = transform());


        #if UNITY_AI&&!UNITY_2023_2_OR_NEWER
        public static void BindStartTransform(this UnityEngine.AI.OffMeshLink obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.startTransform = v);
        public static void BindStartTransform<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.startTransform = transform(v));
        public static void BindStartTransform(this UnityEngine.AI.OffMeshLink obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.startTransform = transform());
        public static void BindStartTransformInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.startTransform = transform());
        public static void BindEndTransform(this UnityEngine.AI.OffMeshLink obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.endTransform = v);
        public static void BindEndTransform<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.endTransform = transform(v));
        public static void BindEndTransform(this UnityEngine.AI.OffMeshLink obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.endTransform = transform());
        public static void BindEndTransformInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.endTransform = transform());
        public static void BindCostOverride(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.costOverride = v);
        public static void BindCostOverride<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.costOverride = transform(v));
        public static void BindCostOverride(this UnityEngine.AI.OffMeshLink obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.costOverride = transform());
        public static void BindCostOverrideInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.costOverride = transform());
        public static void BindBiDirectional(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.biDirectional = v);
        public static void BindBiDirectional<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.biDirectional = transform(v));
        public static void BindBiDirectional(this UnityEngine.AI.OffMeshLink obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.biDirectional = transform());
        public static void BindBiDirectionalInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.biDirectional = transform());
        public static void BindActivated(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.activated = v);
        public static void BindActivated<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.activated = transform(v));
        public static void BindActivated(this UnityEngine.AI.OffMeshLink obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.activated = transform());
        public static void BindActivatedInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.activated = transform());
        public static void BindAutoUpdatePositions(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoUpdatePositions = v);
        public static void BindAutoUpdatePositions<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoUpdatePositions = transform(v));
        public static void BindAutoUpdatePositions(this UnityEngine.AI.OffMeshLink obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoUpdatePositions = transform());
        public static void BindAutoUpdatePositionsInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoUpdatePositions = transform());
        public static void BindArea(this UnityEngine.AI.OffMeshLink obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.area = v);
        public static void BindArea<T>(this UnityEngine.AI.OffMeshLink obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.area = transform(v));
        public static void BindArea(this UnityEngine.AI.OffMeshLink obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.area = transform());
        public static void BindAreaInterval(this UnityEngine.AI.OffMeshLink obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.area = transform());
        #endif


        #if UNITY_GUI
        public static void BindEffectColor(this UnityEngine.UI.Outline obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.effectColor = v);
        public static void BindEffectColor<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.effectColor = transform(v));
        public static void BindEffectColor(this UnityEngine.UI.Outline obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.effectColor = transform());
        public static void BindEffectColorInterval(this UnityEngine.UI.Outline obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.effectColor = transform());
        public static void BindEffectDistance(this UnityEngine.UI.Outline obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.effectDistance = v);
        public static void BindEffectDistance<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.effectDistance = transform(v));
        public static void BindEffectDistance(this UnityEngine.UI.Outline obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.effectDistance = transform());
        public static void BindEffectDistanceInterval(this UnityEngine.UI.Outline obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.effectDistance = transform());
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Outline obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGraphicAlpha = v);
        public static void BindUseGraphicAlpha<T>(this UnityEngine.UI.Outline obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGraphicAlpha = transform(v));
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Outline obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGraphicAlpha = transform());
        public static void BindUseGraphicAlphaInterval(this UnityEngine.UI.Outline obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGraphicAlpha = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.ParentConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.ParentConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindLocked(this UnityEngine.Animations.ParentConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.ParentConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindTranslationAtRest(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.translationAtRest = v);
        public static void BindTranslationAtRest<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.translationAtRest = transform(v));
        public static void BindTranslationAtRest(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = transform());
        public static void BindTranslationAtRestInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationAtRest = transform());
        public static void BindTranslationAtRestLerp(this UnityEngine.Animations.ParentConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.Lerp(obj.translationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestLerp(this UnityEngine.Animations.ParentConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.Lerp(obj.translationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestTowards(this UnityEngine.Animations.ParentConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.MoveTowards(obj.translationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestTowards(this UnityEngine.Animations.ParentConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.MoveTowards(obj.translationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTranslationAtRest(this UnityEngine.Animations.ParentConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.translationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateTranslationAtRest(this UnityEngine.Animations.ParentConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTranslationAtRest(obj, obj.translationAtRest, end, curve);
        public static void BindRotationAtRest(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = transform());
        public static void BindRotationAtRestInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAtRest = transform());
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.ParentConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.ParentConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.ParentConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.ParentConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.ParentConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.ParentConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationAtRest(obj, obj.rotationAtRest, end, curve);
        public static void BindTranslationOffsets(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3[]> property)
            => Bindings2._scope.Bind(property, v => obj.translationOffsets = v);
        public static void BindTranslationOffsets<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3[]> transform)
            => Bindings2._scope.Bind(property, v => obj.translationOffsets = transform(v));
        public static void BindTranslationOffsets(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Vector3[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationOffsets = transform());
        public static void BindTranslationOffsetsInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Vector3[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationOffsets = transform());
        public static void BindRotationOffsets(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Vector3[]> property)
            => Bindings2._scope.Bind(property, v => obj.rotationOffsets = v);
        public static void BindRotationOffsets<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3[]> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationOffsets = transform(v));
        public static void BindRotationOffsets(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Vector3[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffsets = transform());
        public static void BindRotationOffsetsInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Vector3[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationOffsets = transform());
        public static void BindTranslationAxis(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.translationAxis = v);
        public static void BindTranslationAxis<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.translationAxis = transform(v));
        public static void BindTranslationAxis(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAxis = transform());
        public static void BindTranslationAxisInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationAxis = transform());
        public static void BindRotationAxis(this UnityEngine.Animations.ParentConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.ParentConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.ParentConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAxis = transform());
        public static void BindRotationAxisInterval(this UnityEngine.Animations.ParentConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAxis = transform());
        #endif


        #if UNITY_PARTICLE_SYSTEM
        public static void BindShape(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystemForceFieldShape> property)
            => Bindings2._scope.Bind(property, v => obj.shape = v);
        public static void BindShape<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystemForceFieldShape> transform)
            => Bindings2._scope.Bind(property, v => obj.shape = transform(v));
        public static void BindShape(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystemForceFieldShape> transform)
            => Bindings2._scope.BindUpdate(() => obj.shape = transform());
        public static void BindShapeInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystemForceFieldShape> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shape = transform());
        public static void BindStartRange(this ParticleSystemForceField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.startRange = v);
        public static void BindStartRange<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.startRange = transform(v));
        public static void BindStartRange(this ParticleSystemForceField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.startRange = transform());
        public static void BindStartRangeInterval(this ParticleSystemForceField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.startRange = transform());
        public static void BindEndRange(this ParticleSystemForceField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.endRange = v);
        public static void BindEndRange<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.endRange = transform(v));
        public static void BindEndRange(this ParticleSystemForceField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.endRange = transform());
        public static void BindEndRangeInterval(this ParticleSystemForceField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.endRange = transform());
        public static void BindDirectionX(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.directionX = v);
        public static void BindDirectionX<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.directionX = transform(v));
        public static void BindDirectionX(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.directionX = transform());
        public static void BindDirectionXInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.directionX = transform());
        public static void BindDirectionY(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.directionY = v);
        public static void BindDirectionY<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.directionY = transform(v));
        public static void BindDirectionY(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.directionY = transform());
        public static void BindDirectionYInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.directionY = transform());
        public static void BindDirectionZ(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.directionZ = v);
        public static void BindDirectionZ<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.directionZ = transform(v));
        public static void BindDirectionZ(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.directionZ = transform());
        public static void BindDirectionZInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.directionZ = transform());
        public static void BindGravity(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.gravity = v);
        public static void BindGravity<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.gravity = transform(v));
        public static void BindGravity(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.gravity = transform());
        public static void BindGravityInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.gravity = transform());
        public static void BindGravityFocus(this ParticleSystemForceField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.gravityFocus = v);
        public static void BindGravityFocus<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.gravityFocus = transform(v));
        public static void BindGravityFocus(this ParticleSystemForceField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.gravityFocus = transform());
        public static void BindGravityFocusInterval(this ParticleSystemForceField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.gravityFocus = transform());
        public static void BindRotationSpeed(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.rotationSpeed = v);
        public static void BindRotationSpeed<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationSpeed = transform(v));
        public static void BindRotationSpeed(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationSpeed = transform());
        public static void BindRotationSpeedInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationSpeed = transform());
        public static void BindRotationAttraction(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAttraction = v);
        public static void BindRotationAttraction<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAttraction = transform(v));
        public static void BindRotationAttraction(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAttraction = transform());
        public static void BindRotationAttractionInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAttraction = transform());
        public static void BindRotationRandomness(this ParticleSystemForceField obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.rotationRandomness = v);
        public static void BindRotationRandomness<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationRandomness = transform(v));
        public static void BindRotationRandomness(this ParticleSystemForceField obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationRandomness = transform());
        public static void BindRotationRandomnessInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationRandomness = transform());
        public static void BindDrag(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.drag = v);
        public static void BindDrag<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.drag = transform(v));
        public static void BindDrag(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.drag = transform());
        public static void BindDragInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drag = transform());
        public static void BindMultiplyDragByParticleSize(this ParticleSystemForceField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.multiplyDragByParticleSize = v);
        public static void BindMultiplyDragByParticleSize<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.multiplyDragByParticleSize = transform(v));
        public static void BindMultiplyDragByParticleSize(this ParticleSystemForceField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.multiplyDragByParticleSize = transform());
        public static void BindMultiplyDragByParticleSizeInterval(this ParticleSystemForceField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.multiplyDragByParticleSize = transform());
        public static void BindMultiplyDragByParticleVelocity(this ParticleSystemForceField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.multiplyDragByParticleVelocity = v);
        public static void BindMultiplyDragByParticleVelocity<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.multiplyDragByParticleVelocity = transform(v));
        public static void BindMultiplyDragByParticleVelocity(this ParticleSystemForceField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.multiplyDragByParticleVelocity = transform());
        public static void BindMultiplyDragByParticleVelocityInterval(this ParticleSystemForceField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.multiplyDragByParticleVelocity = transform());
        public static void BindVectorField(this ParticleSystemForceField obj, IProperty<UnityEngine.Texture3D> property)
            => Bindings2._scope.Bind(property, v => obj.vectorField = v);
        public static void BindVectorField<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.Texture3D> transform)
            => Bindings2._scope.Bind(property, v => obj.vectorField = transform(v));
        public static void BindVectorField(this ParticleSystemForceField obj, Func<UnityEngine.Texture3D> transform)
            => Bindings2._scope.BindUpdate(() => obj.vectorField = transform());
        public static void BindVectorFieldInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.Texture3D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.vectorField = transform());
        public static void BindVectorFieldSpeed(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.vectorFieldSpeed = v);
        public static void BindVectorFieldSpeed<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.vectorFieldSpeed = transform(v));
        public static void BindVectorFieldSpeed(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.vectorFieldSpeed = transform());
        public static void BindVectorFieldSpeedInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.vectorFieldSpeed = transform());
        public static void BindVectorFieldAttraction(this ParticleSystemForceField obj, IProperty<UnityEngine.ParticleSystem.MinMaxCurve> property)
            => Bindings2._scope.Bind(property, v => obj.vectorFieldAttraction = v);
        public static void BindVectorFieldAttraction<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.vectorFieldAttraction = transform(v));
        public static void BindVectorFieldAttraction(this ParticleSystemForceField obj, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.vectorFieldAttraction = transform());
        public static void BindVectorFieldAttractionInterval(this ParticleSystemForceField obj, float seconds, Func<UnityEngine.ParticleSystem.MinMaxCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.vectorFieldAttraction = transform());
        #if UNITY_2021_3_OR_NEWER
        public static void BindEnabled(this ParticleSystemForceField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enabled = v);
        public static void BindEnabled<T>(this ParticleSystemForceField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enabled = transform(v));
        public static void BindEnabled(this ParticleSystemForceField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enabled = transform());
        public static void BindEnabledInterval(this ParticleSystemForceField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enabled = transform());
        #endif
        #endif


        #if UNITY_GUI
        public static void BindEventMask(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<UnityEngine.LayerMask> property)
            => Bindings2._scope.Bind(property, v => obj.eventMask = v);
        public static void BindEventMask<T>(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform)
            => Bindings2._scope.Bind(property, v => obj.eventMask = transform(v));
        public static void BindEventMask(this UnityEngine.EventSystems.Physics2DRaycaster obj, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindUpdate(() => obj.eventMask = transform());
        public static void BindEventMaskInterval(this UnityEngine.EventSystems.Physics2DRaycaster obj, float seconds, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.eventMask = transform());
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.maxRayIntersections = v);
        public static void BindMaxRayIntersections<T>(this UnityEngine.EventSystems.Physics2DRaycaster obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.maxRayIntersections = transform(v));
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.Physics2DRaycaster obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxRayIntersections = transform());
        public static void BindMaxRayIntersectionsInterval(this UnityEngine.EventSystems.Physics2DRaycaster obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxRayIntersections = transform());
        #endif


        #if UNITY_GUI
        public static void BindEventMask(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<UnityEngine.LayerMask> property)
            => Bindings2._scope.Bind(property, v => obj.eventMask = v);
        public static void BindEventMask<T>(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<T> property, Func<T, UnityEngine.LayerMask> transform)
            => Bindings2._scope.Bind(property, v => obj.eventMask = transform(v));
        public static void BindEventMask(this UnityEngine.EventSystems.PhysicsRaycaster obj, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindUpdate(() => obj.eventMask = transform());
        public static void BindEventMaskInterval(this UnityEngine.EventSystems.PhysicsRaycaster obj, float seconds, Func<UnityEngine.LayerMask> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.eventMask = transform());
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.maxRayIntersections = v);
        public static void BindMaxRayIntersections<T>(this UnityEngine.EventSystems.PhysicsRaycaster obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.maxRayIntersections = transform(v));
        public static void BindMaxRayIntersections(this UnityEngine.EventSystems.PhysicsRaycaster obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxRayIntersections = transform());
        public static void BindMaxRayIntersectionsInterval(this UnityEngine.EventSystems.PhysicsRaycaster obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxRayIntersections = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this PlatformEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = transform(v));
        public static void BindUseColliderMask(this PlatformEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useColliderMask = transform());
        public static void BindUseColliderMaskInterval(this PlatformEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useColliderMask = transform());
        public static void BindColliderMask(this PlatformEffector2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = transform(v));
        public static void BindColliderMask(this PlatformEffector2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.colliderMask = transform());
        public static void BindColliderMaskInterval(this PlatformEffector2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colliderMask = transform());
        public static void BindRotationalOffset(this PlatformEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.rotationalOffset = v);
        public static void BindRotationalOffset<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationalOffset = transform(v));
        public static void BindRotationalOffset(this PlatformEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationalOffset = transform());
        public static void BindRotationalOffsetInterval(this PlatformEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationalOffset = transform());
        public static void BindUseOneWay(this PlatformEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useOneWay = v);
        public static void BindUseOneWay<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useOneWay = transform(v));
        public static void BindUseOneWay(this PlatformEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useOneWay = transform());
        public static void BindUseOneWayInterval(this PlatformEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useOneWay = transform());
        public static void BindUseOneWayGrouping(this PlatformEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useOneWayGrouping = v);
        public static void BindUseOneWayGrouping<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useOneWayGrouping = transform(v));
        public static void BindUseOneWayGrouping(this PlatformEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useOneWayGrouping = transform());
        public static void BindUseOneWayGroupingInterval(this PlatformEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useOneWayGrouping = transform());
        public static void BindSurfaceArc(this PlatformEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.surfaceArc = v);
        public static void BindSurfaceArc<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.surfaceArc = transform(v));
        public static void BindSurfaceArc(this PlatformEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.surfaceArc = transform());
        public static void BindSurfaceArcInterval(this PlatformEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.surfaceArc = transform());
        public static void BindUseSideFriction(this PlatformEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useSideFriction = v);
        public static void BindUseSideFriction<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useSideFriction = transform(v));
        public static void BindUseSideFriction(this PlatformEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useSideFriction = transform());
        public static void BindUseSideFrictionInterval(this PlatformEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useSideFriction = transform());
        public static void BindUseSideBounce(this PlatformEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useSideBounce = v);
        public static void BindUseSideBounce<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useSideBounce = transform(v));
        public static void BindUseSideBounce(this PlatformEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useSideBounce = transform());
        public static void BindUseSideBounceInterval(this PlatformEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useSideBounce = transform());
        public static void BindSideArc(this PlatformEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.sideArc = v);
        public static void BindSideArc<T>(this PlatformEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.sideArc = transform(v));
        public static void BindSideArc(this PlatformEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.sideArc = transform());
        public static void BindSideArcInterval(this PlatformEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sideArc = transform());
        #endif


        #if UNITY_DIRECTOR
        public static void BindPlayableAsset(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.PlayableAsset> property)
            => Bindings2._scope.Bind(property, v => obj.playableAsset = v);
        public static void BindPlayableAsset<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.PlayableAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.playableAsset = transform(v));
        public static void BindPlayableAsset(this UnityEngine.Playables.PlayableDirector obj, Func<UnityEngine.Playables.PlayableAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.playableAsset = transform());
        public static void BindPlayableAssetInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<UnityEngine.Playables.PlayableAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playableAsset = transform());
        public static void BindTimeUpdateMode(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.DirectorUpdateMode> property)
            => Bindings2._scope.Bind(property, v => obj.timeUpdateMode = v);
        public static void BindTimeUpdateMode<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.DirectorUpdateMode> transform)
            => Bindings2._scope.Bind(property, v => obj.timeUpdateMode = transform(v));
        public static void BindTimeUpdateMode(this UnityEngine.Playables.PlayableDirector obj, Func<UnityEngine.Playables.DirectorUpdateMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.timeUpdateMode = transform());
        public static void BindTimeUpdateModeInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<UnityEngine.Playables.DirectorUpdateMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.timeUpdateMode = transform());
        public static void BindPlayOnAwake(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = transform(v));
        public static void BindPlayOnAwake(this UnityEngine.Playables.PlayableDirector obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.playOnAwake = transform());
        public static void BindPlayOnAwakeInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playOnAwake = transform());
        public static void BindExtrapolationMode(this UnityEngine.Playables.PlayableDirector obj, IProperty<UnityEngine.Playables.DirectorWrapMode> property)
            => Bindings2._scope.Bind(property, v => obj.extrapolationMode = v);
        public static void BindExtrapolationMode<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, UnityEngine.Playables.DirectorWrapMode> transform)
            => Bindings2._scope.Bind(property, v => obj.extrapolationMode = transform(v));
        public static void BindExtrapolationMode(this UnityEngine.Playables.PlayableDirector obj, Func<UnityEngine.Playables.DirectorWrapMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.extrapolationMode = transform());
        public static void BindExtrapolationModeInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<UnityEngine.Playables.DirectorWrapMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.extrapolationMode = transform());
        public static void BindInitialTime(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Double> property)
            => Bindings2._scope.Bind(property, v => obj.initialTime = v);
        public static void BindInitialTime<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Double> transform)
            => Bindings2._scope.Bind(property, v => obj.initialTime = transform(v));
        public static void BindInitialTime(this UnityEngine.Playables.PlayableDirector obj, Func<System.Double> transform)
            => Bindings2._scope.BindUpdate(() => obj.initialTime = transform());
        public static void BindInitialTimeInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<System.Double> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.initialTime = transform());
        public static void BindTime(this UnityEngine.Playables.PlayableDirector obj, IProperty<System.Double> property)
            => Bindings2._scope.Bind(property, v => obj.time = v);
        public static void BindTime<T>(this UnityEngine.Playables.PlayableDirector obj, IProperty<T> property, Func<T, System.Double> transform)
            => Bindings2._scope.Bind(property, v => obj.time = transform(v));
        public static void BindTime(this UnityEngine.Playables.PlayableDirector obj, Func<System.Double> transform)
            => Bindings2._scope.BindUpdate(() => obj.time = transform());
        public static void BindTimeInterval(this UnityEngine.Playables.PlayableDirector obj, float seconds, Func<System.Double> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.time = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this PointEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = transform(v));
        public static void BindUseColliderMask(this PointEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useColliderMask = transform());
        public static void BindUseColliderMaskInterval(this PointEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useColliderMask = transform());
        public static void BindColliderMask(this PointEffector2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = transform(v));
        public static void BindColliderMask(this PointEffector2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.colliderMask = transform());
        public static void BindColliderMaskInterval(this PointEffector2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colliderMask = transform());
        public static void BindForceMagnitude(this PointEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceMagnitude = v);
        public static void BindForceMagnitude<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceMagnitude = transform(v));
        public static void BindForceMagnitude(this PointEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceMagnitude = transform());
        public static void BindForceMagnitudeInterval(this PointEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceMagnitude = transform());
        public static void BindForceVariation(this PointEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceVariation = v);
        public static void BindForceVariation<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceVariation = transform(v));
        public static void BindForceVariation(this PointEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceVariation = transform());
        public static void BindForceVariationInterval(this PointEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceVariation = transform());
        public static void BindDistanceScale(this PointEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.distanceScale = v);
        public static void BindDistanceScale<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.distanceScale = transform(v));
        public static void BindDistanceScale(this PointEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.distanceScale = transform());
        public static void BindDistanceScaleInterval(this PointEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.distanceScale = transform());
        public static void BindForceSource(this PointEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property)
            => Bindings2._scope.Bind(property, v => obj.forceSource = v);
        public static void BindForceSource<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.Bind(property, v => obj.forceSource = transform(v));
        public static void BindForceSource(this PointEffector2D obj, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceSource = transform());
        public static void BindForceSourceInterval(this PointEffector2D obj, float seconds, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceSource = transform());
        public static void BindForceTarget(this PointEffector2D obj, IProperty<UnityEngine.EffectorSelection2D> property)
            => Bindings2._scope.Bind(property, v => obj.forceTarget = v);
        public static void BindForceTarget<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.Bind(property, v => obj.forceTarget = transform(v));
        public static void BindForceTarget(this PointEffector2D obj, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceTarget = transform());
        public static void BindForceTargetInterval(this PointEffector2D obj, float seconds, Func<UnityEngine.EffectorSelection2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceTarget = transform());
        public static void BindForceMode(this PointEffector2D obj, IProperty<UnityEngine.EffectorForceMode2D> property)
            => Bindings2._scope.Bind(property, v => obj.forceMode = v);
        public static void BindForceMode<T>(this PointEffector2D obj, IProperty<T> property, Func<T, UnityEngine.EffectorForceMode2D> transform)
            => Bindings2._scope.Bind(property, v => obj.forceMode = transform(v));
        public static void BindForceMode(this PointEffector2D obj, Func<UnityEngine.EffectorForceMode2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceMode = transform());
        public static void BindForceModeInterval(this PointEffector2D obj, float seconds, Func<UnityEngine.EffectorForceMode2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceMode = transform());
        #if !UNITY_6000_1_OR_NEWER
        public static void BindDrag(this PointEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.drag = v);
        public static void BindDrag<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.drag = transform(v));
        public static void BindDrag(this PointEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.drag = transform());
        public static void BindDragInterval(this PointEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drag = transform());
        #endif
        #if !UNITY_6000_1_OR_NEWER
        public static void BindAngularDrag(this PointEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this PointEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = transform(v));
        public static void BindAngularDrag(this PointEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDrag = transform());
        public static void BindAngularDragInterval(this PointEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDrag = transform());
        #endif
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindSharedMaterial(this PolygonCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this PolygonCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this PolygonCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this PolygonCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this PolygonCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this PolygonCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this PolygonCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this PolygonCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this PolygonCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this PolygonCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this PolygonCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this PolygonCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this PolygonCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this PolygonCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this PolygonCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindAutoTiling(this PolygonCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoTiling = v);
        public static void BindAutoTiling<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoTiling = transform(v));
        public static void BindAutoTiling(this PolygonCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoTiling = transform());
        public static void BindAutoTilingInterval(this PolygonCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoTiling = transform());
        public static void BindOffset(this PolygonCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this PolygonCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this PolygonCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        public static void BindPathCount(this PolygonCollider2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.pathCount = v);
        public static void BindPathCount<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.pathCount = transform(v));
        public static void BindPathCount(this PolygonCollider2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.pathCount = transform());
        public static void BindPathCountInterval(this PolygonCollider2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.pathCount = transform());
        public static void BindPoints(this PolygonCollider2D obj, IProperty<UnityEngine.Vector2[]> property)
            => Bindings2._scope.Bind(property, v => obj.points = v);
        public static void BindPoints<T>(this PolygonCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2[]> transform)
            => Bindings2._scope.Bind(property, v => obj.points = transform(v));
        public static void BindPoints(this PolygonCollider2D obj, Func<UnityEngine.Vector2[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.points = transform());
        public static void BindPointsInterval(this PolygonCollider2D obj, float seconds, Func<UnityEngine.Vector2[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.points = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.PositionConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.PositionConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindLocked(this UnityEngine.Animations.PositionConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.PositionConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindTranslationAtRest(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.translationAtRest = v);
        public static void BindTranslationAtRest<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.translationAtRest = transform(v));
        public static void BindTranslationAtRest(this UnityEngine.Animations.PositionConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = transform());
        public static void BindTranslationAtRestInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationAtRest = transform());
        public static void BindTranslationAtRestLerp(this UnityEngine.Animations.PositionConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.Lerp(obj.translationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestLerp(this UnityEngine.Animations.PositionConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.Lerp(obj.translationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestTowards(this UnityEngine.Animations.PositionConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.MoveTowards(obj.translationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationAtRestTowards(this UnityEngine.Animations.PositionConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAtRest = Vector3.MoveTowards(obj.translationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTranslationAtRest(this UnityEngine.Animations.PositionConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.translationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateTranslationAtRest(this UnityEngine.Animations.PositionConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTranslationAtRest(obj, obj.translationAtRest, end, curve);
        public static void BindTranslationOffset(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.translationOffset = v);
        public static void BindTranslationOffset<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.translationOffset = transform(v));
        public static void BindTranslationOffset(this UnityEngine.Animations.PositionConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationOffset = transform());
        public static void BindTranslationOffsetInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationOffset = transform());
        public static void BindTranslationOffsetLerp(this UnityEngine.Animations.PositionConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationOffset = Vector3.Lerp(obj.translationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationOffsetLerp(this UnityEngine.Animations.PositionConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationOffset = Vector3.Lerp(obj.translationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void BindTranslationOffsetTowards(this UnityEngine.Animations.PositionConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.translationOffset = Vector3.MoveTowards(obj.translationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTranslationOffsetTowards(this UnityEngine.Animations.PositionConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationOffset = Vector3.MoveTowards(obj.translationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTranslationOffset(this UnityEngine.Animations.PositionConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.translationOffset = Vector3.Lerp(start, end, t));
        public static void AnimateTranslationOffset(this UnityEngine.Animations.PositionConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTranslationOffset(obj, obj.translationOffset, end, curve);
        public static void BindTranslationAxis(this UnityEngine.Animations.PositionConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.translationAxis = v);
        public static void BindTranslationAxis<T>(this UnityEngine.Animations.PositionConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.translationAxis = transform(v));
        public static void BindTranslationAxis(this UnityEngine.Animations.PositionConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.translationAxis = transform());
        public static void BindTranslationAxisInterval(this UnityEngine.Animations.PositionConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.translationAxis = transform());
        #endif


        public static void BindNearClipPlane(this Projector obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = transform(v));
        public static void BindNearClipPlane(this Projector obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.nearClipPlane = transform());
        public static void BindNearClipPlaneInterval(this Projector obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.nearClipPlane = transform());
        public static void BindFarClipPlane(this Projector obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = transform(v));
        public static void BindFarClipPlane(this Projector obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.farClipPlane = transform());
        public static void BindFarClipPlaneInterval(this Projector obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.farClipPlane = transform());
        public static void BindFieldOfView(this Projector obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fieldOfView = v);
        public static void BindFieldOfView<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fieldOfView = transform(v));
        public static void BindFieldOfView(this Projector obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fieldOfView = transform());
        public static void BindFieldOfViewInterval(this Projector obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fieldOfView = transform());
        public static void BindAspectRatio(this Projector obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.aspectRatio = v);
        public static void BindAspectRatio<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.aspectRatio = transform(v));
        public static void BindAspectRatio(this Projector obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.aspectRatio = transform());
        public static void BindAspectRatioInterval(this Projector obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.aspectRatio = transform());
        public static void BindOrthographic(this Projector obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.orthographic = v);
        public static void BindOrthographic<T>(this Projector obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.orthographic = transform(v));
        public static void BindOrthographic(this Projector obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.orthographic = transform());
        public static void BindOrthographicInterval(this Projector obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.orthographic = transform());
        public static void BindOrthographicSize(this Projector obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.orthographicSize = v);
        public static void BindOrthographicSize<T>(this Projector obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.orthographicSize = transform(v));
        public static void BindOrthographicSize(this Projector obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.orthographicSize = transform());
        public static void BindOrthographicSizeInterval(this Projector obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.orthographicSize = transform());
        public static void BindMaterial(this Projector obj, IProperty<UnityEngine.Material> property)
            => Bindings2._scope.Bind(property, v => obj.material = v);
        public static void BindMaterial<T>(this Projector obj, IProperty<T> property, Func<T, UnityEngine.Material> transform)
            => Bindings2._scope.Bind(property, v => obj.material = transform(v));
        public static void BindMaterial(this Projector obj, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindUpdate(() => obj.material = transform());
        public static void BindMaterialInterval(this Projector obj, float seconds, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.material = transform());
        public static void BindIgnoreLayers(this Projector obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.ignoreLayers = v);
        public static void BindIgnoreLayers<T>(this Projector obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.ignoreLayers = transform(v));
        public static void BindIgnoreLayers(this Projector obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.ignoreLayers = transform());
        public static void BindIgnoreLayersInterval(this Projector obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.ignoreLayers = transform());


        #if UNITY_GUI
        public static void BindTexture(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Texture> property)
            => Bindings2._scope.Bind(property, v => obj.texture = v);
        public static void BindTexture<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Texture> transform)
            => Bindings2._scope.Bind(property, v => obj.texture = transform(v));
        public static void BindTexture(this UnityEngine.UI.RawImage obj, Func<UnityEngine.Texture> transform)
            => Bindings2._scope.BindUpdate(() => obj.texture = transform());
        public static void BindTextureInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<UnityEngine.Texture> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.texture = transform());
        public static void BindColor(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this UnityEngine.UI.RawImage obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindRaycastTarget(this UnityEngine.UI.RawImage obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.RawImage obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastTarget = transform());
        public static void BindRaycastTargetInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastTarget = transform());
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = transform(v));
        public static void BindRaycastPadding(this UnityEngine.UI.RawImage obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastPadding = transform());
        public static void BindRaycastPaddingInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastPadding = transform());
        #endif
        public static void BindMaskable(this UnityEngine.UI.RawImage obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.maskable = transform(v));
        public static void BindMaskable(this UnityEngine.UI.RawImage obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskable = transform());
        public static void BindMaskableInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskable = transform());
        public static void BindUvRect(this UnityEngine.UI.RawImage obj, IProperty<UnityEngine.Rect> property)
            => Bindings2._scope.Bind(property, v => obj.uvRect = v);
        public static void BindUvRect<T>(this UnityEngine.UI.RawImage obj, IProperty<T> property, Func<T, UnityEngine.Rect> transform)
            => Bindings2._scope.Bind(property, v => obj.uvRect = transform(v));
        public static void BindUvRect(this UnityEngine.UI.RawImage obj, Func<UnityEngine.Rect> transform)
            => Bindings2._scope.BindUpdate(() => obj.uvRect = transform());
        public static void BindUvRectInterval(this UnityEngine.UI.RawImage obj, float seconds, Func<UnityEngine.Rect> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.uvRect = transform());
        #endif


        #if UNITY_GUI
        public static void BindPadding(this UnityEngine.UI.RectMask2D obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.padding = v);
        public static void BindPadding<T>(this UnityEngine.UI.RectMask2D obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.padding = transform(v));
        public static void BindPadding(this UnityEngine.UI.RectMask2D obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.padding = transform());
        public static void BindPaddingInterval(this UnityEngine.UI.RectMask2D obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.padding = transform());
        public static void BindSoftness(this UnityEngine.UI.RectMask2D obj, IProperty<UnityEngine.Vector2Int> property)
            => Bindings2._scope.Bind(property, v => obj.softness = v);
        public static void BindSoftness<T>(this UnityEngine.UI.RectMask2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2Int> transform)
            => Bindings2._scope.Bind(property, v => obj.softness = transform(v));
        public static void BindSoftness(this UnityEngine.UI.RectMask2D obj, Func<UnityEngine.Vector2Int> transform)
            => Bindings2._scope.BindUpdate(() => obj.softness = transform());
        public static void BindSoftnessInterval(this UnityEngine.UI.RectMask2D obj, float seconds, Func<UnityEngine.Vector2Int> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.softness = transform());
        #endif


        public static void BindLocalPosition(this RectTransform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.localPosition = v);
        public static void BindLocalPosition<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.localPosition = transform(v));
        public static void BindLocalPosition(this RectTransform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = transform());
        public static void BindLocalPositionInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localPosition = transform());
        public static void BindLocalPositionLerp(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.Lerp(obj.localPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalPositionLerp(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.Lerp(obj.localPosition, transform(), speed * Time.smoothDeltaTime));
        public static void BindLocalPositionTowards(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.MoveTowards(obj.localPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalPositionTowards(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.MoveTowards(obj.localPosition, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateLocalPosition(this RectTransform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.localPosition = Vector3.Lerp(start, end, t));
        public static void AnimateLocalPosition(this RectTransform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateLocalPosition(obj, obj.localPosition, end, curve);
        public static void BindSizeDelta(this RectTransform obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.sizeDelta = v);
        public static void BindSizeDelta<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.sizeDelta = transform(v));
        public static void BindSizeDelta(this RectTransform obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.sizeDelta = transform());
        public static void BindSizeDeltaInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sizeDelta = transform());
        public static void BindAnchorMin(this RectTransform obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchorMin = v);
        public static void BindAnchorMin<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchorMin = transform(v));
        public static void BindAnchorMin(this RectTransform obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchorMin = transform());
        public static void BindAnchorMinInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchorMin = transform());
        public static void BindAnchorMax(this RectTransform obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchorMax = v);
        public static void BindAnchorMax<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchorMax = transform(v));
        public static void BindAnchorMax(this RectTransform obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchorMax = transform());
        public static void BindAnchorMaxInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchorMax = transform());
        public static void BindLocalRotation(this RectTransform obj, IProperty<UnityEngine.Quaternion> property)
            => Bindings2._scope.Bind(property, v => obj.localRotation = v);
        public static void BindLocalRotation<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform)
            => Bindings2._scope.Bind(property, v => obj.localRotation = transform(v));
        public static void BindLocalRotation(this RectTransform obj, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindUpdate(() => obj.localRotation = transform());
        public static void BindLocalRotationInterval(this RectTransform obj, float seconds, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localRotation = transform());
        public static void BindLocalScale(this RectTransform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.localScale = v);
        public static void BindLocalScale<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.localScale = transform(v));
        public static void BindLocalScale(this RectTransform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = transform());
        public static void BindLocalScaleInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localScale = transform());
        public static void BindLocalScaleLerp(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.Lerp(obj.localScale, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalScaleLerp(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.Lerp(obj.localScale, transform(), speed * Time.smoothDeltaTime));
        public static void BindLocalScaleTowards(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.MoveTowards(obj.localScale, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalScaleTowards(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.MoveTowards(obj.localScale, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateLocalScale(this RectTransform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.localScale = Vector3.Lerp(start, end, t));
        public static void AnimateLocalScale(this RectTransform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateLocalScale(obj, obj.localScale, end, curve);
        public static void BindPosition(this RectTransform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.position = v);
        public static void BindPosition<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.position = transform(v));
        public static void BindPosition(this RectTransform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = transform());
        public static void BindPositionInterval(this RectTransform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.position = transform());
        public static void BindPositionLerp(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.Lerp(obj.position, property.Value, speed * Time.smoothDeltaTime));
        public static void BindPositionLerp(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.Lerp(obj.position, transform(), speed * Time.smoothDeltaTime));
        public static void BindPositionTowards(this RectTransform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.MoveTowards(obj.position, property.Value, speed * Time.smoothDeltaTime));
        public static void BindPositionTowards(this RectTransform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.MoveTowards(obj.position, transform(), speed * Time.smoothDeltaTime));
        public static void AnimatePosition(this RectTransform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.position = Vector3.Lerp(start, end, t));
        public static void AnimatePosition(this RectTransform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimatePosition(obj, obj.position, end, curve);
        public static void BindRotation(this RectTransform obj, IProperty<UnityEngine.Quaternion> property)
            => Bindings2._scope.Bind(property, v => obj.rotation = v);
        public static void BindRotation<T>(this RectTransform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform)
            => Bindings2._scope.Bind(property, v => obj.rotation = transform(v));
        public static void BindRotation(this RectTransform obj, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotation = transform());
        public static void BindRotationInterval(this RectTransform obj, float seconds, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotation = transform());


        public static void BindMode(this ReflectionProbe obj, IProperty<UnityEngine.Rendering.ReflectionProbeMode> property)
            => Bindings2._scope.Bind(property, v => obj.mode = v);
        public static void BindMode<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeMode> transform)
            => Bindings2._scope.Bind(property, v => obj.mode = transform(v));
        public static void BindMode(this ReflectionProbe obj, Func<UnityEngine.Rendering.ReflectionProbeMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.mode = transform());
        public static void BindModeInterval(this ReflectionProbe obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mode = transform());
        public static void BindImportance(this ReflectionProbe obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.importance = v);
        public static void BindImportance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.importance = transform(v));
        public static void BindImportance(this ReflectionProbe obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.importance = transform());
        public static void BindImportanceInterval(this ReflectionProbe obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.importance = transform());
        public static void BindIntensity(this ReflectionProbe obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.intensity = v);
        public static void BindIntensity<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.intensity = transform(v));
        public static void BindIntensity(this ReflectionProbe obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.intensity = transform());
        public static void BindIntensityInterval(this ReflectionProbe obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.intensity = transform());
        public static void BindBoxProjection(this ReflectionProbe obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.boxProjection = v);
        public static void BindBoxProjection<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.boxProjection = transform(v));
        public static void BindBoxProjection(this ReflectionProbe obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.boxProjection = transform());
        public static void BindBoxProjectionInterval(this ReflectionProbe obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.boxProjection = transform());
        public static void BindBlendDistance(this ReflectionProbe obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.blendDistance = v);
        public static void BindBlendDistance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.blendDistance = transform(v));
        public static void BindBlendDistance(this ReflectionProbe obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.blendDistance = transform());
        public static void BindBlendDistanceInterval(this ReflectionProbe obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.blendDistance = transform());
        public static void BindSize(this ReflectionProbe obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this ReflectionProbe obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this ReflectionProbe obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindSizeLerp(this ReflectionProbe obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeLerp(this ReflectionProbe obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.Lerp(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this ReflectionProbe obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, property.Value, speed * Time.smoothDeltaTime));
        public static void BindSizeTowards(this ReflectionProbe obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = Vector3.MoveTowards(obj.size, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateSize(this ReflectionProbe obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.size = Vector3.Lerp(start, end, t));
        public static void AnimateSize(this ReflectionProbe obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateSize(obj, obj.size, end, curve);
        public static void BindCenter(this ReflectionProbe obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this ReflectionProbe obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this ReflectionProbe obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this ReflectionProbe obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this ReflectionProbe obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this ReflectionProbe obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this ReflectionProbe obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this ReflectionProbe obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this ReflectionProbe obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindResolution(this ReflectionProbe obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.resolution = v);
        public static void BindResolution<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.resolution = transform(v));
        public static void BindResolution(this ReflectionProbe obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.resolution = transform());
        public static void BindResolutionInterval(this ReflectionProbe obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.resolution = transform());
        public static void BindHdr(this ReflectionProbe obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.hdr = v);
        public static void BindHdr<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.hdr = transform(v));
        public static void BindHdr(this ReflectionProbe obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.hdr = transform());
        public static void BindHdrInterval(this ReflectionProbe obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.hdr = transform());
        public static void BindShadowDistance(this ReflectionProbe obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.shadowDistance = v);
        public static void BindShadowDistance<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowDistance = transform(v));
        public static void BindShadowDistance(this ReflectionProbe obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowDistance = transform());
        public static void BindShadowDistanceInterval(this ReflectionProbe obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowDistance = transform());
        public static void BindClearFlags(this ReflectionProbe obj, IProperty<UnityEngine.Rendering.ReflectionProbeClearFlags> property)
            => Bindings2._scope.Bind(property, v => obj.clearFlags = v);
        public static void BindClearFlags<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeClearFlags> transform)
            => Bindings2._scope.Bind(property, v => obj.clearFlags = transform(v));
        public static void BindClearFlags(this ReflectionProbe obj, Func<UnityEngine.Rendering.ReflectionProbeClearFlags> transform)
            => Bindings2._scope.BindUpdate(() => obj.clearFlags = transform());
        public static void BindClearFlagsInterval(this ReflectionProbe obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeClearFlags> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clearFlags = transform());
        public static void BindBackgroundColor(this ReflectionProbe obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.backgroundColor = v);
        public static void BindBackgroundColor<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.backgroundColor = transform(v));
        public static void BindBackgroundColor(this ReflectionProbe obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.backgroundColor = transform());
        public static void BindBackgroundColorInterval(this ReflectionProbe obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.backgroundColor = transform());
        public static void BindCullingMask(this ReflectionProbe obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = v);
        public static void BindCullingMask<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.cullingMask = transform(v));
        public static void BindCullingMask(this ReflectionProbe obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.cullingMask = transform());
        public static void BindCullingMaskInterval(this ReflectionProbe obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cullingMask = transform());
        public static void BindNearClipPlane(this ReflectionProbe obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = v);
        public static void BindNearClipPlane<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.nearClipPlane = transform(v));
        public static void BindNearClipPlane(this ReflectionProbe obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.nearClipPlane = transform());
        public static void BindNearClipPlaneInterval(this ReflectionProbe obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.nearClipPlane = transform());
        public static void BindFarClipPlane(this ReflectionProbe obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = v);
        public static void BindFarClipPlane<T>(this ReflectionProbe obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.farClipPlane = transform(v));
        public static void BindFarClipPlane(this ReflectionProbe obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.farClipPlane = transform());
        public static void BindFarClipPlaneInterval(this ReflectionProbe obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.farClipPlane = transform());


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this RelativeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this RelativeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this RelativeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this RelativeJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this RelativeJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this RelativeJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindMaxForce(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxForce = transform(v));
        public static void BindMaxForce(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxForce = transform());
        public static void BindMaxForceInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxForce = transform());
        public static void BindMaxTorque(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxTorque = v);
        public static void BindMaxTorque<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxTorque = transform(v));
        public static void BindMaxTorque(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxTorque = transform());
        public static void BindMaxTorqueInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxTorque = transform());
        public static void BindCorrectionScale(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.correctionScale = v);
        public static void BindCorrectionScale<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.correctionScale = transform(v));
        public static void BindCorrectionScale(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.correctionScale = transform());
        public static void BindCorrectionScaleInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.correctionScale = transform());
        public static void BindAutoConfigureOffset(this RelativeJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureOffset = v);
        public static void BindAutoConfigureOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureOffset = transform(v));
        public static void BindAutoConfigureOffset(this RelativeJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureOffset = transform());
        public static void BindAutoConfigureOffsetInterval(this RelativeJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureOffset = transform());
        public static void BindLinearOffset(this RelativeJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.linearOffset = v);
        public static void BindLinearOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.linearOffset = transform(v));
        public static void BindLinearOffset(this RelativeJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearOffset = transform());
        public static void BindLinearOffsetInterval(this RelativeJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearOffset = transform());
        public static void BindAngularOffset(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularOffset = v);
        public static void BindAngularOffset<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularOffset = transform(v));
        public static void BindAngularOffset(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularOffset = transform());
        public static void BindAngularOffsetInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularOffset = transform());
        public static void BindBreakForce(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this RelativeJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this RelativeJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this RelativeJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this RelativeJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindMass(this Rigidbody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.mass = v);
        public static void BindMass<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.mass = transform(v));
        public static void BindMass(this Rigidbody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.mass = transform());
        public static void BindMassInterval(this Rigidbody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mass = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindDrag(this Rigidbody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.drag = v);
        public static void BindDrag<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.drag = transform(v));
        public static void BindDrag(this Rigidbody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.drag = transform());
        public static void BindDragInterval(this Rigidbody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drag = transform());
        #endif
        #if !UNITY_6000_0_OR_NEWER
        public static void BindAngularDrag(this Rigidbody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = transform(v));
        public static void BindAngularDrag(this Rigidbody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDrag = transform());
        public static void BindAngularDragInterval(this Rigidbody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDrag = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindLinearDamping(this Rigidbody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = transform(v));
        public static void BindLinearDamping(this Rigidbody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearDamping = transform());
        public static void BindLinearDampingInterval(this Rigidbody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearDamping = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindAngularDamping(this Rigidbody obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = transform(v));
        public static void BindAngularDamping(this Rigidbody obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDamping = transform());
        public static void BindAngularDampingInterval(this Rigidbody obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDamping = transform());
        #endif
        public static void BindUseGravity(this Rigidbody obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGravity = v);
        public static void BindUseGravity<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGravity = transform(v));
        public static void BindUseGravity(this Rigidbody obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGravity = transform());
        public static void BindUseGravityInterval(this Rigidbody obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGravity = transform());
        public static void BindIsKinematic(this Rigidbody obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isKinematic = v);
        public static void BindIsKinematic<T>(this Rigidbody obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isKinematic = transform(v));
        public static void BindIsKinematic(this Rigidbody obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isKinematic = transform());
        public static void BindIsKinematicInterval(this Rigidbody obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isKinematic = transform());
        public static void BindInterpolation(this Rigidbody obj, IProperty<UnityEngine.RigidbodyInterpolation> property)
            => Bindings2._scope.Bind(property, v => obj.interpolation = v);
        public static void BindInterpolation<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyInterpolation> transform)
            => Bindings2._scope.Bind(property, v => obj.interpolation = transform(v));
        public static void BindInterpolation(this Rigidbody obj, Func<UnityEngine.RigidbodyInterpolation> transform)
            => Bindings2._scope.BindUpdate(() => obj.interpolation = transform());
        public static void BindInterpolationInterval(this Rigidbody obj, float seconds, Func<UnityEngine.RigidbodyInterpolation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interpolation = transform());
        public static void BindCollisionDetectionMode(this Rigidbody obj, IProperty<UnityEngine.CollisionDetectionMode> property)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = transform(v));
        public static void BindCollisionDetectionMode(this Rigidbody obj, Func<UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.collisionDetectionMode = transform());
        public static void BindCollisionDetectionModeInterval(this Rigidbody obj, float seconds, Func<UnityEngine.CollisionDetectionMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.collisionDetectionMode = transform());
        public static void BindConstraints(this Rigidbody obj, IProperty<UnityEngine.RigidbodyConstraints> property)
            => Bindings2._scope.Bind(property, v => obj.constraints = v);
        public static void BindConstraints<T>(this Rigidbody obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyConstraints> transform)
            => Bindings2._scope.Bind(property, v => obj.constraints = transform(v));
        public static void BindConstraints(this Rigidbody obj, Func<UnityEngine.RigidbodyConstraints> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraints = transform());
        public static void BindConstraintsInterval(this Rigidbody obj, float seconds, Func<UnityEngine.RigidbodyConstraints> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraints = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindBodyType(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyType2D> property)
            => Bindings2._scope.Bind(property, v => obj.bodyType = v);
        public static void BindBodyType<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyType2D> transform)
            => Bindings2._scope.Bind(property, v => obj.bodyType = transform(v));
        public static void BindBodyType(this Rigidbody2D obj, Func<UnityEngine.RigidbodyType2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.bodyType = transform());
        public static void BindBodyTypeInterval(this Rigidbody2D obj, float seconds, Func<UnityEngine.RigidbodyType2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bodyType = transform());
        public static void BindSimulated(this Rigidbody2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.simulated = v);
        public static void BindSimulated<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.simulated = transform(v));
        public static void BindSimulated(this Rigidbody2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.simulated = transform());
        public static void BindSimulatedInterval(this Rigidbody2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.simulated = transform());
        public static void BindUseAutoMass(this Rigidbody2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useAutoMass = v);
        public static void BindUseAutoMass<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useAutoMass = transform(v));
        public static void BindUseAutoMass(this Rigidbody2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useAutoMass = transform());
        public static void BindUseAutoMassInterval(this Rigidbody2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useAutoMass = transform());
        public static void BindMass(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.mass = v);
        public static void BindMass<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.mass = transform(v));
        public static void BindMass(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.mass = transform());
        public static void BindMassInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mass = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindDrag(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.drag = v);
        public static void BindDrag<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.drag = transform(v));
        public static void BindDrag(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.drag = transform());
        public static void BindDragInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drag = transform());
        #endif
        #if !UNITY_6000_0_OR_NEWER
        public static void BindAngularDrag(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = v);
        public static void BindAngularDrag<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDrag = transform(v));
        public static void BindAngularDrag(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDrag = transform());
        public static void BindAngularDragInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDrag = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindLinearDamping(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = v);
        public static void BindLinearDamping<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.linearDamping = transform(v));
        public static void BindLinearDamping(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.linearDamping = transform());
        public static void BindLinearDampingInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.linearDamping = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindAngularDamping(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = v);
        public static void BindAngularDamping<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angularDamping = transform(v));
        public static void BindAngularDamping(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angularDamping = transform());
        public static void BindAngularDampingInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angularDamping = transform());
        #endif
        public static void BindGravityScale(this Rigidbody2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.gravityScale = v);
        public static void BindGravityScale<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.gravityScale = transform(v));
        public static void BindGravityScale(this Rigidbody2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.gravityScale = transform());
        public static void BindGravityScaleInterval(this Rigidbody2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.gravityScale = transform());
        public static void BindCollisionDetectionMode(this Rigidbody2D obj, IProperty<UnityEngine.CollisionDetectionMode2D> property)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = v);
        public static void BindCollisionDetectionMode<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.CollisionDetectionMode2D> transform)
            => Bindings2._scope.Bind(property, v => obj.collisionDetectionMode = transform(v));
        public static void BindCollisionDetectionMode(this Rigidbody2D obj, Func<UnityEngine.CollisionDetectionMode2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.collisionDetectionMode = transform());
        public static void BindCollisionDetectionModeInterval(this Rigidbody2D obj, float seconds, Func<UnityEngine.CollisionDetectionMode2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.collisionDetectionMode = transform());
        public static void BindSleepMode(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodySleepMode2D> property)
            => Bindings2._scope.Bind(property, v => obj.sleepMode = v);
        public static void BindSleepMode<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodySleepMode2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sleepMode = transform(v));
        public static void BindSleepMode(this Rigidbody2D obj, Func<UnityEngine.RigidbodySleepMode2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sleepMode = transform());
        public static void BindSleepModeInterval(this Rigidbody2D obj, float seconds, Func<UnityEngine.RigidbodySleepMode2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sleepMode = transform());
        public static void BindInterpolation(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyInterpolation2D> property)
            => Bindings2._scope.Bind(property, v => obj.interpolation = v);
        public static void BindInterpolation<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyInterpolation2D> transform)
            => Bindings2._scope.Bind(property, v => obj.interpolation = transform(v));
        public static void BindInterpolation(this Rigidbody2D obj, Func<UnityEngine.RigidbodyInterpolation2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.interpolation = transform());
        public static void BindInterpolationInterval(this Rigidbody2D obj, float seconds, Func<UnityEngine.RigidbodyInterpolation2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interpolation = transform());
        public static void BindConstraints(this Rigidbody2D obj, IProperty<UnityEngine.RigidbodyConstraints2D> property)
            => Bindings2._scope.Bind(property, v => obj.constraints = v);
        public static void BindConstraints<T>(this Rigidbody2D obj, IProperty<T> property, Func<T, UnityEngine.RigidbodyConstraints2D> transform)
            => Bindings2._scope.Bind(property, v => obj.constraints = transform(v));
        public static void BindConstraints(this Rigidbody2D obj, Func<UnityEngine.RigidbodyConstraints2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraints = transform());
        public static void BindConstraintsInterval(this Rigidbody2D obj, float seconds, Func<UnityEngine.RigidbodyConstraints2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraints = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.RotationConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.RotationConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindLocked(this UnityEngine.Animations.RotationConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.RotationConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindRotationAtRest(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = v);
        public static void BindRotationAtRest<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAtRest = transform(v));
        public static void BindRotationAtRest(this UnityEngine.Animations.RotationConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = transform());
        public static void BindRotationAtRestInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAtRest = transform());
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.RotationConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestLerp(this UnityEngine.Animations.RotationConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.Lerp(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.RotationConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationAtRestTowards(this UnityEngine.Animations.RotationConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAtRest = Vector3.MoveTowards(obj.rotationAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.RotationConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateRotationAtRest(this UnityEngine.Animations.RotationConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationAtRest(obj, obj.rotationAtRest, end, curve);
        public static void BindRotationOffset(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = v);
        public static void BindRotationOffset<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationOffset = transform(v));
        public static void BindRotationOffset(this UnityEngine.Animations.RotationConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = transform());
        public static void BindRotationOffsetInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationOffset = transform());
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.RotationConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetLerp(this UnityEngine.Animations.RotationConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.Lerp(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.RotationConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindRotationOffsetTowards(this UnityEngine.Animations.RotationConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationOffset = Vector3.MoveTowards(obj.rotationOffset, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateRotationOffset(this UnityEngine.Animations.RotationConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.rotationOffset = Vector3.Lerp(start, end, t));
        public static void AnimateRotationOffset(this UnityEngine.Animations.RotationConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateRotationOffset(obj, obj.rotationOffset, end, curve);
        public static void BindRotationAxis(this UnityEngine.Animations.RotationConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = v);
        public static void BindRotationAxis<T>(this UnityEngine.Animations.RotationConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.rotationAxis = transform(v));
        public static void BindRotationAxis(this UnityEngine.Animations.RotationConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotationAxis = transform());
        public static void BindRotationAxisInterval(this UnityEngine.Animations.RotationConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotationAxis = transform());
        #endif


        #if UNITY_ANIMATION
        public static void BindConstraintActive(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = v);
        public static void BindConstraintActive<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.constraintActive = transform(v));
        public static void BindConstraintActive(this UnityEngine.Animations.ScaleConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.constraintActive = transform());
        public static void BindConstraintActiveInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.constraintActive = transform());
        public static void BindWeight(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.weight = v);
        public static void BindWeight<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.weight = transform(v));
        public static void BindWeight(this UnityEngine.Animations.ScaleConstraint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.weight = transform());
        public static void BindWeightInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.weight = transform());
        public static void BindLocked(this UnityEngine.Animations.ScaleConstraint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.locked = v);
        public static void BindLocked<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.locked = transform(v));
        public static void BindLocked(this UnityEngine.Animations.ScaleConstraint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.locked = transform());
        public static void BindLockedInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.locked = transform());
        public static void BindScaleAtRest(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.scaleAtRest = v);
        public static void BindScaleAtRest<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.scaleAtRest = transform(v));
        public static void BindScaleAtRest(this UnityEngine.Animations.ScaleConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleAtRest = transform());
        public static void BindScaleAtRestInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.scaleAtRest = transform());
        public static void BindScaleAtRestLerp(this UnityEngine.Animations.ScaleConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.scaleAtRest = Vector3.Lerp(obj.scaleAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindScaleAtRestLerp(this UnityEngine.Animations.ScaleConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleAtRest = Vector3.Lerp(obj.scaleAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void BindScaleAtRestTowards(this UnityEngine.Animations.ScaleConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.scaleAtRest = Vector3.MoveTowards(obj.scaleAtRest, property.Value, speed * Time.smoothDeltaTime));
        public static void BindScaleAtRestTowards(this UnityEngine.Animations.ScaleConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleAtRest = Vector3.MoveTowards(obj.scaleAtRest, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateScaleAtRest(this UnityEngine.Animations.ScaleConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.scaleAtRest = Vector3.Lerp(start, end, t));
        public static void AnimateScaleAtRest(this UnityEngine.Animations.ScaleConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateScaleAtRest(obj, obj.scaleAtRest, end, curve);
        public static void BindScaleOffset(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.scaleOffset = v);
        public static void BindScaleOffset<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.scaleOffset = transform(v));
        public static void BindScaleOffset(this UnityEngine.Animations.ScaleConstraint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleOffset = transform());
        public static void BindScaleOffsetInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.scaleOffset = transform());
        public static void BindScaleOffsetLerp(this UnityEngine.Animations.ScaleConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.scaleOffset = Vector3.Lerp(obj.scaleOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindScaleOffsetLerp(this UnityEngine.Animations.ScaleConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleOffset = Vector3.Lerp(obj.scaleOffset, transform(), speed * Time.smoothDeltaTime));
        public static void BindScaleOffsetTowards(this UnityEngine.Animations.ScaleConstraint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.scaleOffset = Vector3.MoveTowards(obj.scaleOffset, property.Value, speed * Time.smoothDeltaTime));
        public static void BindScaleOffsetTowards(this UnityEngine.Animations.ScaleConstraint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.scaleOffset = Vector3.MoveTowards(obj.scaleOffset, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateScaleOffset(this UnityEngine.Animations.ScaleConstraint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.scaleOffset = Vector3.Lerp(start, end, t));
        public static void AnimateScaleOffset(this UnityEngine.Animations.ScaleConstraint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateScaleOffset(obj, obj.scaleOffset, end, curve);
        public static void BindScalingAxis(this UnityEngine.Animations.ScaleConstraint obj, IProperty<UnityEngine.Animations.Axis> property)
            => Bindings2._scope.Bind(property, v => obj.scalingAxis = v);
        public static void BindScalingAxis<T>(this UnityEngine.Animations.ScaleConstraint obj, IProperty<T> property, Func<T, UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.Bind(property, v => obj.scalingAxis = transform(v));
        public static void BindScalingAxis(this UnityEngine.Animations.ScaleConstraint obj, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindUpdate(() => obj.scalingAxis = transform());
        public static void BindScalingAxisInterval(this UnityEngine.Animations.ScaleConstraint obj, float seconds, Func<UnityEngine.Animations.Axis> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.scalingAxis = transform());
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Scrollbar obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.Scrollbar obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindHandleRect(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.handleRect = v);
        public static void BindHandleRect<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.handleRect = transform(v));
        public static void BindHandleRect(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.handleRect = transform());
        public static void BindHandleRectInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.handleRect = transform());
        public static void BindDirection(this UnityEngine.UI.Scrollbar obj, IProperty<UnityEngine.UI.Scrollbar.Direction> property)
            => Bindings2._scope.Bind(property, v => obj.direction = v);
        public static void BindDirection<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar.Direction> transform)
            => Bindings2._scope.Bind(property, v => obj.direction = transform(v));
        public static void BindDirection(this UnityEngine.UI.Scrollbar obj, Func<UnityEngine.UI.Scrollbar.Direction> transform)
            => Bindings2._scope.BindUpdate(() => obj.direction = transform());
        public static void BindDirectionInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<UnityEngine.UI.Scrollbar.Direction> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.direction = transform());
        public static void BindValue(this UnityEngine.UI.Scrollbar obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.value = transform(v));
        public static void BindValue(this UnityEngine.UI.Scrollbar obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.value = transform());
        public static void BindValueInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.value = transform());
        public static void BindSize(this UnityEngine.UI.Scrollbar obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.size = v);
        public static void BindSize<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.size = transform(v));
        public static void BindSize(this UnityEngine.UI.Scrollbar obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.size = transform());
        public static void BindSizeInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.size = transform());
        public static void BindNumberOfSteps(this UnityEngine.UI.Scrollbar obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.numberOfSteps = v);
        public static void BindNumberOfSteps<T>(this UnityEngine.UI.Scrollbar obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.numberOfSteps = transform(v));
        public static void BindNumberOfSteps(this UnityEngine.UI.Scrollbar obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.numberOfSteps = transform());
        public static void BindNumberOfStepsInterval(this UnityEngine.UI.Scrollbar obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.numberOfSteps = transform());
        #endif


        #if UNITY_GUI
        public static void BindContent(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.content = v);
        public static void BindContent<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.content = transform(v));
        public static void BindContent(this UnityEngine.UI.ScrollRect obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.content = transform());
        public static void BindContentInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.content = transform());
        public static void BindHorizontal(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.horizontal = v);
        public static void BindHorizontal<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontal = transform(v));
        public static void BindHorizontal(this UnityEngine.UI.ScrollRect obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontal = transform());
        public static void BindHorizontalInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontal = transform());
        public static void BindVertical(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.vertical = v);
        public static void BindVertical<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.vertical = transform(v));
        public static void BindVertical(this UnityEngine.UI.ScrollRect obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.vertical = transform());
        public static void BindVerticalInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.vertical = transform());
        public static void BindMovementType(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.ScrollRect.MovementType> property)
            => Bindings2._scope.Bind(property, v => obj.movementType = v);
        public static void BindMovementType<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.ScrollRect.MovementType> transform)
            => Bindings2._scope.Bind(property, v => obj.movementType = transform(v));
        public static void BindMovementType(this UnityEngine.UI.ScrollRect obj, Func<UnityEngine.UI.ScrollRect.MovementType> transform)
            => Bindings2._scope.BindUpdate(() => obj.movementType = transform());
        public static void BindMovementTypeInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<UnityEngine.UI.ScrollRect.MovementType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.movementType = transform());
        public static void BindElasticity(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.elasticity = v);
        public static void BindElasticity<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.elasticity = transform(v));
        public static void BindElasticity(this UnityEngine.UI.ScrollRect obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.elasticity = transform());
        public static void BindElasticityInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.elasticity = transform());
        public static void BindInertia(this UnityEngine.UI.ScrollRect obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.inertia = v);
        public static void BindInertia<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.inertia = transform(v));
        public static void BindInertia(this UnityEngine.UI.ScrollRect obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.inertia = transform());
        public static void BindInertiaInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.inertia = transform());
        public static void BindDecelerationRate(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.decelerationRate = v);
        public static void BindDecelerationRate<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.decelerationRate = transform(v));
        public static void BindDecelerationRate(this UnityEngine.UI.ScrollRect obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.decelerationRate = transform());
        public static void BindDecelerationRateInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.decelerationRate = transform());
        public static void BindScrollSensitivity(this UnityEngine.UI.ScrollRect obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.scrollSensitivity = v);
        public static void BindScrollSensitivity<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.scrollSensitivity = transform(v));
        public static void BindScrollSensitivity(this UnityEngine.UI.ScrollRect obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.scrollSensitivity = transform());
        public static void BindScrollSensitivityInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.scrollSensitivity = transform());
        public static void BindViewport(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.viewport = v);
        public static void BindViewport<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.viewport = transform(v));
        public static void BindViewport(this UnityEngine.UI.ScrollRect obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.viewport = transform());
        public static void BindViewportInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.viewport = transform());
        public static void BindHorizontalScrollbar(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.Scrollbar> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalScrollbar = v);
        public static void BindHorizontalScrollbar<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalScrollbar = transform(v));
        public static void BindHorizontalScrollbar(this UnityEngine.UI.ScrollRect obj, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalScrollbar = transform());
        public static void BindHorizontalScrollbarInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalScrollbar = transform());
        public static void BindVerticalScrollbar(this UnityEngine.UI.ScrollRect obj, IProperty<UnityEngine.UI.Scrollbar> property)
            => Bindings2._scope.Bind(property, v => obj.verticalScrollbar = v);
        public static void BindVerticalScrollbar<T>(this UnityEngine.UI.ScrollRect obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalScrollbar = transform(v));
        public static void BindVerticalScrollbar(this UnityEngine.UI.ScrollRect obj, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalScrollbar = transform());
        public static void BindVerticalScrollbarInterval(this UnityEngine.UI.ScrollRect obj, float seconds, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalScrollbar = transform());
        #endif


        #if UNITY_GUI
        public static void BindEffectColor(this UnityEngine.UI.Shadow obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.effectColor = v);
        public static void BindEffectColor<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.effectColor = transform(v));
        public static void BindEffectColor(this UnityEngine.UI.Shadow obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.effectColor = transform());
        public static void BindEffectColorInterval(this UnityEngine.UI.Shadow obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.effectColor = transform());
        public static void BindEffectDistance(this UnityEngine.UI.Shadow obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.effectDistance = v);
        public static void BindEffectDistance<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.effectDistance = transform(v));
        public static void BindEffectDistance(this UnityEngine.UI.Shadow obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.effectDistance = transform());
        public static void BindEffectDistanceInterval(this UnityEngine.UI.Shadow obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.effectDistance = transform());
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Shadow obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useGraphicAlpha = v);
        public static void BindUseGraphicAlpha<T>(this UnityEngine.UI.Shadow obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useGraphicAlpha = transform(v));
        public static void BindUseGraphicAlpha(this UnityEngine.UI.Shadow obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useGraphicAlpha = transform());
        public static void BindUseGraphicAlphaInterval(this UnityEngine.UI.Shadow obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useGraphicAlpha = transform());
        #endif


        #if UNITY_2021_2_OR_NEWER
        public static void BindBounds(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Bounds> property)
            => Bindings2._scope.Bind(property, v => obj.bounds = v);
        public static void BindBounds<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Bounds> transform)
            => Bindings2._scope.Bind(property, v => obj.bounds = transform(v));
        public static void BindBounds(this SkinnedMeshRenderer obj, Func<UnityEngine.Bounds> transform)
            => Bindings2._scope.BindUpdate(() => obj.bounds = transform());
        public static void BindBoundsInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Bounds> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.bounds = transform());
        #endif
        public static void BindQuality(this SkinnedMeshRenderer obj, IProperty<UnityEngine.SkinQuality> property)
            => Bindings2._scope.Bind(property, v => obj.quality = v);
        public static void BindQuality<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.SkinQuality> transform)
            => Bindings2._scope.Bind(property, v => obj.quality = transform(v));
        public static void BindQuality(this SkinnedMeshRenderer obj, Func<UnityEngine.SkinQuality> transform)
            => Bindings2._scope.BindUpdate(() => obj.quality = transform());
        public static void BindQualityInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.SkinQuality> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.quality = transform());
        public static void BindUpdateWhenOffscreen(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.updateWhenOffscreen = v);
        public static void BindUpdateWhenOffscreen<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.updateWhenOffscreen = transform(v));
        public static void BindUpdateWhenOffscreen(this SkinnedMeshRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.updateWhenOffscreen = transform());
        public static void BindUpdateWhenOffscreenInterval(this SkinnedMeshRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.updateWhenOffscreen = transform());
        public static void BindSharedMesh(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Mesh> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = v);
        public static void BindSharedMesh<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Mesh> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMesh = transform(v));
        public static void BindSharedMesh(this SkinnedMeshRenderer obj, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMesh = transform());
        public static void BindSharedMeshInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Mesh> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMesh = transform());
        public static void BindRootBone(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Transform> property)
            => Bindings2._scope.Bind(property, v => obj.rootBone = v);
        public static void BindRootBone<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Transform> transform)
            => Bindings2._scope.Bind(property, v => obj.rootBone = transform(v));
        public static void BindRootBone(this SkinnedMeshRenderer obj, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindUpdate(() => obj.rootBone = transform());
        public static void BindRootBoneInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Transform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rootBone = transform());
        public static void BindSharedMaterials(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this SkinnedMeshRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindShadowCastingMode(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = transform(v));
        public static void BindShadowCastingMode(this SkinnedMeshRenderer obj, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowCastingMode = transform());
        public static void BindShadowCastingModeInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowCastingMode = transform());
        public static void BindReceiveShadows(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = transform(v));
        public static void BindReceiveShadows(this SkinnedMeshRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.receiveShadows = transform());
        public static void BindReceiveShadowsInterval(this SkinnedMeshRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.receiveShadows = transform());
        public static void BindLightProbeUsage(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = transform(v));
        public static void BindLightProbeUsage(this SkinnedMeshRenderer obj, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.lightProbeUsage = transform());
        public static void BindLightProbeUsageInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lightProbeUsage = transform());
        public static void BindReflectionProbeUsage(this SkinnedMeshRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this SkinnedMeshRenderer obj, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionProbeUsage = transform());
        public static void BindReflectionProbeUsageInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionProbeUsage = transform());
        public static void BindMotionVectorGenerationMode(this SkinnedMeshRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindMotionVectorGenerationMode(this SkinnedMeshRenderer obj, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.motionVectorGenerationMode = transform());
        public static void BindMotionVectorGenerationModeInterval(this SkinnedMeshRenderer obj, float seconds, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motionVectorGenerationMode = transform());
        public static void BindAllowOcclusionWhenDynamic(this SkinnedMeshRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this SkinnedMeshRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this SkinnedMeshRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowOcclusionWhenDynamic = transform());
        public static void BindAllowOcclusionWhenDynamicInterval(this SkinnedMeshRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowOcclusionWhenDynamic = transform());


        public static void BindMaterial(this Skybox obj, IProperty<UnityEngine.Material> property)
            => Bindings2._scope.Bind(property, v => obj.material = v);
        public static void BindMaterial<T>(this Skybox obj, IProperty<T> property, Func<T, UnityEngine.Material> transform)
            => Bindings2._scope.Bind(property, v => obj.material = transform(v));
        public static void BindMaterial(this Skybox obj, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindUpdate(() => obj.material = transform());
        public static void BindMaterialInterval(this Skybox obj, float seconds, Func<UnityEngine.Material> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.material = transform());


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Slider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.Slider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.Slider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.Slider obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Slider obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.Slider obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Slider obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindFillRect(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.fillRect = v);
        public static void BindFillRect<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.fillRect = transform(v));
        public static void BindFillRect(this UnityEngine.UI.Slider obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.fillRect = transform());
        public static void BindFillRectInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fillRect = transform());
        public static void BindHandleRect(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.handleRect = v);
        public static void BindHandleRect<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.handleRect = transform(v));
        public static void BindHandleRect(this UnityEngine.UI.Slider obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.handleRect = transform());
        public static void BindHandleRectInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.handleRect = transform());
        public static void BindDirection(this UnityEngine.UI.Slider obj, IProperty<UnityEngine.UI.Slider.Direction> property)
            => Bindings2._scope.Bind(property, v => obj.direction = v);
        public static void BindDirection<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, UnityEngine.UI.Slider.Direction> transform)
            => Bindings2._scope.Bind(property, v => obj.direction = transform(v));
        public static void BindDirection(this UnityEngine.UI.Slider obj, Func<UnityEngine.UI.Slider.Direction> transform)
            => Bindings2._scope.BindUpdate(() => obj.direction = transform());
        public static void BindDirectionInterval(this UnityEngine.UI.Slider obj, float seconds, Func<UnityEngine.UI.Slider.Direction> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.direction = transform());
        public static void BindMinValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minValue = v);
        public static void BindMinValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minValue = transform(v));
        public static void BindMinValue(this UnityEngine.UI.Slider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minValue = transform());
        public static void BindMinValueInterval(this UnityEngine.UI.Slider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minValue = transform());
        public static void BindMaxValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxValue = v);
        public static void BindMaxValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxValue = transform(v));
        public static void BindMaxValue(this UnityEngine.UI.Slider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxValue = transform());
        public static void BindMaxValueInterval(this UnityEngine.UI.Slider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxValue = transform());
        public static void BindWholeNumbers(this UnityEngine.UI.Slider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.wholeNumbers = v);
        public static void BindWholeNumbers<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.wholeNumbers = transform(v));
        public static void BindWholeNumbers(this UnityEngine.UI.Slider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.wholeNumbers = transform());
        public static void BindWholeNumbersInterval(this UnityEngine.UI.Slider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wholeNumbers = transform());
        public static void BindValue(this UnityEngine.UI.Slider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.value = v);
        public static void BindValue<T>(this UnityEngine.UI.Slider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.value = transform(v));
        public static void BindValue(this UnityEngine.UI.Slider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.value = transform());
        public static void BindValueInterval(this UnityEngine.UI.Slider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.value = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this SliderJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this SliderJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this SliderJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this SliderJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this SliderJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this SliderJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this SliderJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SliderJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this SliderJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this SliderJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this SliderJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this SliderJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this SliderJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this SliderJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this SliderJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindAutoConfigureAngle(this SliderJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureAngle = v);
        public static void BindAutoConfigureAngle<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureAngle = transform(v));
        public static void BindAutoConfigureAngle(this SliderJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureAngle = transform());
        public static void BindAutoConfigureAngleInterval(this SliderJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureAngle = transform());
        public static void BindAngle(this SliderJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.angle = v);
        public static void BindAngle<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.angle = transform(v));
        public static void BindAngle(this SliderJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.angle = transform());
        public static void BindAngleInterval(this SliderJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.angle = transform());
        public static void BindUseMotor(this SliderJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMotor = transform(v));
        public static void BindUseMotor(this SliderJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMotor = transform());
        public static void BindUseMotorInterval(this SliderJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMotor = transform());
        public static void BindMotor(this SliderJoint2D obj, IProperty<UnityEngine.JointMotor2D> property)
            => Bindings2._scope.Bind(property, v => obj.motor = v);
        public static void BindMotor<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.Bind(property, v => obj.motor = transform(v));
        public static void BindMotor(this SliderJoint2D obj, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.motor = transform());
        public static void BindMotorInterval(this SliderJoint2D obj, float seconds, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motor = transform());
        public static void BindUseLimits(this SliderJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useLimits = v);
        public static void BindUseLimits<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useLimits = transform(v));
        public static void BindUseLimits(this SliderJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useLimits = transform());
        public static void BindUseLimitsInterval(this SliderJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useLimits = transform());
        public static void BindLimits(this SliderJoint2D obj, IProperty<UnityEngine.JointTranslationLimits2D> property)
            => Bindings2._scope.Bind(property, v => obj.limits = v);
        public static void BindLimits<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointTranslationLimits2D> transform)
            => Bindings2._scope.Bind(property, v => obj.limits = transform(v));
        public static void BindLimits(this SliderJoint2D obj, Func<UnityEngine.JointTranslationLimits2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.limits = transform());
        public static void BindLimitsInterval(this SliderJoint2D obj, float seconds, Func<UnityEngine.JointTranslationLimits2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.limits = transform());
        public static void BindBreakForce(this SliderJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this SliderJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this SliderJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this SliderJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this SliderJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this SliderJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this SliderJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        public static void BindSortingLayerID(this UnityEngine.Rendering.SortingGroup obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.Rendering.SortingGroup obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this UnityEngine.Rendering.SortingGroup obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this UnityEngine.Rendering.SortingGroup obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this UnityEngine.Rendering.SortingGroup obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.Rendering.SortingGroup obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this UnityEngine.Rendering.SortingGroup obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this UnityEngine.Rendering.SortingGroup obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());


        #if UNITY_PHYSICS
        public static void BindIsTrigger(this SphereCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this SphereCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this SphereCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this SphereCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this SphereCollider obj, IProperty<PhysicMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this SphereCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this SphereCollider obj, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this SphereCollider obj, float seconds, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this SphereCollider obj, IProperty<PhysicsMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this SphereCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this SphereCollider obj, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this SphereCollider obj, float seconds, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        public static void BindCenter(this SphereCollider obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this SphereCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this SphereCollider obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this SphereCollider obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this SphereCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this SphereCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this SphereCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this SphereCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this SphereCollider obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this SphereCollider obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindRadius(this SphereCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this SphereCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this SphereCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this SphereCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        #endif


        #if UNITY_PHYSICS
        public static void BindConnectedBody(this SpringJoint obj, IProperty<UnityEngine.Rigidbody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this SpringJoint obj, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this SpringJoint obj, float seconds, Func<UnityEngine.Rigidbody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        #if UNITY_2020_2_OR_NEWER
        public static void BindConnectedArticulationBody(this SpringJoint obj, IProperty<UnityEngine.ArticulationBody> property)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = v);
        public static void BindConnectedArticulationBody<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedArticulationBody = transform(v));
        public static void BindConnectedArticulationBody(this SpringJoint obj, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedArticulationBody = transform());
        public static void BindConnectedArticulationBodyInterval(this SpringJoint obj, float seconds, Func<UnityEngine.ArticulationBody> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedArticulationBody = transform());
        #endif
        public static void BindAnchor(this SpringJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this SpringJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this SpringJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindAnchorLerp(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorLerp(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.Lerp(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAnchorTowards(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = Vector3.MoveTowards(obj.anchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAnchor(this SpringJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.anchor = Vector3.Lerp(start, end, t));
        public static void AnimateAnchor(this SpringJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAnchor(obj, obj.anchor, end, curve);
        public static void BindAxis(this SpringJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.axis = v);
        public static void BindAxis<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.axis = transform(v));
        public static void BindAxis(this SpringJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = transform());
        public static void BindAxisInterval(this SpringJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.axis = transform());
        public static void BindAxisLerp(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisLerp(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.Lerp(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, property.Value, speed * Time.smoothDeltaTime));
        public static void BindAxisTowards(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.axis = Vector3.MoveTowards(obj.axis, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateAxis(this SpringJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.axis = Vector3.Lerp(start, end, t));
        public static void AnimateAxis(this SpringJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateAxis(obj, obj.axis, end, curve);
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this SpringJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindConnectedAnchor(this SpringJoint obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SpringJoint obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this SpringJoint obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this SpringJoint obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorLerp(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorLerp(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.Lerp(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this SpringJoint obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindConnectedAnchorTowards(this SpringJoint obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = Vector3.MoveTowards(obj.connectedAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateConnectedAnchor(this SpringJoint obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.connectedAnchor = Vector3.Lerp(start, end, t));
        public static void AnimateConnectedAnchor(this SpringJoint obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateConnectedAnchor(obj, obj.connectedAnchor, end, curve);
        public static void BindSpring(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.spring = v);
        public static void BindSpring<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.spring = transform(v));
        public static void BindSpring(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.spring = transform());
        public static void BindSpringInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spring = transform());
        public static void BindDamper(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.damper = v);
        public static void BindDamper<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.damper = transform(v));
        public static void BindDamper(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.damper = transform());
        public static void BindDamperInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.damper = transform());
        public static void BindMinDistance(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minDistance = v);
        public static void BindMinDistance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minDistance = transform(v));
        public static void BindMinDistance(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minDistance = transform());
        public static void BindMinDistanceInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minDistance = transform());
        public static void BindMaxDistance(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = v);
        public static void BindMaxDistance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxDistance = transform(v));
        public static void BindMaxDistance(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxDistance = transform());
        public static void BindMaxDistanceInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxDistance = transform());
        public static void BindTolerance(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.tolerance = v);
        public static void BindTolerance<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.tolerance = transform(v));
        public static void BindTolerance(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.tolerance = transform());
        public static void BindToleranceInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.tolerance = transform());
        public static void BindBreakForce(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        public static void BindEnableCollision(this SpringJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this SpringJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this SpringJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindEnablePreprocessing(this SpringJoint obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = v);
        public static void BindEnablePreprocessing<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enablePreprocessing = transform(v));
        public static void BindEnablePreprocessing(this SpringJoint obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enablePreprocessing = transform());
        public static void BindEnablePreprocessingInterval(this SpringJoint obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enablePreprocessing = transform());
        public static void BindMassScale(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.massScale = v);
        public static void BindMassScale<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.massScale = transform(v));
        public static void BindMassScale(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.massScale = transform());
        public static void BindMassScaleInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.massScale = transform());
        public static void BindConnectedMassScale(this SpringJoint obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = v);
        public static void BindConnectedMassScale<T>(this SpringJoint obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedMassScale = transform(v));
        public static void BindConnectedMassScale(this SpringJoint obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedMassScale = transform());
        public static void BindConnectedMassScaleInterval(this SpringJoint obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedMassScale = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this SpringJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this SpringJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this SpringJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this SpringJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this SpringJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this SpringJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this SpringJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this SpringJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this SpringJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this SpringJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this SpringJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this SpringJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this SpringJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this SpringJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindAutoConfigureDistance(this SpringJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureDistance = v);
        public static void BindAutoConfigureDistance<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureDistance = transform(v));
        public static void BindAutoConfigureDistance(this SpringJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureDistance = transform());
        public static void BindAutoConfigureDistanceInterval(this SpringJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureDistance = transform());
        public static void BindDistance(this SpringJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.distance = v);
        public static void BindDistance<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.distance = transform(v));
        public static void BindDistance(this SpringJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.distance = transform());
        public static void BindDistanceInterval(this SpringJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.distance = transform());
        public static void BindDampingRatio(this SpringJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = transform(v));
        public static void BindDampingRatio(this SpringJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dampingRatio = transform());
        public static void BindDampingRatioInterval(this SpringJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dampingRatio = transform());
        public static void BindFrequency(this SpringJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.frequency = v);
        public static void BindFrequency<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.frequency = transform(v));
        public static void BindFrequency(this SpringJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.frequency = transform());
        public static void BindFrequencyInterval(this SpringJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.frequency = transform());
        public static void BindBreakForce(this SpringJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this SpringJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this SpringJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this SpringJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        #endif


        public static void BindSprite(this SpriteMask obj, IProperty<UnityEngine.Sprite> property)
            => Bindings2._scope.Bind(property, v => obj.sprite = v);
        public static void BindSprite<T>(this SpriteMask obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform)
            => Bindings2._scope.Bind(property, v => obj.sprite = transform(v));
        public static void BindSprite(this SpriteMask obj, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindUpdate(() => obj.sprite = transform());
        public static void BindSpriteInterval(this SpriteMask obj, float seconds, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sprite = transform());
        public static void BindAlphaCutoff(this SpriteMask obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.alphaCutoff = v);
        public static void BindAlphaCutoff<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.alphaCutoff = transform(v));
        public static void BindAlphaCutoff(this SpriteMask obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.alphaCutoff = transform());
        public static void BindAlphaCutoffInterval(this SpriteMask obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alphaCutoff = transform());
        public static void BindIsCustomRangeActive(this SpriteMask obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isCustomRangeActive = v);
        public static void BindIsCustomRangeActive<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isCustomRangeActive = transform(v));
        public static void BindIsCustomRangeActive(this SpriteMask obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isCustomRangeActive = transform());
        public static void BindIsCustomRangeActiveInterval(this SpriteMask obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isCustomRangeActive = transform());
        public static void BindFrontSortingOrder(this SpriteMask obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.frontSortingOrder = v);
        public static void BindFrontSortingOrder<T>(this SpriteMask obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.frontSortingOrder = transform(v));
        public static void BindFrontSortingOrder(this SpriteMask obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.frontSortingOrder = transform());
        public static void BindFrontSortingOrderInterval(this SpriteMask obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.frontSortingOrder = transform());


        public static void BindSprite(this SpriteRenderer obj, IProperty<UnityEngine.Sprite> property)
            => Bindings2._scope.Bind(property, v => obj.sprite = v);
        public static void BindSprite<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Sprite> transform)
            => Bindings2._scope.Bind(property, v => obj.sprite = transform(v));
        public static void BindSprite(this SpriteRenderer obj, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindUpdate(() => obj.sprite = transform());
        public static void BindSpriteInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.Sprite> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sprite = transform());
        public static void BindColor(this SpriteRenderer obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this SpriteRenderer obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindFlipX(this SpriteRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.flipX = v);
        public static void BindFlipX<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.flipX = transform(v));
        public static void BindFlipX(this SpriteRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.flipX = transform());
        public static void BindFlipXInterval(this SpriteRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flipX = transform());
        public static void BindFlipY(this SpriteRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.flipY = v);
        public static void BindFlipY<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.flipY = transform(v));
        public static void BindFlipY(this SpriteRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.flipY = transform());
        public static void BindFlipYInterval(this SpriteRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.flipY = transform());
        public static void BindDrawMode(this SpriteRenderer obj, IProperty<UnityEngine.SpriteDrawMode> property)
            => Bindings2._scope.Bind(property, v => obj.drawMode = v);
        public static void BindDrawMode<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteDrawMode> transform)
            => Bindings2._scope.Bind(property, v => obj.drawMode = transform(v));
        public static void BindDrawMode(this SpriteRenderer obj, Func<UnityEngine.SpriteDrawMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.drawMode = transform());
        public static void BindDrawModeInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.SpriteDrawMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.drawMode = transform());
        public static void BindMaskInteraction(this SpriteRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = transform(v));
        public static void BindMaskInteraction(this SpriteRenderer obj, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskInteraction = transform());
        public static void BindMaskInteractionInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskInteraction = transform());
        public static void BindSpriteSortPoint(this SpriteRenderer obj, IProperty<UnityEngine.SpriteSortPoint> property)
            => Bindings2._scope.Bind(property, v => obj.spriteSortPoint = v);
        public static void BindSpriteSortPoint<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteSortPoint> transform)
            => Bindings2._scope.Bind(property, v => obj.spriteSortPoint = transform(v));
        public static void BindSpriteSortPoint(this SpriteRenderer obj, Func<UnityEngine.SpriteSortPoint> transform)
            => Bindings2._scope.BindUpdate(() => obj.spriteSortPoint = transform());
        public static void BindSpriteSortPointInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.SpriteSortPoint> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spriteSortPoint = transform());
        public static void BindSharedMaterials(this SpriteRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this SpriteRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this SpriteRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindSortingLayerID(this SpriteRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this SpriteRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this SpriteRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this SpriteRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this SpriteRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this SpriteRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this SpriteRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());


        #if UNITY_UI
        public static void BindColor(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this UnityEngine.U2D.SpriteShapeRenderer obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this UnityEngine.U2D.SpriteShapeRenderer obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindMaskInteraction(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = transform(v));
        public static void BindMaskInteraction(this UnityEngine.U2D.SpriteShapeRenderer obj, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskInteraction = transform());
        public static void BindMaskInteractionInterval(this UnityEngine.U2D.SpriteShapeRenderer obj, float seconds, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskInteraction = transform());
        public static void BindSharedMaterials(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this UnityEngine.U2D.SpriteShapeRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this UnityEngine.U2D.SpriteShapeRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindSortingLayerID(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this UnityEngine.U2D.SpriteShapeRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this UnityEngine.U2D.SpriteShapeRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.U2D.SpriteShapeRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this UnityEngine.U2D.SpriteShapeRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this UnityEngine.U2D.SpriteShapeRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());
        #endif


        #if UNITY_GUI
        public static void BindHorizontalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalAxis = v.ToString());
        public static void BindHorizontalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalAxis = transform(v));
        public static void BindHorizontalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalAxis = transform().ToString());
        public static void BindHorizontalAxisInterval<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalAxis = transform().ToString());
        public static void BindVerticalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.verticalAxis = v.ToString());
        public static void BindVerticalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalAxis = transform(v));
        public static void BindVerticalAxis<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalAxis = transform().ToString());
        public static void BindVerticalAxisInterval<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalAxis = transform().ToString());
        public static void BindSubmitButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.submitButton = v.ToString());
        public static void BindSubmitButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.submitButton = transform(v));
        public static void BindSubmitButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.submitButton = transform().ToString());
        public static void BindSubmitButtonInterval<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.submitButton = transform().ToString());
        public static void BindCancelButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.cancelButton = v.ToString());
        public static void BindCancelButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.cancelButton = transform(v));
        public static void BindCancelButton<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.cancelButton = transform().ToString());
        public static void BindCancelButtonInterval<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.cancelButton = transform().ToString());
        public static void BindInputActionsPerSecond(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.inputActionsPerSecond = v);
        public static void BindInputActionsPerSecond<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.inputActionsPerSecond = transform(v));
        public static void BindInputActionsPerSecond(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.inputActionsPerSecond = transform());
        public static void BindInputActionsPerSecondInterval(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.inputActionsPerSecond = transform());
        public static void BindRepeatDelay(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.repeatDelay = v);
        public static void BindRepeatDelay<T>(this UnityEngine.EventSystems.StandaloneInputModule obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.repeatDelay = transform(v));
        public static void BindRepeatDelay(this UnityEngine.EventSystems.StandaloneInputModule obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.repeatDelay = transform());
        public static void BindRepeatDelayInterval(this UnityEngine.EventSystems.StandaloneInputModule obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.repeatDelay = transform());
        #endif


        public static void BindStreamingMipmapBias(this StreamingController obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.streamingMipmapBias = v);
        public static void BindStreamingMipmapBias<T>(this StreamingController obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.streamingMipmapBias = transform(v));
        public static void BindStreamingMipmapBias(this StreamingController obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.streamingMipmapBias = transform());
        public static void BindStreamingMipmapBiasInterval(this StreamingController obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.streamingMipmapBias = transform());


        #if UNITY_PHYSICS_2D
        public static void BindUseColliderMask(this SurfaceEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = v);
        public static void BindUseColliderMask<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useColliderMask = transform(v));
        public static void BindUseColliderMask(this SurfaceEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useColliderMask = transform());
        public static void BindUseColliderMaskInterval(this SurfaceEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useColliderMask = transform());
        public static void BindColliderMask(this SurfaceEffector2D obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = v);
        public static void BindColliderMask<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.colliderMask = transform(v));
        public static void BindColliderMask(this SurfaceEffector2D obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.colliderMask = transform());
        public static void BindColliderMaskInterval(this SurfaceEffector2D obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colliderMask = transform());
        public static void BindSpeed(this SurfaceEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.speed = v);
        public static void BindSpeed<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.speed = transform(v));
        public static void BindSpeed(this SurfaceEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.speed = transform());
        public static void BindSpeedInterval(this SurfaceEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.speed = transform());
        public static void BindSpeedVariation(this SurfaceEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.speedVariation = v);
        public static void BindSpeedVariation<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.speedVariation = transform(v));
        public static void BindSpeedVariation(this SurfaceEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.speedVariation = transform());
        public static void BindSpeedVariationInterval(this SurfaceEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.speedVariation = transform());
        public static void BindForceScale(this SurfaceEffector2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceScale = v);
        public static void BindForceScale<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceScale = transform(v));
        public static void BindForceScale(this SurfaceEffector2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceScale = transform());
        public static void BindForceScaleInterval(this SurfaceEffector2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceScale = transform());
        public static void BindUseContactForce(this SurfaceEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useContactForce = v);
        public static void BindUseContactForce<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useContactForce = transform(v));
        public static void BindUseContactForce(this SurfaceEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useContactForce = transform());
        public static void BindUseContactForceInterval(this SurfaceEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useContactForce = transform());
        public static void BindUseFriction(this SurfaceEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useFriction = v);
        public static void BindUseFriction<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useFriction = transform(v));
        public static void BindUseFriction(this SurfaceEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useFriction = transform());
        public static void BindUseFrictionInterval(this SurfaceEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useFriction = transform());
        public static void BindUseBounce(this SurfaceEffector2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useBounce = v);
        public static void BindUseBounce<T>(this SurfaceEffector2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useBounce = transform(v));
        public static void BindUseBounce(this SurfaceEffector2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useBounce = transform());
        public static void BindUseBounceInterval(this SurfaceEffector2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useBounce = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindAnchor(this TargetJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this TargetJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this TargetJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindTarget(this TargetJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.target = v);
        public static void BindTarget<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.target = transform(v));
        public static void BindTarget(this TargetJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.target = transform());
        public static void BindTargetInterval(this TargetJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.target = transform());
        public static void BindAutoConfigureTarget(this TargetJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureTarget = v);
        public static void BindAutoConfigureTarget<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureTarget = transform(v));
        public static void BindAutoConfigureTarget(this TargetJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureTarget = transform());
        public static void BindAutoConfigureTargetInterval(this TargetJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureTarget = transform());
        public static void BindMaxForce(this TargetJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.maxForce = v);
        public static void BindMaxForce<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.maxForce = transform(v));
        public static void BindMaxForce(this TargetJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.maxForce = transform());
        public static void BindMaxForceInterval(this TargetJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maxForce = transform());
        public static void BindDampingRatio(this TargetJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = v);
        public static void BindDampingRatio<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.dampingRatio = transform(v));
        public static void BindDampingRatio(this TargetJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.dampingRatio = transform());
        public static void BindDampingRatioInterval(this TargetJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.dampingRatio = transform());
        public static void BindFrequency(this TargetJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.frequency = v);
        public static void BindFrequency<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.frequency = transform(v));
        public static void BindFrequency(this TargetJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.frequency = transform());
        public static void BindFrequencyInterval(this TargetJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.frequency = transform());
        public static void BindBreakForce(this TargetJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this TargetJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this TargetJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this TargetJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        #endif


        #if UNITY_TERRAIN_PHYSICS
        public static void BindIsTrigger(this TerrainCollider obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this TerrainCollider obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this TerrainCollider obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this TerrainCollider obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        #if !UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this TerrainCollider obj, IProperty<PhysicMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this TerrainCollider obj, IProperty<T> property, Func<T, PhysicMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this TerrainCollider obj, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this TerrainCollider obj, float seconds, Func<PhysicMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        #if UNITY_6000_0_OR_NEWER
        public static void BindSharedMaterial(this TerrainCollider obj, IProperty<PhysicsMaterial> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this TerrainCollider obj, IProperty<T> property, Func<T, PhysicsMaterial> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this TerrainCollider obj, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this TerrainCollider obj, float seconds, Func<PhysicsMaterial> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        #endif
        public static void BindTerrainData(this TerrainCollider obj, IProperty<UnityEngine.TerrainData> property)
            => Bindings2._scope.Bind(property, v => obj.terrainData = v);
        public static void BindTerrainData<T>(this TerrainCollider obj, IProperty<T> property, Func<T, UnityEngine.TerrainData> transform)
            => Bindings2._scope.Bind(property, v => obj.terrainData = transform(v));
        public static void BindTerrainData(this TerrainCollider obj, Func<UnityEngine.TerrainData> transform)
            => Bindings2._scope.BindUpdate(() => obj.terrainData = transform());
        public static void BindTerrainDataInterval(this TerrainCollider obj, float seconds, Func<UnityEngine.TerrainData> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.terrainData = transform());
        #endif


        #if UNITY_GUI
        public static void BindText<T>(this UnityEngine.UI.Text obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this UnityEngine.UI.Text obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this UnityEngine.UI.Text obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindFont(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Font> property)
            => Bindings2._scope.Bind(property, v => obj.font = v);
        public static void BindFont<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Font> transform)
            => Bindings2._scope.Bind(property, v => obj.font = transform(v));
        public static void BindFont(this UnityEngine.UI.Text obj, Func<UnityEngine.Font> transform)
            => Bindings2._scope.BindUpdate(() => obj.font = transform());
        public static void BindFontInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.Font> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.font = transform());
        public static void BindFontStyle(this UnityEngine.UI.Text obj, IProperty<UnityEngine.FontStyle> property)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.FontStyle> transform)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = transform(v));
        public static void BindFontStyle(this UnityEngine.UI.Text obj, Func<UnityEngine.FontStyle> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontStyle = transform());
        public static void BindFontStyleInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.FontStyle> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontStyle = transform());
        public static void BindFontSize(this UnityEngine.UI.Text obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.fontSize = transform(v));
        public static void BindFontSize(this UnityEngine.UI.Text obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontSize = transform());
        public static void BindFontSizeInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontSize = transform());
        public static void BindLineSpacing(this UnityEngine.UI.Text obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = transform(v));
        public static void BindLineSpacing(this UnityEngine.UI.Text obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineSpacing = transform());
        public static void BindLineSpacingInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineSpacing = transform());
        public static void BindSupportRichText(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.supportRichText = v);
        public static void BindSupportRichText<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.supportRichText = transform(v));
        public static void BindSupportRichText(this UnityEngine.UI.Text obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.supportRichText = transform());
        public static void BindSupportRichTextInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.supportRichText = transform());
        public static void BindAlignment(this UnityEngine.UI.Text obj, IProperty<UnityEngine.TextAnchor> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this UnityEngine.UI.Text obj, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        public static void BindAlignByGeometry(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.alignByGeometry = v);
        public static void BindAlignByGeometry<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.alignByGeometry = transform(v));
        public static void BindAlignByGeometry(this UnityEngine.UI.Text obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignByGeometry = transform());
        public static void BindAlignByGeometryInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignByGeometry = transform());
        public static void BindHorizontalOverflow(this UnityEngine.UI.Text obj, IProperty<UnityEngine.HorizontalWrapMode> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalOverflow = v);
        public static void BindHorizontalOverflow<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.HorizontalWrapMode> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalOverflow = transform(v));
        public static void BindHorizontalOverflow(this UnityEngine.UI.Text obj, Func<UnityEngine.HorizontalWrapMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalOverflow = transform());
        public static void BindHorizontalOverflowInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.HorizontalWrapMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalOverflow = transform());
        public static void BindVerticalOverflow(this UnityEngine.UI.Text obj, IProperty<UnityEngine.VerticalWrapMode> property)
            => Bindings2._scope.Bind(property, v => obj.verticalOverflow = v);
        public static void BindVerticalOverflow<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.VerticalWrapMode> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalOverflow = transform(v));
        public static void BindVerticalOverflow(this UnityEngine.UI.Text obj, Func<UnityEngine.VerticalWrapMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalOverflow = transform());
        public static void BindVerticalOverflowInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.VerticalWrapMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalOverflow = transform());
        public static void BindResizeTextForBestFit(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.resizeTextForBestFit = v);
        public static void BindResizeTextForBestFit<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.resizeTextForBestFit = transform(v));
        public static void BindResizeTextForBestFit(this UnityEngine.UI.Text obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.resizeTextForBestFit = transform());
        public static void BindResizeTextForBestFitInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.resizeTextForBestFit = transform());
        public static void BindColor(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this UnityEngine.UI.Text obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindRaycastTarget(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = v);
        public static void BindRaycastTarget<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastTarget = transform(v));
        public static void BindRaycastTarget(this UnityEngine.UI.Text obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastTarget = transform());
        public static void BindRaycastTargetInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastTarget = transform());
        #if UNITY_2020_1_OR_NEWER
        public static void BindRaycastPadding(this UnityEngine.UI.Text obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = v);
        public static void BindRaycastPadding<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.raycastPadding = transform(v));
        public static void BindRaycastPadding(this UnityEngine.UI.Text obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.raycastPadding = transform());
        public static void BindRaycastPaddingInterval(this UnityEngine.UI.Text obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.raycastPadding = transform());
        #endif
        public static void BindMaskable(this UnityEngine.UI.Text obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.maskable = v);
        public static void BindMaskable<T>(this UnityEngine.UI.Text obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.maskable = transform(v));
        public static void BindMaskable(this UnityEngine.UI.Text obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskable = transform());
        public static void BindMaskableInterval(this UnityEngine.UI.Text obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskable = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindAnchorPosition(this TMPro.TextContainer obj, IProperty<TMPro.TextContainerAnchors> property)
            => Bindings2._scope.Bind(property, v => obj.anchorPosition = v);
        public static void BindAnchorPosition<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, TMPro.TextContainerAnchors> transform)
            => Bindings2._scope.Bind(property, v => obj.anchorPosition = transform(v));
        public static void BindAnchorPosition(this TMPro.TextContainer obj, Func<TMPro.TextContainerAnchors> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchorPosition = transform());
        public static void BindAnchorPositionInterval(this TMPro.TextContainer obj, float seconds, Func<TMPro.TextContainerAnchors> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchorPosition = transform());
        public static void BindWidth(this TMPro.TextContainer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.width = v);
        public static void BindWidth<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.width = transform(v));
        public static void BindWidth(this TMPro.TextContainer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.width = transform());
        public static void BindWidthInterval(this TMPro.TextContainer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.width = transform());
        public static void BindHeight(this TMPro.TextContainer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.height = v);
        public static void BindHeight<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.height = transform(v));
        public static void BindHeight(this TMPro.TextContainer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.height = transform());
        public static void BindHeightInterval(this TMPro.TextContainer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.height = transform());
        public static void BindMargins(this TMPro.TextContainer obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.margins = v);
        public static void BindMargins<T>(this TMPro.TextContainer obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.margins = transform(v));
        public static void BindMargins(this TMPro.TextContainer obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.margins = transform());
        public static void BindMarginsInterval(this TMPro.TextContainer obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.margins = transform());
        #endif


        public static void BindText<T>(this TextMesh obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this TextMesh obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this TextMesh obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this TextMesh obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindOffsetZ(this TextMesh obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.offsetZ = v);
        public static void BindOffsetZ<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.offsetZ = transform(v));
        public static void BindOffsetZ(this TextMesh obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.offsetZ = transform());
        public static void BindOffsetZInterval(this TextMesh obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offsetZ = transform());
        public static void BindCharacterSize(this TextMesh obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.characterSize = v);
        public static void BindCharacterSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.characterSize = transform(v));
        public static void BindCharacterSize(this TextMesh obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.characterSize = transform());
        public static void BindCharacterSizeInterval(this TextMesh obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.characterSize = transform());
        public static void BindLineSpacing(this TextMesh obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = transform(v));
        public static void BindLineSpacing(this TextMesh obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineSpacing = transform());
        public static void BindLineSpacingInterval(this TextMesh obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineSpacing = transform());
        public static void BindAnchor(this TextMesh obj, IProperty<UnityEngine.TextAnchor> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.TextAnchor> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this TextMesh obj, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this TextMesh obj, float seconds, Func<UnityEngine.TextAnchor> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindAlignment(this TextMesh obj, IProperty<UnityEngine.TextAlignment> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.TextAlignment> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this TextMesh obj, Func<UnityEngine.TextAlignment> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this TextMesh obj, float seconds, Func<UnityEngine.TextAlignment> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        public static void BindTabSize(this TextMesh obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.tabSize = v);
        public static void BindTabSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.tabSize = transform(v));
        public static void BindTabSize(this TextMesh obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.tabSize = transform());
        public static void BindTabSizeInterval(this TextMesh obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.tabSize = transform());
        public static void BindFontSize(this TextMesh obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.fontSize = transform(v));
        public static void BindFontSize(this TextMesh obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontSize = transform());
        public static void BindFontSizeInterval(this TextMesh obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontSize = transform());
        public static void BindFontStyle(this TextMesh obj, IProperty<UnityEngine.FontStyle> property)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.FontStyle> transform)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = transform(v));
        public static void BindFontStyle(this TextMesh obj, Func<UnityEngine.FontStyle> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontStyle = transform());
        public static void BindFontStyleInterval(this TextMesh obj, float seconds, Func<UnityEngine.FontStyle> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontStyle = transform());
        public static void BindRichText(this TextMesh obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.richText = v);
        public static void BindRichText<T>(this TextMesh obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.richText = transform(v));
        public static void BindRichText(this TextMesh obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.richText = transform());
        public static void BindRichTextInterval(this TextMesh obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.richText = transform());
        public static void BindFont(this TextMesh obj, IProperty<UnityEngine.Font> property)
            => Bindings2._scope.Bind(property, v => obj.font = v);
        public static void BindFont<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.Font> transform)
            => Bindings2._scope.Bind(property, v => obj.font = transform(v));
        public static void BindFont(this TextMesh obj, Func<UnityEngine.Font> transform)
            => Bindings2._scope.BindUpdate(() => obj.font = transform());
        public static void BindFontInterval(this TextMesh obj, float seconds, Func<UnityEngine.Font> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.font = transform());
        public static void BindColor(this TextMesh obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this TextMesh obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this TextMesh obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this TextMesh obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());


        #if UNITY_TMPRO
        public static void BindText<T>(this TMPro.TextMeshPro obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this TMPro.TextMeshPro obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this TMPro.TextMeshPro obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindFont(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_FontAsset> property)
            => Bindings2._scope.Bind(property, v => obj.font = v);
        public static void BindFont<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.font = transform(v));
        public static void BindFont(this TMPro.TextMeshPro obj, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.font = transform());
        public static void BindFontInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.font = transform());
        public static void BindFontStyle(this TMPro.TextMeshPro obj, IProperty<TMPro.FontStyles> property)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.FontStyles> transform)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = transform(v));
        public static void BindFontStyle(this TMPro.TextMeshPro obj, Func<TMPro.FontStyles> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontStyle = transform());
        public static void BindFontStyleInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.FontStyles> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontStyle = transform());
        public static void BindFontSize(this TMPro.TextMeshPro obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fontSize = transform(v));
        public static void BindFontSize(this TMPro.TextMeshPro obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontSize = transform());
        public static void BindFontSizeInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontSize = transform());
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoSizeTextContainer = v);
        public static void BindAutoSizeTextContainer<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoSizeTextContainer = transform(v));
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoSizeTextContainer = transform());
        public static void BindAutoSizeTextContainerInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoSizeTextContainer = transform());
        public static void BindColor(this TMPro.TextMeshPro obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this TMPro.TextMeshPro obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this TMPro.TextMeshPro obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindColorGradientPreset(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_ColorGradient> property)
            => Bindings2._scope.Bind(property, v => obj.colorGradientPreset = v);
        public static void BindColorGradientPreset<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.Bind(property, v => obj.colorGradientPreset = transform(v));
        public static void BindColorGradientPreset(this TMPro.TextMeshPro obj, Func<TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.BindUpdate(() => obj.colorGradientPreset = transform());
        public static void BindColorGradientPresetInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colorGradientPreset = transform());
        public static void BindColorGradient(this TMPro.TextMeshPro obj, IProperty<TMPro.VertexGradient> property)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.VertexGradient> transform)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = transform(v));
        public static void BindColorGradient(this TMPro.TextMeshPro obj, Func<TMPro.VertexGradient> transform)
            => Bindings2._scope.BindUpdate(() => obj.colorGradient = transform());
        public static void BindColorGradientInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.VertexGradient> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colorGradient = transform());
        public static void BindOverrideColorTags(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.overrideColorTags = v);
        public static void BindOverrideColorTags<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.overrideColorTags = transform(v));
        public static void BindOverrideColorTags(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.overrideColorTags = transform());
        public static void BindOverrideColorTagsInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.overrideColorTags = transform());
        public static void BindCharacterSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.characterSpacing = v);
        public static void BindCharacterSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.characterSpacing = transform(v));
        public static void BindCharacterSpacing(this TMPro.TextMeshPro obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.characterSpacing = transform());
        public static void BindCharacterSpacingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.characterSpacing = transform());
        public static void BindWordSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wordSpacing = v);
        public static void BindWordSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wordSpacing = transform(v));
        public static void BindWordSpacing(this TMPro.TextMeshPro obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wordSpacing = transform());
        public static void BindWordSpacingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wordSpacing = transform());
        public static void BindLineSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = transform(v));
        public static void BindLineSpacing(this TMPro.TextMeshPro obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineSpacing = transform());
        public static void BindLineSpacingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineSpacing = transform());
        public static void BindParagraphSpacing(this TMPro.TextMeshPro obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.paragraphSpacing = v);
        public static void BindParagraphSpacing<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.paragraphSpacing = transform(v));
        public static void BindParagraphSpacing(this TMPro.TextMeshPro obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.paragraphSpacing = transform());
        public static void BindParagraphSpacingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.paragraphSpacing = transform());
        public static void BindAlignment(this TMPro.TextMeshPro obj, IProperty<TMPro.TextAlignmentOptions> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this TMPro.TextMeshPro obj, Func<TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableWordWrapping(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableWordWrapping = v);
        public static void BindEnableWordWrapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableWordWrapping = transform(v));
        public static void BindEnableWordWrapping(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableWordWrapping = transform());
        public static void BindEnableWordWrappingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableWordWrapping = transform());
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindTextWrappingMode(this TMPro.TextMeshPro obj, IProperty<TMPro.TextWrappingModes> property)
            => Bindings2._scope.Bind(property, v => obj.textWrappingMode = v);
        public static void BindTextWrappingMode<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextWrappingModes> transform)
            => Bindings2._scope.Bind(property, v => obj.textWrappingMode = transform(v));
        public static void BindTextWrappingMode(this TMPro.TextMeshPro obj, Func<TMPro.TextWrappingModes> transform)
            => Bindings2._scope.BindUpdate(() => obj.textWrappingMode = transform());
        public static void BindTextWrappingModeInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TextWrappingModes> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textWrappingMode = transform());
        #endif
        public static void BindOverflowMode(this TMPro.TextMeshPro obj, IProperty<TMPro.TextOverflowModes> property)
            => Bindings2._scope.Bind(property, v => obj.overflowMode = v);
        public static void BindOverflowMode<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextOverflowModes> transform)
            => Bindings2._scope.Bind(property, v => obj.overflowMode = transform(v));
        public static void BindOverflowMode(this TMPro.TextMeshPro obj, Func<TMPro.TextOverflowModes> transform)
            => Bindings2._scope.BindUpdate(() => obj.overflowMode = transform());
        public static void BindOverflowModeInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TextOverflowModes> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.overflowMode = transform());
        public static void BindHorizontalMapping(this TMPro.TextMeshPro obj, IProperty<TMPro.TextureMappingOptions> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalMapping = v);
        public static void BindHorizontalMapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalMapping = transform(v));
        public static void BindHorizontalMapping(this TMPro.TextMeshPro obj, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalMapping = transform());
        public static void BindHorizontalMappingInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalMapping = transform());
        public static void BindVerticalMapping(this TMPro.TextMeshPro obj, IProperty<TMPro.TextureMappingOptions> property)
            => Bindings2._scope.Bind(property, v => obj.verticalMapping = v);
        public static void BindVerticalMapping<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalMapping = transform(v));
        public static void BindVerticalMapping(this TMPro.TextMeshPro obj, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalMapping = transform());
        public static void BindVerticalMappingInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalMapping = transform());
        public static void BindMargin(this TMPro.TextMeshPro obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.margin = v);
        public static void BindMargin<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.margin = transform(v));
        public static void BindMargin(this TMPro.TextMeshPro obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.margin = transform());
        public static void BindMarginInterval(this TMPro.TextMeshPro obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.margin = transform());
        public static void BindSortingLayerID(this TMPro.TextMeshPro obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this TMPro.TextMeshPro obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this TMPro.TextMeshPro obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this TMPro.TextMeshPro obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());
        public static void BindGeometrySortingOrder(this TMPro.TextMeshPro obj, IProperty<TMPro.VertexSortingOrder> property)
            => Bindings2._scope.Bind(property, v => obj.geometrySortingOrder = v);
        public static void BindGeometrySortingOrder<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.Bind(property, v => obj.geometrySortingOrder = transform(v));
        public static void BindGeometrySortingOrder(this TMPro.TextMeshPro obj, Func<TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.BindUpdate(() => obj.geometrySortingOrder = transform());
        public static void BindGeometrySortingOrderInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.geometrySortingOrder = transform());
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTextObjectScaleStatic = v);
        public static void BindIsTextObjectScaleStatic<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTextObjectScaleStatic = transform(v));
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTextObjectScaleStatic = transform());
        public static void BindIsTextObjectScaleStaticInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTextObjectScaleStatic = transform());
        public static void BindIsOrthographic(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isOrthographic = v);
        public static void BindIsOrthographic<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isOrthographic = transform(v));
        public static void BindIsOrthographic(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isOrthographic = transform());
        public static void BindIsOrthographicInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isOrthographic = transform());
        public static void BindRichText(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.richText = transform(v));
        public static void BindRichText(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.richText = transform());
        public static void BindRichTextInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.richText = transform());
        public static void BindParseCtrlCharacters(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.parseCtrlCharacters = v);
        public static void BindParseCtrlCharacters<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.parseCtrlCharacters = transform(v));
        public static void BindParseCtrlCharacters(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.parseCtrlCharacters = transform());
        public static void BindParseCtrlCharactersInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.parseCtrlCharacters = transform());
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMaxVisibleDescender = v);
        public static void BindUseMaxVisibleDescender<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMaxVisibleDescender = transform(v));
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMaxVisibleDescender = transform());
        public static void BindUseMaxVisibleDescenderInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMaxVisibleDescender = transform());
        public static void BindSpriteAsset(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_SpriteAsset> property)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TextMeshPro obj, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.spriteAsset = transform());
        public static void BindSpriteAssetInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spriteAsset = transform());
        public static void BindStyleSheet(this TMPro.TextMeshPro obj, IProperty<TMPro.TMP_StyleSheet> property)
            => Bindings2._scope.Bind(property, v => obj.styleSheet = v);
        public static void BindStyleSheet<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.Bind(property, v => obj.styleSheet = transform(v));
        public static void BindStyleSheet(this TMPro.TextMeshPro obj, Func<TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.BindUpdate(() => obj.styleSheet = transform());
        public static void BindStyleSheetInterval(this TMPro.TextMeshPro obj, float seconds, Func<TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.styleSheet = transform());
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableKerning(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableKerning = v);
        public static void BindEnableKerning<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableKerning = transform(v));
        public static void BindEnableKerning(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableKerning = transform());
        public static void BindEnableKerningInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableKerning = transform());
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindFontFeatures(this TMPro.TextMeshPro obj, IProperty<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> property)
            => Bindings2._scope.Bind(property, v => obj.fontFeatures = v);
        public static void BindFontFeatures<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.Bind(property, v => obj.fontFeatures = transform(v));
        public static void BindFontFeatures(this TMPro.TextMeshPro obj, Func<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontFeatures = transform());
        public static void BindFontFeaturesInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontFeatures = transform());
        #endif
        public static void BindExtraPadding(this TMPro.TextMeshPro obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.extraPadding = v);
        public static void BindExtraPadding<T>(this TMPro.TextMeshPro obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.extraPadding = transform(v));
        public static void BindExtraPadding(this TMPro.TextMeshPro obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.extraPadding = transform());
        public static void BindExtraPaddingInterval(this TMPro.TextMeshPro obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.extraPadding = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindText<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this TMPro.TextMeshProUGUI obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this TMPro.TextMeshProUGUI obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindFont(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_FontAsset> property)
            => Bindings2._scope.Bind(property, v => obj.font = v);
        public static void BindFont<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.font = transform(v));
        public static void BindFont(this TMPro.TextMeshProUGUI obj, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.font = transform());
        public static void BindFontInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.font = transform());
        public static void BindFontStyle(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.FontStyles> property)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = v);
        public static void BindFontStyle<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.FontStyles> transform)
            => Bindings2._scope.Bind(property, v => obj.fontStyle = transform(v));
        public static void BindFontStyle(this TMPro.TextMeshProUGUI obj, Func<TMPro.FontStyles> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontStyle = transform());
        public static void BindFontStyleInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.FontStyles> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontStyle = transform());
        public static void BindFontSize(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.fontSize = v);
        public static void BindFontSize<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.fontSize = transform(v));
        public static void BindFontSize(this TMPro.TextMeshProUGUI obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontSize = transform());
        public static void BindFontSizeInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontSize = transform());
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoSizeTextContainer = v);
        public static void BindAutoSizeTextContainer<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoSizeTextContainer = transform(v));
        public static void BindAutoSizeTextContainer(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoSizeTextContainer = transform());
        public static void BindAutoSizeTextContainerInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoSizeTextContainer = transform());
        public static void BindColor(this TMPro.TextMeshProUGUI obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this TMPro.TextMeshProUGUI obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindColorGradientPreset(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_ColorGradient> property)
            => Bindings2._scope.Bind(property, v => obj.colorGradientPreset = v);
        public static void BindColorGradientPreset<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.Bind(property, v => obj.colorGradientPreset = transform(v));
        public static void BindColorGradientPreset(this TMPro.TextMeshProUGUI obj, Func<TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.BindUpdate(() => obj.colorGradientPreset = transform());
        public static void BindColorGradientPresetInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TMP_ColorGradient> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colorGradientPreset = transform());
        public static void BindColorGradient(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.VertexGradient> property)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.VertexGradient> transform)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = transform(v));
        public static void BindColorGradient(this TMPro.TextMeshProUGUI obj, Func<TMPro.VertexGradient> transform)
            => Bindings2._scope.BindUpdate(() => obj.colorGradient = transform());
        public static void BindColorGradientInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.VertexGradient> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colorGradient = transform());
        public static void BindOverrideColorTags(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.overrideColorTags = v);
        public static void BindOverrideColorTags<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.overrideColorTags = transform(v));
        public static void BindOverrideColorTags(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.overrideColorTags = transform());
        public static void BindOverrideColorTagsInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.overrideColorTags = transform());
        public static void BindCharacterSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.characterSpacing = v);
        public static void BindCharacterSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.characterSpacing = transform(v));
        public static void BindCharacterSpacing(this TMPro.TextMeshProUGUI obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.characterSpacing = transform());
        public static void BindCharacterSpacingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.characterSpacing = transform());
        public static void BindWordSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wordSpacing = v);
        public static void BindWordSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wordSpacing = transform(v));
        public static void BindWordSpacing(this TMPro.TextMeshProUGUI obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wordSpacing = transform());
        public static void BindWordSpacingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wordSpacing = transform());
        public static void BindLineSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = v);
        public static void BindLineSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.lineSpacing = transform(v));
        public static void BindLineSpacing(this TMPro.TextMeshProUGUI obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineSpacing = transform());
        public static void BindLineSpacingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineSpacing = transform());
        public static void BindParagraphSpacing(this TMPro.TextMeshProUGUI obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.paragraphSpacing = v);
        public static void BindParagraphSpacing<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.paragraphSpacing = transform(v));
        public static void BindParagraphSpacing(this TMPro.TextMeshProUGUI obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.paragraphSpacing = transform());
        public static void BindParagraphSpacingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.paragraphSpacing = transform());
        public static void BindAlignment(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextAlignmentOptions> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this TMPro.TextMeshProUGUI obj, Func<TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TextAlignmentOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableWordWrapping(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableWordWrapping = v);
        public static void BindEnableWordWrapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableWordWrapping = transform(v));
        public static void BindEnableWordWrapping(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableWordWrapping = transform());
        public static void BindEnableWordWrappingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableWordWrapping = transform());
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindTextWrappingMode(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextWrappingModes> property)
            => Bindings2._scope.Bind(property, v => obj.textWrappingMode = v);
        public static void BindTextWrappingMode<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextWrappingModes> transform)
            => Bindings2._scope.Bind(property, v => obj.textWrappingMode = transform(v));
        public static void BindTextWrappingMode(this TMPro.TextMeshProUGUI obj, Func<TMPro.TextWrappingModes> transform)
            => Bindings2._scope.BindUpdate(() => obj.textWrappingMode = transform());
        public static void BindTextWrappingModeInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TextWrappingModes> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textWrappingMode = transform());
        #endif
        public static void BindOverflowMode(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextOverflowModes> property)
            => Bindings2._scope.Bind(property, v => obj.overflowMode = v);
        public static void BindOverflowMode<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextOverflowModes> transform)
            => Bindings2._scope.Bind(property, v => obj.overflowMode = transform(v));
        public static void BindOverflowMode(this TMPro.TextMeshProUGUI obj, Func<TMPro.TextOverflowModes> transform)
            => Bindings2._scope.BindUpdate(() => obj.overflowMode = transform());
        public static void BindOverflowModeInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TextOverflowModes> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.overflowMode = transform());
        public static void BindHorizontalMapping(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextureMappingOptions> property)
            => Bindings2._scope.Bind(property, v => obj.horizontalMapping = v);
        public static void BindHorizontalMapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.horizontalMapping = transform(v));
        public static void BindHorizontalMapping(this TMPro.TextMeshProUGUI obj, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.horizontalMapping = transform());
        public static void BindHorizontalMappingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.horizontalMapping = transform());
        public static void BindVerticalMapping(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TextureMappingOptions> property)
            => Bindings2._scope.Bind(property, v => obj.verticalMapping = v);
        public static void BindVerticalMapping<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalMapping = transform(v));
        public static void BindVerticalMapping(this TMPro.TextMeshProUGUI obj, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalMapping = transform());
        public static void BindVerticalMappingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TextureMappingOptions> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalMapping = transform());
        public static void BindMargin(this TMPro.TextMeshProUGUI obj, IProperty<UnityEngine.Vector4> property)
            => Bindings2._scope.Bind(property, v => obj.margin = v);
        public static void BindMargin<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, UnityEngine.Vector4> transform)
            => Bindings2._scope.Bind(property, v => obj.margin = transform(v));
        public static void BindMargin(this TMPro.TextMeshProUGUI obj, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindUpdate(() => obj.margin = transform());
        public static void BindMarginInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<UnityEngine.Vector4> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.margin = transform());
        public static void BindGeometrySortingOrder(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.VertexSortingOrder> property)
            => Bindings2._scope.Bind(property, v => obj.geometrySortingOrder = v);
        public static void BindGeometrySortingOrder<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.Bind(property, v => obj.geometrySortingOrder = transform(v));
        public static void BindGeometrySortingOrder(this TMPro.TextMeshProUGUI obj, Func<TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.BindUpdate(() => obj.geometrySortingOrder = transform());
        public static void BindGeometrySortingOrderInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.VertexSortingOrder> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.geometrySortingOrder = transform());
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTextObjectScaleStatic = v);
        public static void BindIsTextObjectScaleStatic<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTextObjectScaleStatic = transform(v));
        public static void BindIsTextObjectScaleStatic(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTextObjectScaleStatic = transform());
        public static void BindIsTextObjectScaleStaticInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTextObjectScaleStatic = transform());
        public static void BindIsOrthographic(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isOrthographic = v);
        public static void BindIsOrthographic<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isOrthographic = transform(v));
        public static void BindIsOrthographic(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isOrthographic = transform());
        public static void BindIsOrthographicInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isOrthographic = transform());
        public static void BindRichText(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.richText = transform(v));
        public static void BindRichText(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.richText = transform());
        public static void BindRichTextInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.richText = transform());
        public static void BindParseCtrlCharacters(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.parseCtrlCharacters = v);
        public static void BindParseCtrlCharacters<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.parseCtrlCharacters = transform(v));
        public static void BindParseCtrlCharacters(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.parseCtrlCharacters = transform());
        public static void BindParseCtrlCharactersInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.parseCtrlCharacters = transform());
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMaxVisibleDescender = v);
        public static void BindUseMaxVisibleDescender<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMaxVisibleDescender = transform(v));
        public static void BindUseMaxVisibleDescender(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMaxVisibleDescender = transform());
        public static void BindUseMaxVisibleDescenderInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMaxVisibleDescender = transform());
        public static void BindSpriteAsset(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_SpriteAsset> property)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TextMeshProUGUI obj, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.spriteAsset = transform());
        public static void BindSpriteAssetInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spriteAsset = transform());
        public static void BindStyleSheet(this TMPro.TextMeshProUGUI obj, IProperty<TMPro.TMP_StyleSheet> property)
            => Bindings2._scope.Bind(property, v => obj.styleSheet = v);
        public static void BindStyleSheet<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.Bind(property, v => obj.styleSheet = transform(v));
        public static void BindStyleSheet(this TMPro.TextMeshProUGUI obj, Func<TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.BindUpdate(() => obj.styleSheet = transform());
        public static void BindStyleSheetInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<TMPro.TMP_StyleSheet> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.styleSheet = transform());
        #if !UNITY_2023_2_OR_NEWER
        public static void BindEnableKerning(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableKerning = v);
        public static void BindEnableKerning<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableKerning = transform(v));
        public static void BindEnableKerning(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableKerning = transform());
        public static void BindEnableKerningInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableKerning = transform());
        #endif
        #if UNITY_2023_2_OR_NEWER
        public static void BindFontFeatures(this TMPro.TextMeshProUGUI obj, IProperty<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> property)
            => Bindings2._scope.Bind(property, v => obj.fontFeatures = v);
        public static void BindFontFeatures<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.Bind(property, v => obj.fontFeatures = transform(v));
        public static void BindFontFeatures(this TMPro.TextMeshProUGUI obj, Func<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontFeatures = transform());
        public static void BindFontFeaturesInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag>> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontFeatures = transform());
        #endif
        public static void BindExtraPadding(this TMPro.TextMeshProUGUI obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.extraPadding = v);
        public static void BindExtraPadding<T>(this TMPro.TextMeshProUGUI obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.extraPadding = transform(v));
        public static void BindExtraPadding(this TMPro.TextMeshProUGUI obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.extraPadding = transform());
        public static void BindExtraPaddingInterval(this TMPro.TextMeshProUGUI obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.extraPadding = transform());
        #endif


        #if UNITY_TILEMAP
        public static void BindAnimationFrameRate(this UnityEngine.Tilemaps.Tilemap obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.animationFrameRate = v);
        public static void BindAnimationFrameRate<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.animationFrameRate = transform(v));
        public static void BindAnimationFrameRate(this UnityEngine.Tilemaps.Tilemap obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.animationFrameRate = transform());
        public static void BindAnimationFrameRateInterval(this UnityEngine.Tilemaps.Tilemap obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.animationFrameRate = transform());
        public static void BindColor(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.color = v);
        public static void BindColor<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.color = transform(v));
        public static void BindColor(this UnityEngine.Tilemaps.Tilemap obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.color = transform());
        public static void BindColorInterval(this UnityEngine.Tilemaps.Tilemap obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.color = transform());
        public static void BindTileAnchor(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.tileAnchor = v);
        public static void BindTileAnchor<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.tileAnchor = transform(v));
        public static void BindTileAnchor(this UnityEngine.Tilemaps.Tilemap obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.tileAnchor = transform());
        public static void BindTileAnchorInterval(this UnityEngine.Tilemaps.Tilemap obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.tileAnchor = transform());
        public static void BindTileAnchorLerp(this UnityEngine.Tilemaps.Tilemap obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.tileAnchor = Vector3.Lerp(obj.tileAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTileAnchorLerp(this UnityEngine.Tilemaps.Tilemap obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.tileAnchor = Vector3.Lerp(obj.tileAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void BindTileAnchorTowards(this UnityEngine.Tilemaps.Tilemap obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.tileAnchor = Vector3.MoveTowards(obj.tileAnchor, property.Value, speed * Time.smoothDeltaTime));
        public static void BindTileAnchorTowards(this UnityEngine.Tilemaps.Tilemap obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.tileAnchor = Vector3.MoveTowards(obj.tileAnchor, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateTileAnchor(this UnityEngine.Tilemaps.Tilemap obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.tileAnchor = Vector3.Lerp(start, end, t));
        public static void AnimateTileAnchor(this UnityEngine.Tilemaps.Tilemap obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateTileAnchor(obj, obj.tileAnchor, end, curve);
        public static void BindOrientation(this UnityEngine.Tilemaps.Tilemap obj, IProperty<UnityEngine.Tilemaps.Tilemap.Orientation> property)
            => Bindings2._scope.Bind(property, v => obj.orientation = v);
        public static void BindOrientation<T>(this UnityEngine.Tilemaps.Tilemap obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.Tilemap.Orientation> transform)
            => Bindings2._scope.Bind(property, v => obj.orientation = transform(v));
        public static void BindOrientation(this UnityEngine.Tilemaps.Tilemap obj, Func<UnityEngine.Tilemaps.Tilemap.Orientation> transform)
            => Bindings2._scope.BindUpdate(() => obj.orientation = transform());
        public static void BindOrientationInterval(this UnityEngine.Tilemaps.Tilemap obj, float seconds, Func<UnityEngine.Tilemaps.Tilemap.Orientation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.orientation = transform());
        #endif


        #if UNITY_TILEMAP
        public static void BindMaximumTileChangeCount(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.UInt32> property)
            => Bindings2._scope.Bind(property, v => obj.maximumTileChangeCount = v);
        public static void BindMaximumTileChangeCount<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.UInt32> transform)
            => Bindings2._scope.Bind(property, v => obj.maximumTileChangeCount = transform(v));
        public static void BindMaximumTileChangeCount(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<System.UInt32> transform)
            => Bindings2._scope.BindUpdate(() => obj.maximumTileChangeCount = transform());
        public static void BindMaximumTileChangeCountInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<System.UInt32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maximumTileChangeCount = transform());
        public static void BindExtrusionFactor(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.extrusionFactor = v);
        public static void BindExtrusionFactor<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.extrusionFactor = transform(v));
        public static void BindExtrusionFactor(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.extrusionFactor = transform());
        public static void BindExtrusionFactorInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.extrusionFactor = transform());
        public static void BindSharedMaterial(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.PhysicsMaterial2D> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = v);
        public static void BindSharedMaterial<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterial = transform(v));
        public static void BindSharedMaterial(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterial = transform());
        public static void BindSharedMaterialInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<UnityEngine.PhysicsMaterial2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterial = transform());
        public static void BindIsTrigger(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = v);
        public static void BindIsTrigger<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isTrigger = transform(v));
        public static void BindIsTrigger(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isTrigger = transform());
        public static void BindIsTriggerInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isTrigger = transform());
        public static void BindUsedByEffector(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = v);
        public static void BindUsedByEffector<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByEffector = transform(v));
        public static void BindUsedByEffector(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByEffector = transform());
        public static void BindUsedByEffectorInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByEffector = transform());
        #if !UNITY_2023_1_OR_NEWER
        public static void BindUsedByComposite(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = v);
        public static void BindUsedByComposite<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.usedByComposite = transform(v));
        public static void BindUsedByComposite(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.usedByComposite = transform());
        public static void BindUsedByCompositeInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.usedByComposite = transform());
        #endif
        #if UNITY_2023_1_OR_NEWER
        public static void BindCompositeOperation(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.Collider2D.CompositeOperation> property)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = v);
        public static void BindCompositeOperation<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.Bind(property, v => obj.compositeOperation = transform(v));
        public static void BindCompositeOperation(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindUpdate(() => obj.compositeOperation = transform());
        public static void BindCompositeOperationInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<UnityEngine.Collider2D.CompositeOperation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.compositeOperation = transform());
        #endif
        public static void BindOffset(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.offset = v);
        public static void BindOffset<T>(this UnityEngine.Tilemaps.TilemapCollider2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.offset = transform(v));
        public static void BindOffset(this UnityEngine.Tilemaps.TilemapCollider2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.offset = transform());
        public static void BindOffsetInterval(this UnityEngine.Tilemaps.TilemapCollider2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.offset = transform());
        #endif


        #if UNITY_TILEMAP
        public static void BindSortOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.SortOrder> property)
            => Bindings2._scope.Bind(property, v => obj.sortOrder = v);
        public static void BindSortOrder<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.SortOrder> transform)
            => Bindings2._scope.Bind(property, v => obj.sortOrder = transform(v));
        public static void BindSortOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.Tilemaps.TilemapRenderer.SortOrder> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortOrder = transform());
        public static void BindSortOrderInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.Tilemaps.TilemapRenderer.SortOrder> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortOrder = transform());
        public static void BindMode(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.Mode> property)
            => Bindings2._scope.Bind(property, v => obj.mode = v);
        public static void BindMode<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.Mode> transform)
            => Bindings2._scope.Bind(property, v => obj.mode = transform(v));
        public static void BindMode(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.Tilemaps.TilemapRenderer.Mode> transform)
            => Bindings2._scope.BindUpdate(() => obj.mode = transform());
        public static void BindModeInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.Tilemaps.TilemapRenderer.Mode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mode = transform());
        public static void BindDetectChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> property)
            => Bindings2._scope.Bind(property, v => obj.detectChunkCullingBounds = v);
        public static void BindDetectChunkCullingBounds<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> transform)
            => Bindings2._scope.Bind(property, v => obj.detectChunkCullingBounds = transform(v));
        public static void BindDetectChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> transform)
            => Bindings2._scope.BindUpdate(() => obj.detectChunkCullingBounds = transform());
        public static void BindDetectChunkCullingBoundsInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.detectChunkCullingBounds = transform());
        public static void BindChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.chunkCullingBounds = v);
        public static void BindChunkCullingBounds<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.chunkCullingBounds = transform(v));
        public static void BindChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.chunkCullingBounds = transform());
        public static void BindChunkCullingBoundsInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.chunkCullingBounds = transform());
        public static void BindChunkCullingBoundsLerp(this UnityEngine.Tilemaps.TilemapRenderer obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.chunkCullingBounds = Vector3.Lerp(obj.chunkCullingBounds, property.Value, speed * Time.smoothDeltaTime));
        public static void BindChunkCullingBoundsLerp(this UnityEngine.Tilemaps.TilemapRenderer obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.chunkCullingBounds = Vector3.Lerp(obj.chunkCullingBounds, transform(), speed * Time.smoothDeltaTime));
        public static void BindChunkCullingBoundsTowards(this UnityEngine.Tilemaps.TilemapRenderer obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.chunkCullingBounds = Vector3.MoveTowards(obj.chunkCullingBounds, property.Value, speed * Time.smoothDeltaTime));
        public static void BindChunkCullingBoundsTowards(this UnityEngine.Tilemaps.TilemapRenderer obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.chunkCullingBounds = Vector3.MoveTowards(obj.chunkCullingBounds, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.chunkCullingBounds = Vector3.Lerp(start, end, t));
        public static void AnimateChunkCullingBounds(this UnityEngine.Tilemaps.TilemapRenderer obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateChunkCullingBounds(obj, obj.chunkCullingBounds, end, curve);
        public static void BindMaskInteraction(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.SpriteMaskInteraction> property)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = v);
        public static void BindMaskInteraction<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.Bind(property, v => obj.maskInteraction = transform(v));
        public static void BindMaskInteraction(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindUpdate(() => obj.maskInteraction = transform());
        public static void BindMaskInteractionInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.SpriteMaskInteraction> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.maskInteraction = transform());
        public static void BindSharedMaterials(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindSortingLayerID(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.Tilemaps.TilemapRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this UnityEngine.Tilemaps.TilemapRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this UnityEngine.Tilemaps.TilemapRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindTemplate(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.template = v);
        public static void BindTemplate<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.template = transform(v));
        public static void BindTemplate(this TMPro.TMP_Dropdown obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.template = transform());
        public static void BindTemplateInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.template = transform());
        public static void BindCaptionText(this TMPro.TMP_Dropdown obj, IProperty<TMPro.TMP_Text> property)
            => Bindings2._scope.Bind(property, v => obj.captionText = v);
        public static void BindCaptionText<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform)
            => Bindings2._scope.Bind(property, v => obj.captionText = transform(v));
        public static void BindCaptionText(this TMPro.TMP_Dropdown obj, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.captionText = transform());
        public static void BindCaptionTextInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.captionText = transform());
        public static void BindCaptionImage(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Image> property)
            => Bindings2._scope.Bind(property, v => obj.captionImage = v);
        public static void BindCaptionImage<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform)
            => Bindings2._scope.Bind(property, v => obj.captionImage = transform(v));
        public static void BindCaptionImage(this TMPro.TMP_Dropdown obj, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindUpdate(() => obj.captionImage = transform());
        public static void BindCaptionImageInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.captionImage = transform());
        public static void BindPlaceholder(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.placeholder = transform(v));
        public static void BindPlaceholder(this TMPro.TMP_Dropdown obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.placeholder = transform());
        public static void BindPlaceholderInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.placeholder = transform());
        public static void BindItemText(this TMPro.TMP_Dropdown obj, IProperty<TMPro.TMP_Text> property)
            => Bindings2._scope.Bind(property, v => obj.itemText = v);
        public static void BindItemText<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform)
            => Bindings2._scope.Bind(property, v => obj.itemText = transform(v));
        public static void BindItemText(this TMPro.TMP_Dropdown obj, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.itemText = transform());
        public static void BindItemTextInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.itemText = transform());
        public static void BindItemImage(this TMPro.TMP_Dropdown obj, IProperty<UnityEngine.UI.Image> property)
            => Bindings2._scope.Bind(property, v => obj.itemImage = v);
        public static void BindItemImage<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, UnityEngine.UI.Image> transform)
            => Bindings2._scope.Bind(property, v => obj.itemImage = transform(v));
        public static void BindItemImage(this TMPro.TMP_Dropdown obj, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindUpdate(() => obj.itemImage = transform());
        public static void BindItemImageInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<UnityEngine.UI.Image> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.itemImage = transform());
        public static void BindValue(this TMPro.TMP_Dropdown obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.value = v);
        public static void BindValue<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.value = transform(v));
        public static void BindValue(this TMPro.TMP_Dropdown obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.value = transform());
        public static void BindValueInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.value = transform());
        public static void BindAlphaFadeSpeed(this TMPro.TMP_Dropdown obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.alphaFadeSpeed = v);
        public static void BindAlphaFadeSpeed<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.alphaFadeSpeed = transform(v));
        public static void BindAlphaFadeSpeed(this TMPro.TMP_Dropdown obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.alphaFadeSpeed = transform());
        public static void BindAlphaFadeSpeedInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alphaFadeSpeed = transform());
        public static void BindOptions(this TMPro.TMP_Dropdown obj, IProperty<System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> property)
            => Bindings2._scope.Bind(property, v => obj.options = v);
        public static void BindOptions<T>(this TMPro.TMP_Dropdown obj, IProperty<T> property, Func<T, System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> transform)
            => Bindings2._scope.Bind(property, v => obj.options = transform(v));
        public static void BindOptions(this TMPro.TMP_Dropdown obj, Func<System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> transform)
            => Bindings2._scope.BindUpdate(() => obj.options = transform());
        public static void BindOptionsInterval(this TMPro.TMP_Dropdown obj, float seconds, Func<System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.options = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindInteractable(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindTextViewport(this TMPro.TMP_InputField obj, IProperty<UnityEngine.RectTransform> property)
            => Bindings2._scope.Bind(property, v => obj.textViewport = v);
        public static void BindTextViewport<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.RectTransform> transform)
            => Bindings2._scope.Bind(property, v => obj.textViewport = transform(v));
        public static void BindTextViewport(this TMPro.TMP_InputField obj, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindUpdate(() => obj.textViewport = transform());
        public static void BindTextViewportInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.RectTransform> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textViewport = transform());
        public static void BindTextComponent(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_Text> property)
            => Bindings2._scope.Bind(property, v => obj.textComponent = v);
        public static void BindTextComponent<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_Text> transform)
            => Bindings2._scope.Bind(property, v => obj.textComponent = transform(v));
        public static void BindTextComponent(this TMPro.TMP_InputField obj, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindUpdate(() => obj.textComponent = transform());
        public static void BindTextComponentInterval(this TMPro.TMP_InputField obj, float seconds, Func<TMPro.TMP_Text> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textComponent = transform());
        public static void BindText<T>(this TMPro.TMP_InputField obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.text = v.ToString());
        public static void BindText<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.text = transform(v));
        public static void BindText<T>(this TMPro.TMP_InputField obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.text = transform().ToString());
        public static void BindTextInterval<T>(this TMPro.TMP_InputField obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.text = transform().ToString());
        public static void BindFontAsset(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_FontAsset> property)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = transform(v));
        public static void BindFontAsset(this TMPro.TMP_InputField obj, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontAsset = transform());
        public static void BindFontAssetInterval(this TMPro.TMP_InputField obj, float seconds, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontAsset = transform());
        public static void BindPointSize(this TMPro.TMP_InputField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.pointSize = v);
        public static void BindPointSize<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.pointSize = transform(v));
        public static void BindPointSize(this TMPro.TMP_InputField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.pointSize = transform());
        public static void BindPointSizeInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.pointSize = transform());
        public static void BindCharacterLimit(this TMPro.TMP_InputField obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.characterLimit = v);
        public static void BindCharacterLimit<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.characterLimit = transform(v));
        public static void BindCharacterLimit(this TMPro.TMP_InputField obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.characterLimit = transform());
        public static void BindCharacterLimitInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.characterLimit = transform());
        public static void BindContentType(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_InputField.ContentType> property)
            => Bindings2._scope.Bind(property, v => obj.contentType = v);
        public static void BindContentType<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_InputField.ContentType> transform)
            => Bindings2._scope.Bind(property, v => obj.contentType = transform(v));
        public static void BindContentType(this TMPro.TMP_InputField obj, Func<TMPro.TMP_InputField.ContentType> transform)
            => Bindings2._scope.BindUpdate(() => obj.contentType = transform());
        public static void BindContentTypeInterval(this TMPro.TMP_InputField obj, float seconds, Func<TMPro.TMP_InputField.ContentType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.contentType = transform());
        public static void BindLineType(this TMPro.TMP_InputField obj, IProperty<TMPro.TMP_InputField.LineType> property)
            => Bindings2._scope.Bind(property, v => obj.lineType = v);
        public static void BindLineType<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, TMPro.TMP_InputField.LineType> transform)
            => Bindings2._scope.Bind(property, v => obj.lineType = transform(v));
        public static void BindLineType(this TMPro.TMP_InputField obj, Func<TMPro.TMP_InputField.LineType> transform)
            => Bindings2._scope.BindUpdate(() => obj.lineType = transform());
        public static void BindLineTypeInterval(this TMPro.TMP_InputField obj, float seconds, Func<TMPro.TMP_InputField.LineType> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lineType = transform());
        public static void BindPlaceholder(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.placeholder = v);
        public static void BindPlaceholder<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.placeholder = transform(v));
        public static void BindPlaceholder(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.placeholder = transform());
        public static void BindPlaceholderInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.placeholder = transform());
        public static void BindVerticalScrollbar(this TMPro.TMP_InputField obj, IProperty<UnityEngine.UI.Scrollbar> property)
            => Bindings2._scope.Bind(property, v => obj.verticalScrollbar = v);
        public static void BindVerticalScrollbar<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.Bind(property, v => obj.verticalScrollbar = transform(v));
        public static void BindVerticalScrollbar(this TMPro.TMP_InputField obj, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindUpdate(() => obj.verticalScrollbar = transform());
        public static void BindVerticalScrollbarInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.UI.Scrollbar> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.verticalScrollbar = transform());
        public static void BindCaretBlinkRate(this TMPro.TMP_InputField obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.caretBlinkRate = v);
        public static void BindCaretBlinkRate<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.caretBlinkRate = transform(v));
        public static void BindCaretBlinkRate(this TMPro.TMP_InputField obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.caretBlinkRate = transform());
        public static void BindCaretBlinkRateInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.caretBlinkRate = transform());
        public static void BindCaretWidth(this TMPro.TMP_InputField obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.caretWidth = v);
        public static void BindCaretWidth<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.caretWidth = transform(v));
        public static void BindCaretWidth(this TMPro.TMP_InputField obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.caretWidth = transform());
        public static void BindCaretWidthInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.caretWidth = transform());
        public static void BindCustomCaretColor(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.customCaretColor = v);
        public static void BindCustomCaretColor<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.customCaretColor = transform(v));
        public static void BindCustomCaretColor(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.customCaretColor = transform());
        public static void BindCustomCaretColorInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.customCaretColor = transform());
        public static void BindSelectionColor(this TMPro.TMP_InputField obj, IProperty<UnityEngine.Color> property)
            => Bindings2._scope.Bind(property, v => obj.selectionColor = v);
        public static void BindSelectionColor<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, UnityEngine.Color> transform)
            => Bindings2._scope.Bind(property, v => obj.selectionColor = transform(v));
        public static void BindSelectionColor(this TMPro.TMP_InputField obj, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindUpdate(() => obj.selectionColor = transform());
        public static void BindSelectionColorInterval(this TMPro.TMP_InputField obj, float seconds, Func<UnityEngine.Color> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.selectionColor = transform());
        public static void BindOnFocusSelectAll(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.onFocusSelectAll = v);
        public static void BindOnFocusSelectAll<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.onFocusSelectAll = transform(v));
        public static void BindOnFocusSelectAll(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.onFocusSelectAll = transform());
        public static void BindOnFocusSelectAllInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.onFocusSelectAll = transform());
        public static void BindResetOnDeActivation(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.resetOnDeActivation = v);
        public static void BindResetOnDeActivation<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.resetOnDeActivation = transform(v));
        public static void BindResetOnDeActivation(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.resetOnDeActivation = transform());
        public static void BindResetOnDeActivationInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.resetOnDeActivation = transform());
        public static void BindRestoreOriginalTextOnEscape(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.restoreOriginalTextOnEscape = v);
        public static void BindRestoreOriginalTextOnEscape<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.restoreOriginalTextOnEscape = transform(v));
        public static void BindRestoreOriginalTextOnEscape(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.restoreOriginalTextOnEscape = transform());
        public static void BindRestoreOriginalTextOnEscapeInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.restoreOriginalTextOnEscape = transform());
        public static void BindShouldHideSoftKeyboard(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.shouldHideSoftKeyboard = v);
        public static void BindShouldHideSoftKeyboard<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.shouldHideSoftKeyboard = transform(v));
        public static void BindShouldHideSoftKeyboard(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.shouldHideSoftKeyboard = transform());
        public static void BindShouldHideSoftKeyboardInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shouldHideSoftKeyboard = transform());
        public static void BindShouldHideMobileInput(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.shouldHideMobileInput = v);
        public static void BindShouldHideMobileInput<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.shouldHideMobileInput = transform(v));
        public static void BindShouldHideMobileInput(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.shouldHideMobileInput = transform());
        public static void BindShouldHideMobileInputInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shouldHideMobileInput = transform());
        public static void BindReadOnly(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.readOnly = v);
        public static void BindReadOnly<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.readOnly = transform(v));
        public static void BindReadOnly(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.readOnly = transform());
        public static void BindReadOnlyInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.readOnly = transform());
        public static void BindRichText(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.richText = v);
        public static void BindRichText<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.richText = transform(v));
        public static void BindRichText(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.richText = transform());
        public static void BindRichTextInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.richText = transform());
        public static void BindIsRichTextEditingAllowed(this TMPro.TMP_InputField obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isRichTextEditingAllowed = v);
        public static void BindIsRichTextEditingAllowed<T>(this TMPro.TMP_InputField obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isRichTextEditingAllowed = transform(v));
        public static void BindIsRichTextEditingAllowed(this TMPro.TMP_InputField obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isRichTextEditingAllowed = transform());
        public static void BindIsRichTextEditingAllowedInterval(this TMPro.TMP_InputField obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isRichTextEditingAllowed = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindIsSelected(this TMPro.TMP_ScrollbarEventHandler obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isSelected = v);
        public static void BindIsSelected<T>(this TMPro.TMP_ScrollbarEventHandler obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isSelected = transform(v));
        public static void BindIsSelected(this TMPro.TMP_ScrollbarEventHandler obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isSelected = transform());
        public static void BindIsSelectedInterval(this TMPro.TMP_ScrollbarEventHandler obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isSelected = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindFontAsset(this TMPro.TMP_SubMesh obj, IProperty<TMPro.TMP_FontAsset> property)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_SubMesh obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = transform(v));
        public static void BindFontAsset(this TMPro.TMP_SubMesh obj, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontAsset = transform());
        public static void BindFontAssetInterval(this TMPro.TMP_SubMesh obj, float seconds, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontAsset = transform());
        public static void BindSpriteAsset(this TMPro.TMP_SubMesh obj, IProperty<TMPro.TMP_SpriteAsset> property)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TMP_SubMesh obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TMP_SubMesh obj, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.spriteAsset = transform());
        public static void BindSpriteAssetInterval(this TMPro.TMP_SubMesh obj, float seconds, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spriteAsset = transform());
        #endif


        #if UNITY_TMPRO
        public static void BindFontAsset(this TMPro.TMP_SubMeshUI obj, IProperty<TMPro.TMP_FontAsset> property)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = v);
        public static void BindFontAsset<T>(this TMPro.TMP_SubMeshUI obj, IProperty<T> property, Func<T, TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.fontAsset = transform(v));
        public static void BindFontAsset(this TMPro.TMP_SubMeshUI obj, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.fontAsset = transform());
        public static void BindFontAssetInterval(this TMPro.TMP_SubMeshUI obj, float seconds, Func<TMPro.TMP_FontAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.fontAsset = transform());
        public static void BindSpriteAsset(this TMPro.TMP_SubMeshUI obj, IProperty<TMPro.TMP_SpriteAsset> property)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = v);
        public static void BindSpriteAsset<T>(this TMPro.TMP_SubMeshUI obj, IProperty<T> property, Func<T, TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.spriteAsset = transform(v));
        public static void BindSpriteAsset(this TMPro.TMP_SubMeshUI obj, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.spriteAsset = transform());
        public static void BindSpriteAssetInterval(this TMPro.TMP_SubMeshUI obj, float seconds, Func<TMPro.TMP_SpriteAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.spriteAsset = transform());
        #endif


        #if UNITY_GUI
        public static void BindInteractable(this UnityEngine.UI.Toggle obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.interactable = v);
        public static void BindInteractable<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.interactable = transform(v));
        public static void BindInteractable(this UnityEngine.UI.Toggle obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.interactable = transform());
        public static void BindInteractableInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.interactable = transform());
        public static void BindTransition(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Selectable.Transition> property)
            => Bindings2._scope.Bind(property, v => obj.transition = v);
        public static void BindTransition<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.Bind(property, v => obj.transition = transform(v));
        public static void BindTransition(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindUpdate(() => obj.transition = transform());
        public static void BindTransitionInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.Selectable.Transition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.transition = transform());
        public static void BindTargetGraphic(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = v);
        public static void BindTargetGraphic<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.targetGraphic = transform(v));
        public static void BindTargetGraphic(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetGraphic = transform());
        public static void BindTargetGraphicInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetGraphic = transform());
        public static void BindColors(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.ColorBlock> property)
            => Bindings2._scope.Bind(property, v => obj.colors = v);
        public static void BindColors<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.Bind(property, v => obj.colors = transform(v));
        public static void BindColors(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindUpdate(() => obj.colors = transform());
        public static void BindColorsInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.ColorBlock> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colors = transform());
        public static void BindNavigation(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Navigation> property)
            => Bindings2._scope.Bind(property, v => obj.navigation = v);
        public static void BindNavigation<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.Bind(property, v => obj.navigation = transform(v));
        public static void BindNavigation(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindUpdate(() => obj.navigation = transform());
        public static void BindNavigationInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.Navigation> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.navigation = transform());
        public static void BindIsOn(this UnityEngine.UI.Toggle obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isOn = v);
        public static void BindIsOn<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isOn = transform(v));
        public static void BindIsOn(this UnityEngine.UI.Toggle obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isOn = transform());
        public static void BindIsOnInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isOn = transform());
        public static void BindToggleTransition(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Toggle.ToggleTransition> property)
            => Bindings2._scope.Bind(property, v => obj.toggleTransition = v);
        public static void BindToggleTransition<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Toggle.ToggleTransition> transform)
            => Bindings2._scope.Bind(property, v => obj.toggleTransition = transform(v));
        public static void BindToggleTransition(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.Toggle.ToggleTransition> transform)
            => Bindings2._scope.BindUpdate(() => obj.toggleTransition = transform());
        public static void BindToggleTransitionInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.Toggle.ToggleTransition> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.toggleTransition = transform());
        public static void BindGraphic(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.Graphic> property)
            => Bindings2._scope.Bind(property, v => obj.graphic = v);
        public static void BindGraphic<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.Bind(property, v => obj.graphic = transform(v));
        public static void BindGraphic(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindUpdate(() => obj.graphic = transform());
        public static void BindGraphicInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.Graphic> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.graphic = transform());
        public static void BindGroup(this UnityEngine.UI.Toggle obj, IProperty<UnityEngine.UI.ToggleGroup> property)
            => Bindings2._scope.Bind(property, v => obj.group = v);
        public static void BindGroup<T>(this UnityEngine.UI.Toggle obj, IProperty<T> property, Func<T, UnityEngine.UI.ToggleGroup> transform)
            => Bindings2._scope.Bind(property, v => obj.group = transform(v));
        public static void BindGroup(this UnityEngine.UI.Toggle obj, Func<UnityEngine.UI.ToggleGroup> transform)
            => Bindings2._scope.BindUpdate(() => obj.group = transform());
        public static void BindGroupInterval(this UnityEngine.UI.Toggle obj, float seconds, Func<UnityEngine.UI.ToggleGroup> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.group = transform());
        #endif


        #if UNITY_GUI
        public static void BindAllowSwitchOff(this UnityEngine.UI.ToggleGroup obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowSwitchOff = v);
        public static void BindAllowSwitchOff<T>(this UnityEngine.UI.ToggleGroup obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowSwitchOff = transform(v));
        public static void BindAllowSwitchOff(this UnityEngine.UI.ToggleGroup obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowSwitchOff = transform());
        public static void BindAllowSwitchOffInterval(this UnityEngine.UI.ToggleGroup obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowSwitchOff = transform());
        #endif


        public static void BindTime(this TrailRenderer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.time = v);
        public static void BindTime<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.time = transform(v));
        public static void BindTime(this TrailRenderer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.time = transform());
        public static void BindTimeInterval(this TrailRenderer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.time = transform());
        public static void BindMinVertexDistance(this TrailRenderer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.minVertexDistance = v);
        public static void BindMinVertexDistance<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.minVertexDistance = transform(v));
        public static void BindMinVertexDistance(this TrailRenderer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.minVertexDistance = transform());
        public static void BindMinVertexDistanceInterval(this TrailRenderer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.minVertexDistance = transform());
        public static void BindAutodestruct(this TrailRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autodestruct = v);
        public static void BindAutodestruct<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autodestruct = transform(v));
        public static void BindAutodestruct(this TrailRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autodestruct = transform());
        public static void BindAutodestructInterval(this TrailRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autodestruct = transform());
        public static void BindEmitting(this TrailRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.emitting = v);
        public static void BindEmitting<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.emitting = transform(v));
        public static void BindEmitting(this TrailRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.emitting = transform());
        public static void BindEmittingInterval(this TrailRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.emitting = transform());
        public static void BindColorGradient(this TrailRenderer obj, IProperty<UnityEngine.Gradient> property)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = v);
        public static void BindColorGradient<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Gradient> transform)
            => Bindings2._scope.Bind(property, v => obj.colorGradient = transform(v));
        public static void BindColorGradient(this TrailRenderer obj, Func<UnityEngine.Gradient> transform)
            => Bindings2._scope.BindUpdate(() => obj.colorGradient = transform());
        public static void BindColorGradientInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.Gradient> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.colorGradient = transform());
        public static void BindNumCornerVertices(this TrailRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.numCornerVertices = v);
        public static void BindNumCornerVertices<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.numCornerVertices = transform(v));
        public static void BindNumCornerVertices(this TrailRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.numCornerVertices = transform());
        public static void BindNumCornerVerticesInterval(this TrailRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.numCornerVertices = transform());
        public static void BindNumCapVertices(this TrailRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.numCapVertices = v);
        public static void BindNumCapVertices<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.numCapVertices = transform(v));
        public static void BindNumCapVertices(this TrailRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.numCapVertices = transform());
        public static void BindNumCapVerticesInterval(this TrailRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.numCapVertices = transform());
        public static void BindAlignment(this TrailRenderer obj, IProperty<UnityEngine.LineAlignment> property)
            => Bindings2._scope.Bind(property, v => obj.alignment = v);
        public static void BindAlignment<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineAlignment> transform)
            => Bindings2._scope.Bind(property, v => obj.alignment = transform(v));
        public static void BindAlignment(this TrailRenderer obj, Func<UnityEngine.LineAlignment> transform)
            => Bindings2._scope.BindUpdate(() => obj.alignment = transform());
        public static void BindAlignmentInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.LineAlignment> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.alignment = transform());
        public static void BindTextureMode(this TrailRenderer obj, IProperty<UnityEngine.LineTextureMode> property)
            => Bindings2._scope.Bind(property, v => obj.textureMode = v);
        public static void BindTextureMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.Bind(property, v => obj.textureMode = transform(v));
        public static void BindTextureMode(this TrailRenderer obj, Func<UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.textureMode = transform());
        public static void BindTextureModeInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.LineTextureMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.textureMode = transform());
        public static void BindGenerateLightingData(this TrailRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.generateLightingData = v);
        public static void BindGenerateLightingData<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.generateLightingData = transform(v));
        public static void BindGenerateLightingData(this TrailRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.generateLightingData = transform());
        public static void BindGenerateLightingDataInterval(this TrailRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.generateLightingData = transform());
        public static void BindShadowBias(this TrailRenderer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.shadowBias = v);
        public static void BindShadowBias<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowBias = transform(v));
        public static void BindShadowBias(this TrailRenderer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowBias = transform());
        public static void BindShadowBiasInterval(this TrailRenderer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowBias = transform());
        public static void BindSharedMaterials(this TrailRenderer obj, IProperty<UnityEngine.Material[]> property)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = v);
        public static void BindSharedMaterials<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Material[]> transform)
            => Bindings2._scope.Bind(property, v => obj.sharedMaterials = transform(v));
        public static void BindSharedMaterials(this TrailRenderer obj, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindUpdate(() => obj.sharedMaterials = transform());
        public static void BindSharedMaterialsInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.Material[]> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sharedMaterials = transform());
        public static void BindShadowCastingMode(this TrailRenderer obj, IProperty<UnityEngine.Rendering.ShadowCastingMode> property)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = v);
        public static void BindShadowCastingMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.Bind(property, v => obj.shadowCastingMode = transform(v));
        public static void BindShadowCastingMode(this TrailRenderer obj, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.shadowCastingMode = transform());
        public static void BindShadowCastingModeInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.Rendering.ShadowCastingMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.shadowCastingMode = transform());
        public static void BindReceiveShadows(this TrailRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = v);
        public static void BindReceiveShadows<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.receiveShadows = transform(v));
        public static void BindReceiveShadows(this TrailRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.receiveShadows = transform());
        public static void BindReceiveShadowsInterval(this TrailRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.receiveShadows = transform());
        public static void BindLightProbeUsage(this TrailRenderer obj, IProperty<UnityEngine.Rendering.LightProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = v);
        public static void BindLightProbeUsage<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.lightProbeUsage = transform(v));
        public static void BindLightProbeUsage(this TrailRenderer obj, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.lightProbeUsage = transform());
        public static void BindLightProbeUsageInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.Rendering.LightProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.lightProbeUsage = transform());
        public static void BindReflectionProbeUsage(this TrailRenderer obj, IProperty<UnityEngine.Rendering.ReflectionProbeUsage> property)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = v);
        public static void BindReflectionProbeUsage<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.Bind(property, v => obj.reflectionProbeUsage = transform(v));
        public static void BindReflectionProbeUsage(this TrailRenderer obj, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindUpdate(() => obj.reflectionProbeUsage = transform());
        public static void BindReflectionProbeUsageInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.Rendering.ReflectionProbeUsage> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.reflectionProbeUsage = transform());
        public static void BindMotionVectorGenerationMode(this TrailRenderer obj, IProperty<UnityEngine.MotionVectorGenerationMode> property)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = v);
        public static void BindMotionVectorGenerationMode<T>(this TrailRenderer obj, IProperty<T> property, Func<T, UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.Bind(property, v => obj.motionVectorGenerationMode = transform(v));
        public static void BindMotionVectorGenerationMode(this TrailRenderer obj, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.motionVectorGenerationMode = transform());
        public static void BindMotionVectorGenerationModeInterval(this TrailRenderer obj, float seconds, Func<UnityEngine.MotionVectorGenerationMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motionVectorGenerationMode = transform());
        public static void BindAllowOcclusionWhenDynamic(this TrailRenderer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = v);
        public static void BindAllowOcclusionWhenDynamic<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.allowOcclusionWhenDynamic = transform(v));
        public static void BindAllowOcclusionWhenDynamic(this TrailRenderer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.allowOcclusionWhenDynamic = transform());
        public static void BindAllowOcclusionWhenDynamicInterval(this TrailRenderer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.allowOcclusionWhenDynamic = transform());
        public static void BindSortingLayerID(this TrailRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = v);
        public static void BindSortingLayerID<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingLayerID = transform(v));
        public static void BindSortingLayerID(this TrailRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingLayerID = transform());
        public static void BindSortingLayerIDInterval(this TrailRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingLayerID = transform());
        public static void BindSortingOrder(this TrailRenderer obj, IProperty<System.Int32> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this TrailRenderer obj, IProperty<T> property, Func<T, System.Int32> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this TrailRenderer obj, Func<System.Int32> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this TrailRenderer obj, float seconds, Func<System.Int32> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());


        public static void BindLocalPosition(this Transform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.localPosition = v);
        public static void BindLocalPosition<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.localPosition = transform(v));
        public static void BindLocalPosition(this Transform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = transform());
        public static void BindLocalPositionInterval(this Transform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localPosition = transform());
        public static void BindLocalPositionLerp(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.Lerp(obj.localPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalPositionLerp(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.Lerp(obj.localPosition, transform(), speed * Time.smoothDeltaTime));
        public static void BindLocalPositionTowards(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.MoveTowards(obj.localPosition, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalPositionTowards(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localPosition = Vector3.MoveTowards(obj.localPosition, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateLocalPosition(this Transform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.localPosition = Vector3.Lerp(start, end, t));
        public static void AnimateLocalPosition(this Transform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateLocalPosition(obj, obj.localPosition, end, curve);
        public static void BindLocalRotation(this Transform obj, IProperty<UnityEngine.Quaternion> property)
            => Bindings2._scope.Bind(property, v => obj.localRotation = v);
        public static void BindLocalRotation<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform)
            => Bindings2._scope.Bind(property, v => obj.localRotation = transform(v));
        public static void BindLocalRotation(this Transform obj, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindUpdate(() => obj.localRotation = transform());
        public static void BindLocalRotationInterval(this Transform obj, float seconds, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localRotation = transform());
        public static void BindLocalScale(this Transform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.localScale = v);
        public static void BindLocalScale<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.localScale = transform(v));
        public static void BindLocalScale(this Transform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = transform());
        public static void BindLocalScaleInterval(this Transform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.localScale = transform());
        public static void BindLocalScaleLerp(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.Lerp(obj.localScale, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalScaleLerp(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.Lerp(obj.localScale, transform(), speed * Time.smoothDeltaTime));
        public static void BindLocalScaleTowards(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.MoveTowards(obj.localScale, property.Value, speed * Time.smoothDeltaTime));
        public static void BindLocalScaleTowards(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.localScale = Vector3.MoveTowards(obj.localScale, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateLocalScale(this Transform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.localScale = Vector3.Lerp(start, end, t));
        public static void AnimateLocalScale(this Transform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateLocalScale(obj, obj.localScale, end, curve);
        public static void BindPosition(this Transform obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.position = v);
        public static void BindPosition<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.position = transform(v));
        public static void BindPosition(this Transform obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = transform());
        public static void BindPositionInterval(this Transform obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.position = transform());
        public static void BindPositionLerp(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.Lerp(obj.position, property.Value, speed * Time.smoothDeltaTime));
        public static void BindPositionLerp(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.Lerp(obj.position, transform(), speed * Time.smoothDeltaTime));
        public static void BindPositionTowards(this Transform obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.MoveTowards(obj.position, property.Value, speed * Time.smoothDeltaTime));
        public static void BindPositionTowards(this Transform obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.position = Vector3.MoveTowards(obj.position, transform(), speed * Time.smoothDeltaTime));
        public static void AnimatePosition(this Transform obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.position = Vector3.Lerp(start, end, t));
        public static void AnimatePosition(this Transform obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimatePosition(obj, obj.position, end, curve);
        public static void BindRotation(this Transform obj, IProperty<UnityEngine.Quaternion> property)
            => Bindings2._scope.Bind(property, v => obj.rotation = v);
        public static void BindRotation<T>(this Transform obj, IProperty<T> property, Func<T, UnityEngine.Quaternion> transform)
            => Bindings2._scope.Bind(property, v => obj.rotation = transform(v));
        public static void BindRotation(this Transform obj, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindUpdate(() => obj.rotation = transform());
        public static void BindRotationInterval(this Transform obj, float seconds, Func<UnityEngine.Quaternion> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.rotation = transform());


        #if UNITY_2021_2_OR_NEWER&&UNITY_UIELEMENTS
        public static void BindPanelSettings(this UnityEngine.UIElements.UIDocument obj, IProperty<UnityEngine.UIElements.PanelSettings> property)
            => Bindings2._scope.Bind(property, v => obj.panelSettings = v);
        public static void BindPanelSettings<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, UnityEngine.UIElements.PanelSettings> transform)
            => Bindings2._scope.Bind(property, v => obj.panelSettings = transform(v));
        public static void BindPanelSettings(this UnityEngine.UIElements.UIDocument obj, Func<UnityEngine.UIElements.PanelSettings> transform)
            => Bindings2._scope.BindUpdate(() => obj.panelSettings = transform());
        public static void BindPanelSettingsInterval(this UnityEngine.UIElements.UIDocument obj, float seconds, Func<UnityEngine.UIElements.PanelSettings> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.panelSettings = transform());
        public static void BindVisualTreeAsset(this UnityEngine.UIElements.UIDocument obj, IProperty<UnityEngine.UIElements.VisualTreeAsset> property)
            => Bindings2._scope.Bind(property, v => obj.visualTreeAsset = v);
        public static void BindVisualTreeAsset<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, UnityEngine.UIElements.VisualTreeAsset> transform)
            => Bindings2._scope.Bind(property, v => obj.visualTreeAsset = transform(v));
        public static void BindVisualTreeAsset(this UnityEngine.UIElements.UIDocument obj, Func<UnityEngine.UIElements.VisualTreeAsset> transform)
            => Bindings2._scope.BindUpdate(() => obj.visualTreeAsset = transform());
        public static void BindVisualTreeAssetInterval(this UnityEngine.UIElements.UIDocument obj, float seconds, Func<UnityEngine.UIElements.VisualTreeAsset> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.visualTreeAsset = transform());
        public static void BindSortingOrder(this UnityEngine.UIElements.UIDocument obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = v);
        public static void BindSortingOrder<T>(this UnityEngine.UIElements.UIDocument obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.sortingOrder = transform(v));
        public static void BindSortingOrder(this UnityEngine.UIElements.UIDocument obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.sortingOrder = transform());
        public static void BindSortingOrderInterval(this UnityEngine.UIElements.UIDocument obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sortingOrder = transform());
        #endif


        #if UNITY_VIDEO
        public static void BindSource(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoSource> property)
            => Bindings2._scope.Bind(property, v => obj.source = v);
        public static void BindSource<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoSource> transform)
            => Bindings2._scope.Bind(property, v => obj.source = transform(v));
        public static void BindSource(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.VideoSource> transform)
            => Bindings2._scope.BindUpdate(() => obj.source = transform());
        public static void BindSourceInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.VideoSource> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.source = transform());
        public static void BindClip(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoClip> property)
            => Bindings2._scope.Bind(property, v => obj.clip = v);
        public static void BindClip<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoClip> transform)
            => Bindings2._scope.Bind(property, v => obj.clip = transform(v));
        public static void BindClip(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.VideoClip> transform)
            => Bindings2._scope.BindUpdate(() => obj.clip = transform());
        public static void BindClipInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.VideoClip> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.clip = transform());
        public static void BindUrl<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property)
            => Bindings2._scope.Bind(property, v => obj.url = v.ToString());
        public static void BindUrl<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.String> transform)
            => Bindings2._scope.Bind(property, v => obj.url = transform(v));
        public static void BindUrl<T>(this UnityEngine.Video.VideoPlayer obj, Func<T> transform)
            => Bindings2._scope.BindUpdate(() => obj.url = transform().ToString());
        public static void BindUrlInterval<T>(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<T> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.url = transform().ToString());
        public static void BindPlayOnAwake(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = v);
        public static void BindPlayOnAwake<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.playOnAwake = transform(v));
        public static void BindPlayOnAwake(this UnityEngine.Video.VideoPlayer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.playOnAwake = transform());
        public static void BindPlayOnAwakeInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playOnAwake = transform());
        public static void BindWaitForFirstFrame(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.waitForFirstFrame = v);
        public static void BindWaitForFirstFrame<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.waitForFirstFrame = transform(v));
        public static void BindWaitForFirstFrame(this UnityEngine.Video.VideoPlayer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.waitForFirstFrame = transform());
        public static void BindWaitForFirstFrameInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.waitForFirstFrame = transform());
        public static void BindIsLooping(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.isLooping = v);
        public static void BindIsLooping<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.isLooping = transform(v));
        public static void BindIsLooping(this UnityEngine.Video.VideoPlayer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.isLooping = transform());
        public static void BindIsLoopingInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.isLooping = transform());
        public static void BindSkipOnDrop(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.skipOnDrop = v);
        public static void BindSkipOnDrop<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.skipOnDrop = transform(v));
        public static void BindSkipOnDrop(this UnityEngine.Video.VideoPlayer obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.skipOnDrop = transform());
        public static void BindSkipOnDropInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.skipOnDrop = transform());
        public static void BindPlaybackSpeed(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.playbackSpeed = v);
        public static void BindPlaybackSpeed<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.playbackSpeed = transform(v));
        public static void BindPlaybackSpeed(this UnityEngine.Video.VideoPlayer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.playbackSpeed = transform());
        public static void BindPlaybackSpeedInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.playbackSpeed = transform());
        public static void BindRenderMode(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoRenderMode> property)
            => Bindings2._scope.Bind(property, v => obj.renderMode = v);
        public static void BindRenderMode<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoRenderMode> transform)
            => Bindings2._scope.Bind(property, v => obj.renderMode = transform(v));
        public static void BindRenderMode(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.VideoRenderMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.renderMode = transform());
        public static void BindRenderModeInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.VideoRenderMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.renderMode = transform());
        public static void BindTargetCamera(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Camera> property)
            => Bindings2._scope.Bind(property, v => obj.targetCamera = v);
        public static void BindTargetCamera<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Camera> transform)
            => Bindings2._scope.Bind(property, v => obj.targetCamera = transform(v));
        public static void BindTargetCamera(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Camera> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetCamera = transform());
        public static void BindTargetCameraInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Camera> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetCamera = transform());
        public static void BindTargetCameraAlpha(this UnityEngine.Video.VideoPlayer obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.targetCameraAlpha = v);
        public static void BindTargetCameraAlpha<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.targetCameraAlpha = transform(v));
        public static void BindTargetCameraAlpha(this UnityEngine.Video.VideoPlayer obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetCameraAlpha = transform());
        public static void BindTargetCameraAlphaInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetCameraAlpha = transform());
        public static void BindTargetCamera3DLayout(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.Video3DLayout> property)
            => Bindings2._scope.Bind(property, v => obj.targetCamera3DLayout = v);
        public static void BindTargetCamera3DLayout<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.Video3DLayout> transform)
            => Bindings2._scope.Bind(property, v => obj.targetCamera3DLayout = transform(v));
        public static void BindTargetCamera3DLayout(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.Video3DLayout> transform)
            => Bindings2._scope.BindUpdate(() => obj.targetCamera3DLayout = transform());
        public static void BindTargetCamera3DLayoutInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.Video3DLayout> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.targetCamera3DLayout = transform());
        public static void BindAspectRatio(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoAspectRatio> property)
            => Bindings2._scope.Bind(property, v => obj.aspectRatio = v);
        public static void BindAspectRatio<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoAspectRatio> transform)
            => Bindings2._scope.Bind(property, v => obj.aspectRatio = transform(v));
        public static void BindAspectRatio(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.VideoAspectRatio> transform)
            => Bindings2._scope.BindUpdate(() => obj.aspectRatio = transform());
        public static void BindAspectRatioInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.VideoAspectRatio> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.aspectRatio = transform());
        public static void BindAudioOutputMode(this UnityEngine.Video.VideoPlayer obj, IProperty<UnityEngine.Video.VideoAudioOutputMode> property)
            => Bindings2._scope.Bind(property, v => obj.audioOutputMode = v);
        public static void BindAudioOutputMode<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, UnityEngine.Video.VideoAudioOutputMode> transform)
            => Bindings2._scope.Bind(property, v => obj.audioOutputMode = transform(v));
        public static void BindAudioOutputMode(this UnityEngine.Video.VideoPlayer obj, Func<UnityEngine.Video.VideoAudioOutputMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.audioOutputMode = transform());
        public static void BindAudioOutputModeInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<UnityEngine.Video.VideoAudioOutputMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.audioOutputMode = transform());
        public static void BindControlledAudioTrackCount(this UnityEngine.Video.VideoPlayer obj, IProperty<System.UInt16> property)
            => Bindings2._scope.Bind(property, v => obj.controlledAudioTrackCount = v);
        public static void BindControlledAudioTrackCount<T>(this UnityEngine.Video.VideoPlayer obj, IProperty<T> property, Func<T, System.UInt16> transform)
            => Bindings2._scope.Bind(property, v => obj.controlledAudioTrackCount = transform(v));
        public static void BindControlledAudioTrackCount(this UnityEngine.Video.VideoPlayer obj, Func<System.UInt16> transform)
            => Bindings2._scope.BindUpdate(() => obj.controlledAudioTrackCount = transform());
        public static void BindControlledAudioTrackCountInterval(this UnityEngine.Video.VideoPlayer obj, float seconds, Func<System.UInt16> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.controlledAudioTrackCount = transform());
        #endif


        #if UNITY_VEHICLES
        public static void BindMass(this WheelCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.mass = v);
        public static void BindMass<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.mass = transform(v));
        public static void BindMass(this WheelCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.mass = transform());
        public static void BindMassInterval(this WheelCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mass = transform());
        public static void BindRadius(this WheelCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.radius = v);
        public static void BindRadius<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.radius = transform(v));
        public static void BindRadius(this WheelCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.radius = transform());
        public static void BindRadiusInterval(this WheelCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.radius = transform());
        public static void BindWheelDampingRate(this WheelCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.wheelDampingRate = v);
        public static void BindWheelDampingRate<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.wheelDampingRate = transform(v));
        public static void BindWheelDampingRate(this WheelCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.wheelDampingRate = transform());
        public static void BindWheelDampingRateInterval(this WheelCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.wheelDampingRate = transform());
        public static void BindSuspensionDistance(this WheelCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.suspensionDistance = v);
        public static void BindSuspensionDistance<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.suspensionDistance = transform(v));
        public static void BindSuspensionDistance(this WheelCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.suspensionDistance = transform());
        public static void BindSuspensionDistanceInterval(this WheelCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.suspensionDistance = transform());
        public static void BindForceAppPointDistance(this WheelCollider obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.forceAppPointDistance = v);
        public static void BindForceAppPointDistance<T>(this WheelCollider obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.forceAppPointDistance = transform(v));
        public static void BindForceAppPointDistance(this WheelCollider obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.forceAppPointDistance = transform());
        public static void BindForceAppPointDistanceInterval(this WheelCollider obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forceAppPointDistance = transform());
        public static void BindCenter(this WheelCollider obj, IProperty<UnityEngine.Vector3> property)
            => Bindings2._scope.Bind(property, v => obj.center = v);
        public static void BindCenter<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.Vector3> transform)
            => Bindings2._scope.Bind(property, v => obj.center = transform(v));
        public static void BindCenter(this WheelCollider obj, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = transform());
        public static void BindCenterInterval(this WheelCollider obj, float seconds, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.center = transform());
        public static void BindCenterLerp(this WheelCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterLerp(this WheelCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.Lerp(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this WheelCollider obj, float speed, Property<UnityEngine.Vector3> property)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, property.Value, speed * Time.smoothDeltaTime));
        public static void BindCenterTowards(this WheelCollider obj, float speed, Func<UnityEngine.Vector3> transform)
            => Bindings2._scope.BindUpdate(() => obj.center = Vector3.MoveTowards(obj.center, transform(), speed * Time.smoothDeltaTime));
        public static void AnimateCenter(this WheelCollider obj, UnityEngine.Vector3 start, UnityEngine.Vector3 end, AnimationCurve curve)
            => Bindings2._scope.Animate(curve, t => obj.center = Vector3.Lerp(start, end, t));
        public static void AnimateCenter(this WheelCollider obj, UnityEngine.Vector3 end, AnimationCurve curve)
            => AnimateCenter(obj, obj.center, end, curve);
        public static void BindSuspensionSpring(this WheelCollider obj, IProperty<UnityEngine.JointSpring> property)
            => Bindings2._scope.Bind(property, v => obj.suspensionSpring = v);
        public static void BindSuspensionSpring<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.JointSpring> transform)
            => Bindings2._scope.Bind(property, v => obj.suspensionSpring = transform(v));
        public static void BindSuspensionSpring(this WheelCollider obj, Func<UnityEngine.JointSpring> transform)
            => Bindings2._scope.BindUpdate(() => obj.suspensionSpring = transform());
        public static void BindSuspensionSpringInterval(this WheelCollider obj, float seconds, Func<UnityEngine.JointSpring> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.suspensionSpring = transform());
        public static void BindForwardFriction(this WheelCollider obj, IProperty<UnityEngine.WheelFrictionCurve> property)
            => Bindings2._scope.Bind(property, v => obj.forwardFriction = v);
        public static void BindForwardFriction<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.forwardFriction = transform(v));
        public static void BindForwardFriction(this WheelCollider obj, Func<UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.forwardFriction = transform());
        public static void BindForwardFrictionInterval(this WheelCollider obj, float seconds, Func<UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.forwardFriction = transform());
        public static void BindSidewaysFriction(this WheelCollider obj, IProperty<UnityEngine.WheelFrictionCurve> property)
            => Bindings2._scope.Bind(property, v => obj.sidewaysFriction = v);
        public static void BindSidewaysFriction<T>(this WheelCollider obj, IProperty<T> property, Func<T, UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.Bind(property, v => obj.sidewaysFriction = transform(v));
        public static void BindSidewaysFriction(this WheelCollider obj, Func<UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.BindUpdate(() => obj.sidewaysFriction = transform());
        public static void BindSidewaysFrictionInterval(this WheelCollider obj, float seconds, Func<UnityEngine.WheelFrictionCurve> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.sidewaysFriction = transform());
        #endif


        #if UNITY_PHYSICS_2D
        public static void BindEnableCollision(this WheelJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = v);
        public static void BindEnableCollision<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.enableCollision = transform(v));
        public static void BindEnableCollision(this WheelJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.enableCollision = transform());
        public static void BindEnableCollisionInterval(this WheelJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.enableCollision = transform());
        public static void BindConnectedBody(this WheelJoint2D obj, IProperty<UnityEngine.Rigidbody2D> property)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = v);
        public static void BindConnectedBody<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedBody = transform(v));
        public static void BindConnectedBody(this WheelJoint2D obj, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedBody = transform());
        public static void BindConnectedBodyInterval(this WheelJoint2D obj, float seconds, Func<UnityEngine.Rigidbody2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedBody = transform());
        public static void BindAutoConfigureConnectedAnchor(this WheelJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = v);
        public static void BindAutoConfigureConnectedAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.autoConfigureConnectedAnchor = transform(v));
        public static void BindAutoConfigureConnectedAnchor(this WheelJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAutoConfigureConnectedAnchorInterval(this WheelJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.autoConfigureConnectedAnchor = transform());
        public static void BindAnchor(this WheelJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.anchor = v);
        public static void BindAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.anchor = transform(v));
        public static void BindAnchor(this WheelJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.anchor = transform());
        public static void BindAnchorInterval(this WheelJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.anchor = transform());
        public static void BindConnectedAnchor(this WheelJoint2D obj, IProperty<UnityEngine.Vector2> property)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = v);
        public static void BindConnectedAnchor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.Vector2> transform)
            => Bindings2._scope.Bind(property, v => obj.connectedAnchor = transform(v));
        public static void BindConnectedAnchor(this WheelJoint2D obj, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindUpdate(() => obj.connectedAnchor = transform());
        public static void BindConnectedAnchorInterval(this WheelJoint2D obj, float seconds, Func<UnityEngine.Vector2> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.connectedAnchor = transform());
        public static void BindSuspension(this WheelJoint2D obj, IProperty<UnityEngine.JointSuspension2D> property)
            => Bindings2._scope.Bind(property, v => obj.suspension = v);
        public static void BindSuspension<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointSuspension2D> transform)
            => Bindings2._scope.Bind(property, v => obj.suspension = transform(v));
        public static void BindSuspension(this WheelJoint2D obj, Func<UnityEngine.JointSuspension2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.suspension = transform());
        public static void BindSuspensionInterval(this WheelJoint2D obj, float seconds, Func<UnityEngine.JointSuspension2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.suspension = transform());
        public static void BindUseMotor(this WheelJoint2D obj, IProperty<System.Boolean> property)
            => Bindings2._scope.Bind(property, v => obj.useMotor = v);
        public static void BindUseMotor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Boolean> transform)
            => Bindings2._scope.Bind(property, v => obj.useMotor = transform(v));
        public static void BindUseMotor(this WheelJoint2D obj, Func<System.Boolean> transform)
            => Bindings2._scope.BindUpdate(() => obj.useMotor = transform());
        public static void BindUseMotorInterval(this WheelJoint2D obj, float seconds, Func<System.Boolean> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.useMotor = transform());
        public static void BindMotor(this WheelJoint2D obj, IProperty<UnityEngine.JointMotor2D> property)
            => Bindings2._scope.Bind(property, v => obj.motor = v);
        public static void BindMotor<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.Bind(property, v => obj.motor = transform(v));
        public static void BindMotor(this WheelJoint2D obj, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindUpdate(() => obj.motor = transform());
        public static void BindMotorInterval(this WheelJoint2D obj, float seconds, Func<UnityEngine.JointMotor2D> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.motor = transform());
        public static void BindBreakForce(this WheelJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakForce = v);
        public static void BindBreakForce<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakForce = transform(v));
        public static void BindBreakForce(this WheelJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakForce = transform());
        public static void BindBreakForceInterval(this WheelJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakForce = transform());
        public static void BindBreakTorque(this WheelJoint2D obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = v);
        public static void BindBreakTorque<T>(this WheelJoint2D obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.breakTorque = transform(v));
        public static void BindBreakTorque(this WheelJoint2D obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.breakTorque = transform());
        public static void BindBreakTorqueInterval(this WheelJoint2D obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.breakTorque = transform());
        #endif


        #if UNITY_WIND
        public static void BindMode(this WindZone obj, IProperty<UnityEngine.WindZoneMode> property)
            => Bindings2._scope.Bind(property, v => obj.mode = v);
        public static void BindMode<T>(this WindZone obj, IProperty<T> property, Func<T, UnityEngine.WindZoneMode> transform)
            => Bindings2._scope.Bind(property, v => obj.mode = transform(v));
        public static void BindMode(this WindZone obj, Func<UnityEngine.WindZoneMode> transform)
            => Bindings2._scope.BindUpdate(() => obj.mode = transform());
        public static void BindModeInterval(this WindZone obj, float seconds, Func<UnityEngine.WindZoneMode> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.mode = transform());
        public static void BindWindMain(this WindZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.windMain = v);
        public static void BindWindMain<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.windMain = transform(v));
        public static void BindWindMain(this WindZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.windMain = transform());
        public static void BindWindMainInterval(this WindZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.windMain = transform());
        public static void BindWindTurbulence(this WindZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.windTurbulence = v);
        public static void BindWindTurbulence<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.windTurbulence = transform(v));
        public static void BindWindTurbulence(this WindZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.windTurbulence = transform());
        public static void BindWindTurbulenceInterval(this WindZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.windTurbulence = transform());
        public static void BindWindPulseMagnitude(this WindZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.windPulseMagnitude = v);
        public static void BindWindPulseMagnitude<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.windPulseMagnitude = transform(v));
        public static void BindWindPulseMagnitude(this WindZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.windPulseMagnitude = transform());
        public static void BindWindPulseMagnitudeInterval(this WindZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.windPulseMagnitude = transform());
        public static void BindWindPulseFrequency(this WindZone obj, IProperty<System.Single> property)
            => Bindings2._scope.Bind(property, v => obj.windPulseFrequency = v);
        public static void BindWindPulseFrequency<T>(this WindZone obj, IProperty<T> property, Func<T, System.Single> transform)
            => Bindings2._scope.Bind(property, v => obj.windPulseFrequency = transform(v));
        public static void BindWindPulseFrequency(this WindZone obj, Func<System.Single> transform)
            => Bindings2._scope.BindUpdate(() => obj.windPulseFrequency = transform());
        public static void BindWindPulseFrequencyInterval(this WindZone obj, float seconds, Func<System.Single> transform)
            => Bindings2._scope.BindInterval(seconds, () => obj.windPulseFrequency = transform());
        #endif
    }
}