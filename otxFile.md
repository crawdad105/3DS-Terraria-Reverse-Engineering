# OTX files
OTX files are the medium in which the 3DS version of Terraria stores textures.
Put simply, OTX files contain either raw or compressed image data with a 32 bytes header.

Due to there only being 33 different texture files, this information is basically compleat.
All 33 files match these descriptions.

## Header
The file header consists of 32 bytes, the header contains the real width and hight of the image the encoded width and hight (a power of 2), the total size of the image in bytes (does not include header) and the pixel/file format, all other bytes, are identical throughout the files. 

|Offset|Length|Description|
|-|-|-|
|0x00|0x2| Always 0x0001. |
|0x02|0x2| The full image width. A pawer of 2. |
|0x04|0x2| The full image height. A pawer of 2. |
|0x06|0x2| The real/desired image width. |
|0x08|0x2| The real/desired image height. |
|0x09|0x1| The image/pixel format. |
|0x0A|0x1| Always 0x01. |
|0x0B|0x4| The image size in bytes. (does not include header) |
|0x10|0x10| All 0s. |

"color_swatch.otx" is the only texture that does not have the full and real size match. The texture data matches a 16 by 16 image, however the actual image dimensions are 10 by 10.

## Image formats

According this [this site](https://problemkaputt.de/gbatek-3ds-gpu-texture-formats.htm) the 3DS natively supports 14 different file types.
Most of them are not for storing normal images, because of this Terraria only utilizes the few that do, and even then they only utilize `RGBA8888`, `RGBA4444`, `ETC1A4` and `ETC1`. For some reason the pixel value listed in the file header does not corelate to the 3DS values.
[Rohul1997's OTX Tool](https://gbatemp.net/threads/otx-tool-terraria-texture-tool.458493/) directly translates these values, 
which is where this information is from.

|Terraria Value|3DS Value|
|-|-|
|1|0|
|2|4|
|8|12|
|9|13|

Unless non-'colour' maps are wanted, the only other formats that store normal image colours are `RGB888`, `RGB5551` and `RGB565`. However because Terraria does not use them, finding the corresponding "Terraria Value" for the "3DS Value" would likely require searching through the code, if it exists at all.

## File content
Other then the header the only other content in the file is the image data, which is stored in a raw or compressed format.
The raw-ness come from the fact the pixels are stored as raw colour data like `.bmp` files do, unlike `.jpeg` or `.png` which use compression.
This does depend on the pixel format as `ETC1` and `ETC1A4` losslessly compresses 16 pixels into a 64-bit chunk (`ETC1A4` does store raw alpha data).

The image's data is a sequential list of 8 by 8 pixel chunks.
These chunks contain a list of pixels in a [Z-order curve](https://en.wikipedia.org/wiki/Z-order_curve).
Once you decode the chunks they can be placed sequential from left to right, top to bottom and each pixel in the chunk can be unraveled to reconstruct the image.
`ETC1` and `ETC1A4` are slightly different, although the chunk data is z-ordered because 1 ETC1 "block" is 8 pixels its only 1 layer of z-ordered.

Image from wikipedia showing the 8 by 8 pixel chunks. This is exactly the arrangement the raw images use. `ETC1` and `ETC1A4` can be though of as just the first 2 by 2 section. <br/>
<img src="https://upload.wikimedia.org/wikipedia/commons/6/6b/Moser%E2%80%93de_Bruijn_addition.svg" width="200">

### `ETC1` / `ETC1A4`
Like previously mentioned `ETC1` and `ETC1A4` store compressed data by encoding 16 pixels into a 64-bit chunk. 
These are apparently standard image compression formats using the `.pkm` file extension however the normal header and the header Terraria uses for its image are not the same, thus are not compatible (maybe if the header was change it could but i don't know if normal `ETC1` chunks are z-ordered).

Decoding `ETC1` is fairly strait forward, [this page](https://registry.khronos.org/OpenGL/extensions/OES/OES_compressed_ETC1_RGB8_texture.txt) 
contains a good breakdown of how decoding works.

Encoding `ETC1` is slightly more tricky, there is no single explanation page as there is for encoding and the pages i found (listed below), although are helpful
do not provided a lot of important information. The best sources would be crawdad105's custom algorithm, Rohul1997's OTX Tool and Pugemon's python port.

[crawdad105's OTX Viewer](http://crawdad105.com/otxViewer/) (View page source)<br/>
[Rohul1997's OTX Tool](https://gbatemp.net/threads/otx-tool-terraria-texture-tool.458493/) (Must be decompiled)<br/>
[Pugemon's python port of Rohul1997's OTX Tool](https://github.com/Pugemon/otx_tool/blob/main/etc1.py)<br/>

[Original ETCPACK implementation?](https://github.com/Ericsson/ETCPACK/blob/14a64d9d19318fb9f81ce339b7103ffa0f1781d7/source/etcpack.cxx)<br/>
[Main android opengl implementation](https://android.googlesource.com/platform/frameworks/native/+/refs/heads/main/opengl/libs/ETC1/etc1.cpp)<br/>
[Android etc1tool](https://github.com/nigeltao/etc1tool/blob/main/src/ETC1/etc1.cpp)<br/>
["Goofy" Runtime ETC1 encoder](https://github.com/SergeyMakeev/Goofy)<br/>

Also note that `ETC1` is lossless, there are multiple ways a single chunk can be formed and different encoding will likely produce different results.

## Converting, Viewing and Creating

[Browser converter/viewer/creator](http://crawdad105.com/otxViewer/). (Source available by inspecting page source)

Rohul1997's originally create the first OTX Tool in c# ([Link here](https://gbatemp.net/threads/otx-tool-terraria-texture-tool.458493/)).
Pugemon then ported it to Python who seemed to clone the logic ([Link here](https://gbatemp.net/threads/otx-tool-terraria-texture-tool.458493/)).
However these require downloading and running things, it can be done in a browser on the [crawdad105 website](http://crawdad105.com/otxViewer/).