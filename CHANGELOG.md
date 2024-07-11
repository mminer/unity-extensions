# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


## [Unreleased]

### Changed

- Support params in `Transform.AddChildren`.

### Fixed

- Prevent repeated access of `Transform.position` in `Transform.Set` functions.
- Stop bypassing `UnityEngine.Object` lifetime check in
  `Component.GetOrAddComponent` and `GameObject.GetOrAddComponent`.

## [1.0.1] - 2024-07-10

### Fixed

- Make `Rigidbody.ChangeDirection` compatible with Unity 6.

## [1.0.0] - 2022-08-08

### Added

- Initial collection of Unity extensions.
