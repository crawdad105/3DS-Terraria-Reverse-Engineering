import json

print(f"Hello World!")

userInput = input("Input size:\n> ")
try:
    size = int(userInput)
except ValueError:
    size = int(userInput, 16)
except:
    print("Bad input. base-10 and base-16 are accepted.")


for n in range(size):
    print(f"\tu8 _{n:02x};")