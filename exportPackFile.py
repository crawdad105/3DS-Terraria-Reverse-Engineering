import json

print(f"Hello World!")

RED = "\033[31m"
GREEN = "\033[32m"
YELLOW = "\033[33m"
BLUE = "\033[34m"
RESET = "\033[0m"

try:
    path = input("Input path to .pck file:\n")
except KeyboardInterrupt:
    print("Ctrl+C")
    quit(1)
try:
    outPath = input("Input output path:\n")
except KeyboardInterrupt:
    print("Ctrl+C")
    quit(1)

print(f"Opening \"{path}\"")
try:
    file = open(path, 'rb')
except OSError as e:
    print(f"\"{RED}OSError{RESET}\"\n{e}")
    quit(1)
except FileNotFoundError:
    print(f"{RED}altas.meta file not found.{RESET}")
    quit(1)

print(f"Opening \"{outPath}\"")
try:
    outFile = open(outPath, 'w')
except OSError as e:
    print(f"\"{RED}OSError{RESET}\"\n{e}")
    quit(1)
except FileNotFoundError:
    print(f"{RED}Output file not found.{RESET}")
    quit(1)

print(f"Reading pack..")
images = []
while True:
    v = file.read(1)
    if v.__len__() == 0: break
    packStr = str(file.read(v[0]).decode("ascii"))
    curImage = { "name": packStr, "data": [] }
    while True:
        v = file.read(1)[0]
        # if v == 0 then its a new file, not sure what happens if a string is length 0
        if v == 0: break
        texName = str(file.read(v).decode("ascii"))
        texX = int.from_bytes(file.read(4), byteorder='little')
        texY = int.from_bytes(file.read(4), byteorder='little')
        texW = int.from_bytes(file.read(4), byteorder='little')
        texH = int.from_bytes(file.read(4), byteorder='little')
        curImage["data"].append({ "name": texName, "x": texX, "y": texY, "w": texW, "h": texH })
    images.append(curImage)

print(f"Closing pack.")
file.close()
print(f"Outputting data..")
json.dump(images, outFile, indent=2)
print(f"Closing output file.")
outFile.close()

print(f"Done.")
