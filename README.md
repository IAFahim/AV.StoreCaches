# AV.StoreCaches

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

Abstract base for ScriptableObject-based data stores with change tracking.

## ✨ Features

- **StoreCache<T, TKey>**: Base class for data containers that update based on key changes.
- **IChangeAble**: Interface for keys that can trigger updates.

## 📦 Installation

Install via Unity Package Manager (git URL).

## 🚀 Usage

Inherit from `StoreCache` to create reactive data stores.

```csharp
public class EnemyStore : StoreCache<EnemyData, EnemyID> { ... }
```

## ⚠️ Status

- 🧪 **Tests**: Missing.
- 📘 **Samples**: None.
