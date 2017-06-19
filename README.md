HarNetCore
==========

HarNet is .NET Library for handling HTTP Archive files. The library is available as a NuGet package here: https://www.nuget.org/packages/HarNetCore/

HAR files can be created by browsers or browser extensions. HAR is a W3C-defined format (https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html) based on JSON. The format defines obligatory and optional parameters for each log.

This project aims to provide a free .NET library. This library relies on Newtonsoft.JSON for efficient data deserialization. Newtonsoft.JSON deserializes into basic data types (int, string and object). HarNet converts this to more complex types (ulong, float) as well as class implementations of the objects. A set of useful methods have also been added to many of the classes, making it easier to manipulate the data in those files.

This is a .NET Standard 1.4 port of the older version of this library

License
=======

HarNet is released under the MIT License.
