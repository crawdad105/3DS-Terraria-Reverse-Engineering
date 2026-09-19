# 3DS Terraria Decompilation/Reverse Engineering
### This is for Terraria 3DS versions 1.0.5 (Update Code: v5.6.0).
### This is not a redistribution, no source code/memory is downloadable.
This is an attempt ad reverce engineering the 3DS version of Terraria. It mostly contains some tools and general information such as functions names. Cartage dump data including images, code or other files are not included although tools and methods are provided to do it your self. The code was mostly analyzed from a ram dump, a cartridge dump would work as well but you don't get get other ram stuff like the heap or other sections.
The disassembly was done in [Binary Ninja](https://binary.ninja/) rather then Ghidra because Ghidra (and literally any other free disassembler for some reason) can not decompile the ridiculously large jump table Terraria uses.

For more up to date info or other progress on mods or hacks go to the [crawdad105 discord](https://crawdad105.com/discord)

# Files
[data.json](data.json) has exported data from Binary Ninja containing functions and variable names and addresses.<br/>
[userDefinedData.json](userDefinedData.json) has user defined exported data.<br/>
[index.html](index.html) also exists with options to show and hide exported data in a viewable form (this requires [data.json](data.json)).<br/>
[segments.png](segments.png) has an image of sections extracted directly from the 3DS (this was done on the New 3DS XL but should be roughly the same on other 3DSs).<br/>
[types.h](types.h) are the exported types form Binary Ninja as a header file. The types need to be manually created, so they are incomplete, its mainly used for referencing.<br/>
[BinaryNinjaTypeArchive.bnta](BinaryNinjaTypeArchive.bnta) is the type archive for Binary Ninja, its a bit complicated to set up though.<br/>
<br/>
The files within [/ExportExtractor](ExportExtractor) are used to extract the data from the Binary Ninja export.
It generates [data.json](data.json), [userDefinedData.json](userDefinedData.json), [markdownFunctions.md](markdownFunctions.md), [markdownVariables.md](markdownVariables.md) and [extracted.txt](extracted.txt).
[descriptions.txt](descriptions.txt) has description data for variables and functions, it is used when generating [markdownFunctions.md](markdownFunctions.md) and [markdownVariables.md](markdownVariables.md).

# Comparing code
Code was compared to Terraria Versions around 1.2.4.1 but may contain code from some 1.3 versions and old mobile versions.<br/>
The old Codeglue mobile versions are the best option as many functions are 1-to-1 with the 3DS.
Version [1.2.12785](https://archive.org/download/terraria-apks#:~:text=Terraria%201.2.12785.apk) seems to be good.

# Exporting/Viewing Data
Unfortunately the free versions of Binary Ninja does not allow exporting functions/variable data,
however you can export the "linear" view as raw text, this takes forever
but results in a text file you can search through to get data. 
Binary ninja files are upwards of a GB so they can't easily be shared,
also it would be distributing code which is illegal.<br/>
This can be parsed using [ExtractDumpNames.dll](ExportExtractor/ExtractDumpNames.dll), it was written in dotnet 8.0 so should work on linux. (you also need the other files as well).

# Modding
There is not much information about 3DS Terraria modding it seems (other them people wanting to port modern Terraria or Calamity for some reason).
There is some effort to mod it however.<br/>
[Working vein miner](https://www.reddit.com/r/Terraria/comments/1votqoj/successfully_modded_terraria_for_3ds/) (the impressive part is they got UI elements drawn, it can be downloaded on [GameBanana](https://gamebanana.com/mods/704537), but may only work on the European versions (not the one this repo is about)).<br/>
[Rom hack that change the music](https://www.gamebrew.org/wiki/Terratale_3DS)<br/>
[Inventory Editor](https://www.reddit.com/r/Terraria/comments/1votqoj/successfully_modded_terraria_for_3ds/) (not really a mod)<br/>
There are also some cheats exist through [Checkpoint](https://github.com/JourneyOver/CTRPF-AR-CHEAT-CODES/blob/master/Cheats/Terraria%20(USA)/000400000016A900.txt)
but these are not live mods.

# "Decompiling" (idk if this should be here)
Dumping the 3DS versions can be done by dumping the cartage with [GodMode9](https://github.com/d0k3/GodMode9) or something and using [ctrtool](https://gbatemp.net/threads/release-ctrtool-v1-0-0.609238/) to extract the files.<br/>
Assuming you have the `.cia` file (idk how to do it with a `.3ds` file), run `ctrtool.exe --contents=contents "game.cia"` to extract a `contents.0000.XXXXXXXX` file (there may be 2, i chose the larger one which seemed to work)
run `ctrtool.exe -x --decompresscode --exefsdir=ExeFS --romfsdir=RomFS contents.0000.XXXXXXXX` to extract that file into `ExeFS` and `RomFS` folders, game content is in `RomFS` and code is in `ExeFS`.
The code might be compressed, it should be around 5KB not compressed, if it it not run `ctrtool.exe --exefs=exefs.bin contents.0000.XXXXXXXX` and `ctrtool.exe --exefsdir=ExeFS --decompresscode exefs.bin`, this should uncompressed it.<br/>
Note that you will need 2 separate `.cia` file, one for the base game and one for the update content, with the update content you simply just paste the new content over the old content.

If this does not work, then idk.

[OTX tool](https://gbatemp.net/threads/otx-tool-terraria-texture-tool.458493/) can be used to convert otx files to pngs.

[ctr_WaveConverter32](https://github.com/realhumii/ctr_WaveConverter32) can be used to convert normal files to .bcwav files (not sure about the other way around).

If you do not want to dump the cartage but want the code, you can dump the ram (which is better anyways since it gives more to work with) either using Rosalina, [ctn Firmware](https://github.com/crawdad105/ctn-Firmware) (which can dump any arbitrary section of memory), or some other way.


# Memory
<details>
  <summary>Expand memory section</summary>

These are the important sections/segments, [segments.png](segments.png) has all of them.<br/>
These are virtual addresses.<br/>
I think all 3DS programs start at `0x00100000` (Rosalina is the only i found that does not)<br/>
The heap is almost always at `0x080000000` and i think the address space always ends at `0x40000000`.

| Start        | End          | Length       | Flags | Name |
| -----        | ---          | ------       | ----- | ---- |
| `0x00100000` | `0x005C1000` | `0x004C1000` | r-x   | .text |
| `0x005C1000` | `0x00629000` | `0x00068000` | r--   | .rodata |
| `0x00629000` | `0x008B5000` | `0x0028C000` | rw-   | .data(/.bss?) |
| `0x008B8000` | `0x008DC000` | `0x00024000` | rw-   | other (.bss?) |
| `0x008DC000` | `0x80000000` | `0x07724000` | ---   | Free |
| `0x08000000` | `0x0AAE4000` | `0x02AE4000` | rw-   | Heap |
|  |  |  |  |  |
| `0x30000000` | `0x34900000`\* | `0x04900000`\* | rw-   | "Continuous" |

\*`0x04900000`, may change sizes depending on if its a new or old 3DS (i think this is for the New 3DS XL).<br/>

Note: For some reason .rodata/.bss have a size of `0x002B3000` while another section at the same location has a size of `0x0028C000`, im not sure whats going on here, maybe .bss is not the same section as .data but idk.<br/>
Note for modders: a lot of memory after `0x008DC000` is free, this is where 3ModLoader starts allocating.

</details>
<br/>

# [Functions](markdownFunctions.md)
See [markdownFunctions.md](markdownFunctions.md) (All exported symbols can be found in [extracted.txt](extracted.txt)).<br/>
Note: Addresses past `0x008DC000` may change locations.
# [Variables](markdownVariables.md)
See [markdownVariables.md](markdownVariables.md) (All exported symbols can be found in [extracted.txt](extracted.txt)).<br/>
Note: Addresses past `0x008DC000` may change locations.

# 3ModLoader
3ModLoader is a mod loader for this versions of 3DS Terraria, build off of a modified versions of Luma3DS (specifically the Rosalina sysmodule) called [ctn Firmware](https://github.com/crawdad105/ctn-Firmware).
ctn has a built in memory viewer, reader and writer, memory dumper, debugger, file viewer (with a custom ftp like file server), UI system, plugin system and more.
3Modloader itself is a plugin for ctn that currently just has built in mods and hacks, it cant actually load mods.
A versions can technically be recompiled from an accidentally leak which was published with ctn firmware or you can find and download a versions from the crawdad105 discord, but its a prototype and not officially released yet, and it cant load mods yet.

# Credit
crawdad105<br/>
Bean

Want to help? Join the [crawdad105 discord](https://crawdad105.com/discord).
