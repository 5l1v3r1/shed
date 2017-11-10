# Shed - .NET runtine inspector

_Shed_ is an application that allow to inspect the .NET runtime of a program in order to extract useful information. It can be used to inspect malicious applications in order to have a first general 
overview of which information are stored once that the malware is executed.

_Shed_ is able to:
* Extract all objects stored in the managed heap
* Print strings stored in memory
* Save the snapshot of the heap in a JSON format for post-processing
* Dump all modules that are loaded in memory


### Donation please

If you find this project useful, please consider a donation in order to ensure its continuation and improvement. All contributions gratefully accepted.

<a href='https://pledgie.com/campaigns/35054'><img alt='Click here to lend your support to: Shed - .NET runtine inspector and make a donation at pledgie.com !' src='https://pledgie.com/campaigns/35054.png?skin_name=chrome' border='0' ></a>

## Download
 - [Source code][1]
 - [Download binary][2]

## Using Shed

### Inspecting an already running application
In order to inspect an already running process you have to pass the pid to _Shed_. Example:

Shed.exe --pid 2356

### Inspecting a binary
In order to inspect a binary, _Shed_ needs to execute it and to attach to it in order to inspect the runtime. Example:

**Shed.exe --exe malware.exe**

You can also specify the amount of time (in milliseconds) to wait before to suspend the process. This will allow the program to have the time to initialize its properties. Example:

**Shed.exe --timeout 2000 --exe malware.exe**

### Dumping options
By default _Shed_ dump both the heap and the modules. If you want only one of that specify the _--dump-heap_ option to dump only the objects in the heap or the _--dump-modules_ to dump only the modules.

Dumping the heap can produce a lot of information which are not strictly useful for the analysis. You can filter it by using two files:

**blacklist.txt** this file contains the type names prefix that must not be logged
**whitelist.txt** this file contains the type names prefix that must be logged even if blacklisted

For example, if you want to filter all the *System.IO* namespace but you are interested in logging *System.IO.MemoryStream*, you can add the first value to **blacklist.txt** and the second one to **whitelist.txt**.

### Examples
In the _Examples_ folder you will find three different projects that you can use in order to test _Shed_. Example:

**Shed.exe --exe ..\Examples\ConfigurationSample\ConfigurationSample.exe**

When the analysis is completed, _Shed_ will print where you can find the result, as shown below:

_[+] Result saved to C:\Shed\Result\7800_

## Build Shed

If you have installed Visual Studio, just run the build.bat batch file, it will create a zip file inside the build folder.

### License information

Copyright (C) 2017 Antonio Parata - @s4tan

License: GNU General Public License, version 2 or later; see LICENSE included in this archive for details.

  [1]: https://github.com/enkomio/shed/tree/master/Src
  [2]: https://github.com/enkomio/shed/releases/latest