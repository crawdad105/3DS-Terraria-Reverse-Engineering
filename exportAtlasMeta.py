import json

print(f"Hello World!")

RED = "\033[31m"
GREEN = "\033[32m"
YELLOW = "\033[33m"
BLUE = "\033[34m"
RESET = "\033[0m"

try:
    path = input("Input path to altas.meta:\n")
except KeyboardInterrupt:
    print("Ctrl+C")
    quit(1)
try:
    outPath = input("Input output path (will be saved as json file):\n")
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

entries = []
print(f"Reading altas...")
while True:
    v = file.read(4)
    if v.__len__() == 0: break
    curId = int.from_bytes(v, byteorder='little')
    curStr = str(file.read(file.read(1)[0]).decode("ascii"))
    curWidth = int.from_bytes(file.read(4), byteorder='little')
    curHeight = int.from_bytes(file.read(4), byteorder='little')
    entries.append({"name": curStr, "width": curWidth, "height": curHeight, "id": curId})

print(f"Closing altas.")
file.close()
print(f"Writing output data.")
json.dump(entries, outFile, indent=2)
print(f"Closing output file.")
outFile.close()

print(f"Done.")
