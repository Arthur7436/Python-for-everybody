largest = None
smallest = None
numList = []

while True:
    try:
        num = input("Enter a number: ")
        # Store num in a list
        if num != "done":
            numList.append(num)
        
        # upon finishing, find the largest and smallest
        if num == "done":
            #turn list into int
            for item in numList:
                numList.append(int(item))
            
            # Find the largest
            largest = numList[0]
            for l in numList:
                if l > largest:
                    largest = l
        
            # Find the smallest
            smallest = numList[0]
            for i in numList:
                if i < smallest:
                    smallest = i
            break
    except:
        print("Invalid input")
    print(num)

print("Maximum is", largest)
print("Minimum is", smallest)