# Participants may update the following function parameters
def getMaximizedReturn(n, k, d, m, dailyReturns):
    # Participants code will be here
    return -1

def main():
    firstLine = input().split(" ")
    secondLine = input().split(" ")

    n = int(firstLine[0])
    k = int(firstLine[1])
    d = int(firstLine[2])
    m = int(firstLine[3])
    dailyReturns = list(map(int, secondLine))

    # Participants may update the following function parameters
    answer = getMaximizedReturn(n, k, d, m, dailyReturns)

    # Please do not remove the below line.
    print(answer)
    # Do not print anything after this line

if __name__ == '__main__':
    main()