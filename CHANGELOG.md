# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- `Bounds.RandomPointInside`
- `Transform.CopyFrom`
- `Vector2.Abs`, `Vector3.Abs`, `Vector4.Abs`, `Vector2Int.Abs`,
  `Vector3Int.Abs`
- `Vector2.Ceil`, `Vector3.Ceil`, `Vector4.Ceil`
- `Vector2.Floor`, `Vector3.Floor`, `Vector4.Floor`
- `Vector2.Round`, `Vector3.Round`, `Vector4.Round`

## [1.10.0] - 2025-04-25

### Added

- `Component.GetComponentsInChildrenIgnoringSelf`
- `Vector3` to `Vector2` swizzles (e.g. `Vector3.XZ`)

## [1.9.0] - 2025-04-07

### Added

- `Quaternion.WithEulerX`, `Quaternion.WithEulerY`, `Quaternion.WithEulerZ`

## [1.8.0] - 2025-02-28

### Added

- `Component.AddComponents` and `GameObject.AddComponents`

## [1.7.0] - 2025-02-28

### Added

- `GameObject.SetLayerInChildren`

## [1.6.0] - 2025-02-23

### Added

- `Component.TryGetComponentInChildren` and
  `GameObject.TryGetComponentInChildren`

## [1.5.0] - 2024-09-19

### Added

- `Color.WithR`, `Color.WithG`, `Color.WithB`, `Color.WithA`

### Fixed

- Prevent compiler error if physics module missing

## [1.4.0] - 2024-07-23

### Added

- `Transform.SetPosition` and `Transform.SetLocalPosition`

### Fixed

- Remove array allocation in `LayerMask` extensions
- Replace `GetComponent` with `TryGetComponent` in `GameObject` and `Component`
  extensions

## [1.3.0] - 2024-07-14

### Added

- `Transform.Reset`
- `Vector2.WithX`, `Vector2.WithY`
- `Vector2Int.WithX`, `Vector2Int.WithY`
- `Vector3.WithX`, `Vector3.WithY`, `Vector3.WithZ`
- `Vector3Int.WithX`, `Vector3Int.WithY`, `Vector3Int.WithZ`
- `Vector4.WithX`, `Vector4.WithY`, `Vector4.WithZ`, `Vector4.WithW`

## [1.2.0] - 2024-07-12

### Added

- `LayerMask.WithLayers`
- `LayerMask.WithoutLayers`

## [1.1.0] - 2024-07-11

### Added

- `GameObject.IsInCullingMask`

### Changed

- Support params in `Transform.AddChildren`

### Fixed

- Prevent repeated access of `Transform.position` in `Transform.Set` functions
- Stop bypassing `UnityEngine.Object` lifetime check in
    `Component.GetOrAddComponent` and `GameObject.GetOrAddComponent`

### Removed

- Remove `Vector3Int.ToVector3` in favour of Unity's implicit conversion

## [1.0.1] - 2024-07-10

### Fixed

- Make `Rigidbody.ChangeDirection` compatible with Unity 6

## [1.0.0] - 2022-08-08

### Added

- Initial collection of Unity extensions
