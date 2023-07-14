file = open("myData.csv", mode="r")

header = file.readline()
print(header)

file = open("myData.csv", mode="a")
file.write("\nLength, Width, Time")

