# ChromiumFX #

### .NET bindings for the [Chromium Embedded Framework](https://code.google.com/p/chromiumembedded/). ###
----------

## Home ##
[https://bitbucket.org/wborgsm/chromiumfx]()

## Overview ##

### ChromiumFX.dll ###

* **[Managed wrapper](http://chromiumfx.bitbucket.org/api/html/N_Chromium.htm) for the complete CEF API**
* **[Remote wrapper](http://chromiumfx.bitbucket.org/api/html/N_Chromium_Remote.htm) for full access to DOM and V8 from within the browser process**

### ChromiumWebBrowser.dll ###

* **[Windows Forms control](http://chromiumfx.bitbucket.org/api/html/N_Chromium_WebBrowser.htm) based on ChromiumFX**

### See Also ###

* [Project Setup and Description](https://bitbucket.org/wborgsm/chromiumfx/wiki/Project)
* [Getting started with the Browser Control](https://bitbucket.org/wborgsm/chromiumfx/wiki/Walkthrough_01) 
* [Getting started with the Remoting Framework](https://bitbucket.org/wborgsm/chromiumfx/wiki/Walkthrough_02)
* [API Reference](http://chromiumfx.bitbucket.org/api/)
* [Binary releases](https://bitbucket.org/wborgsm/chromiumfx/downloads)

### Warning ###
The API of this project is not frozen and is subject to change. The overall structure will be kept though.

### Versioning ###

ChromiumFX version numbers consist of four digits. The first three digits are the version number of the underlying CEF binaries. The fourth number is the release number of ChromiumFX for a specific CEF version. Example: 3.1750.1738.0 is the first release of ChromiumFX for CEF 3.1750.1738 and 3.1750.1738.3 would be the fourth release for the same CEF version, and so on.

### Licensing and Credits ###

ChromiumFX is BSD licensed. The CEF project is BSD licensed. Please visit
"about:credits" in a CEF-based application for complete Chromium and third-party
licensing information. See also cef/LICENSE.txt and cef/README.txt.


## Changes ##

This is a summary of the most important changes and those relevant to embedders (API changes etc.).

### Version 3.2171.1979.7 ###

* Some of the framework callback container classes were not recognized as such by the code generator. This has been fixed. `CfxEndTracingCallback`, `CfxCompletionCallback`, `CfxRunFileDialogCallback` and `CfxSchemeHandlerFactory` are now correctly wrapped as framework callbacks.
* Removed browser-only `EndTracing` and `CfxEndTracingCallback` from remote layer.
* Fixed int to bool conversion for `GetBool` and `SetBool` functions in several classes.

### Version 3.2171.1979.6 ###

* Removed the `CfxRuntime.Initialize()` and `CfxRuntime.ExecuteProcess()` functions with sandbox parameter from the public API. Currently there is no way to start this within a sandbox. 
* Internally, the callback delegates and native function pointers are now created on demand, reducing the work load at startup. Most applications won't use all callbacks anyway. 
* Version information functions added to CfxRuntime.

### Version 3.2171.1979.5 ###

* The event handler and event arg classes for the framework callback events moved into their own namespaces. If you get errors, add `using Chromium.Event` and/or `using Chromium.Remote.Event` directives.
* A Sandcastle Help File Builder project was added and the xml documentation comments were improved for the new API reference.
