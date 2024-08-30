# com.virtualmaker.bindings

[![Discord](https://img.shields.io/discord/855294214065487932.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/xQgMW9ufN4) [![openupm](https://img.shields.io/npm/v/com.virtualmaker.bindings?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.virtualmaker.bindings/) [![openupm](https://img.shields.io/badge/dynamic/json?color=brightgreen&label=downloads&query=%24.downloads&suffix=%2Fmonth&url=https%3A%2F%2Fpackage.openupm.com%2Fdownloads%2Fpoint%2Flast-month%2Fcom.virtualmaker.bindings)](https://openupm.com/packages/com.virtualmaker.bindings/)

UI binding is the act of taking a data source and applying it a user interface. This is our team's package to make that as easy to do as possible.

## Installing

Requires Unity 2021.3 LTS or higher.

The recommended installation method is though the unity package manager and [OpenUPM](https://openupm.com/packages/com.virtualmaker.bindings).

### Via Unity Package Manager and OpenUPM

- Open your Unity project settings
- Select the `Package Manager`
![scoped-registries](images/package-manager-scopes.png)
- Add the OpenUPM package registry:
  - Name: `OpenUPM`
  - URL: `https://package.openupm.com`
  - Scope(s):
    - `com.virtualmaker`
- Open the Unity Package Manager window
- Change the Registry from Unity to `My Registries`
- Add the `Bindings` package

### Via Unity Package Manager and Git url

- Open your Unity Package Manager
- Add package from git url: `https://github.com/virtual-maker-net/com.virtualmaker.bindings.git#upm`

## Documentation

Key principles:
  1. Bindings should be simple and automatic.
  2. You should be able to view and edit all data in the editor for easy debugging.

To implement UI bindings, we use three classes:
- `Property<T>` - Some data + a changed event. **These can be viewed and edited in the Unity editor**.
- `Derived<T, W>` - Transforms an IProperty<T> into an IProperty<W>.
- `Bindings` - a helper class which makes it easy to take data from an IProperty<T> and apply it to a UXML element, or vice versa.