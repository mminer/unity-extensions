# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


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
